using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Criticon;
using Xamarin.Forms;

namespace Criticon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            string Nombre = NombreUser.Text;
            bool Hombre = RBhombre.IsChecked;
            bool Mujer = RBmujer.IsChecked;
            bool Alto = CheckAlto.IsChecked;
            bool Feo = CheckFeo.IsChecked;
            bool Listo = CheckListo.IsChecked;
            bool Extra = CheckExtravagante.IsChecked;
            bool Raro = CheckRaro.IsChecked;
            bool Grande = CheckGrande.IsChecked;

            if(!String.IsNullOrEmpty(Nombre))
            {
                if(Hombre || Mujer)
                {
                    string mensaje = $"{Nombre} es, {(Hombre ? "Hombre" : "Mujer")}, {(Alto ? "es alto" : "")}, " +
                        $"{(Feo ? "feo":"")} {(Listo ? "listo":"")}, {(Extra ? "Extravagante" : "")}, {(Raro ? "Raro":"")}, " +
                        $"{(Grande ? "Grande":"")}";
                    Criticaxd.Text = mensaje;
                }
                else
                {
                    DisplayAlert("Mensaje", "Por favor seleccione un genero", "Salir");
                }
            }
            else
            {
                DisplayAlert("Mensaje", "Por favor ingrese su nombre!", "Salir");
            }

        }
    }
}
