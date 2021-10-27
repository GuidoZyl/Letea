
namespace Pantalla_Contraseña
{
    partial class FormCrearGruposAmigos
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
            this.btn_agregarfoto = new System.Windows.Forms.PictureBox();
            this.pic_ParteSuperior = new System.Windows.Forms.PictureBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            this.lbl_IngreseNombre = new System.Windows.Forms.Label();
            this.pic_FotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.que_lindo_boton;
            this.btn_agregarfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarfoto.Location = new System.Drawing.Point(755, 299);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(400, 400);
            this.btn_agregarfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_agregarfoto.TabIndex = 0;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.btn_AgregarFoto_Click);
            this.btn_agregarfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_agregarfoto_Paint);
            // 
            // pic_ParteSuperior
            // 
            this.pic_ParteSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pic_ParteSuperior.Image = global::Pantalla_Contraseña.Properties.Resources.Parte_Superior_Crear_GurupoAmigos;
            this.pic_ParteSuperior.Location = new System.Drawing.Point(0, 0);
            this.pic_ParteSuperior.Name = "pic_ParteSuperior";
            this.pic_ParteSuperior.Size = new System.Drawing.Size(1920, 245);
            this.pic_ParteSuperior.TabIndex = 1;
            this.pic_ParteSuperior.TabStop = false;
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Nom.Location = new System.Drawing.Point(713, 750);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(495, 38);
            this.txt_Nom.TabIndex = 0;
            this.txt_Nom.TabStop = false;
            this.txt_Nom.Text = "Introduzca el nombre del grupo";
            this.txt_Nom.Click += new System.EventHandler(this.txt_Nom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(710, 739);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_Guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(1565, 899);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(288, 96);
            this.btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_IngreseNombre
            // 
            this.lbl_IngreseNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngreseNombre.ForeColor = System.Drawing.Color.Red;
            this.lbl_IngreseNombre.Location = new System.Drawing.Point(746, 806);
            this.lbl_IngreseNombre.Name = "lbl_IngreseNombre";
            this.lbl_IngreseNombre.Size = new System.Drawing.Size(418, 54);
            this.lbl_IngreseNombre.TabIndex = 15;
            this.lbl_IngreseNombre.Text = "Ingrese un nombre";
            this.lbl_IngreseNombre.Visible = false;
            // 
            // pic_FotoPerfil
            // 
            this.pic_FotoPerfil.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Vector1;
            this.pic_FotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_FotoPerfil.Location = new System.Drawing.Point(1431, 376);
            this.pic_FotoPerfil.Name = "pic_FotoPerfil";
            this.pic_FotoPerfil.Size = new System.Drawing.Size(102, 69);
            this.pic_FotoPerfil.TabIndex = 16;
            this.pic_FotoPerfil.TabStop = false;
            this.pic_FotoPerfil.Visible = false;
            // 
            // FormCrearGruposAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pic_FotoPerfil);
            this.Controls.Add(this.lbl_IngreseNombre);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.pic_ParteSuperior);
            this.Controls.Add(this.btn_agregarfoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCrearGruposAmigos";
            this.Text = "Amigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Amigos_Load);
            this.Click += new System.EventHandler(this.FormCrearGruposAmigos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.PictureBox pic_ParteSuperior;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Guardar;
        private System.Windows.Forms.Label lbl_IngreseNombre;
        private System.Windows.Forms.PictureBox pic_FotoPerfil;
    }
}