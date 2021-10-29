using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuración_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(10, 6, Width - 10, Height - 13, 185, 185));
        }

        private void btn_AcercaDeNosotros_Click(object sender, EventArgs e)
        {
            AcercaDenosotros form = new AcercaDenosotros();
            form.Show();
            this.Hide();
        }

        private void btn_CerrarSesión_Click(object sender, EventArgs e)
        {
            FormPantallaLogIn form = new FormPantallaLogIn();
            FormPrincipal form2 = new FormPrincipal();
            form.Show();            
            form2.Hide();
            this.Hide();
        }

        private void btn_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Creditos_Click(object sender, EventArgs e)
        {
            Creditos form = new Creditos();
            form.Show();
            this.Hide();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect, 
        int nRightRect, 
        int nBottomRect, 
        int nWidthEllipse, 
        int nHeightEllipse 
        );
    }
}
