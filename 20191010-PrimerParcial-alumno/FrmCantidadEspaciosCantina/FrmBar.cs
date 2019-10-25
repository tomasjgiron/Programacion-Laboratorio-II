using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantidadEspaciosCantina
{
    public partial class FrmBar : Form
    {
        public FrmBar()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBar formEspacios = new FrmBar();
            formEspacios.ShowDialog();
            
            if(formEspacios.ShowDialog() == DialogResult.OK)
            { 
            }
        }
    }
}
