namespace Pantalla_Contraseña
{
    partial class FormGrupo
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
            this.lbl_NomGrupo = new System.Windows.Forms.Label();
            this.pic_GrupoAmigo = new System.Windows.Forms.PictureBox();
            this.btn_AgregarAmigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GrupoAmigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarAmigo)).BeginInit();
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
            this.btn_Volver.TabIndex = 20;
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
            this.btn_Config.TabIndex = 21;
            this.btn_Config.TabStop = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // lbl_NomGrupo
            // 
            this.lbl_NomGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NomGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomGrupo.Location = new System.Drawing.Point(857, 100);
            this.lbl_NomGrupo.Name = "lbl_NomGrupo";
            this.lbl_NomGrupo.Size = new System.Drawing.Size(600, 100);
            this.lbl_NomGrupo.TabIndex = 22;
            this.lbl_NomGrupo.Text = "lbl_NomGrupo";
            this.lbl_NomGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NomGrupo.Click += new System.EventHandler(this.lbl_NomGrupo_Click);
            // 
            // pic_GrupoAmigo
            // 
            this.pic_GrupoAmigo.Location = new System.Drawing.Point(800, 205);
            this.pic_GrupoAmigo.Name = "pic_GrupoAmigo";
            this.pic_GrupoAmigo.Size = new System.Drawing.Size(715, 335);
            this.pic_GrupoAmigo.TabIndex = 23;
            this.pic_GrupoAmigo.TabStop = false;
            // 
            // btn_AgregarAmigo
            // 
            this.btn_AgregarAmigo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarAmigo.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.AGREGAR_AMIGO__1_;
            this.btn_AgregarAmigo.Location = new System.Drawing.Point(907, 550);
            this.btn_AgregarAmigo.Name = "btn_AgregarAmigo";
            this.btn_AgregarAmigo.Size = new System.Drawing.Size(500, 134);
            this.btn_AgregarAmigo.TabIndex = 24;
            this.btn_AgregarAmigo.TabStop = false;
            // 
            // FormGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_AgregarAmigo);
            this.Controls.Add(this.pic_GrupoAmigo);
            this.Controls.Add(this.lbl_NomGrupo);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_Volver);
            this.Name = "FormGrupo";
            this.Text = "FormGrupo";
            this.Load += new System.EventHandler(this.FormGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GrupoAmigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarAmigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox btn_Config;
        private System.Windows.Forms.Label lbl_NomGrupo;
        private System.Windows.Forms.PictureBox pic_GrupoAmigo;
        private System.Windows.Forms.PictureBox btn_AgregarAmigo;
    }
}