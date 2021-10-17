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
    public partial class FormFotoUsuarioRegistro : Form
    {
        Color Color_Fondo = new Color();
        public FormFotoUsuarioRegistro()
        {
            InitializeComponent();
        }

        private void Foto_Usuario_registro_Load(object sender, EventArgs e)
        {
            Color_Fondo = Color.FromArgb(208, 208, 208);
            this.BackColor = Color_Fondo;
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

        private void click_crearfotousuario(object sender, EventArgs e)
        {

        }
    }
}
