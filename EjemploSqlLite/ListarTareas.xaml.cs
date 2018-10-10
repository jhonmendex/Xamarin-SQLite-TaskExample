using EjemploSqlLite.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.SQLite.SQLite;

namespace EjemploSqlLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarTareas : ContentPage
    {
        private SQLiteConnection _sqLiteConnection;

        public ListarTareas()
        {
            InitializeComponent();


            //crear elementos con c#
            var botonAgregar = new ToolbarItem(){
                Text = "+"
            };

            botonAgregar.Clicked += agregarTarea;
            ToolbarItems.Add(botonAgregar);
        }

       async private void agregarTarea(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new NuevaTarea());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (_sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection())
            {
                List<Tarea> listaTareas;
                listaTareas = _sqLiteConnection.Table<Tarea>().Where(t => t.Completada == false).ToList();                                                                                  
                listarTareasListView.ItemsSource = listaTareas;
            }

        }
        //actualizar el elemento
        private void completarTarea(object sender, EventArgs e)
        {
            using (_sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection())
            {
                var tareaCompletar = (sender as MenuItem).CommandParameter as Tarea;
                tareaCompletar.Completada = true;
                _sqLiteConnection.Update(tareaCompletar);

                List<Tarea> listaTareasFiltrada; //tareas que aun no esta completadas
                listaTareasFiltrada = _sqLiteConnection.Table<Tarea>().Where(t=>t.Completada == false).ToList(); //filtros de linq
                // listaTareas = new List<Tarea>();
                listarTareasListView.ItemsSource = listaTareasFiltrada;
            }
        }
    }
}