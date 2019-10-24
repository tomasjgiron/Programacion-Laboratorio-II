using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace FormCentralita
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(string value) : this()
        {
            rtbMostrar.Text = value;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
        }
    }
}
