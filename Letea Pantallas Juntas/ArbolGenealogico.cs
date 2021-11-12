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


        public static bool Edit = false;
        bool Linea = false;
        bool cerrado = false;
        int y = 50;
        string Nombre;
        private bool btnDown;
        private int offsetX;
        private int offsetY;

        List<Point> Lista = new List<Point>();

        Pen Lapiz = new Pen(Color.Black, 3);
        Pen LapizAncho = new Pen(Color.Black, 5);

        Graphics g;

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
                btn_Editar.Visible = true;
            }

            g = CreateGraphics();
            

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

                if (Convert.ToBoolean(ds.Tables["Familia"].Rows[i]["Editado"]) == false)
                {
                    temp.Location = new Point(30, 200);
                }

                else
                {
                    temp.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[i]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Y"]));
                }


                temp.Name = "pic_Familiar";
                Nombre = temp.Name;
                temp.Tag = Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Id"]);

                temp.Paint += new PaintEventHandler(handlerComun_Paint);
                temp.MouseDown += new MouseEventHandler(temp_MouseDown);
                temp.MouseUp += new MouseEventHandler(temp_MouseUp);
                temp.MouseMove += new MouseEventHandler(temp_MouseMove);
                temp.MouseEnter += new EventHandler(temp_MouseEnter);

                Controls.Add(temp);
            }
        }

        private void temp_MouseEnter(object sender, EventArgs e)
        {
            PictureBox PictureBoxTemp = sender as PictureBox;
            if (FormPantallaLogIn.ModoAdmin && Edit && !Linea)
            {
                PictureBoxTemp.Cursor = new Cursor("openhand.cur");
            }

            else if (Linea)
            {
                PictureBoxTemp.Cursor = Cursors.Cross;
            }
            else
            {
                PictureBoxTemp.Cursor = Cursors.Default;
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
            PictureBox PictureBoxTemp = sender as PictureBox;
            if (FormPantallaLogIn.ModoAdmin && Edit)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!Linea)
                    {
                        PictureBoxTemp.Cursor = new Cursor("closedhand.cur");
                        btnDown = true;
                        offsetX = e.X;
                        offsetY = e.Y;
                    }

                    else
                    {
                        Cursor = Cursors.Cross;
                        cerrado = false;
                        if (e.Button == MouseButtons.Left)
                        {
                            g.DrawRectangle(Lapiz, new Rectangle(e.X + PictureBoxTemp.Location.X, e.Y + PictureBoxTemp.Location.Y, 1, 1));
                            Lista.Add(new Point(e.X + PictureBoxTemp.Location.X, e.Y + PictureBoxTemp.Location.Y));
                        }

                        else if (e.Button == MouseButtons.Right)
                        {
                            Lista.Add(new Point(Lista[0].X, Lista[0].Y));
                            cerrado = true;
                        }

                        if (Lista.Count > 1)
                        {
                            g.DrawLine(Lapiz, Lista[0], Lista[1]);
                            Linea = false;
                            cerrado = true;
                        }

                        if (cerrado == true)
                        {
                            Lista.Clear();
                            btn_Linea.Visible = true;
                        }
                    }
                }

            }
        }

        private void temp_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormPantallaLogIn.ModoAdmin && Edit)
            {
                 PictureBox PictureBoxTemp = sender as PictureBox;
                 if (btnDown)
                 {
                     PictureBoxTemp.Left += e.X - offsetX;
                     PictureBoxTemp.Top += e.Y - offsetY;
                 }

            }
        }

        private void temp_MouseUp(object sender, MouseEventArgs e)
        {
            if (FormPantallaLogIn.ModoAdmin && Edit)
            {
                 PictureBox PictureBoxTemp = sender as PictureBox;

                 if (e.Button == MouseButtons.Left)
                 {
                    PictureBoxTemp.Cursor = new Cursor("openhand.cur");
                        btnDown = false;
                 }
                 string sql2 = "UPDATE Familia set X = " + PictureBoxTemp.Location.X + ", Y = " + PictureBoxTemp.Location.Y + ",  Editado = " + true + " WHERE Id = " + PictureBoxTemp.Tag + "";
                 OleDbCommand consulta2 = new OleDbCommand(sql2, conexion);
                 consulta2.ExecuteNonQuery();
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Edit = true;
            btn_Editar.Visible = false;
            btn_Crear.Visible = true;
            btn_Guardar.Visible = true;
            btn_Linea.Visible = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Edit = false;
            btn_Guardar.Visible = false;
            btn_Editar.Visible = true;
            btn_Linea.Visible = false;
            btn_Crear.Visible = false;
        }

        private void btn_Linea_Click(object sender, EventArgs e)
        {
            Linea = true;
            btn_Linea.Visible = false;
        }

        private void ArbolGenealogico_MouseEnter(object sender, EventArgs e)
        {
            if (Linea)
            {
                Cursor = Cursors.Cross;
            }

            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void ArbolGenealogico_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox PictureBoxTemp = sender as PictureBox;
            if (FormPantallaLogIn.ModoAdmin && Edit)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (Linea)
                    {
                        Cursor = Cursors.Cross;
                        cerrado = false;
                        if (e.Button == MouseButtons.Left)
                        {
                            g.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 1, 1));
                            Lista.Add(new Point(e.X, e.Y));
                        }

                        else if (e.Button == MouseButtons.Right)
                        {
                            Lista.Add(new Point(Lista[0].X, Lista[0].Y));
                            cerrado = true;
                        }

                        if (Lista.Count > 1)
                        {
                            g.DrawLine(LapizAncho, Lista[0], Lista[1]);
                            Linea = false;
                            cerrado = true;
                        }

                        if (cerrado)
                        {
                            Lista.Clear();
                            btn_Linea.Visible = true;
                        }
                    }
                }
            }
        }
    }
}   

