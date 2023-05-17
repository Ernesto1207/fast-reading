using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fast_Reading
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LiteraturaPeruana1 : ContentPage
    {
        public LiteraturaPeruana1()
        {
            Title = "Literatura del Perú";
            InitializeComponent();
            StartDelay();
        }
        private async void StartDelay()
        {
            await Task.Delay(15000); // Esperar 15[ segundos
            await Navigation.PushAsync(new PreguntaLiteratura1());
        }
    }
}