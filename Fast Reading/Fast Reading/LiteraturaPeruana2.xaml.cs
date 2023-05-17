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
    public partial class LiteraturaPeruana2 : ContentPage
    {
        public LiteraturaPeruana2()
        {
            Title = "Literatura del Perú";
            InitializeComponent();
            StartDelay();
        }
        private async void StartDelay()
        {
            await Task.Delay(10000); // Esperar 10 segundos
            await Navigation.PushAsync(new PreguntaLiteratura2());
        }
    }
}