
namespace Pantalla_Contraseña
{
    partial class Creditos
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
            this.btn_Volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Boton_Volver;
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Volver.Location = new System.Drawing.Point(20, 20);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(124, 82);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Creditos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1618, 722);
            this.Controls.Add(this.btn_Volver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditos";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
    }
}