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
    public partial class JuegosAmigos : Form
    {
        public JuegosAmigos()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            if (!FormPrincipal.JuegoFamilia)
            {
                FormGruposAmigos form = new FormGruposAmigos();
                form.Show();
                this.Hide();
            }

            else
            {
                ArbolGenealogico form = new ArbolGenealogico();
                form.Show();
                this.Hide();
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion form = new Configuracion();
            form.Show();
        }

        private void btn_Preguntas_Click(object sender, EventArgs e)
        {
            FormPreguntas form = new FormPreguntas();
            form.Show();
            this.Hide();
        }

        private void btn_AsociandoNombres_Click(object sender, EventArgs e)
        {
            UnirSinFlechas form = new UnirSinFlechas();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JuegoArbol form = new JuegoArbol();
            form.Show();
            this.Hide();
        }

        private void btn_PreguntasFamilia_Click(object sender, EventArgs e)
        {
            FormPreguntas form = new FormPreguntas();
            form.Show();
            this.Hide();
        }

        private void btn_AsociandonombresFamilia_Click(object sender, EventArgs e)
        {
            UnirSinFlechas form = new UnirSinFlechas();
            form.Show();
            this.Hide();
        }

        private void btn_JuegodelArbol_Click(object sender, EventArgs e)
        {
            JuegoArbol form = new JuegoArbol();
            form.Show();
            this.Hide();
        }

        private void JuegosAmigos_Load(object sender, EventArgs e)
        {
            if (FormPrincipal.JuegoFamilia)
            {
                btn_AsociandonombresFamilia.Visible = true;
                btn_PreguntasFamilia.Visible = true;
                btn_JuegodelArbol.Visible = true;
            }
            else
            {
                btn_PreguntasAmigo.Visible = true;
                btn_AsociandoNombresAmigo.Visible = true;
            }
        }
    }
}
