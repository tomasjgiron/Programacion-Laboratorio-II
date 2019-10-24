namespace FormCentralita
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(164, 46);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(463, 343);
            this.rtbMostrar.TabIndex = 0;
            this.rtbMostrar.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMostrar);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}