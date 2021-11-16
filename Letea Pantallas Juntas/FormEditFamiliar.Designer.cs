
namespace Pantalla_Contraseña
{
    partial class FormEditFamiliar
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
            this.btn_agregarfoto = new System.Windows.Forms.PictureBox();
            this.pic_Parentesco = new System.Windows.Forms.PictureBox();
            this.lbl_Parentesco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ApellidoNoEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.btn_EditarAmigo = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            this.btn_Eliminar = new System.Windows.Forms.PictureBox();
            this.lbl_RelacionParentesco = new System.Windows.Forms.Label();
            this.cmb_Relacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Parentesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarAmigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
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
            this.btn_Volver.TabIndex = 25;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_agregarfoto
            // 
            this.btn_agregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarfoto.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.que_lindo_boton;
            this.btn_agregarfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarfoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_agregarfoto.Location = new System.Drawing.Point(242, 185);
            this.btn_agregarfoto.Name = "btn_agregarfoto";
            this.btn_agregarfoto.Size = new System.Drawing.Size(600, 600);
            this.btn_agregarfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_agregarfoto.TabIndex = 26;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.btn_agregarfoto_Click);
            this.btn_agregarfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_agregarfoto_Paint);
            // 
            // pic_Parentesco
            // 
            this.pic_Parentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pic_Parentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Parentesco.Location = new System.Drawing.Point(997, 764);
            this.pic_Parentesco.Name = "pic_Parentesco";
            this.pic_Parentesco.Size = new System.Drawing.Size(500, 60);
            this.pic_Parentesco.TabIndex = 45;
            this.pic_Parentesco.TabStop = false;
            // 
            // lbl_Parentesco
            // 
            this.lbl_Parentesco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Parentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Parentesco.Location = new System.Drawing.Point(990, 702);
            this.lbl_Parentesco.Name = "lbl_Parentesco";
            this.lbl_Parentesco.Size = new System.Drawing.Size(347, 41);
            this.lbl_Parentesco.TabIndex = 43;
            this.lbl_Parentesco.Text = "Esta persona es tu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(990, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre del familiar:";
            // 
            // lbl_ApellidoNoEdit
            // 
            this.lbl_ApellidoNoEdit.AutoSize = true;
            this.lbl_ApellidoNoEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApellidoNoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_ApellidoNoEdit.Location = new System.Drawing.Point(989, 365);
            this.lbl_ApellidoNoEdit.Name = "lbl_ApellidoNoEdit";
            this.lbl_ApellidoNoEdit.Size = new System.Drawing.Size(323, 39);
            this.lbl_ApellidoNoEdit.TabIndex = 41;
            this.lbl_ApellidoNoEdit.Text = "Apellido del familiar:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(990, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1000, 601);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 53);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.ForeColor = System.Drawing.Color.Black;
            this.txt_Apellido.Location = new System.Drawing.Point(997, 430);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(495, 38);
            this.txt_Apellido.TabIndex = 37;
            this.txt_Apellido.TabStop = false;
            this.txt_Apellido.Text = "Introduzca el apellido del familiar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(994, 419);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 60);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.ForeColor = System.Drawing.Color.Black;
            this.txt_Nom.Location = new System.Drawing.Point(997, 236);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(483, 38);
            this.txt_Nom.TabIndex = 35;
            this.txt_Nom.TabStop = false;
            this.txt_Nom.Text = "Introduzca el nombre del familiar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(992, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 60);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(992, 598);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 60);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(998, 235);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(481, 45);
            this.lbl_Nombre.TabIndex = 47;
            this.lbl_Nombre.Text = "label1g";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Apellido.ForeColor = System.Drawing.Color.Black;
            this.lbl_Apellido.Location = new System.Drawing.Point(999, 429);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(481, 42);
            this.lbl_Apellido.TabIndex = 46;
            this.lbl_Apellido.Text = "asdfgj";
            // 
            // btn_EditarAmigo
            // 
            this.btn_EditarAmigo.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarAmigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarAmigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarAmigo.Image = global::Pantalla_Contraseña.Properties.Resources.Editar_familiarr;
            this.btn_EditarAmigo.Location = new System.Drawing.Point(1477, 899);
            this.btn_EditarAmigo.Name = "btn_EditarAmigo";
            this.btn_EditarAmigo.Size = new System.Drawing.Size(376, 96);
            this.btn_EditarAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_EditarAmigo.TabIndex = 49;
            this.btn_EditarAmigo.TabStop = false;
            this.btn_EditarAmigo.Visible = false;
            this.btn_EditarAmigo.Click += new System.EventHandler(this.btn_EditarAmigo_Click);
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
            this.btn_Guardar.TabIndex = 50;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Image = global::Pantalla_Contraseña.Properties.Resources.Eliminar_amigo1;
            this.btn_Eliminar.Location = new System.Drawing.Point(97, 899);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(376, 96);
            this.btn_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Eliminar.TabIndex = 51;
            this.btn_Eliminar.TabStop = false;
            this.btn_Eliminar.Visible = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_RelacionParentesco
            // 
            this.lbl_RelacionParentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lbl_RelacionParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_RelacionParentesco.ForeColor = System.Drawing.Color.Black;
            this.lbl_RelacionParentesco.Location = new System.Drawing.Point(999, 775);
            this.lbl_RelacionParentesco.Name = "lbl_RelacionParentesco";
            this.lbl_RelacionParentesco.Size = new System.Drawing.Size(481, 42);
            this.lbl_RelacionParentesco.TabIndex = 48;
            this.lbl_RelacionParentesco.Text = "asdfgj";
            // 
            // cmb_Relacion
            // 
            this.cmb_Relacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cmb_Relacion.FormattingEnabled = true;
            this.cmb_Relacion.Location = new System.Drawing.Point(997, 766);
            this.cmb_Relacion.Name = "cmb_Relacion";
            this.cmb_Relacion.Size = new System.Drawing.Size(492, 54);
            this.cmb_Relacion.TabIndex = 52;
            this.cmb_Relacion.Text = "Elija parentesco";
            this.cmb_Relacion.Visible = false;
            // 
            // FormEditFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cmb_Relacion);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_EditarAmigo);
            this.Controls.Add(this.lbl_RelacionParentesco);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.pic_Parentesco);
            this.Controls.Add(this.lbl_Parentesco);
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
            this.Controls.Add(this.btn_Volver);
            this.Name = "FormEditFamiliar";
            this.Text = "FormEditFamiliar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEditFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Parentesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarAmigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.PictureBox pic_Parentesco;
        private System.Windows.Forms.Label lbl_Parentesco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ApellidoNoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.PictureBox btn_EditarAmigo;
        private System.Windows.Forms.PictureBox btn_Guardar;
        private System.Windows.Forms.PictureBox btn_Eliminar;
        private System.Windows.Forms.Label lbl_RelacionParentesco;
        private System.Windows.Forms.ComboBox cmb_Relacion;
    }
}