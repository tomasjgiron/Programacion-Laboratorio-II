using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueria = new Comiqueria();
        Producto producto;

        public VentasForm(Comiqueria comiqueria, Producto producto)// no corresponde sobrecargar porque no hay que contruir un constructor vacío
        {
            InitializeComponent();

            this.comiqueria = comiqueria;
            this.producto = producto;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = producto.Descripcion;
            lblPrecioFinal.Text += producto.Precio.ToString();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = "Precio final: " + (producto.Precio * (double)numericUpDownCantidad.Value).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(numericUpDownCantidad.Value <= producto.Stock)
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Venta creada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha superado el stock disponible. Disminuya la cantidad.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
