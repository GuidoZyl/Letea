using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pantalla_Contraseña
{
    public partial class FormFotoUsuarioRegistro : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        public FormFotoUsuarioRegistro()
        {
            InitializeComponent();
        }

        private void Foto_Usuario_registro_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
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
            string ConsultaSql = "INSERT INTO Usuario (Foto) values (@foto)";
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            btn_agregarfoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            OleDbCommand cmd = new OleDbCommand(ConsultaSql, conexion);
            cmd.Parameters.Add("@foto", OleDbType.VarBinary).Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();


            FormPantallaLogIn PantallaLogIn = new FormPantallaLogIn();
            PantallaLogIn.Show();
            this.Hide();
        }
    }
}
