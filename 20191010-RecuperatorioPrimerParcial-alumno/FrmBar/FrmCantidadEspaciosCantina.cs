using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBar
{
    public partial class FrmCantidadEspaciosCantina : Form
    {
        public FrmCantidadEspaciosCantina()
        {
            InitializeComponent();
        }

        public short CantidadEspacios
        {
            get
            {
                return (short)nudCantidad.Value;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(btnAceptar.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
