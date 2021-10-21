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
using System.Drawing.Imaging;
using System.IO;

namespace Pantalla_Contraseña
{
    public partial class FormFotoUsuarioRegistro : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
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
            string sql = "UPDATE Usuario set Foto = (@foto)";
            MemoryStream ms = new MemoryStream();
            btn_agregarfoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            OleDbCommand consulta = new OleDbCommand(sql, conexion);
            consulta.Parameters.AddWithValue("Foto", aByte);
            consulta.ExecuteNonQuery();

            btn_agregarfoto.Image = null;

            FormPantallaLogIn form = new FormPantallaLogIn();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Foto FROM Usuario";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);

            data.Fill(ds, "foto");

            int ult = ds.Tables["foto"].Rows.Count - 1;
            MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[ult]["Foto"]);

            Bitmap bm = new Bitmap(ms);
            btn_agregarfoto.Image = bm;
        }
    }
}
