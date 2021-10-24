
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
            this.btn_AgregarFoto = new System.Windows.Forms.PictureBox();
            this.pic_ParteSuperior = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarFoto
            // 
            this.btn_AgregarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarFoto.Image = global::Pantalla_Contraseña.Properties.Resources.que_lindo_boton;
            this.btn_AgregarFoto.Location = new System.Drawing.Point(760, 299);
            this.btn_AgregarFoto.Name = "btn_AgregarFoto";
            this.btn_AgregarFoto.Size = new System.Drawing.Size(400, 400);
            this.btn_AgregarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarFoto.TabIndex = 0;
            this.btn_AgregarFoto.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(737, 747);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 45);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(735, 739);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormCrearGruposAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pic_ParteSuperior);
            this.Controls.Add(this.btn_AgregarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCrearGruposAmigos";
            this.Text = "Amigos";
            this.Load += new System.EventHandler(this.Amigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ParteSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarFoto;
        private System.Windows.Forms.PictureBox pic_ParteSuperior;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}