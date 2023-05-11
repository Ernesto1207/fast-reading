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
	public partial class PreguntaPage : ContentPage
	{
        private List<string> opciones = new List<string>()
        {
            "En las escuelas públicas",
            "En el Jardín",
            "En su casita"
        };
        public PreguntaPage ()
		{
            Title = "Historia del Perú";
            InitializeComponent ();

            // Obtener las opciones aleatorias para la pregunta
            var opcionesAleatorias = ObtenerOpcionesAleatorias();

            // Mostrar las opciones en los botones de A, B y C
            opcionA.Text = opcionesAleatorias[0];
            opcionB.Text = opcionesAleatorias[1];
            opcionC.Text = opcionesAleatorias[2];
        }
        private List<string> ObtenerOpcionesAleatorias()
        {
            // Obtener las opciones en un orden aleatorio
            var opcionesAleatorias = opciones.OrderBy(x => Guid.NewGuid()).ToList();

            // Seleccionar las tres primeras opciones
            return opcionesAleatorias.Take(3).ToList();
        }
        private async void Comprobar_Clicked(object sender, EventArgs e)
        {
            // Obtener la opción seleccionada
            var opcionSeleccionada = (sender as Button).Text;

            // Comprobar si la opción seleccionada es la correcta
            if (opcionSeleccionada == opciones[0])
            {
                // La opción seleccionada es la correcta
                await DisplayAlert("¡Correcto!", "¡Has acertado la pregunta!", "OK");
            }
            else
            {
                // La opción seleccionada es incorrecta
                await DisplayAlert("¡Incorrecto!", "Lo siento, has fallado la pregunta.", "OK");
            }

            // Esperar 5 segundos antes de redirigir a la página anterior
            await Task.Delay(5000);
            await Navigation.PopAsync();
        }

    }
}