﻿
namespace Pantalla_Contraseña
{
    partial class AcercaDenosotros
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
            this.pic_TextoNosotros = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TextoNosotros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_TextoNosotros
            // 
            this.pic_TextoNosotros.BackColor = System.Drawing.Color.Transparent;
            this.pic_TextoNosotros.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.TextoAcercaDeNosotros;
            this.pic_TextoNosotros.Location = new System.Drawing.Point(165, 41);
            this.pic_TextoNosotros.Name = "pic_TextoNosotros";
            this.pic_TextoNosotros.Size = new System.Drawing.Size(1416, 680);
            this.pic_TextoNosotros.TabIndex = 0;
            this.pic_TextoNosotros.TabStop = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Boton_Volver;
            this.btn_Volver.Location = new System.Drawing.Point(29, 42);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(124, 122);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AcercaDenosotros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Rectangle_51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1634, 761);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.pic_TextoNosotros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcercaDenosotros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_TextoNosotros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_TextoNosotros;
        private System.Windows.Forms.PictureBox btn_Volver;
    }
}