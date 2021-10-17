using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pantalla_Contraseña
{
    public partial class FormCrearPaciente : Form
    {
        Color Color_Fondo = new Color();
        public FormCrearPaciente()
        {
            InitializeComponent();
        }

        private void btn_noojonombreusuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_ojonombreusuario_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color_Fondo = Color.FromArgb(208, 208, 208);
            this.BackColor = Color_Fondo;
        }
    }
}
