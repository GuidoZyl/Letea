﻿
namespace Pantalla_Contraseña
{
    partial class FormCrearPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearPaciente));
            this.pic_ParteSuperior = new System.Windows.Forms.PictureBox();
            this.pic_nombrecompleto = new System.Windows.Forms.PictureBox();
            this.txtbox_nombreusuario = new System.Windows.Forms.TextBox();
            this.btn_siguiente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nombrecompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_siguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_ParteSuperior
            // 
            this.pic_ParteSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pic_ParteSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_ParteSuperior.BackgroundImage")));
            this.pic_ParteSuperior.Location = new System.Drawing.Point(0, 0);
            this.pic_ParteSuperior.Name = "pic_ParteSuperior";
            this.pic_ParteSuperior.Size = new System.Drawing.Size(1920, 300);
            this.pic_ParteSuperior.TabIndex = 1;
            this.pic_ParteSuperior.TabStop = false;
            // 
            // pic_nombrecompleto
            // 
            this.pic_nombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.pic_nombrecompleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_nombrecompleto.BackgroundImage")));
            this.pic_nombrecompleto.Location = new System.Drawing.Point(242, 380);
            this.pic_nombrecompleto.Name = "pic_nombrecompleto";
            this.pic_nombrecompleto.Size = new System.Drawing.Size(1237, 257);
            this.pic_nombrecompleto.TabIndex = 3;
            this.pic_nombrecompleto.TabStop = false;
            // 
            // txtbox_nombreusuario
            // 
            this.txtbox_nombreusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nombreusuario.Location = new System.Drawing.Point(461, 500);
            this.txtbox_nombreusuario.Name = "txtbox_nombreusuario";
            this.txtbox_nombreusuario.Size = new System.Drawing.Size(998, 124);
            this.txtbox_nombreusuario.TabIndex = 4;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.BackgroundImage")));
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.Location = new System.Drawing.Point(767, 788);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(368, 110);
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.TabStop = false;
            // 
            // FormCrearPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.txtbox_nombreusuario);
            this.Controls.Add(this.pic_nombrecompleto);
            this.Controls.Add(this.pic_ParteSuperior);
            this.Name = "FormCrearPaciente";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nombrecompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_siguiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ParteSuperior;
        private System.Windows.Forms.PictureBox pic_nombrecompleto;
        private System.Windows.Forms.TextBox txtbox_nombreusuario;
        private System.Windows.Forms.PictureBox btn_siguiente;
    }
}