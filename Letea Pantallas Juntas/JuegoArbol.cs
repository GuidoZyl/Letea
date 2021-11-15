﻿using System;
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
            uno.Image = pic_CuloGris.Image;
            uno.SizeMode = PictureBoxSizeMode.StretchImage;
            uno.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[0]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[0]]["Y"]));
            uno.Tag = 1;
            uno.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(uno);
            uno.BringToFront();
           
            MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[0]]["Foto"]);
            Bitmap bm2= new Bitmap(ms2);
            fotouno.Image = bm2;
            fotouno.SizeMode = PictureBoxSizeMode.StretchImage;
            fotouno.Height = 175;
            fotouno.Width = 175;
            fotouno.Location = new Point(400, 820);
            fotouno.Tag = 1;
            fotouno.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(fotouno);

            
            dos.Height = 150;
            dos.Width = 150;
            dos.Image = pic_CuloGris.Image;
            dos.SizeMode = PictureBoxSizeMode.StretchImage;
            dos.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[1]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[1]]["Y"]));
            dos.Tag = 2;
            dos.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(dos);
            dos.BringToFront();
          
            MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[1]]["Foto"]);
            Bitmap bm3 = new Bitmap(ms3);
            fotodos.Image = bm3;
            fotodos.SizeMode = PictureBoxSizeMode.StretchImage;
            fotodos.Height = 175;
            fotodos.Width = 175;
            fotodos.Location = new Point(870, 820);
            fotodos.Tag = 2;
            fotodos.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(fotodos);

           
            tres.Height = 150;
            tres.Width = 150;
            tres.Image = pic_CuloGris.Image;
            tres.SizeMode = PictureBoxSizeMode.StretchImage;
            tres.Location = new Point(Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[2]]["X"]), Convert.ToInt32(ds.Tables["Familia"].Rows[CantPersonas[2]]["Y"]));
            tres.Tag = 2;
            tres.Paint += new PaintEventHandler(handlerComun_Paint);
            Controls.Add(tres);
            tres.BringToFront();
            
            
            MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["Familia"].Rows[CantPersonas[2]]["Foto"]);
            Bitmap bm4 = new Bitmap(ms4);
            fototres.Image = bm4;
            fototres.SizeMode = PictureBoxSizeMode.StretchImage;
            fototres.Height = 175;
            fototres.Width = 175;
            fototres.Location = new Point(1345, 820);
            fototres.Tag = 2;
            fototres.Paint += new PaintEventHandler(handlerComun_Paint);
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
            if (ClickedPic.Tag == uno.Tag)
            {
                dos.Visible = false;
                tres.Visible = false;
            }
            else if (ClickedPic.Tag == dos.Tag)
            {
                uno.Visible = false;
                tres.Visible = false;
            }
            else if (ClickedPic.Tag == tres.Tag)
            {
                dos.Visible = false;
                uno.Visible = false;
            }
            if (TagFotoClickeada!= 0 && TagFotoClickeada2!= 0)
            {
                VerificarCorrecta();
            }

        }
        void VerificarCorrecta()
        {

        }
        private void handlerArbolClicked (object sender, EventArgs e)
        {
            PictureBox ClickedPic = sender as PictureBox;
            TagFotoClickeada2 = Convert.ToInt32(ClickedPic.Tag);
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
            if (TagFotoClickeada != 0 && TagFotoClickeada2 != 0)
            {
                VerificarCorrecta();
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
    }
}
