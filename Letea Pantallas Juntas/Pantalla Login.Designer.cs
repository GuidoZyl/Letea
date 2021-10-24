
namespace Pantalla_Contraseña
{
    partial class FormPantallaLogIn
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
            this.pic_Administrador = new System.Windows.Forms.PictureBox();
            this.txt_Administrador = new System.Windows.Forms.PictureBox();
            this.pic_Contraseña = new System.Windows.Forms.PictureBox();
            this.txtbox_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_ingresaradmin = new System.Windows.Forms.PictureBox();
            this.btn_Vercontraseña = new System.Windows.Forms.PictureBox();
            this.btn_NoVercontraseña = new System.Windows.Forms.PictureBox();
            this.btn_IngresoPaciente = new System.Windows.Forms.PictureBox();
            this.lbl_ContraseñaIncorrecta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Administrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Administrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ingresaradmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Vercontraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NoVercontraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IngresoPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Administrador
            // 
            this.pic_Administrador.BackColor = System.Drawing.Color.Transparent;
            this.pic_Administrador.Location = new System.Drawing.Point(360, 134);
            this.pic_Administrador.Name = "pic_Administrador";
            this.pic_Administrador.Size = new System.Drawing.Size(300, 300);
            this.pic_Administrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Administrador.TabIndex = 0;
            this.pic_Administrador.TabStop = false;
            // 
            // txt_Administrador
            // 
            this.txt_Administrador.BackColor = System.Drawing.Color.Transparent;
            this.txt_Administrador.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Administrador;
            this.txt_Administrador.Location = new System.Drawing.Point(330, 478);
            this.txt_Administrador.Name = "txt_Administrador";
            this.txt_Administrador.Size = new System.Drawing.Size(350, 66);
            this.txt_Administrador.TabIndex = 1;
            this.txt_Administrador.TabStop = false;
            // 
            // pic_Contraseña
            // 
            this.pic_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.pic_Contraseña.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Contraseña;
            this.pic_Contraseña.Location = new System.Drawing.Point(202, 582);
            this.pic_Contraseña.Name = "pic_Contraseña";
            this.pic_Contraseña.Size = new System.Drawing.Size(536, 126);
            this.pic_Contraseña.TabIndex = 2;
            this.pic_Contraseña.TabStop = false;
            // 
            // txtbox_Contraseña
            // 
            this.txtbox_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F);
            this.txtbox_Contraseña.Location = new System.Drawing.Point(259, 635);
            this.txtbox_Contraseña.Name = "txtbox_Contraseña";
            this.txtbox_Contraseña.Size = new System.Drawing.Size(475, 67);
            this.txtbox_Contraseña.TabIndex = 3;
            this.txtbox_Contraseña.TextChanged += new System.EventHandler(this.txtbox_Contraseña_TextChanged);
            // 
            // btn_ingresaradmin
            // 
            this.btn_ingresaradmin.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresaradmin.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Crear_admin;
            this.btn_ingresaradmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresaradmin.Location = new System.Drawing.Point(408, 783);
            this.btn_ingresaradmin.Name = "btn_ingresaradmin";
            this.btn_ingresaradmin.Size = new System.Drawing.Size(208, 98);
            this.btn_ingresaradmin.TabIndex = 4;
            this.btn_ingresaradmin.TabStop = false;
            this.btn_ingresaradmin.Click += new System.EventHandler(this.btn_ingresaradmin_Click);
            // 
            // btn_Vercontraseña
            // 
            this.btn_Vercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vercontraseña.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Vector;
            this.btn_Vercontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Vercontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vercontraseña.Location = new System.Drawing.Point(757, 641);
            this.btn_Vercontraseña.Name = "btn_Vercontraseña";
            this.btn_Vercontraseña.Size = new System.Drawing.Size(78, 58);
            this.btn_Vercontraseña.TabIndex = 5;
            this.btn_Vercontraseña.TabStop = false;
            this.btn_Vercontraseña.Click += new System.EventHandler(this.click_vercontraseña);
            // 
            // btn_NoVercontraseña
            // 
            this.btn_NoVercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.btn_NoVercontraseña.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Vector__1_;
            this.btn_NoVercontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NoVercontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NoVercontraseña.Location = new System.Drawing.Point(754, 633);
            this.btn_NoVercontraseña.Name = "btn_NoVercontraseña";
            this.btn_NoVercontraseña.Size = new System.Drawing.Size(86, 73);
            this.btn_NoVercontraseña.TabIndex = 6;
            this.btn_NoVercontraseña.TabStop = false;
            this.btn_NoVercontraseña.Visible = false;
            this.btn_NoVercontraseña.Click += new System.EventHandler(this.click_novercontraseña);
            // 
            // btn_IngresoPaciente
            // 
            this.btn_IngresoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btn_IngresoPaciente.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Ingresar_como_paciente;
            this.btn_IngresoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IngresoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresoPaciente.Location = new System.Drawing.Point(983, 439);
            this.btn_IngresoPaciente.Name = "btn_IngresoPaciente";
            this.btn_IngresoPaciente.Size = new System.Drawing.Size(759, 136);
            this.btn_IngresoPaciente.TabIndex = 7;
            this.btn_IngresoPaciente.TabStop = false;
            this.btn_IngresoPaciente.Click += new System.EventHandler(this.btn_IngresoPaciente_Click);
            // 
            // lbl_ContraseñaIncorrecta
            // 
            this.lbl_ContraseñaIncorrecta.AutoSize = true;
            this.lbl_ContraseñaIncorrecta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ContraseñaIncorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContraseñaIncorrecta.ForeColor = System.Drawing.Color.Red;
            this.lbl_ContraseñaIncorrecta.Location = new System.Drawing.Point(269, 715);
            this.lbl_ContraseñaIncorrecta.Name = "lbl_ContraseñaIncorrecta";
            this.lbl_ContraseñaIncorrecta.Size = new System.Drawing.Size(485, 54);
            this.lbl_ContraseñaIncorrecta.TabIndex = 16;
            this.lbl_ContraseñaIncorrecta.Text = "Contraseña incorrecta";
            this.lbl_ContraseñaIncorrecta.Visible = false;
            // 
            // FormPantallaLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lbl_ContraseñaIncorrecta);
            this.Controls.Add(this.btn_IngresoPaciente);
            this.Controls.Add(this.btn_NoVercontraseña);
            this.Controls.Add(this.btn_Vercontraseña);
            this.Controls.Add(this.btn_ingresaradmin);
            this.Controls.Add(this.txtbox_Contraseña);
            this.Controls.Add(this.pic_Contraseña);
            this.Controls.Add(this.txt_Administrador);
            this.Controls.Add(this.pic_Administrador);
            this.Name = "FormPantallaLogIn";
            this.Text = "FormPantallaLogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPantallaLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Administrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Administrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ingresaradmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Vercontraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NoVercontraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_IngresoPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Administrador;
        private System.Windows.Forms.PictureBox txt_Administrador;
        private System.Windows.Forms.PictureBox pic_Contraseña;
        private System.Windows.Forms.TextBox txtbox_Contraseña;
        private System.Windows.Forms.PictureBox btn_ingresaradmin;
        private System.Windows.Forms.PictureBox btn_Vercontraseña;
        private System.Windows.Forms.PictureBox btn_NoVercontraseña;
        private System.Windows.Forms.PictureBox btn_IngresoPaciente;
        private System.Windows.Forms.Label lbl_ContraseñaIncorrecta;
    }
}