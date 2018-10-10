using EjemploSqlLite.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploSqlLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void nuevaTarea(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevaTarea());
        }
         
        async private void listarTarea(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListarTareas());
        }
    }
}
