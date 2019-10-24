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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(Centralita central) : this()
        {
            this.central = central;
        }

        private Centralita central = new Centralita("Tomi Center");

        public Centralita Central
        {
            get { return this.central; }
            set { central = value; }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Form formLlamador = new FrmLlamador(central);
            formLlamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            Form frmMostrar = new FrmMostrar(central.Mostrar());
            frmMostrar.ShowDialog();
            /*
            string aux = "No se hicieron llamadas";
            if(central.ListLlamadas.Count > 0)
            {
                aux = central.Mostrar();
            }
            MessageBox.Show(aux);
            */
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            foreach(Llamada call in central.ListLlamadas)
            {
                if(call is Local)
                {
                    aux += call.ToString() + "\n";
                }
            }
            if(string.IsNullOrEmpty(aux))
            {
                aux = "No se hicieron llamadas locales";
            }
            //MessageBox.Show(aux); //esta es otra opcion para mostrar los datos

            Form frmMostrar = new FrmMostrar(aux);
            frmMostrar.Show();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            foreach (Llamada call in central.ListLlamadas)
            {
                if (call is Provincial)
                {
                    aux += call.ToString() + "\n";
                }
            }
            if (string.IsNullOrEmpty(aux))
            {
                aux = "No se hicieron llamadas provinciales";
            }
            //MessageBox.Show(aux);
            Form frmMostrar = new FrmMostrar(aux);
            frmMostrar.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            central = CrearLlamadas();
        }

        private Centralita CrearLlamadas()
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial prueba = new Provincial("Gerli", Provincial.Franja.Franja_2, 12, "Caballito");
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, prueba);

            // Las llamadas se irán registrando en la Centralita. 
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 
            c += l1;
            c += l2;
            c += l3;
            c += l4;

            return c;
        }
    }
}
