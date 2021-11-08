using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class ArbolGenealogico : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        

        int y = 50;
        string Nombre;
        private bool btnDown;
        private int offsetX;
        private int offsetY;
        public ArbolGenealogico()
        {
            InitializeComponent();
        }

        private void ArbolGenealogico_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            if (FormPantallaLogIn.ModoAdmin)
            {
                btn_Crear.Visible = true;
            }

            string sql = "SELECT * FROM Familia WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "Familia");

            for (int i = 0; i < ds.Tables["Familia"].Rows.Count; i++)
            {
                PictureBox temp = new PictureBox();

                temp.Height = 150;
                temp.Width = 150;

                MemoryStream ms = new MemoryStream((byte[])ds.Tables["Familia"].Rows[i]["Foto"]);
                Bitmap bm = new Bitmap(ms);
                temp.Image = bm;

                temp.SizeMode = PictureBoxSizeMode.StretchImage;

                temp.Location = new Point(200, y);
                y += 155;

                temp.Name = "pic_Familiar" + Convert.ToString(i);
                Nombre = temp.Name;

                temp.Paint += new PaintEventHandler(handlerComun_Paint);
                temp.MouseDown += new MouseEventHandler(temp_MouseDown);
                temp.MouseUp += new MouseEventHandler(temp_MouseUp);
                temp.MouseMove += new MouseEventHandler(temp_MouseMove);

                Controls.Add(temp);
            }
        }

        private void handlerComun_Paint(object sender, PaintEventArgs pe)
        {
            PictureBox PictureBoxPaint = sender as PictureBox;

            int borderSize = 5;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(PictureBoxPaint.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(PictureBoxPaint.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                PictureBoxPaint.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            FormCrearFamiliar form = new FormCrearFamiliar();
            form.Show();
            this.Hide();
        }
        
        private void btn_Volver_Move(object sender, EventArgs e)
        {

        }
        private void temp_MouseDown(object sender, MouseEventArgs e)
        {
            // el boton izquierdo esta pulsado
            if (e.Button == MouseButtons.Left)
            {
                btnDown = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void temp_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxTemp = sender as PictureBox;
            if (btnDown)
            {
                // mover el pictureBox con el raton
                PictureBoxTemp.Left += e.X - offsetX;
                PictureBoxTemp.Top += e.Y - offsetY;
            }
        }

        private void temp_MouseUp(object sender, MouseEventArgs e)
        {
            // el boton izquierdo se libera
            if (e.Button == MouseButtons.Left)
            {
                btnDown = false;
            }
        }
    }
}   

