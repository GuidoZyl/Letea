using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Pantalla_Contraseña
{
    public partial class FormCrearGruposAmigos : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public FormCrearGruposAmigos()
        {
            InitializeComponent();
        }

        private void Amigos_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            //string sql = ""
        }

        private void txt_Nom_Click(object sender, EventArgs e)
        {
            if (txt_Nom.Text == "Introduzca el nombre del grupo")
            {
                txt_Nom.Text = "";
                txt_Nom.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void FormCrearGruposAmigos_Click(object sender, EventArgs e)
        {
            /*if (txt_Nom.Text == "")
            {
                txt_Nom.Text = "Introduzca el nombre del grupo";
                txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }*/
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Nom.Text != null && txt_Nom.Text != "Introduzca el nombre del grupo")
            {
                string sql = "INSERT into GruposdeAmigos (Nombre, IDUsuario) values ('" + txt_Nom.Text + "', " + FormPacientes2.IDPaciente + ")";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();
            }
            else
            {
                this.Cursor = default;
                lbl_IngreseNombre.Visible = true;
                Task.Delay(2000).Wait();
                lbl_IngreseNombre.Visible = false;
            }
            string sql2 = "INSERT GruposdeAmigos set Foto = (@foto)";
            MemoryStream ms = new MemoryStream();
            btn_AgregarFoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            OleDbCommand consulta = new OleDbCommand(sql2, conexion);
            consulta.Parameters.AddWithValue("Foto", aByte);
            consulta.ExecuteNonQuery();
        }

        private void btn_AgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen |*.jpg;*.jpeg";

            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {

                String Direccion = BuscarImagen.FileName;

                btn_AgregarFoto.ImageLocation = Direccion;

                btn_AgregarFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
