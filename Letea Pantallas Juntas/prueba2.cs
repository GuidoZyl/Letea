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
    public partial class prueba2 : Form
    {
        public prueba2()
        {
            InitializeComponent();
        }

        private void prueba2_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Captura.bmp";
        }
    }
}
