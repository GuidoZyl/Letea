using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormCrearFamiliar : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public FormCrearFamiliar()
        {
            InitializeComponent();
        }

        private void btn_agregarfoto_Click(object sender, EventArgs e)
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

        private void FormCrearFamiliar_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();            
        }

        private void txt_Nom_Click(object sender, EventArgs e)
        {
            if (txt_Nom.Text == "Introduzca el nombre del familiar")
            {
                txt_Nom.Text = "";
                txt_Nom.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_Apellido_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "Introduzca el apellido del familiar")
            {
                txt_Apellido.Text = "";
                txt_Apellido.ForeColor = SystemColors.WindowText;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_agregarfoto.Image == null)
            {
                btn_agregarfoto.Image = pic_FotoPerfil.BackgroundImage;
            }
            string relacion = txt_Parentesco.Text.ToLower();
            string sql = "INSERT INTO Familia ([Nombre], [Apellido], [Foto], [IDUsuario], [FechadeNacimiento], [RelaciondeParentesco]) VALUES ('" + txt_Nom.Text + "', '" + txt_Apellido.Text + "', @foto, " + FormPacientes2.IDPaciente + ", '"+this.dateTimePicker1.Text+"', '"+relacion+"')";

            MemoryStream ms = new MemoryStream();
            btn_agregarfoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            OleDbCommand cmd = new OleDbCommand(sql, conexion);

            cmd.Parameters.AddWithValue("Foto", aByte);
            cmd.ExecuteNonQuery();

            conexion.Close();

            ArbolGenealogico form = new ArbolGenealogico();
            form.Show();
            this.Hide();
        }

        private void btn_agregarfoto_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(btn_agregarfoto.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
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

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Familia WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "checkeo");

            if (Convert.ToInt32(ds.Tables["checkeo"].Rows.Count) > 0)
            {
                ArbolGenealogico form = new ArbolGenealogico();
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

        private void txt_Parentesco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Parentesco_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "Introduzca el parentesco")
            {
                txt_Apellido.Text = "";
                txt_Apellido.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
