namespace FrmCantina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barra1 = new ControlCantina.Barra();
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.rdBtnAgua = new System.Windows.Forms.RadioButton();
            this.rdBtnCerveza = new System.Windows.Forms.RadioButton();
            this.gpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(587, 321);
            this.barra1.TabIndex = 0;
            // 
            // gpBox1
            // 
            this.gpBox1.Controls.Add(this.txtBoxMarca);
            this.gpBox1.Controls.Add(this.numericUpDown2);
            this.gpBox1.Controls.Add(this.numericUpDown1);
            this.gpBox1.Controls.Add(this.btnAgregar);
            this.gpBox1.Controls.Add(this.cmbBoxTipo);
            this.gpBox1.Controls.Add(this.lblBotellaTipo);
            this.gpBox1.Controls.Add(this.lblContenido);
            this.gpBox1.Controls.Add(this.lblCapacidad);
            this.gpBox1.Controls.Add(this.lblMarca);
            this.gpBox1.Controls.Add(this.rdBtnAgua);
            this.gpBox1.Controls.Add(this.rdBtnCerveza);
            this.gpBox1.Location = new System.Drawing.Point(12, 329);
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.Size = new System.Drawing.Size(587, 142);
            this.gpBox1.TabIndex = 1;
            this.gpBox1.TabStop = false;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(131, 34);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(150, 20);
            this.txtBoxMarca.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(229, 80);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(309, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Location = new System.Drawing.Point(309, 34);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTipo.TabIndex = 6;
            this.cmbBoxTipo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipo_SelectedIndexChanged);
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(306, 16);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 5;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(226, 61);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 4;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(128, 61);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 3;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(128, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // rdBtnAgua
            // 
            this.rdBtnAgua.AutoSize = true;
            this.rdBtnAgua.Location = new System.Drawing.Point(6, 48);
            this.rdBtnAgua.Name = "rdBtnAgua";
            this.rdBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rdBtnAgua.TabIndex = 1;
            this.rdBtnAgua.TabStop = true;
            this.rdBtnAgua.Text = "Agua";
            this.rdBtnAgua.UseVisualStyleBackColor = true;
            // 
            // rdBtnCerveza
            // 
            this.rdBtnCerveza.AutoSize = true;
            this.rdBtnCerveza.Location = new System.Drawing.Point(6, 22);
            this.rdBtnCerveza.Name = "rdBtnCerveza";
            this.rdBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdBtnCerveza.TabIndex = 0;
            this.rdBtnCerveza.TabStop = true;
            this.rdBtnCerveza.Text = "Cerveza";
            this.rdBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 483);
            this.Controls.Add(this.gpBox1);
            this.Controls.Add(this.barra1);
            this.Name = "Form1";
            this.Text = "Alumno Tomás Girón";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.GroupBox gpBox1;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton rdBtnAgua;
        private System.Windows.Forms.RadioButton rdBtnCerveza;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBoxMarca;
    }
}

