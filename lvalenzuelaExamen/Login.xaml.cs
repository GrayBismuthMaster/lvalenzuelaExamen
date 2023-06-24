using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lvalenzuelaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasenia = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContrasenia.Text == contrasenia)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Cerrar");
            }
        }
    }
}