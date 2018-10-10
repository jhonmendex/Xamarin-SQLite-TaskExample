using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinForms.SQLite;

namespace EjemploSqlLite
{
    public partial class App : Application
    {
        public static String RutaBD;
        public App()
        {
            InitializeComponent();

             //MainPage = new SQLiteSamplePage().GetSampleContentPage();
             MainPage = new NavigationPage(new EjemploSqlLite.MainPage());
        }
        
        
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
