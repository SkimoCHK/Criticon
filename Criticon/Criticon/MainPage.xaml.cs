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
            string[] mensajeH = new string[9];
            string[] mensajeM;

            string mensajefinal = "";


            for (int i = 0; i < mensajeH.Length; i++)
            {
                mensajefinal += mensajeH[i];
            }
            if(!String.IsNullOrEmpty(Nombre))
            {
                if(Hombre)
                {
                    string mensaje = $"{Nombre} es, {(Hombre ? mensajeH[0] = "Hombre" : null)}{(Alto ? mensajeH[1] = ", alto" : null)}" +
                        $"{(Feo ? mensajeH[2] = ", feo" :null)}{(Listo ? mensajeH[3]=", listo":null)}{(Extra ? ", Extravagante" : "")}{(Raro ? mensajeH[4]=", Raro":null)}" +
                        $"{(Grande ? mensajeH[5]=", Grande":null)}";
                    for(int i = 0;i < mensajeH.Length; i++)
                    Criticaxd.Text = mensaje;
                }
                else if (Mujer)
                {
                    string mensaje = $"{Nombre} es, {(Mujer ? "Mujer" : null)}{(Alto ? ", es alta" : null)}" +
                       $"{(Feo ? ", fea" : "")}{(Listo ? ", lista" : null)}{(Extra ? ", Extravagante" : null)}{(Raro ? ", Rara" : null)}" +
                       $"{(Grande ? ", Grande" : null)}";
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
