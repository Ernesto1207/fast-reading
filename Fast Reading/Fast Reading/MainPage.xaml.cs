using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fast_Reading
{
    public partial class MainPage : ContentPage
    {
        List<string> opciones = new List<string> { "Literatura Peruana", "Historia Peruana", "Geografia Peruana" };

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Girar_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(opciones.Count);
            var opcionSeleccionada = opciones[index];
            await ruleta.RotateTo(index * (36000 / opciones.Count) + (360 / opciones.Count / 2), 2000, Easing.SinInOut);
            await DisplayAlert("Opción seleccionada", opcionSeleccionada, "Aceptar");

            switch (opcionSeleccionada)
            {
                case "Literatura Peruana":
                    await Navigation.PushAsync(new LiteraturaPeruana());
                    break;
                case "Historia Peruana":
                    await Navigation.PushAsync(new HistoriaPeruana());
                    break;
                case "Geografia Peruana":
                    await Navigation.PushAsync(new Geografia());
                    break;
                default:
                    break;
            }
        }
    }
}