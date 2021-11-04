using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormPreguntas : Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void Juego_de_Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void pic_Persona_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, pic_Persona.Width, pic_Persona.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 70;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Persona.Region = new Region(gp);
        }
    }
}
