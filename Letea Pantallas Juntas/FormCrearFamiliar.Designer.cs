
namespace Pantalla_Contraseña
{
    partial class FormCrearFamiliar
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ApellidoNoEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            this.pic_FotoPerfil = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.PictureBox();
            this.lbl_Parentesco = new System.Windows.Forms.Label();
            this.pic_Parentesco = new System.Windows.Forms.PictureBox();
            this.cmb_Relacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Parentesco)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.que_lindo_boton;
            this.btn_agregarfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarfoto.Location = new System.Drawing.Point(240, 240);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(600, 600);
            this.btn_agregarfoto.TabIndex = 4;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.btn_agregarfoto_Click);
            this.btn_agregarfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_agregarfoto_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(1075, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre del familiar:";
            // 
            // lbl_ApellidoNoEdit
            // 
            this.lbl_ApellidoNoEdit.AutoSize = true;
            this.lbl_ApellidoNoEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApellidoNoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_ApellidoNoEdit.Location = new System.Drawing.Point(1074, 392);
            this.lbl_ApellidoNoEdit.Name = "lbl_ApellidoNoEdit";
            this.lbl_ApellidoNoEdit.Size = new System.Drawing.Size(323, 39);
            this.lbl_ApellidoNoEdit.TabIndex = 26;
            this.lbl_ApellidoNoEdit.Text = "Apellido del familiar:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(1075, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1085, 628);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 53);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Apellido.Location = new System.Drawing.Point(1082, 457);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(495, 38);
            this.txt_Apellido.TabIndex = 22;
            this.txt_Apellido.TabStop = false;
            this.txt_Apellido.Text = "Introduzca el apellido del familiar";
            this.txt_Apellido.Click += new System.EventHandler(this.txt_Apellido_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1079, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 60);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Nom.Location = new System.Drawing.Point(1082, 263);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(483, 38);
            this.txt_Nom.TabIndex = 20;
            this.txt_Nom.TabStop = false;
            this.txt_Nom.Text = "Introduzca el nombre del familiar";
            this.txt_Nom.Click += new System.EventHandler(this.txt_Nom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1077, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 60);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1077, 625);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 60);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_Guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(1553, 883);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(288, 96);
            this.btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Guardar.TabIndex = 28;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // pic_FotoPerfil
            // 
            this.pic_FotoPerfil.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Perfil_Vacío;
            this.pic_FotoPerfil.Location = new System.Drawing.Point(931, 504);
            this.pic_FotoPerfil.Name = "pic_FotoPerfil";
            this.pic_FotoPerfil.Size = new System.Drawing.Size(43, 32);
            this.pic_FotoPerfil.TabIndex = 29;
            this.pic_FotoPerfil.TabStop = false;
            this.pic_FotoPerfil.Visible = false;
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
            this.btn_Volver.TabIndex = 30;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Parentesco
            // 
            this.lbl_Parentesco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Parentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Parentesco.Location = new System.Drawing.Point(1075, 729);
            this.lbl_Parentesco.Name = "lbl_Parentesco";
            this.lbl_Parentesco.Size = new System.Drawing.Size(347, 41);
            this.lbl_Parentesco.TabIndex = 31;
            this.lbl_Parentesco.Text = "Esta persona es tu:";
            // 
            // pic_Parentesco
            // 
            this.pic_Parentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pic_Parentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Parentesco.Location = new System.Drawing.Point(1082, 791);
            this.pic_Parentesco.Name = "pic_Parentesco";
            this.pic_Parentesco.Size = new System.Drawing.Size(500, 60);
            this.pic_Parentesco.TabIndex = 33;
            this.pic_Parentesco.TabStop = false;
            // 
            // cmb_Relacion
            // 
            this.cmb_Relacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cmb_Relacion.FormattingEnabled = true;
            this.cmb_Relacion.Location = new System.Drawing.Point(1085, 794);
            this.cmb_Relacion.Name = "cmb_Relacion";
            this.cmb_Relacion.Size = new System.Drawing.Size(492, 54);
            this.cmb_Relacion.TabIndex = 34;
            this.cmb_Relacion.Text = "Elija parentesco";
            // 
            // FormCrearFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cmb_Relacion);
            this.Controls.Add(this.pic_Parentesco);
            this.Controls.Add(this.lbl_Parentesco);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.pic_FotoPerfil);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ApellidoNoEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_agregarfoto);
            this.Name = "FormCrearFamiliar";
            this.Text = "FormCrearFamiliar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCrearFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Parentesco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ApellidoNoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_Guardar;
        private System.Windows.Forms.PictureBox pic_FotoPerfil;
        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.Label lbl_Parentesco;
        private System.Windows.Forms.PictureBox pic_Parentesco;
        private System.Windows.Forms.ComboBox cmb_Relacion;
    }
}