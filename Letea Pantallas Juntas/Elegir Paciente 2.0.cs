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
using System.Drawing.Drawing2D;

namespace Pantalla_Contraseña
{
    public partial class FormPacientes2 : Form
    {
        public static int IDPaciente;
        //public static FormPrincipal form = new FormPrincipal();

        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        int ultimo;
        string[,] nombrecompleto;

        public FormPacientes2()
        {
            InitializeComponent();
        }

        private void Elegir_Paciente_2_Load(object sender, EventArgs e)
        {
            IDPaciente = 0;

            if (FormPantallaLogIn.ModoAdmin)
            {
                btn_Crear.Visible = true;
            }

            lbl_Nom1.Visible = false;
            lbl_Nom2.Visible = false;
            lbl_Nom3.Visible = false;
            lbl_Nom4.Visible = false;
            lbl_Nom5.Visible = false;
            lbl_Nom6.Visible = false;
            lbl_Nom7.Visible = false;
            lbl_Nom8.Visible = false;
            pic_Nom1.Visible = false;
            pic_Nom2.Visible = false;
            pic_Nom3.Visible = false;
            pic_Nom4.Visible = false;
            pic_Nom5.Visible = false;
            pic_Nom6.Visible = false;
            pic_Nom7.Visible = false;
            pic_Nom8.Visible = false;

            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            string sql = "Select [NombreCompleto], [Foto] from Usuario WHERE NOT Id = 23";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "Usuario");
            ultimo = Convert.ToInt32(ds.Tables["Usuario"].Rows.Count) - 1;

            nombrecompleto = new string[ultimo + 1, 1];
            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["Usuario"].Rows[canti][0].ToString();
            }

            if (ultimo == 0)
            {
                lbl_Nom5.Visible = true;
                pic_Nom5.Visible = true;

                lbl_Nom5.Text = nombrecompleto[0, 0];

                MemoryStream pic5 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[0]["Foto"]);

                Bitmap bm5 = new Bitmap(pic5);

                pic_Nom5.Image = bm5;
            }

            else if (ultimo == 1)
            {
                lbl_Nom6.Visible = true;
                lbl_Nom7.Visible = true;
                pic_Nom6.Visible = true;
                pic_Nom7.Visible = true;

                lbl_Nom6.Text = nombrecompleto[0, 0];
                MemoryStream pic6 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[0]["Foto"]);

                Bitmap bm6 = new Bitmap(pic6);

                pic_Nom6.Image = bm6;

                lbl_Nom7.Text = nombrecompleto[1, 0];
                MemoryStream pic7 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[1]["Foto"]);

                Bitmap bm7 = new Bitmap(pic7);

                pic_Nom7.Image = bm7;
            }

            else if (ultimo == 2)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                lbl_Nom8.Visible = true;
                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                pic_Nom8.Visible = true;

                lbl_Nom1.Text = nombrecompleto[0, 0];
                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

                lbl_Nom2.Text = nombrecompleto[1, 0];
                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[1]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom2.Image = bm2;

                lbl_Nom8.Text = nombrecompleto[2, 0];
                MemoryStream pic8 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[2]["Foto"]);

                Bitmap bm8 = new Bitmap(pic8);

                pic_Nom8.Image = bm8;
            }

            else if (ultimo >= 3)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                lbl_Nom3.Visible = true;
                lbl_Nom4.Visible = true;
                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                pic_Nom3.Visible = true;
                pic_Nom4.Visible = true;

                lbl_Nom1.Text = nombrecompleto[0, 0];

                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom1.Image = bm1;

                lbl_Nom2.Text = nombrecompleto[1, 0];

                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[1]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom2.Image = bm2;

                lbl_Nom3.Text = nombrecompleto[2, 0];

                MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[2]["Foto"]);

                Bitmap bm3 = new Bitmap(pic3);

                pic_Nom3.Image = bm3;

                lbl_Nom4.Text = nombrecompleto[3, 0];

                MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[3]["Foto"]);

                Bitmap bm4 = new Bitmap(pic4);

                pic_Nom4.Image = bm4;
            }

            if (ultimo <= 3)
            {
                btn_Der.Visible = false;
            }

        }

        private void btn_Der_Click(object sender, EventArgs e)
        {

            int z = 0;

            if (lbl_Nom4.Text != null)
            {
                for (int i = 0; i <= ultimo - 4; i++)
                {
                    if (z == 0)
                    {
                        if (lbl_Nom4.Text == nombrecompleto[i, 0])
                        {
                            lbl_Nom1.Text = nombrecompleto[i + 1, 0];
                            MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i+1]["Foto"]);

                            Bitmap bm1 = new Bitmap(pic1);

                            pic_Nom1.Image = bm1;
                            lbl_Nom2.Text = nombrecompleto[i + 2, 0];
                            MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i+2]["Foto"]);

                            Bitmap bm2 = new Bitmap(pic2);

                            pic_Nom2.Image = bm2;
                            lbl_Nom3.Text = nombrecompleto[i + 3, 0];
                            MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i+3]["Foto"]);

                            Bitmap bm3 = new Bitmap(pic3);

                            pic_Nom3.Image = bm3;
                            lbl_Nom4.Text = nombrecompleto[i + 4, 0];
                            MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i+4]["Foto"]);

                            Bitmap bm4 = new Bitmap(pic4);

                            pic_Nom4.Image = bm4;

                            z = 1;

                            if (lbl_Nom4.Text == nombrecompleto[ultimo, 0])
                            {
                                btn_Der.Visible = false;
                            }
                        }
                    }

                    if (z == 0)
                    {
                        if (lbl_Nom4.Text == nombrecompleto[ultimo - 3, 0] && (ultimo + 1) % 4 == 3)
                        {

                            lbl_Nom3.Visible = false;
                            lbl_Nom4.Visible = false;
                            lbl_Nom5.Visible = false;
                            lbl_Nom6.Visible = false;
                            lbl_Nom7.Visible = false;
                            lbl_Nom1.Visible = true;
                            lbl_Nom2.Visible = true;
                            lbl_Nom8.Visible = true;
                            pic_Nom3.Visible = false;
                            pic_Nom4.Visible = false;
                            pic_Nom5.Visible = false;
                            pic_Nom6.Visible = false;
                            pic_Nom7.Visible = false;
                            pic_Nom1.Visible = true;
                            pic_Nom2.Visible = true;
                            pic_Nom8.Visible = true;
                            btn_Der.Visible = false;

                            lbl_Nom1.Text = nombrecompleto[ultimo - 2, 0];
                            MemoryStream pic5 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo-2]["Foto"]);

                            Bitmap bm5 = new Bitmap(pic5);

                            pic_Nom1.Image = bm5;
                            lbl_Nom2.Text = nombrecompleto[ultimo - 1, 0];
                            MemoryStream pic6 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo-1]["Foto"]);

                            Bitmap bm6 = new Bitmap(pic6);

                            pic_Nom2.Image = bm6;
                            lbl_Nom8.Text = nombrecompleto[ultimo, 0];
                            MemoryStream pic7 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo]["Foto"]);

                            Bitmap bm7 = new Bitmap(pic7);

                            pic_Nom8.Image = bm7;
                        }

                        else if (lbl_Nom4.Text == nombrecompleto[ultimo - 2, 0] && (ultimo + 1) % 4 == 2)
                        {
                            lbl_Nom3.Visible = false;
                            lbl_Nom4.Visible = false;
                            lbl_Nom5.Visible = false;
                            lbl_Nom6.Visible = true;
                            lbl_Nom7.Visible = true;
                            lbl_Nom1.Visible = false;
                            lbl_Nom2.Visible = false;
                            lbl_Nom8.Visible = false;
                            pic_Nom3.Visible = false;
                            pic_Nom4.Visible = false;
                            pic_Nom5.Visible = false;
                            pic_Nom6.Visible = true;
                            pic_Nom7.Visible = true;
                            pic_Nom1.Visible = false;
                            pic_Nom2.Visible = false;
                            pic_Nom8.Visible = false;
                            btn_Der.Visible = false;

                            lbl_Nom6.Text = nombrecompleto[ultimo - 1, 0];
                            MemoryStream pic8 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo-1]["Foto"]);

                            Bitmap bm8 = new Bitmap(pic8);

                            pic_Nom6.Image = bm8;
                            lbl_Nom7.Text = nombrecompleto[ultimo, 0];
                            MemoryStream pic9 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo]["Foto"]);

                            Bitmap bm9 = new Bitmap(pic9);

                            pic_Nom7.Image = bm9;
                        }

                        else if (lbl_Nom4.Text == nombrecompleto[ultimo - 1, 0] && (ultimo + 1) % 4 == 1)
                        {
                            lbl_Nom3.Visible = false;
                            lbl_Nom4.Visible = false;
                            lbl_Nom5.Visible = true;
                            lbl_Nom6.Visible = false;
                            lbl_Nom7.Visible = false;
                            lbl_Nom1.Visible = false;
                            lbl_Nom2.Visible = false;
                            lbl_Nom8.Visible = false;
                            pic_Nom3.Visible = false;
                            pic_Nom4.Visible = false;
                            pic_Nom5.Visible = true;
                            pic_Nom6.Visible = false;
                            pic_Nom7.Visible = false;
                            pic_Nom1.Visible = false;
                            pic_Nom2.Visible = false;
                            pic_Nom8.Visible = false;
                            btn_Der.Visible = false;

                            lbl_Nom5.Text = nombrecompleto[ultimo, 0];
                            MemoryStream pic10 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[ultimo]["Foto"]);

                            Bitmap bm10 = new Bitmap(pic10);

                            pic_Nom5.Image = bm10;
                        }
                    }
                    if (lbl_Nom1.Text != nombrecompleto[0, 0] || lbl_Nom1.Visible == false)
                    {
                        btn_Izq.Visible = true;
                    }
                }
            }
        }

        private void btn_Izq_Click(object sender, EventArgs e)
        {

            if (lbl_Nom1.Text != nombrecompleto[0, 0] || lbl_Nom1.Visible == false)
            {
                for (int i = 4; i <= ultimo; i++)
                {
                    if ((lbl_Nom1.Text == nombrecompleto[i, 0] && lbl_Nom1.Visible == true) || (lbl_Nom5.Text == nombrecompleto[i, 0] && lbl_Nom5.Visible == true) || (lbl_Nom6.Text == nombrecompleto[i, 0] && lbl_Nom6.Visible == true))
                    {
                        lbl_Nom1.Visible = true;
                        lbl_Nom2.Visible = true;
                        lbl_Nom3.Visible = true;
                        lbl_Nom4.Visible = true;
                        lbl_Nom5.Visible = false;
                        lbl_Nom6.Visible = false;
                        lbl_Nom7.Visible = false;
                        lbl_Nom8.Visible = false;
                        pic_Nom1.Visible = true;
                        pic_Nom2.Visible = true;
                        pic_Nom3.Visible = true;
                        pic_Nom4.Visible = true;
                        pic_Nom5.Visible = false;
                        pic_Nom6.Visible = false;
                        pic_Nom7.Visible = false;
                        pic_Nom8.Visible = false;

                        lbl_Nom1.Text = nombrecompleto[i - 4, 0];
                        lbl_Nom2.Text = nombrecompleto[i - 3, 0];
                        lbl_Nom3.Text = nombrecompleto[i - 2, 0];
                        lbl_Nom4.Text = nombrecompleto[i - 1, 0];
                    
                        MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i - 4]["Foto"]);

                        Bitmap bm1 = new Bitmap(pic1);

                        pic_Nom1.Image = bm1;
                       
                        MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i - 3]["Foto"]);

                        Bitmap bm2 = new Bitmap(pic2);

                        pic_Nom2.Image = bm2;
                        
                        MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i - 2]["Foto"]);

                        Bitmap bm3 = new Bitmap(pic3);

                        pic_Nom3.Image = bm3;
                        
                        MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["Usuario"].Rows[i - 1]["Foto"]);

                        Bitmap bm4 = new Bitmap(pic4);

                        pic_Nom4.Image = bm4;

                        btn_Der.Visible = true;

                        if (lbl_Nom1.Text == nombrecompleto[0, 0])
                        {
                            btn_Izq.Visible = false;
                        }
                    }
                }
            }
        }

        private void lbl_Clicked(object sender, EventArgs e)
        {
            Label LabelClicked = sender as Label;
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + LabelClicked.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            FormCrearPaciente form = new FormCrearPaciente();
            form.Show();
            this.Hide();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormPantallaLogIn form = new FormPantallaLogIn();
            form.Show();
            this.Hide();
        }

        private void pic_Nom1_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
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
            using (var penSmooth = new Pen(pic_Nom1.BackColor, smoothSize))
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

        private void pic_Nom2_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom2.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom2.BackColor, smoothSize))
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
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom3.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom3.BackColor, smoothSize))
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
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom4.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom4.BackColor, smoothSize))
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

        private void pic_Nom5_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom5.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom5.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom5.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom6_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom6.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom6.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom6.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom7_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom7.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom7.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom7.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom8_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Nom8.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Nom8.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Nom8.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }

        private void pic_Nom1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom2.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom3.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom4.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom5.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom6.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom7_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom7.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void pic_Nom8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + lbl_Nom8.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDPaciente = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);

            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
