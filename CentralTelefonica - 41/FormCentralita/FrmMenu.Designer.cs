namespace FormCentralita
{
    partial class FrmMenu
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProvincial = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(62, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(232, 68);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProvincial
            // 
            this.btnProvincial.Location = new System.Drawing.Point(62, 275);
            this.btnProvincial.Name = "btnProvincial";
            this.btnProvincial.Size = new System.Drawing.Size(232, 68);
            this.btnProvincial.TabIndex = 1;
            this.btnProvincial.Text = "Facturación provincial";
            this.btnProvincial.UseVisualStyleBackColor = true;
            this.btnProvincial.Click += new System.EventHandler(this.btnProvincial_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(62, 188);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(232, 68);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Facturación local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(62, 102);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(232, 68);
            this.btnTodas.TabIndex = 3;
            this.btnTodas.Text = "Facturación total";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(62, 19);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(232, 68);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar llamada";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnProvincial);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProvincial;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnGenerar;
    }
}

