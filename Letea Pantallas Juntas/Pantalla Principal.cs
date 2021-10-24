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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!FormPantallaLogIn.ModoAdmin) {
                btn_Config.Visible = false;
                btn_CrearPaciente.Visible = false;
                btn_Salir.Visible = true;
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Show();
            
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormPacientes2 form = new FormPacientes2();
            form.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Amigos_Click(object sender, EventArgs e)
        {
            FormCrearGruposAmigos form = new FormCrearGruposAmigos();
            form.Show();
            this.Hide();
        }
    }
}
