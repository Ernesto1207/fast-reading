using System;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fast_Reading
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            // Establecer la pantalla de carga como página de inicio
            MainPage = new NavigationPage(new LoadingPage());

            // Crear un temporizador que espere 3 segundos
            Timer timer = new Timer(3000);
            timer.AutoReset = false;
            timer.Elapsed += (sender, args) =>
            {
                // Cambiar la página de la pantalla de carga a la página de inicio
                Device.BeginInvokeOnMainThread(() =>
                {
                    MainPage = new NavigationPage(new MainPage());
                });
            };
            timer.Start();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
