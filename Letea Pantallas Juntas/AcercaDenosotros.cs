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
    public partial class AcercaDenosotros : Form
    {
        public AcercaDenosotros()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Configuracion form = new Configuracion();
            form.Show();
            this.Hide();
        }
    }
}
