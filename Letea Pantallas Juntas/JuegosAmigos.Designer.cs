
namespace Pantalla_Contraseña
{
    partial class JuegosAmigos
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
            this.btn_Config = new System.Windows.Forms.PictureBox();
            this.pic_Juegos = new System.Windows.Forms.PictureBox();
            this.btn_Preguntas = new System.Windows.Forms.PictureBox();
            this.btn_AsociandoNombres = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Juegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Preguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AsociandoNombres)).BeginInit();
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
            this.btn_Volver.TabIndex = 21;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.Transparent;
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.Image = global::Pantalla_Contraseña.Properties.Resources.Configuración;
            this.btn_Config.Location = new System.Drawing.Point(1781, 30);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(116, 122);
            this.btn_Config.TabIndex = 22;
            this.btn_Config.TabStop = false;
            this.btn_Config.Visible = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // pic_Juegos
            // 
            this.pic_Juegos.BackColor = System.Drawing.Color.Transparent;
            this.pic_Juegos.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Juegos;
            this.pic_Juegos.Location = new System.Drawing.Point(778, 33);
            this.pic_Juegos.Name = "pic_Juegos";
            this.pic_Juegos.Size = new System.Drawing.Size(364, 225);
            this.pic_Juegos.TabIndex = 23;
            this.pic_Juegos.TabStop = false;
            // 
            // btn_Preguntas
            // 
            this.btn_Preguntas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Preguntas.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Boton_PREGUNTAS;
            this.btn_Preguntas.Location = new System.Drawing.Point(231, 365);
            this.btn_Preguntas.Name = "btn_Preguntas";
            this.btn_Preguntas.Size = new System.Drawing.Size(544, 387);
            this.btn_Preguntas.TabIndex = 24;
            this.btn_Preguntas.TabStop = false;
            this.btn_Preguntas.Click += new System.EventHandler(this.btn_Preguntas_Click);
            // 
            // btn_AsociandoNombres
            // 
            this.btn_AsociandoNombres.BackColor = System.Drawing.Color.Transparent;
            this.btn_AsociandoNombres.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Boton_ASOCIANDO_NOMBRES;
            this.btn_AsociandoNombres.Location = new System.Drawing.Point(1156, 365);
            this.btn_AsociandoNombres.Name = "btn_AsociandoNombres";
            this.btn_AsociandoNombres.Size = new System.Drawing.Size(544, 387);
            this.btn_AsociandoNombres.TabIndex = 25;
            this.btn_AsociandoNombres.TabStop = false;
            this.btn_AsociandoNombres.Click += new System.EventHandler(this.btn_AsociandoNombres_Click);
            // 
            // JuegosAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_AsociandoNombres);
            this.Controls.Add(this.btn_Preguntas);
            this.Controls.Add(this.pic_Juegos);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_Volver);
            this.Name = "JuegosAmigos";
            this.Text = "JuegosAmigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Juegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Preguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AsociandoNombres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox btn_Config;
        private System.Windows.Forms.PictureBox pic_Juegos;
        private System.Windows.Forms.PictureBox btn_Preguntas;
        private System.Windows.Forms.PictureBox btn_AsociandoNombres;
    }
}