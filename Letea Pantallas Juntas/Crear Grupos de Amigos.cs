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
                btn_agregarfoto.Image = pic_FotoPerfil.BackgroundImage;
            }
            if (txt_Nom.Text != null && txt_Nom.Text != "Introduzca el nombre del grupo")
            {
                string sql = "INSERT into GruposdeAmigos (Nombre, IDUsuario, Foto) values ('" + txt_Nom.Text + "', " + FormPacientes2.IDPaciente + ", " + btn_agregarfoto.Image + ")";
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
            int borderSize = 5;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(btn_agregarfoto.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize +2, -borderSize +2);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(btn_agregarfoto.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                btn_agregarfoto.Region = new Region(pathRegion);


                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
