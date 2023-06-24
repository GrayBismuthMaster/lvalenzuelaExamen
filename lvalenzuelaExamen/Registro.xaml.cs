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
    public partial class Registro : ContentPage
    {
        string Usuario, Apellido, fecha, ciudad, pais;
        double montoInicial, pagoMensual;
        public Registro(string usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            lblUsuario.Text = usuario;
        }


        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

        }

        private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
            lblUsuario.Text = this.ciudad.ToString();
        }

        private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pais = pkPais.Items[pkPais.SelectedIndex];
            lblUsuario.Text = this.pais.ToString();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicked.Text = e.NewDate.ToShortDateString();
            DatePickerUno.IsVisible = false;
            this.fecha = e.NewDate.ToShortDateString();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {

        }

        private void txtMontoInicialLenin_TextChanged(object sender, TextChangedEventArgs e)
        {

            //Costo inicial
            double MontoInicial =Convert.ToDouble( txtMontoInicialLenin.Text);
            //RESTO EL COSTO INICIAL DE 1500
            double MontoInicialRestado = 1500 - MontoInicial;
            //MONTOINICIALRESTADO VIENE A SER EL RESTO Y ESTO HAY QUE DIVIDIR PARA 4
            double MontoInicialRestadoDivididoCuatro = MontoInicialRestado / 4;
            //CADA CUOTA SE SUMA EL 4 POR CIENTO DEL COSTO TOTAL
            //4 POR CIENTO DE 1500
            double CuatroPorCientoDelMontoInicial = MontoInicialRestadoDivididoCuatro * 0.4;
            //SUMA DEL 4 POR CIENTO EN EL COSTO MENSUAL
            double MontoMensualSumadoCuatroPorCiento = MontoInicialRestadoDivididoCuatro + CuatroPorCientoDelMontoInicial;
            txtpagoMensual.Text = MontoMensualSumadoCuatroPorCiento.ToString();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //Costo inicial
            double MontoInicial = Convert.ToDouble(txtMontoInicialLenin.Text);
            //RESTO EL COSTO INICIAL DE 1500
            double MontoInicialRestado = 1500 - MontoInicial;
            //MONTOINICIALRESTADO VIENE A SER EL RESTO Y ESTO HAY QUE DIVIDIR PARA 4
            double MontoInicialRestadoDivididoCuatro = MontoInicialRestado / 4;
            //CADA CUOTA SE SUMA EL 4 POR CIENTO DEL COSTO TOTAL
            //4 POR CIENTO DE 1500
            double CuatroPorCientoDelMontoInicial = MontoInicialRestadoDivididoCuatro * 0.4;
            //SUMA DEL 4 POR CIENTO EN EL COSTO MENSUAL
            double MontoMensualSumadoCuatroPorCiento = MontoInicialRestadoDivididoCuatro + CuatroPorCientoDelMontoInicial;
            txtpagoMensual.Text = MontoMensualSumadoCuatroPorCiento.ToString();
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(Usuario, txtApellido.Text, txtEdad.Text, this.fecha, this.ciudad,this.pais, txtMontoInicialLenin.Text, txtpagoMensual.Text ));
        }
    }
}