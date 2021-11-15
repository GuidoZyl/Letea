
namespace Pantalla_Contraseña
{
    partial class JuegoArbol
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
            this.pic_CuloGris = new System.Windows.Forms.PictureBox();
            this.pic_IntentelodeNuevo = new System.Windows.Forms.PictureBox();
            this.pic_BienHecho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CuloGris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IntentelodeNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BienHecho)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Volver.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_Volver;
            this.btn_Volver.Location = new System.Drawing.Point(30, 30);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(110, 110);
            this.btn_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Volver.TabIndex = 23;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // pic_CuloGris
            // 
            this.pic_CuloGris.Image = global::Pantalla_Contraseña.Properties.Resources.culogris;
            this.pic_CuloGris.Location = new System.Drawing.Point(26, 202);
            this.pic_CuloGris.Name = "pic_CuloGris";
            this.pic_CuloGris.Size = new System.Drawing.Size(13, 25);
            this.pic_CuloGris.TabIndex = 24;
            this.pic_CuloGris.TabStop = false;
            // 
            // pic_IntentelodeNuevo
            // 
            this.pic_IntentelodeNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pic_IntentelodeNuevo.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Frame_14__2_;
            this.pic_IntentelodeNuevo.Location = new System.Drawing.Point(422, 886);
            this.pic_IntentelodeNuevo.Name = "pic_IntentelodeNuevo";
            this.pic_IntentelodeNuevo.Size = new System.Drawing.Size(1022, 128);
            this.pic_IntentelodeNuevo.TabIndex = 66;
            this.pic_IntentelodeNuevo.TabStop = false;
            this.pic_IntentelodeNuevo.Visible = false;
            // 
            // pic_BienHecho
            // 
            this.pic_BienHecho.BackColor = System.Drawing.Color.Transparent;
            this.pic_BienHecho.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Frame_14__4_;
            this.pic_BienHecho.Location = new System.Drawing.Point(601, 886);
            this.pic_BienHecho.Name = "pic_BienHecho";
            this.pic_BienHecho.Size = new System.Drawing.Size(667, 128);
            this.pic_BienHecho.TabIndex = 67;
            this.pic_BienHecho.TabStop = false;
            this.pic_BienHecho.Visible = false;
            // 
            // JuegoArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pic_BienHecho);
            this.Controls.Add(this.pic_IntentelodeNuevo);
            this.Controls.Add(this.pic_CuloGris);
            this.Controls.Add(this.btn_Volver);
            this.Name = "JuegoArbol";
            this.Text = "JuegoArbol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JuegoArbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CuloGris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IntentelodeNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BienHecho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox pic_CuloGris;
        private System.Windows.Forms.PictureBox pic_IntentelodeNuevo;
        private System.Windows.Forms.PictureBox pic_BienHecho;
    }
}