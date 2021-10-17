
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFotoAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_text_agregarfotodeperfil = new System.Windows.Forms.PictureBox();
            this.btn_agregarfoto = new System.Windows.Forms.PictureBox();
            this.btn_crearfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_agregarfotodeperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfoto)).BeginInit();
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
            this.pic_text_agregarfotodeperfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_text_agregarfotodeperfil.BackgroundImage")));
            this.pic_text_agregarfotodeperfil.Location = new System.Drawing.Point(625, 296);
            this.pic_text_agregarfotodeperfil.Name = "pic_text_agregarfotodeperfil";
            this.pic_text_agregarfotodeperfil.Size = new System.Drawing.Size(654, 104);
            this.pic_text_agregarfotodeperfil.TabIndex = 2;
            this.pic_text_agregarfotodeperfil.TabStop = false;
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregarfoto.BackgroundImage")));
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarfoto.Location = new System.Drawing.Point(733, 390);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(433, 433);
            this.btn_agregarfoto.TabIndex = 3;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.click_agregarfoto);
            // 
            // btn_crearfoto
            // 
            this.btn_crearfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_crearfoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_crearfoto.BackgroundImage")));
            this.btn_crearfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearfoto.Location = new System.Drawing.Point(818, 856);
            this.btn_crearfoto.Name = "btn_crearfoto";
            this.btn_crearfoto.Size = new System.Drawing.Size(263, 109);
            this.btn_crearfoto.TabIndex = 4;
            this.btn_crearfoto.TabStop = false;
            this.btn_crearfoto.Click += new System.EventHandler(this.click_crearfoto);
            // 
            // FormFotoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_crearfoto);
            this.Controls.Add(this.btn_agregarfoto);
            this.Controls.Add(this.pic_text_agregarfotodeperfil);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormFotoAdmin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_text_agregarfotodeperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_crearfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_text_agregarfotodeperfil;
        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.PictureBox btn_crearfoto;
    }
}