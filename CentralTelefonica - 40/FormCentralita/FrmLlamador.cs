using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FormCentralita;

namespace FormCentralita
{
    public partial class FrmLlamador : Form
    {
        Centralita central;
        TextBox focus = new TextBox();

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita central) : this()
        {
            this.central = central;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }
        #region numeros
        private void btnUno_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("9");
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("*");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("0");
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            LimpiarConcatenar("#");
        }
        #endregion

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int randomDuracion = num.Next(1, 50);
            string mensaje = string.Empty;

            if(txtDestino.Text != "Nro Destino" && txtOrigen.Text != "Nro Origen")
            {
                if (txtDestino.Text.StartsWith("#"))
                {
                    // Carga 
                    cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                    // Lectura 
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                    Provincial prov = new Provincial(txtOrigen.Text, franjas, (float)randomDuracion, txtDestino.Text);
                    central += prov;
                }
                else
                {
                    int randomCosto = num.Next(5, 56);
                    float costoFloat = randomCosto / 10;
                    Local loc = new Local(txtOrigen.Text, costoFloat, txtDestino.Text, (float)randomDuracion);
                    central += loc;
                }
                mensaje = "Llamada creada exitosamente";
                btnLimpiar_Click(sender, e);

            }
            else
            {
                mensaje = "Error. Ingresar una llamada";
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = "Nro Destino";
            txtOrigen.Text = "Nro Origen";
        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalirLlamador_Click(object sender, EventArgs e)
        {
            Form aux = new FrmMenu(central);
            this.Close();
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LimpiarConcatenar(string nroIngresado)
        {
            if(focus.Text == "Nro Destino" || focus.Text == "Nro Origen")
            {
                focus.Text = nroIngresado; //limpiar al ingresar el primer número
            }
            else
            {
                focus.Text += nroIngresado; //si ya no está NroDestino concateno números
            }
        }

        private void txtDestino_Click(object sender, EventArgs e)
        {
            focus = txtDestino;
        }

        private void txtOrigen_Click(object sender, EventArgs e)
        {
            focus = txtOrigen;
        }
    }
}
