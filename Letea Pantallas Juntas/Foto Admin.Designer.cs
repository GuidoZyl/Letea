
namespace Pantalla_Contraseña
{
    partial class FormFotoAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_text_agregarfotodeperfil = new System.Windows.Forms.PictureBox();
            this.btn_crearfoto = new System.Windows.Forms.PictureBox();
            this.pic_PerfilDefault = new System.Windows.Forms.PictureBox();
            this.btn_agregarfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_agregarfotodeperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PerfilDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Parte_Superior;
            this.pictureBox1.Location = new System.Drawing.Point(0, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_text_agregarfotodeperfil
            // 
            this.pic_text_agregarfotodeperfil.BackColor = System.Drawing.Color.Transparent;
            this.pic_text_agregarfotodeperfil.Location = new System.Drawing.Point(625, 296);
            this.pic_text_agregarfotodeperfil.Name = "pic_text_agregarfotodeperfil";
            this.pic_text_agregarfotodeperfil.Size = new System.Drawing.Size(654, 104);
            this.pic_text_agregarfotodeperfil.TabIndex = 2;
            this.pic_text_agregarfotodeperfil.TabStop = false;
            this.pic_text_agregarfotodeperfil.Click += new System.EventHandler(this.pic_text_agregarfotodeperfil_Click);
            // 
            // btn_crearfoto
            // 
            this.btn_crearfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_crearfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Crear;
            this.btn_crearfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crearfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearfoto.Location = new System.Drawing.Point(818, 856);
            this.btn_crearfoto.Name = "btn_crearfoto";
            this.btn_crearfoto.Size = new System.Drawing.Size(263, 118);
            this.btn_crearfoto.TabIndex = 4;
            this.btn_crearfoto.TabStop = false;
            this.btn_crearfoto.Click += new System.EventHandler(this.click_crearfoto);
            // 
            // pic_PerfilDefault
            // 
            this.pic_PerfilDefault.Image = global::Pantalla_Contraseña.Properties.Resources.Perfil_Vacío;
            this.pic_PerfilDefault.Location = new System.Drawing.Point(86, 357);
            this.pic_PerfilDefault.Name = "pic_PerfilDefault";
            this.pic_PerfilDefault.Size = new System.Drawing.Size(300, 300);
            this.pic_PerfilDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PerfilDefault.TabIndex = 5;
            this.pic_PerfilDefault.TabStop = false;
            this.pic_PerfilDefault.Visible = false;
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.que_lindo_boton;
            this.btn_agregarfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarfoto.Location = new System.Drawing.Point(752, 418);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(400, 400);
            this.btn_agregarfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_agregarfoto.TabIndex = 6;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.btn_agregarfoto_Click);
            this.btn_agregarfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_agregarfoto_Paint);
            // 
            // FormFotoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_agregarfoto);
            this.Controls.Add(this.pic_PerfilDefault);
            this.Controls.Add(this.btn_crearfoto);
            this.Controls.Add(this.pic_text_agregarfotodeperfil);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormFotoAdmin";
            this.Text = "Foto Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_agregarfotodeperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PerfilDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_text_agregarfotodeperfil;
        private System.Windows.Forms.PictureBox btn_crearfoto;
        private System.Windows.Forms.PictureBox pic_PerfilDefault;
        private System.Windows.Forms.PictureBox btn_agregarfoto;
    }
}