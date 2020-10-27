using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChristianArtiedaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrirRegistro_clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "estudiante2020" && pass == "uisrael2020")
            {
                await Navigation.PushAsync(new Registro(user, pass));
            }
            else
                await DisplayAlert("Sistemas de Notas", "Usuario o Clave son incorrectos!!", "Cerrar");

        }
    }
}
