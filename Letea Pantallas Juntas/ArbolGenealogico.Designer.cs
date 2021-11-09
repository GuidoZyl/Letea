
namespace Pantalla_Contraseña
{
    partial class ArbolGenealogico
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
            this.btn_Crear = new System.Windows.Forms.PictureBox();
            this.btn_Editar = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Volver.TabIndex = 22;
            this.btn_Volver.TabStop = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            this.btn_Volver.Move += new System.EventHandler(this.btn_Volver_Move);
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Crear.Image = global::Pantalla_Contraseña.Properties.Resources.Agregar_familiar;
            this.btn_Crear.Location = new System.Drawing.Point(1477, 21);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(426, 96);
            this.btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Crear.TabIndex = 23;
            this.btn_Crear.TabStop = false;
            this.btn_Crear.Visible = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Image = global::Pantalla_Contraseña.Properties.Resources.Editar_árbol__1_;
            this.btn_Editar.Location = new System.Drawing.Point(1512, 908);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(376, 99);
            this.btn_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Editar.TabIndex = 24;
            this.btn_Editar.TabStop = false;
            this.btn_Editar.Visible = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Image = global::Pantalla_Contraseña.Properties.Resources.Boton_Guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(1547, 901);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(328, 106);
            this.btn_Guardar.TabIndex = 25;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // ArbolGenealogico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BackgroundImage = global::Pantalla_Contraseña.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.btn_Volver);
            this.Name = "ArbolGenealogico";
            this.Text = "ArbolGenealogico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ArbolGenealogico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Volver;
        private System.Windows.Forms.PictureBox btn_Crear;
        private System.Windows.Forms.PictureBox btn_Editar;
        private System.Windows.Forms.PictureBox btn_Guardar;
    }
}