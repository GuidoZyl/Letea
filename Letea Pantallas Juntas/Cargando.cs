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
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();

            ArbolGenealogico form = new ArbolGenealogico();
            form.Show();
            this.Hide();
        }

        private void Cargando_Load(object sender, EventArgs e)
        {
            Task.Delay(2500).Wait();

            
        }
    }
}
