using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Moneda;

namespace Formulario_23
{
    public partial class FrmMonedas : Form
    {
        public FrmMonedas()
        {
            InitializeComponent();
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
        }

        //preguntar en donde establecer/convertir que lo que estará dentro de los
        //txtCotizacion sea string en lugar de double

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)//puedo usar cualquier de las 3 monedas como condicion
            {
                btnLockCotizacion.Image = btnLockCotizacion.ImageList.Images[0];//preguntar si la línea es correcta, ya que parece redundante
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnLockCotizacion.Image = btnLockCotizacion.ImageList.Images[1];//mismo que línea 33
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
            //preguntar de qué manera cambia la imagen del candado
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double texto;
            if(double.TryParse(txtEuro.Text,out texto))
            {
                Euro token = new Euro(texto);
                //Dolar d = new Dolar(texto);//declaro una variable tipo Dolar, ya que debo convertir desde Euro
                //Peso p = new Peso(texto);//declaro una variable tipo Peso, ya que debo convertir desde Euro

                txtEuroAEuro.Text = token.GetCantidad().ToString();//queda igual porque ya es Euro
                txtEuroADolar.Text = ((Dolar)token).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Peso)token).GetCantidad().ToString();
                //txtEuroADolar.Text = ((Euro)d).GetCantidad().ToString();//convierto a Euro y paso a String
                //txtEuroAPeso.Text = ((Euro)p).GetCantidad().ToString();//convierto a Euro y paso a String
            }
            else//si lo ingresado no es correcto todos los campos muestran 0(string)
            {
                txtEuroAEuro.Text = "0";
                txtEuroADolar.Text = "0";
                txtEuroAPeso.Text = "0";
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionEuro.Focus();
                    //se puede mejorar
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCorizacionPeso_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionPeso.Text, out aux))
            {
                Peso.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionPeso.Focus();
            }
        }
    }
}
