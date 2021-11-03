﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Pantalla_Contraseña.Componentes;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Pantalla_Contraseña
{
    public partial class FormGrupo : Form
    {
        public static int IDAmigo;

        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public static int ultimo;
        string[,] InfoAmigo;

        MemoryStream pic1;
        MemoryStream pic2;
        MemoryStream pic3;
        MemoryStream pic4;
        MemoryStream pic5;
        MemoryStream pic6;
        MemoryStream pic7;
        MemoryStream pic8;

        Bitmap bm1;
        Bitmap bm2;
        Bitmap bm3;
        Bitmap bm4;
        Bitmap bm5;
        Bitmap bm6;
        Bitmap bm7;
        Bitmap bm8;


        public FormGrupo()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormGruposAmigos form = new FormGruposAmigos();
            form.Show();
            this.Hide();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion form = new Configuracion();
            form.Show();
        }

        private void FormGrupo_Load(object sender, EventArgs e)
        {
            //Modo Admin
            if (FormPantallaLogIn.ModoAdmin)
            {
                btn_AgregarAmigo.Visible = true;
                btn_Config.Visible = true;
            }

            //Guardar nombre y foto del grupo desde la base de datos
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            string consulta = "SELECT Nombre FROM GruposdeAmigos WHERE Id = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "Nombregrupo");
            lbl_NomGrupo.Text = ds.Tables["Nombregrupo"].Rows[0]["Nombre"].ToString();

            string sql = "SELECT Foto FROM GruposdeAmigos WHERE Id = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data2 = new OleDbDataAdapter(cmd);

            data2.Fill(ds, "fotogrupo");

            MemoryStream ms = new MemoryStream((byte[])ds.Tables["fotogrupo"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            pic_GrupoAmigo.Image = bm;

            //Guardar información de los amigos de la base de datos
            string consulta1 = "SELECT [Nombre],[Apellido],[Fecha de Nacimiento],[Foto], [Id] FROM Amigos WHERE IdGruposDeAmigos = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando1 = new OleDbCommand(consulta1, conexion);
            OleDbDataAdapter data1 = new OleDbDataAdapter(comando1);
            data1.Fill(ds, "Amigo");

            ultimo = Convert.ToInt32(ds.Tables["Amigo"].Rows.Count - 1);

            InfoAmigo = new string[ultimo + 1, 5];

            

            for (int i = 0; i <= ultimo; i++)
            {
                InfoAmigo[i, 0] = ds.Tables["Amigo"].Rows[i]["Nombre"].ToString();
                InfoAmigo[i, 4] = ds.Tables["Amigo"].Rows[i]["Id"].ToString();
            }           

            if (ultimo >= 3)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                lbl_Nom3.Visible = true;
                lbl_Nom4.Visible = true;

                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                pic_Nom3.Visible = true;
                pic_Nom4.Visible = true;


                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom1.Tag = InfoAmigo[0, 4];

                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

                lbl_Nom2.Text = InfoAmigo[1, 0];
                lbl_Nom2.Tag = InfoAmigo[1, 4];

                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[1]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom2.Image = bm2;


                lbl_Nom3.Text = InfoAmigo[2, 0];
                lbl_Nom3.Tag = InfoAmigo[2, 4];

                MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[2]["Foto"]);

                Bitmap bm3 = new Bitmap(pic3);

                pic_Nom3.Image = bm3;


                lbl_Nom4.Text = InfoAmigo[3, 0];
                lbl_Nom4.Tag = InfoAmigo[3, 4];

                MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[3]["Foto"]);

                Bitmap bm4 = new Bitmap(pic4);

                pic_Nom4.Image = bm4;
            }

            else if (ultimo == 2)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                lbl_Nom3.Visible = true;
                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                pic_Nom3.Visible = true;

                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom1.Tag = InfoAmigo[0, 4];
                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

                lbl_Nom2.Text = InfoAmigo[1, 0];
                lbl_Nom2.Tag = InfoAmigo[1, 4];
                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[1]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom2.Image = bm2;

                lbl_Nom3.Text = InfoAmigo[2, 0];
                lbl_Nom3.Tag = InfoAmigo[2, 4];
                MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[2]["Foto"]);

                Bitmap bm3 = new Bitmap(pic3);

                pic_Nom3.Image = bm3;
            }
            
            else if (ultimo == 1)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;

                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom1.Tag = InfoAmigo[0, 4];
                lbl_Nom2.Text = InfoAmigo[1, 0];
                lbl_Nom2.Tag = InfoAmigo[1, 4];

                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[1]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom2.Image = bm2;
            }
            
            else if (ultimo == 0)
            {
                lbl_Nom1.Visible = true;
                pic_Nom1.Visible = true;

                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom1.Tag = InfoAmigo[0, 4];

                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

            }

            if (ultimo < 4)
            {
                btn_FlechaDer.Visible = false;
                btn_FlechaIzq.Visible = false;
            }
        }

        private void lbl_NomGrupo_Click(object sender, EventArgs e)
        {

        }

        private void pic_GrupoAmigo_Click(object sender, EventArgs e)
        {

        }

        private void pic_Nom1_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 5;
            Color borderColor = Color.RoyalBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);

            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom1.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(pic_Nom1.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom1.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 5;
            Color borderColor = Color.RoyalBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);

            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom2.ClientRectangle, 0, 0);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(pic_Nom2.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom2.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom3_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 5;
            Color borderColor = Color.RoyalBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);

            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom3.ClientRectangle, 0, 0);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(pic_Nom3.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom3.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom4_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 5;
            Color borderColor = Color.RoyalBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);

            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom4.ClientRectangle, 0, 0);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(pic_Nom4.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom4.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void btn_FlechaIzq_Click(object sender, EventArgs e)
        {
            if (lbl_Nom1.Text != InfoAmigo[0, 0])
            {
                for (int i = 4; i <= ultimo; i++)
                {
                    if ((lbl_Nom1.Text == InfoAmigo[i, 0] && lbl_Nom1.Visible == true))
                    {
                        lbl_Nom1.Visible = true;
                        lbl_Nom2.Visible = true;
                        lbl_Nom3.Visible = true;
                        lbl_Nom4.Visible = true;

                        pic_Nom1.Visible = true;
                        pic_Nom2.Visible = true;
                        pic_Nom3.Visible = true;
                        pic_Nom4.Visible = true;


                        lbl_Nom1.Text = InfoAmigo[i - 4, 0];
                        lbl_Nom1.Tag = InfoAmigo[i - 4, 4];

                        MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i - 4]["Foto"]);

                        Bitmap bm1 = new Bitmap(pic1);

                        pic_Nom1.Image = bm1;

                        lbl_Nom2.Text = InfoAmigo[i - 3, 0];
                        lbl_Nom2.Tag = InfoAmigo[i - 3, 4];

                        MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i - 3]["Foto"]);

                        Bitmap bm2 = new Bitmap(pic2);

                        pic_Nom2.Image = bm2;

                        lbl_Nom3.Text = InfoAmigo[i - 2, 0];
                        lbl_Nom3.Tag = InfoAmigo[i - 2, 4];

                        MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i - 2]["Foto"]);

                        Bitmap bm3 = new Bitmap(pic3);

                        pic_Nom3.Image = bm3;

                        lbl_Nom4.Text = InfoAmigo[i - 1, 0];
                        lbl_Nom4.Tag = InfoAmigo[i - 1, 4];

                        MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i - 1]["Foto"]);

                        Bitmap bm4 = new Bitmap(pic4);

                        pic_Nom4.Image = bm4;

                        btn_FlechaDer.Visible = true;

                        if (lbl_Nom1.Text == InfoAmigo[0, 0])
                        {
                            btn_FlechaIzq.Visible = false;
                        }
                    }
                }
            }
            btn_FlechaDer.Visible = true;
        }

        private void btn_FlechaDer_Click(object sender, EventArgs e)
        {
            int z = 0;
            for (int i = 0; i <= ultimo - 4; i++)
            {
                if (lbl_Nom4.Text == InfoAmigo[i, 0])
                {
                    lbl_Nom1.Text = InfoAmigo[i + 1, 0];
                    lbl_Nom1.Tag = InfoAmigo[i + 1, 4];

                    MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i + 1]["Foto"]);

                    Bitmap bm1 = new Bitmap(pic1);

                    pic_Nom1.Image = bm1;

                    lbl_Nom2.Text = InfoAmigo[i + 2, 0];
                    lbl_Nom2.Tag = InfoAmigo[i + 2, 4];

                    MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i + 2]["Foto"]);

                    Bitmap bm2 = new Bitmap(pic2);

                    pic_Nom2.Image = bm2;

                    lbl_Nom3.Text = InfoAmigo[i + 3, 0];
                    lbl_Nom3.Tag = InfoAmigo[i + 3, 4];

                    MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i + 3]["Foto"]);

                    Bitmap bm3 = new Bitmap(pic3);

                    pic_Nom3.Image = bm3;

                    lbl_Nom4.Text = InfoAmigo[i + 4, 0];
                    lbl_Nom4.Tag = InfoAmigo[i + 4, 4];

                    MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[i + 4]["Foto"]);

                    Bitmap bm4 = new Bitmap(pic4);

                    pic_Nom4.Image = bm4;

                    z = 1;
                }
            }
            if (z == 0)
            {
                if (lbl_Nom4.Text == InfoAmigo[ultimo - 3, 0])
                {
                    lbl_Nom4.Visible = false;
                    pic_Nom4.Visible = false;

                    lbl_Nom1.Text = InfoAmigo[ultimo - 2, 0];
                    lbl_Nom1.Tag = InfoAmigo[ultimo - 2, 4];

                    MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo - 2]["Foto"]);

                    Bitmap bm1 = new Bitmap(pic1);

                    pic_Nom1.Image = bm1;

                    lbl_Nom2.Text = InfoAmigo[ultimo - 1, 0];
                    lbl_Nom2.Tag = InfoAmigo[ultimo - 1, 4];

                    MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo - 1]["Foto"]);

                    Bitmap bm2 = new Bitmap(pic2);

                    pic_Nom2.Image = bm2;

                    lbl_Nom3.Text = InfoAmigo[ultimo, 0];
                    lbl_Nom3.Tag = InfoAmigo[ultimo, 4];

                    MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo]["Foto"]);

                    Bitmap bm3 = new Bitmap(pic3);

                    pic_Nom3.Image = bm3;
                }

                if (lbl_Nom4.Text == InfoAmigo[ultimo - 2, 0])
                {
                    lbl_Nom4.Visible = false;
                    pic_Nom4.Visible = false;

                    lbl_Nom1.Text = InfoAmigo[ultimo - 1, 0];
                    lbl_Nom1.Tag = InfoAmigo[ultimo - 1, 4];

                    MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo - 1]["Foto"]);

                    Bitmap bm1 = new Bitmap(pic1);

                    pic_Nom1.Image = bm1;

                    lbl_Nom2.Text = InfoAmigo[ultimo, 0];
                    lbl_Nom2.Tag = InfoAmigo[ultimo, 4];

                    MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo]["Foto"]);

                    Bitmap bm2 = new Bitmap(pic2);

                    pic_Nom2.Image = bm2;

                    lbl_Nom3.Visible = false;
                    pic_Nom3.Visible = false;
                }

                if (lbl_Nom4.Text == InfoAmigo[ultimo - 1, 0])
                {
                    lbl_Nom4.Visible = false;
                    pic_Nom4.Visible = false;

                    lbl_Nom1.Text = InfoAmigo[ultimo, 0];
                    lbl_Nom1.Tag = InfoAmigo[ultimo, 4];

                    MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Amigo"].Rows[ultimo]["Foto"]);

                    Bitmap bm1 = new Bitmap(pic1);

                    pic_Nom1.Image = bm1;

                    lbl_Nom2.Visible = false;
                    pic_Nom2.Visible = false;
                    lbl_Nom3.Visible = false;
                    pic_Nom3.Visible = false;
                }

                if (lbl_Nom4.Text == InfoAmigo[ultimo, 0])
                {
                    btn_FlechaDer.Visible = false;
                }
            }
            for (int j = ultimo - 3; j<=ultimo;j++)
            {
                if (lbl_Nom1.Text == InfoAmigo[j,0])
                {
                    btn_FlechaDer.Visible = false;
                }
            }
            if (lbl_Nom1.Text != InfoAmigo[0, 0] || lbl_Nom1.Visible == false)
            {
                btn_FlechaIzq.Visible = true;
            }
        }

        private void btn_AgregarAmigo_Click(object sender, EventArgs e)
        {
            AgregarAmigo form = new AgregarAmigo();
            form.Show();
            FormGruposAmigos.form.Hide();
        }

        private void lbl_Nom1_Click(object sender, EventArgs e)
        {
            Label LabelClicked = sender as Label;

            IDAmigo = Convert.ToInt32(LabelClicked.Tag);

            FormEditAmigo form = new FormEditAmigo();
            form.Show();
            this.Hide();
        }

        private void pic_GrupoAmigo_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, pic_GrupoAmigo.Width, pic_GrupoAmigo.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_GrupoAmigo.Region = new Region(gp);
        }
    }
}

