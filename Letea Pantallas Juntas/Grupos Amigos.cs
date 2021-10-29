using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormGruposAmigos : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public static int IDGrupo;

        int ultimo;
        string[,] nombrecompleto;
        byte[,] foto;

        public FormGruposAmigos()
        {
            InitializeComponent();
        }

        private void FormGruposAmigos_Load(object sender, EventArgs e)
        {
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

            string sql = "Select Nombre from GruposdeAmigos WHERE IDUsuario = "+FormPacientes2.IDPaciente+"";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "NombreGrupo");
            ultimo = Convert.ToInt32(ds.Tables["NombreGrupo"].Rows.Count) - 1;

            nombrecompleto = new string[ultimo + 1, 1];
            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["NombreGrupo"].Rows[canti][0].ToString();
            }

            /*string sql2 = "Select Foto from Usuario";
            OleDbCommand comando2 = new OleDbCommand(sql2, conexion);
            OleDbDataAdapter data2 = new OleDbDataAdapter(comando2);

            data2.Fill(ds, "Fotos");
            foto = new byte[ultimo + 1, 1];
            for (int canti = 0; canti <= ultimo; canti++)
            {
                foto[canti, 0] = ds.Tables["Fotos"].Rows[canti][0];
            }*/

            if (ultimo == 0)
            {
                lbl_Nom5.Visible = true;
                pic_Nom5.Visible = true;

                lbl_Nom5.Text = nombrecompleto[0, 0];

                /*MemoryStream ms = new MemoryStream(foto[0, 0]);
                Bitmap bm = new Bitmap(ms);
                pic_Nom5.Image = bm;*/
            }

            else if (ultimo == 1)
            {
                lbl_Nom6.Visible = true;
                lbl_Nom7.Visible = true;
                pic_Nom6.Visible = true;
                pic_Nom7.Visible = true;

                lbl_Nom6.Text = nombrecompleto[0, 0];
                lbl_Nom7.Text = nombrecompleto[1, 0];
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
                lbl_Nom2.Text = nombrecompleto[1, 0];
                lbl_Nom8.Text = nombrecompleto[2, 0];
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
                lbl_Nom2.Text = nombrecompleto[1, 0];
                lbl_Nom3.Text = nombrecompleto[2, 0];
                lbl_Nom4.Text = nombrecompleto[3, 0];
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
                            lbl_Nom2.Text = nombrecompleto[i + 2, 0];
                            lbl_Nom3.Text = nombrecompleto[i + 3, 0];
                            lbl_Nom4.Text = nombrecompleto[i + 4, 0];

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
                            lbl_Nom2.Text = nombrecompleto[ultimo - 1, 0];
                            lbl_Nom8.Text = nombrecompleto[ultimo, 0];
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
                            lbl_Nom7.Text = nombrecompleto[ultimo, 0];
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
            string sql = "SELECT Id FROM GruposdeAmigos WHERE Nombre = '" + LabelClicked.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "IDPaciente");

            IDGrupo = Convert.ToInt32(ds.Tables["IDPaciente"].Rows[0]["Id"]);
            FormGrupo form = new FormGrupo();
            form.Show();
            this.Hide();
         
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            FormCrearGruposAmigos form = new FormCrearGruposAmigos();
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

        private void btn_Volver_Click_1(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
