
namespace Pantalla_Contraseña
{
    partial class FormPrincipal
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
            this.btn_Familia = new System.Windows.Forms.PictureBox();
            this.btn_Amigos = new System.Windows.Forms.PictureBox();
            this.btn_Config = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Familia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Amigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Familia
            // 
            this.btn_Familia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Familia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Familia.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_familia__1_;
            this.btn_Familia.Location = new System.Drawing.Point(582, 500);
            this.btn_Familia.Name = "btn_Familia";
            this.btn_Familia.Size = new System.Drawing.Size(300, 300);
            this.btn_Familia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Familia.TabIndex = 0;
            this.btn_Familia.TabStop = false;
            this.btn_Familia.Click += new System.EventHandler(this.btn_Familia_Click);
            // 
            // btn_Amigos
            // 
            this.btn_Amigos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Amigos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Amigos.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_amigos__1_;
            this.btn_Amigos.Location = new System.Drawing.Point(1038, 500);
            this.btn_Amigos.Name = "btn_Amigos";
            this.btn_Amigos.Size = new System.Drawing.Size(300, 300);
            this.btn_Amigos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Amigos.TabIndex = 1;
            this.btn_Amigos.TabStop = false;
            this.btn_Amigos.Click += new System.EventHandler(this.btn_Amigos_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.Transparent;
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.Image = global::Pantalla_Contraseña.Properties.Resources.Configuración;
            this.btn_Config.Location = new System.Drawing.Point(1781, 29);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(116, 122);
            this.btn_Config.TabIndex = 3;
            this.btn_Config.TabStop = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Volver.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_Volver;
            this.btn_Volver.Location = new System.Drawing.Point(30, 27);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(110, 110);
            this.btn_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Volver.TabIndex = 20;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Image = global::Pantalla_Contraseña.Properties.Resources.Salir;
            this.btn_Salir.Location = new System.Drawing.Point(1621, 18);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(276, 133);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Visible = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Pantalla_Contraseña.Properties.Resources.Logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(807, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo_Principal;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_Amigos);
            this.Controls.Add(this.btn_Familia);
            this.DoubleBuffered = true;
            this.Name = "FormPrincipal";
            this.Text = "Pantalla_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Familia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Amigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Familia;
        private System.Windows.Forms.PictureBox btn_Amigos;
        private System.Windows.Forms.PictureBox btn_Config;
        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}