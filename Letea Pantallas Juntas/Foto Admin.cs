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
    public partial class FormFotoAdmin : Form
    {
        public FormFotoAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_agregarfoto(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen |*.jpg;*.jpeg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
        
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {

                String Direccion = BuscarImagen.FileName; 

                btn_agregarfoto.ImageLocation = Direccion;

                btn_agregarfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void click_crearfoto(object sender, EventArgs e)
        {
            FormCrearPaciente form = new FormCrearPaciente();
            form.Show();
            this.Hide();
        }
    }
}
