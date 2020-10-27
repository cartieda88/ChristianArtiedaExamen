using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristianArtiedaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double total;
        double cuota;
        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            var monto = Convert.ToDouble(txtMonto.Text);
            if (txtNombre.Text != "")
            {
                if (monto != 1800)
                {
                    double pagoM = 1800 - monto;
                    double cuota = (((pagoM / 3) * 0.05) + (pagoM / 3));
                    txtPago.Text = cuota.ToString();
                }
                else
                {
                    await DisplayAlert("Advertencia", "El valor del curso no es el correcto", "Aceptar");
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "Todos los campos son obligatorios", "Aceptar");
            }



        }

        private async void btnGuardarRegistro_Clicked(object sender, EventArgs e)
        {

                await DisplayAlert("Alerta", "Elemento guardado con exito.", "Enviar.:!!");
                var monto = Convert.ToDouble(txtMonto.Text);
                double pagoM = 1800 - monto;
                double cuota = (((pagoM / 3) * 0.05) + (pagoM / 3));
                double total = cuota * 3;   
                txtPago.Text = total.ToString();
            await Navigation.PushModalAsync(new Resumen(lblUser.Text, txtNombre.Text, total));
            
        }
    }
}