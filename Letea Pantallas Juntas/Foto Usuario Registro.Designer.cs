namespace Pantalla_Contraseña
{
    partial class FormFotoUsuarioRegistro
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
            this.pic_usuariofoto = new System.Windows.Forms.PictureBox();
            this.pic_text_fotodeperfil = new System.Windows.Forms.PictureBox();
            this.btn_agregarfoto = new System.Windows.Forms.PictureBox();
            this.btn_crearfotousuario = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuariofoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_fotodeperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfotousuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_usuariofoto
            // 
            this.pic_usuariofoto.BackColor = System.Drawing.Color.Transparent;
            this.pic_usuariofoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Parte_Superior2;
            this.pic_usuariofoto.Location = new System.Drawing.Point(0, -36);
            this.pic_usuariofoto.Name = "pic_usuariofoto";
            this.pic_usuariofoto.Size = new System.Drawing.Size(1920, 323);
            this.pic_usuariofoto.TabIndex = 0;
            this.pic_usuariofoto.TabStop = false;
            // 
            // pic_text_fotodeperfil
            // 
            this.pic_text_fotodeperfil.BackColor = System.Drawing.Color.Transparent;
            this.pic_text_fotodeperfil.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Agregar_foto;
            this.pic_text_fotodeperfil.Location = new System.Drawing.Point(625, 296);
            this.pic_text_fotodeperfil.Name = "pic_text_fotodeperfil";
            this.pic_text_fotodeperfil.Size = new System.Drawing.Size(654, 104);
            this.pic_text_fotodeperfil.TabIndex = 1;
            this.pic_text_fotodeperfil.TabStop = false;
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Agregar_Imagen;
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarfoto.Location = new System.Drawing.Point(733, 390);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(433, 433);
            this.btn_agregarfoto.TabIndex = 2;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.click_agregarfoto);
            // 
            // btn_crearfotousuario
            // 
            this.btn_crearfotousuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_crearfotousuario.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Siguiente1;
            this.btn_crearfotousuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearfotousuario.Location = new System.Drawing.Point(818, 856);
            this.btn_crearfotousuario.Name = "btn_crearfotousuario";
            this.btn_crearfotousuario.Size = new System.Drawing.Size(263, 109);
            this.btn_crearfotousuario.TabIndex = 3;
            this.btn_crearfotousuario.TabStop = false;
            this.btn_crearfotousuario.Click += new System.EventHandler(this.click_crearfotousuario);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFotoUsuarioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_crearfotousuario);
            this.Controls.Add(this.btn_agregarfoto);
            this.Controls.Add(this.pic_text_fotodeperfil);
            this.Controls.Add(this.pic_usuariofoto);
            this.Name = "FormFotoUsuarioRegistro";
            this.Text = "Foto_Usuario_registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Foto_Usuario_registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuariofoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_fotodeperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfotousuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_usuariofoto;
        private System.Windows.Forms.PictureBox pic_text_fotodeperfil;
        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.PictureBox btn_crearfotousuario;
        private System.Windows.Forms.Button button1;
    }
}