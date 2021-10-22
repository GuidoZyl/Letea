
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
            this.btn_CrearPaciente = new System.Windows.Forms.PictureBox();
            this.btn_Config = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Familia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Amigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CrearPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Familia
            // 
            this.btn_Familia.Location = new System.Drawing.Point(582, 500);
            this.btn_Familia.Name = "btn_Familia";
            this.btn_Familia.Size = new System.Drawing.Size(300, 300);
            this.btn_Familia.TabIndex = 0;
            this.btn_Familia.TabStop = false;
            // 
            // btn_Amigos
            // 
            this.btn_Amigos.Location = new System.Drawing.Point(1038, 500);
            this.btn_Amigos.Name = "btn_Amigos";
            this.btn_Amigos.Size = new System.Drawing.Size(300, 300);
            this.btn_Amigos.TabIndex = 1;
            this.btn_Amigos.TabStop = false;
            // 
            // btn_CrearPaciente
            // 
            this.btn_CrearPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btn_CrearPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CrearPaciente.Image = global::Pantalla_Contraseña.Properties.Resources.Crear_paciente;
            this.btn_CrearPaciente.Location = new System.Drawing.Point(725, 867);
            this.btn_CrearPaciente.Name = "btn_CrearPaciente";
            this.btn_CrearPaciente.Size = new System.Drawing.Size(485, 120);
            this.btn_CrearPaciente.TabIndex = 2;
            this.btn_CrearPaciente.TabStop = false;
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.Transparent;
            this.btn_Config.Image = global::Pantalla_Contraseña.Properties.Resources.Configuración;
            this.btn_Config.Location = new System.Drawing.Point(1781, 29);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(116, 122);
            this.btn_Config.TabIndex = 3;
            this.btn_Config.TabStop = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo_Principal;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_CrearPaciente);
            this.Controls.Add(this.btn_Amigos);
            this.Controls.Add(this.btn_Familia);
            this.DoubleBuffered = true;
            this.Name = "FormPrincipal";
            this.Text = "Pantalla_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Familia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Amigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CrearPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Familia;
        private System.Windows.Forms.PictureBox btn_Amigos;
        private System.Windows.Forms.PictureBox btn_CrearPaciente;
        private System.Windows.Forms.PictureBox btn_Config;
    }
}