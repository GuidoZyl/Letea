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
using System.Drawing.Drawing2D;

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

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            if (btn_agregarfoto.Image == null && txt_Nom.Text != null && txt_Nom.Text != "Introduzca el nombre del grupo")
            {
                btn_agregarfoto.Image = pic_FotoPerfil.Image;
            }
            if (txt_Nom.Text != null && txt_Nom.Text != "Introduzca el nombre del grupo")
            {
                string sql = "INSERT into GruposdeAmigos (Nombre, IDUsuario, Foto) values ('" + txt_Nom.Text + "', " + FormPacientes2.IDPaciente + ", @foto)";
                MemoryStream ms = new MemoryStream();
                btn_agregarfoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.Parameters.AddWithValue("Foto", aByte);
                cmd.ExecuteNonQuery();
            }
            else
            {
                this.Cursor = default;
                lbl_IngreseNombre.Visible = true;
                Task.Delay(2000).Wait();
                lbl_IngreseNombre.Visible = false;
            }
            FormGruposAmigos form = new FormGruposAmigos();
            form.Show();
            this.Hide();
        }

        private void btn_AgregarFoto_Click(object sender, EventArgs e)
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

        private void btn_agregarfoto_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, btn_agregarfoto.Width, btn_agregarfoto.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_agregarfoto.Region = new Region(gp);
        }

        private void txt_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM GruposdeAmigos WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "checkeo");

            if (Convert.ToInt32(ds.Tables["checkeo"].Rows.Count) > 0)
            {
                FormGruposAmigos form = new FormGruposAmigos();
                form.Show();
                this.Hide();
            }

            else
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();
            }
        }
    }
}
