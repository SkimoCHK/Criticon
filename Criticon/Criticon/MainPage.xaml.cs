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
        public string Remplazar(string Message)
        {           
            while (Message.Contains("o"))
            {
                int femenino = Message.IndexOf("o");
                Message = Message.Remove(femenino, "o".Length).Insert(femenino, "a");
            } 
            return Message;
        }
        public string mensaje;
        public string datos;
        private void Button_Clicked(object sender, EventArgs e)
        {
   
            datos = NombreUser.Text + " es";
          
            if (CheckAlto.IsChecked || CheckFeo.IsChecked || CheckListo.IsChecked || CheckExtravagante.IsChecked || CheckRaro.IsChecked || CheckGrande.IsChecked)
            {
                if (!String.IsNullOrEmpty(datos))
                {
                    mensaje ="";
                    mensaje += RBhombre.IsChecked ? " hombre" : " mujer";
                    mensaje += CheckAlto.IsChecked ? ", alto" : "";
                    mensaje += CheckFeo.IsChecked ? ", feo" : "";
                    mensaje += CheckListo.IsChecked ? ", listo" : "";
                    mensaje += CheckExtravagante.IsChecked ? ", extravagante" : "";
                    mensaje += CheckRaro.IsChecked ? ", raro" : "";
                    mensaje += CheckGrande.IsChecked ? ", grande" : "";
                    int indice = mensaje.LastIndexOf(",");
                    string puntoBuscado = ", ";
                    mensaje = mensaje.Remove(indice, puntoBuscado.Length).Insert(indice, " y ");

                    if (RBhombre.IsChecked)
                    {
                        datos += mensaje;
                        Criticaxd.Text = datos;
                    }
                    else if (RBmujer.IsChecked)
                    {
                        mensaje = Remplazar(mensaje);
                        datos+= mensaje;
                        Criticaxd.Text = datos;
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
