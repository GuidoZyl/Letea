﻿namespace Pantalla_Contraseña
{
    partial class AgregarAmigo
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
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Nacimiento = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
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
            this.btn_agregarfoto.TabIndex = 3;
            this.btn_agregarfoto.TabStop = false;
            this.btn_agregarfoto.Click += new System.EventHandler(this.btn_agregarfoto_Click);
            this.btn_agregarfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_agregarfoto_Paint);
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Nom.Location = new System.Drawing.Point(1012, 297);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(495, 38);
            this.txt_Nom.TabIndex = 4;
            this.txt_Nom.TabStop = false;
            this.txt_Nom.Text = "Introduzca el nombre del amigo";
            this.txt_Nom.Click += new System.EventHandler(this.txt_Nom_Click);
            this.txt_Nom.TextChanged += new System.EventHandler(this.txt_Nom_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Apellido.Location = new System.Drawing.Point(1021, 492);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(495, 38);
            this.txt_Apellido.TabIndex = 6;
            this.txt_Apellido.TabStop = false;
            this.txt_Apellido.Text = "Introduzca el apellido del amigo";
            this.txt_Apellido.Click += new System.EventHandler(this.txt_Apellido_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1018, 481);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 60);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1561, 663);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 53);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_Nacimiento
            // 
            this.lbl_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Nacimiento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_Nacimiento.Location = new System.Drawing.Point(1018, 672);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(537, 33);
            this.lbl_Nacimiento.TabIndex = 11;
            this.lbl_Nacimiento.Text = "Introduzca la fecha de nacimiento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1016, 660);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(797, 60);
            this.pictureBox3.TabIndex = 12;
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
            this.btn_Guardar.TabIndex = 13;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // AgregarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_Nacimiento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_agregarfoto);
            this.Controls.Add(this.pictureBox3);
            this.Name = "AgregarAmigo";
            this.Text = "AgregarAmigo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgregarAmigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregarfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_agregarfoto;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Nacimiento;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_Guardar;
    }
}