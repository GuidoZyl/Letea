using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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

        public static int IDFamiliar;
        public static bool Edit = false;
        bool Linea = false;
        bool cerrado = false;
        string Nombre;
        private bool btnDown;
        private int offsetX;
        private int offsetY;

        int z = 0;
        int[] PosLinea = new int[4];

        List<Point> Lista = new List<Point>();

        Pen Lapiz = new Pen(Color.Black, 3);
        Pen LapizAncho = new Pen(Color.Black, 5);

        Graphics g;

        private PrintDocument DocumentoParaImprimir = new PrintDocument();
        private PrintDialog Impresora = new PrintDialog();
        private PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        private Bitmap bmp;

        public ArbolGenealogico()
        {
            InitializeComponent();

            DocumentoParaImprimir.PrintPage +=
                new PrintPageEventHandler(DocumentoParaImprimir_PrintPage);
        }

        void DocumentoParaImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width - 864, bmp.Height - 458);
        }

        private void CapturaFormulario()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                   this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

            bmp.Save("Captura.bmp", ImageFormat.Bmp);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Volver.Visible = false;
            btn_Editar.Visible = false;
            Labels();
            button1.Visible = false;
            Task.Delay(1000).Wait();
            CapturaFormulario();

            pic_Captura.ImageLocation = "Captura.bmp";
            pic_Captura.Visible = true;
            pic_Captura.BringToFront();
            button2.Visible = true;
            button2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            Task.Delay(500).Wait();
            CapturaFormulario();

            Impresora.Document = DocumentoParaImprimir;
            DialogResult Result = Impresora.ShowDialog();

            if (Result == DialogResult.OK)
            {
                DocumentoParaImprimir.DefaultPageSettings.Landscape = true;
                DocumentoParaImprimir.Print();
            }
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

            /* for (int i = 0; i < ds.Tables["Familia"].Rows.Count; i++)
             {
                 Label tempNombre = new Label();

                 tempNombre.Width = 200;
                 tempNombre.AutoSize = false;
                 tempNombre.Height = 50;
                 tempNombre.Font = new Font("Microsoft Sans Serif", 15F);
                 tempNombre.TextAlign = ContentAlignment.MiddleCenter;
                 tempNombre.Text = ds.Tables["Familia"].Rows[i]["Nombre"].ToString();
                 tempNombre.BackColor = Color.Transparent;
                 if (Convert.ToBoolean(ds.Tables["Familia"].Rows[i]["Editado"]) == false)
                 {

                 }

                 else
                 {
                     tempNombre.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[i]["X"]) - 25, Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Y"]) + 150);
                 }
                 Controls.Add(tempNombre);
                 tempNombre.SendToBack();
             }*/


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
                temp.Click += new EventHandler(handler_Click);

                Controls.Add(temp);
                temp.BringToFront();
            }
            //Labels();
            Lineas();
        }
        void Lineas()
        {
            string query = "SELECT * FROM Lineas WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
            OleDbCommand comando = new OleDbCommand(query, conexion);
            OleDbDataAdapter da2 = new OleDbDataAdapter(comando);
            da2.Fill(ds, "Lineas");

            for (int i = 0; i < ds.Tables["Lineas"].Rows.Count; i++)
            {
                Lista.Add(new Point(Convert.ToInt32(ds.Tables["Lineas"].Rows[i]["X1"]), Convert.ToInt32(ds.Tables["Lineas"].Rows[i]["Y1"])));
                Lista.Add(new Point(Convert.ToInt32(ds.Tables["Lineas"].Rows[i]["X2"]), Convert.ToInt32(ds.Tables["Lineas"].Rows[i]["Y2"])));
                g.DrawLine(Lapiz, Lista[0], Lista[1]);
                Lista.Clear();
            }
        }

        private void handlerLabel_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                Label lblClicked = sender as Label;
                IDFamiliar = Convert.ToInt32(lblClicked.Tag);

                FormEditFamiliar form = new FormEditFamiliar();
                form.Show();
                this.Hide();
            }
        }

        void Labels()
        {
            for (int i = 0; i < ds.Tables["Familia"].Rows.Count; i++)
            {
                Label tempNombre = new Label();

                tempNombre.Width = 200;
                tempNombre.AutoSize = false;
                tempNombre.Height = 50;
                tempNombre.Font = new Font("Microsoft Sans Serif", 15F);
                tempNombre.TextAlign = ContentAlignment.MiddleCenter;
                tempNombre.Text = ds.Tables["Familia"].Rows[i]["Nombre"].ToString();
                tempNombre.BackColor = Color.Transparent;
                tempNombre.Tag = Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Id"]);

                tempNombre.Name = "Nombre_";

                tempNombre.Click += new EventHandler(handlerLabel_Click);
                tempNombre.Cursor = Cursors.Hand;
                if (Convert.ToBoolean(ds.Tables["Familia"].Rows[i]["Editado"]) == false)
                {

                }

                else
                {
                    tempNombre.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[i]["X"]) - 25, Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Y"]) + 150);
                }
                Controls.Add(tempNombre);
                tempNombre.SendToBack();
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
                PictureBoxTemp.Cursor = Cursors.Hand;
            }
        }

        private void handler_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                PictureBox pictureBoxClicked = sender as PictureBox;
                IDFamiliar = Convert.ToInt32(pictureBoxClicked.Tag);

                FormEditFamiliar form = new FormEditFamiliar();
                form.Show();
                this.Hide();
            }
        }
        private void Label_Visible(object sender, EventArgs e)
        {

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
            var rectContourSmooth = Rectangle.Inflate(PictureBoxPaint.ClientRectangle, 0, 0);
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
            Edit = false;
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
                            PosLinea[z] = e.X + PictureBoxTemp.Location.X;
                            PosLinea[z + 1] = e.Y + PictureBoxTemp.Location.Y;

                            z += 2;
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

                        if (cerrado)
                        {
                            string sql = "INSERT INTO Lineas (X1, Y1, X2, Y2, IDUsuario) VALUES (" + PosLinea[0] + ", " + PosLinea[1] + ", " + PosLinea[2] + ", " + PosLinea[3] + ", " + FormPacientes2.IDPaciente + ")";
                            OleDbCommand cmd = new OleDbCommand(sql, conexion);
                            cmd.ExecuteNonQuery();

                            Lista.Clear();
                            btn_Linea.Visible = true;
                            z = 0;
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
            FormPrincipal.JuegoFamilia = false;

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
            btn_EliminarLineas.Visible = true;

            foreach (Control item in this.Controls.OfType<Label>())
            {
                this.Controls.Remove(item);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Edit = false;
            btn_Guardar.Visible = false;
            btn_Editar.Visible = true;
            btn_Linea.Visible = false;
            btn_Crear.Visible = false;
            btn_EliminarLineas.Visible = false;
            //Labels();

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

                            PosLinea[z] = e.X;
                            PosLinea[z + 1] = e.Y;

                            z += 2;
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
                            string sql = "INSERT INTO Lineas (X1, Y1, X2, Y2, IDUsuario) VALUES (" + PosLinea[0] + ", " + PosLinea[1] + ", " + PosLinea[2] + ", " + PosLinea[3] + ", " + FormPacientes2.IDPaciente + ")";
                            OleDbCommand cmd = new OleDbCommand(sql, conexion);
                            cmd.ExecuteNonQuery();

                            Lista.Clear();
                            btn_Linea.Visible = true;

                            z = 0;
                        }
                    }
                }
            }
        }

        private void pic_Captura_Click(object sender, EventArgs e)
        {

        }
        private void btn_EliminarLineas_Click(object sender, EventArgs e)
        {
            string sql = "DELETE * FROM Lineas WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            // falta agregar form de carga

        }

        private void btn_Jugar_Click(object sender, EventArgs e)
        {

        }
    }
}   

