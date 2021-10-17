using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormPantallaLogIn : Form
    {
        Color Color_Fondo = new Color();
        public FormPantallaLogIn()
        {
            InitializeComponent();
            txtbox_Contraseña.UseSystemPasswordChar = true;
        }

        private void FormPantallaLogIn_Load(object sender, EventArgs e)
        {
            Color_Fondo = Color.FromArgb(208, 208, 208);
            this.BackColor = Color_Fondo;
        }

        private void click_vercontraseña(object sender, EventArgs e)
        {
            txtbox_Contraseña.UseSystemPasswordChar = false;
            btn_Vercontraseña.Visible = false;
            btn_NoVercontraseña.Visible = true;
        }

        private void click_novercontraseña(object sender, EventArgs e)
        {
            txtbox_Contraseña.UseSystemPasswordChar = true;
            btn_Vercontraseña.Visible = true;
            btn_NoVercontraseña.Visible = false;
        }

        private void btn_ingresaradmin_Click(object sender, EventArgs e)
        {

        }
    }
}
