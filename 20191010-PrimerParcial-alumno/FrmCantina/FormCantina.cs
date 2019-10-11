﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;

namespace FrmCantina
{
    public partial class FormCantina : Form
    {
        public FormCantina()
        {
            InitializeComponent();
            this.barra.SetCantina = Cantina.GetCantina(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBoxTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtBoxMarca.Text;
            int capacidad = (int)numCapacidad.Value;
            int contenido = (int)numContenido.Value;
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBoxTipo.SelectedValue.ToString(), out tipo);

            if (rdBtnCerveza.Checked)
            {
                Cerveza c = new Cerveza(capacidad, contenido, marca, tipo);
                barra.AgregarBotella(c);
            }
            else if(rdBtnAgua.Checked)
            {
                Agua a = new Agua(capacidad, contenido, marca);
                barra.AgregarBotella(a);
            }
        }

    }
}