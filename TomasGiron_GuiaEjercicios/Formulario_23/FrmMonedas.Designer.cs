namespace Formulario_23
{
    partial class FrmMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblCotizacion.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblCotizacion.Location = new System.Drawing.Point(105, 26);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(124, 26);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(729, 18);
            this.txtCotizacionPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionPeso.Multiline = true;
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(135, 37);
            this.txtCotizacionPeso.TabIndex = 2;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCorizacionPeso_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(557, 18);
            this.txtCotizacionDolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionDolar.Multiline = true;
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(135, 37);
            this.txtCotizacionDolar.TabIndex = 5;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(384, 18);
            this.txtCotizacionEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionEuro.Multiline = true;
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(135, 37);
            this.txtCotizacionEuro.TabIndex = 6;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(384, 222);
            this.txtDolarAEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolarAEuro.Multiline = true;
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(135, 37);
            this.txtDolarAEuro.TabIndex = 7;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(729, 116);
            this.txtEuroAPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEuroAPeso.Multiline = true;
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(135, 37);
            this.txtEuroAPeso.TabIndex = 8;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(384, 116);
            this.txtEuroAEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEuroAEuro.Multiline = true;
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(135, 37);
            this.txtEuroAEuro.TabIndex = 9;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(557, 116);
            this.txtEuroADolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEuroADolar.Multiline = true;
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(135, 37);
            this.txtEuroADolar.TabIndex = 10;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(557, 222);
            this.txtDolarADolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolarADolar.Multiline = true;
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(135, 37);
            this.txtDolarADolar.TabIndex = 11;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(729, 222);
            this.txtDolarAPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolarAPeso.Multiline = true;
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(135, 37);
            this.txtDolarAPeso.TabIndex = 12;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(729, 326);
            this.txtPesoAPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesoAPeso.Multiline = true;
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(135, 37);
            this.txtPesoAPeso.TabIndex = 13;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(557, 326);
            this.txtPesoADolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesoADolar.Multiline = true;
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(135, 37);
            this.txtPesoADolar.TabIndex = 14;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(384, 327);
            this.txtPesoAEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesoAEuro.Multiline = true;
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(135, 37);
            this.txtPesoAEuro.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(101, 327);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(135, 37);
            this.txtPeso.TabIndex = 16;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(101, 223);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolar.Multiline = true;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(135, 37);
            this.txtDolar.TabIndex = 17;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(101, 116);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEuro.Multiline = true;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(135, 37);
            this.txtEuro.TabIndex = 18;
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblEuroA.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblEuroA.Location = new System.Drawing.Point(419, 75);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(62, 26);
            this.lblEuroA.TabIndex = 19;
            this.lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblDolarA.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDolarA.Location = new System.Drawing.Point(595, 75);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(70, 26);
            this.lblDolarA.TabIndex = 20;
            this.lblDolarA.Text = "Dólar";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblPesoA.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPesoA.Location = new System.Drawing.Point(759, 75);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(61, 26);
            this.lblPesoA.TabIndex = 21;
            this.lblPesoA.Text = "Peso";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblEuro.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblEuro.Location = new System.Drawing.Point(17, 121);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(62, 26);
            this.lblEuro.TabIndex = 22;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblDolar.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDolar.Location = new System.Drawing.Point(17, 226);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(70, 26);
            this.lblDolar.TabIndex = 23;
            this.lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblPeso.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPeso.Location = new System.Drawing.Point(17, 331);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 26);
            this.lblPeso.TabIndex = 24;
            this.lblPeso.Text = "Peso";
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(259, 116);
            this.btnConvertEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(93, 37);
            this.btnConvertEuro.TabIndex = 25;
            this.btnConvertEuro.Text = "> > >";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(259, 224);
            this.btnConvertDolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(93, 36);
            this.btnConvertDolar.TabIndex = 26;
            this.btnConvertDolar.Text = "> > >";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(259, 326);
            this.btnConvertPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(93, 36);
            this.btnConvertPeso.TabIndex = 27;
            this.btnConvertPeso.Text = "> > >";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(259, 21);
            this.btnLockCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(93, 36);
            this.btnLockCotizacion.TabIndex = 4;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_lock_green_68949.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_lock-unlock_green_68950.png");
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 409);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.lblCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario.23";
            this.Load += new System.EventHandler(this.FrmMonedas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.ImageList imageList1;
    }
}

