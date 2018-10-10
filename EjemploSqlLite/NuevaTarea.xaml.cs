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
    public partial class NuevaTarea : ContentPage
    {
        private SQLiteConnection _sqLiteConnection;
        public NuevaTarea()
        {
            InitializeComponent();
        }

        async private void guardarTarea(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea()
            {
                Nombre = nombreTarea.Text,
                Fecha = fechaTarea.Date,
                Hora = horaTarea.Time,
                Completada = false
            };

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqLiteConnection.CreateTable<Tarea>();

            var resultado = _sqLiteConnection.Insert(nuevaTarea);
            if (resultado > 0)
            {
                await DisplayAlert("Exito", "El elemento se guardo", "Ok");
                await Navigation.PushAsync(new ListarTareas());
            }
            else
            {
                   await DisplayAlert("Error", "No se pudo insertar el dato", "Ok");
            }
        }
    }
}