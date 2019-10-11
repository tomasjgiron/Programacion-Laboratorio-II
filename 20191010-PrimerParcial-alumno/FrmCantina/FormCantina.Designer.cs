namespace FrmCantina
{
    partial class FormCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.barra = new ControlCantina.Barra();
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.rdBtnAgua = new System.Windows.Forms.RadioButton();
            this.rdBtnCerveza = new System.Windows.Forms.RadioButton();
            this.gpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(16, 2);
            this.barra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(783, 395);
            this.barra.TabIndex = 0;
            // 
            // gpBox1
            // 
            this.gpBox1.Controls.Add(this.txtBoxMarca);
            this.gpBox1.Controls.Add(this.numContenido);
            this.gpBox1.Controls.Add(this.numCapacidad);
            this.gpBox1.Controls.Add(this.btnAgregar);
            this.gpBox1.Controls.Add(this.cmbBoxTipo);
            this.gpBox1.Controls.Add(this.lblBotellaTipo);
            this.gpBox1.Controls.Add(this.lblContenido);
            this.gpBox1.Controls.Add(this.lblCapacidad);
            this.gpBox1.Controls.Add(this.lblMarca);
            this.gpBox1.Controls.Add(this.rdBtnAgua);
            this.gpBox1.Controls.Add(this.rdBtnCerveza);
            this.gpBox1.Location = new System.Drawing.Point(16, 405);
            this.gpBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBox1.Size = new System.Drawing.Size(783, 175);
            this.gpBox1.TabIndex = 1;
            this.gpBox1.TabStop = false;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(175, 42);
            this.txtBoxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(199, 22);
            this.txtBoxMarca.TabIndex = 10;
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(305, 98);
            this.numContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(69, 22);
            this.numContenido.TabIndex = 9;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(175, 98);
            this.numCapacidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(73, 22);
            this.numCapacidad.TabIndex = 8;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(412, 75);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 48);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Location = new System.Drawing.Point(412, 42);
            this.cmbBoxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxTipo.TabIndex = 6;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(408, 20);
            this.lblBotellaTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(83, 17);
            this.lblBotellaTipo.TabIndex = 5;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(301, 75);
            this.lblContenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(72, 17);
            this.lblContenido.TabIndex = 4;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(171, 75);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidad.TabIndex = 3;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(171, 20);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // rdBtnAgua
            // 
            this.rdBtnAgua.AutoSize = true;
            this.rdBtnAgua.Location = new System.Drawing.Point(8, 59);
            this.rdBtnAgua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnAgua.Name = "rdBtnAgua";
            this.rdBtnAgua.Size = new System.Drawing.Size(62, 21);
            this.rdBtnAgua.TabIndex = 1;
            this.rdBtnAgua.TabStop = true;
            this.rdBtnAgua.Text = "Agua";
            this.rdBtnAgua.UseVisualStyleBackColor = true;
            // 
            // rdBtnCerveza
            // 
            this.rdBtnCerveza.AutoSize = true;
            this.rdBtnCerveza.Location = new System.Drawing.Point(8, 27);
            this.rdBtnCerveza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnCerveza.Name = "rdBtnCerveza";
            this.rdBtnCerveza.Size = new System.Drawing.Size(81, 21);
            this.rdBtnCerveza.TabIndex = 0;
            this.rdBtnCerveza.TabStop = true;
            this.rdBtnCerveza.Text = "Cerveza";
            this.rdBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 594);
            this.Controls.Add(this.gpBox1);
            this.Controls.Add(this.barra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Alumno Tomás Girón";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra;
        private System.Windows.Forms.GroupBox gpBox1;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton rdBtnAgua;
        private System.Windows.Forms.RadioButton rdBtnCerveza;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBoxMarca;
    }
}

