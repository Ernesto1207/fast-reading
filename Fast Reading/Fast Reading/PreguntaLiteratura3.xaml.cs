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
    public partial class PreguntaLiteratura3 : ContentPage
    {
        private List<string> opciones = new List<string>()
        {
            "El Español",
            "El Quechua",
            "El Aymara"
        };
        public PreguntaLiteratura3()
        {
            Title = "Literatura del Perú";
            InitializeComponent();

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
                var result = await DisplayAlert("¡Correcto!", "Has acertado", "Seguir Jugando", "Volver a la ruleta");
                if (result)
                {
                    await Navigation.PushAsync(new LiteraturaPeruana4());
                }
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }
            }
            else
            {
                // La opción seleccionada es incorrecta
                var result = await DisplayAlert("¡Incorrecto!", "Lo siento, has fallado.", "Seguir Jugando", "Volver a la ruleta");

                if (result)
                {
                    await Navigation.PushAsync(new LiteraturaPeruana4());
                }
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }
            }
        }
    }
}

