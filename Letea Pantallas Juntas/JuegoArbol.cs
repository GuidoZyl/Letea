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
    public partial class JuegoArbol : Form
    {
        List<Point> Lista = new List<Point>();

        Pen Lapiz = new Pen(Color.Black, 3);
        Pen LapizAncho = new Pen(Color.Black, 5);
        Graphics g;
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        int[] CantPersonas;
        int TagFotoClickeada = 0;
        int TagFotoClickeada2 = 0;
        PictureBox uno = new PictureBox();
        PictureBox dos = new PictureBox();
        PictureBox tres = new PictureBox();
        PictureBox fotouno = new PictureBox();
        PictureBox fotodos = new PictureBox();
        PictureBox fototres = new PictureBox();
        public JuegoArbol()
        {
            InitializeComponent();
        }
        void Random<T>(IList<T> values)
        {
            var n = values.Count;
            var rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }

        private void JuegoArbol_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            Juego();
            
        }
        void Juego()
        {
            g = CreateGraphics();
            string sql2 = "SELECT * FROM Usuario WHERE Id = " + FormPacientes2.IDPaciente + "";
            OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
            da2.Fill(ds, "Usuarios");

            PictureBox usuario = new PictureBox();
            usuario.Height = 150;
            usuario.Width = 150;


            MemoryStream ms1 = new MemoryStream((byte[])ds.Tables["Usuarios"].Rows[0]["Foto"]);
            Bitmap bm1 = new Bitmap(ms1);
            usuario.Image = bm1;

            usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            usuario.Location = new Point(Convert.ToInt32(ds.Tables["Usuarios"].Rows[0]["X"]), Convert.ToInt32(ds.Tables["Usuarios"].Rows[0]["Y"]));
            usuario.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(usuario);
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
                temp.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[i]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[i]["Y"]));
                temp.Paint += new PaintEventHandler(handlerComun_Paint);
                Controls.Add(temp);
            }
            Lineas();
            CantPersonas = new int[ds.Tables["Familia"].Rows.Count];
            for (int i = 0; i < ds.Tables["Familia"].Rows.Count; i++)
            {
                CantPersonas[i] = i;
            }
            Random(CantPersonas);


            uno.Height = 150;
            uno.Width = 150;
            uno.Image = pic_incognita.Image;
            uno.SizeMode = PictureBoxSizeMode.StretchImage;
            uno.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[0]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[0]]["Y"]));
            uno.Tag = 1;
            uno.Paint += new PaintEventHandler(handlerComun_Paint);
            uno.Click += new EventHandler(handlerArbolClicked);
            uno.Cursor = Cursors.Hand;
            Controls.Add(uno);
            uno.BringToFront();

            MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[0]]["Foto"]);
            Bitmap bm2 = new Bitmap(ms2);
            fotouno.Image = bm2;
            fotouno.SizeMode = PictureBoxSizeMode.StretchImage;
            fotouno.Height = 150;
            fotouno.Width = 150;
            fotouno.Location = new Point(400, 845);
            fotouno.Tag = 1;
            fotouno.Paint += new PaintEventHandler(handlerComun_Paint);
            fotouno.Click += new EventHandler(handlerPicClicked);
            fotouno.Cursor = Cursors.Hand;
            Controls.Add(fotouno);


            dos.Height = 150;
            dos.Width = 150;
            dos.Image = pic_incognita.Image;
            dos.SizeMode = PictureBoxSizeMode.StretchImage;
            dos.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[1]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[1]]["Y"]));
            dos.Tag = 2;
            dos.Paint += new PaintEventHandler(handlerComun_Paint);
            dos.Click += new EventHandler(handlerArbolClicked);
            dos.Cursor = Cursors.Hand;
            Controls.Add(dos);
            dos.BringToFront();

            MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[1]]["Foto"]);
            Bitmap bm3 = new Bitmap(ms3);
            fotodos.Image = bm3;
            fotodos.SizeMode = PictureBoxSizeMode.StretchImage;
            fotodos.Height = 150;
            fotodos.Width = 150;
            fotodos.Location = new Point(870, 845);
            fotodos.Tag = 2;
            fotodos.Paint += new PaintEventHandler(handlerComun_Paint);
            fotodos.Click += new EventHandler(handlerPicClicked);
            fotodos.Cursor = Cursors.Hand;
            Controls.Add(fotodos);


            tres.Height = 150;
            tres.Width = 150;
            tres.Image = pic_incognita.Image;
            tres.SizeMode = PictureBoxSizeMode.StretchImage;
            tres.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[2]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[2]]["Y"]));
            tres.Tag = 3;
            tres.Paint += new PaintEventHandler(handlerComun_Paint);
            tres.Click += new EventHandler(handlerArbolClicked);
            tres.Cursor = Cursors.Hand;
            Controls.Add(tres);
            tres.BringToFront();


            MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[2]]["Foto"]);
            Bitmap bm4 = new Bitmap(ms4);
            fototres.Image = bm4;
            fototres.SizeMode = PictureBoxSizeMode.StretchImage;
            fototres.Height = 150;
            fototres.Width = 150;
            fototres.Location = new Point(1345, 845);
            fototres.Tag = 3;
            fototres.Paint += new PaintEventHandler(handlerComun_Paint);
            fototres.Click += new EventHandler(handlerPicClicked);
            fototres.Cursor = Cursors.Hand;
            Controls.Add(fototres);

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
        private void handlerPicClicked(object sender, EventArgs e)
        {
            PictureBox ClickedPic = sender as PictureBox;
            TagFotoClickeada = Convert.ToInt32(ClickedPic.Tag);
            if (ClickedPic.Tag == fotouno.Tag)
            {
                fotodos.Visible = false;
                fototres.Visible = false;
            }
            else if (ClickedPic.Tag == fotodos.Tag)
            {
                fotouno.Visible = false;
                fototres.Visible = false;
            }
            else if (ClickedPic.Tag == fototres.Tag)
            {
                fotodos.Visible = false;
                fotouno.Visible = false;
            }
            if (TagFotoClickeada!= 0 && TagFotoClickeada2!= 0)
            {
                VerificarCorrecta();
                TagFotoClickeada = 0;
                TagFotoClickeada2 = 0;
            }
          
        }
        void VerificarCorrecta()
        {
            if (TagFotoClickeada == TagFotoClickeada2)
            {
                if (TagFotoClickeada == Convert.ToInt32(fotouno.Tag))
                {
                    fotouno.Tag = 1000;
                    uno.Tag = 1000;
                }
                else if (TagFotoClickeada == Convert.ToInt32(fotodos.Tag))
                {
                    fotodos.Tag = 1000;
                    dos.Tag = 1000;
                }
                else if (TagFotoClickeada == Convert.ToInt32(fototres.Tag))
                {
                    fototres.Tag = 1000;
                    tres.Tag = 1000;
                }

                fotouno.Visible = false;
                fotodos.Visible = false;
                fototres.Visible = false;

                pic_BienHecho.Visible = true;
                Task.Delay(1000).Wait();
                pic_BienHecho.Visible = false;

                SiguientePosicion();
                TagFotoClickeada = 0;
                TagFotoClickeada2 = 0;
            }
            else 
            {
                fotouno.Visible = false;
                fotodos.Visible = false;
                fototres.Visible = false;

                pic_IntentelodeNuevo.Visible = true;
                Task.Delay(1000).Wait();
                pic_IntentelodeNuevo.Visible = false;

                SiguientePosicion();
            }
        }
        
        void SiguientePosicion()
        {
            if (Convert.ToInt32(fotouno.Tag) == 1000)
            {
                fotouno.Visible = false;
                uno.Image = fotouno.Image;
                uno.Cursor = Cursors.Default;
            }
            else { fotouno.Visible = true; }
            if (Convert.ToInt32(fotodos.Tag) == 1000)
            {
                fotodos.Visible = false;
                dos.Image = fotodos.Image;
                dos.Cursor = Cursors.Default;
            }
            else { fotodos.Visible = true; }
            if (Convert.ToInt32(fototres.Tag) == 1000)
            {
                fototres.Visible = false;
                tres.Image = fototres.Image;
                tres.Cursor = Cursors.Default;
            }
            else { fototres.Visible = true; }
            if (fotouno.Visible == false && fotodos.Visible == false && fototres.Visible == false)
            {
                pic_Ganaste.Visible = true;
                btn_Volver2.Visible = true;
                pictureBox1.Visible = true;

                fotouno.Visible = false;
                fotodos.Visible = false;
                fototres.Visible = false;
                uno.Visible = false;
                dos.Visible = false;
                tres.Visible = false;

                pic_Ganaste.BringToFront();
                btn_Volver.BringToFront();
                btn_Volver2.BringToFront();
            }

            if (Convert.ToInt32(fotouno.Tag) != 1000)
            {
                fotouno.Visible = true;
            }
            if (Convert.ToInt32(fotodos.Tag) != 1000)
            {
                fotodos.Visible = true;
            }
            if (Convert.ToInt32(fototres.Tag) != 1000)
            {
                fototres.Visible = true;
            }
        }
        private void handlerArbolClicked (object sender, EventArgs e)
        {
            PictureBox ClickedPic = sender as PictureBox;
            TagFotoClickeada2 = Convert.ToInt32(ClickedPic.Tag);
            
            if (TagFotoClickeada != 0 && TagFotoClickeada2 != 0)
            {
                VerificarCorrecta();
                TagFotoClickeada = 0;
                TagFotoClickeada2 = 0;
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

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            JuegosAmigos form = new JuegosAmigos();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
