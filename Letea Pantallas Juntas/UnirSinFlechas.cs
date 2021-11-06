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
    public partial class UnirSinFlechas : Form
    {
        public UnirSinFlechas()
        {
            InitializeComponent();
        }
        public static void Shuffle<T>(IList<T> values)
        {
            var n = values.Count;
            var rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }
        private void lbl_Res1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            JuegosAmigos form = new JuegosAmigos();
            form.Show();
            this.Hide();
        }

        private void btn_RespuestaClick(object sender, EventArgs e)
        {

        }

        private void btn_FotoClick(object sender, EventArgs e)
        {

        }
    }
}
