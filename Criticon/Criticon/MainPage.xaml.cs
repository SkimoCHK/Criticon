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
            string mensaje = $"{Nombre} es";

            if (Alto || Feo || Listo || Extra || Raro || Grande)
            {
                if (!String.IsNullOrEmpty(Nombre))
                {
                    if (Hombre)
                    {
                        mensaje += ", hombre";
                        mensaje += Alto ? ", alto" : "";
                        mensaje += Feo ? ", feo" : "";
                        mensaje += Listo ? ", listo" : "";
                        mensaje += Extra ? ", extravagante" : "";
                        mensaje += Raro ? ", raro" : "";
                        mensaje += Grande ? ", grande" : "";
                        int indice = mensaje.LastIndexOf(",");
                        string puntoBuscado = ", ";
                        mensaje = mensaje.Remove(indice, puntoBuscado.Length).Insert(indice, " y ");
                        Criticaxd.Text = mensaje;


                    }
                    else if (Mujer)
                    {
                        mensaje += ", mujer";
                        mensaje = $"{Nombre} es " + (Mujer ? ", mujer" : null);
                        mensaje += Alto ? ", alta" : "";
                        mensaje += Feo ? ", fea" : "";
                        mensaje += Listo ? ", lista" : "";
                        mensaje += Extra ? ", extravagante" : "";
                        mensaje += Raro ? ", rara" : "";
                        mensaje += Grande ? ", grande" : "";
                        int indice = mensaje.LastIndexOf(",");
                        string puntoBuscado = ", ";
                        mensaje = mensaje.Remove(indice, puntoBuscado.Length).Insert(indice, " y ");
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
            else
            {
                DisplayAlert("Mensaje:", "Tiene que marcar al menos una casilla", "Salir");
            }




        }
    }
}
