
namespace Pantalla_Contraseña
{
    partial class FormPacientes
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
            this.btn_FlechaIzq = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_FlechaIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FlechaIzq
            // 
            this.btn_FlechaIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_FlechaIzq.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.FLECHA_IZQUIERDA;
            this.btn_FlechaIzq.Location = new System.Drawing.Point(79, 500);
            this.btn_FlechaIzq.Name = "btn_FlechaIzq";
            this.btn_FlechaIzq.Size = new System.Drawing.Size(63, 98);
            this.btn_FlechaIzq.TabIndex = 0;
            this.btn_FlechaIzq.TabStop = false;
            this.btn_FlechaIzq.Click += new System.EventHandler(this.flechaizquierda_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.FLECHA_DERECHA;
            this.pictureBox1.Location = new System.Drawing.Point(1778, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_FlechaIzq);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_FlechaIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_FlechaIzq;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}