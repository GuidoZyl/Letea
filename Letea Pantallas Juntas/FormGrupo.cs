using System;
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

namespace Pantalla_Contraseña
{
    public partial class FormGrupo : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public static int ultimo;
        string[,] InfoAmigo = new string[ultimo + 1, 4];

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
            if (FormPantallaLogIn.ModoAdmin)
            {
                btn_AgregarAmigo.Visible = true;
                btn_Config.Visible = true;
            }

            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string consulta = "SELECT Nombre FROM GruposdeAmigos WHERE Id = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "Nombregrupo");
            lbl_NomGrupo.Text = ds.Tables["Nombregrupo"].Rows[0]["Nombre"].ToString();
            string consulta1 = "SELECT [Nombre],[Apellido],[Fecha de Nacimiento],[Foto] FROM Amigos WHERE IdGruposDeAmigos = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando1 = new OleDbCommand(consulta1, conexion);
            OleDbDataAdapter data1 = new OleDbDataAdapter(comando1);
            data1.Fill(ds, "Amigo");
            ultimo = Convert.ToInt32(ds.Tables["Amigo"].Rows.Count - 1);

                for (int i = 0; i <= ultimo; i++)
                {
                    InfoAmigo[i, 0] = ds.Tables["Amigo"].Rows[i][0].ToString();
                }

            string sql = "SELECT Foto FROM GruposdeAmigos WHERE Id = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data2 = new OleDbDataAdapter(cmd);

            data2.Fill(ds, "fotogrupo");

            MemoryStream ms = new MemoryStream((byte[])ds.Tables["fotogrupo"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            pic_GrupoAmigo.Image = bm;
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
                lbl_Nom2.Text = InfoAmigo[1, 0];
                lbl_Nom3.Text = InfoAmigo[2, 0];
                lbl_Nom4.Text = InfoAmigo[3, 0];
            }
            if (ultimo == 2)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;
                lbl_Nom3.Visible = true;

                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                pic_Nom3.Visible = true;
                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom2.Text = InfoAmigo[1, 0];
                lbl_Nom3.Text = InfoAmigo[2, 0];
            }
            if (ultimo == 1)
            {
                lbl_Nom1.Visible = true;
                lbl_Nom2.Visible = true;

                pic_Nom1.Visible = true;
                pic_Nom2.Visible = true;
                lbl_Nom1.Text = InfoAmigo[0, 0];
                lbl_Nom2.Text = InfoAmigo[1, 0];
            }
            if (ultimo == 0)
            {
                lbl_Nom1.Visible = true;

                pic_Nom1.Visible = true;
                lbl_Nom1.Text = InfoAmigo[0, 0];
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
            var rectContourSmooth = Rectangle.Inflate(pic_Nom1.ClientRectangle, 0, 0);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
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
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
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
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
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
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
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
                        lbl_Nom2.Text = InfoAmigo[i - 3, 0];
                        lbl_Nom3.Text = InfoAmigo[i - 2, 0];
                        lbl_Nom4.Text = InfoAmigo[i - 1, 0];

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
                    lbl_Nom2.Text = InfoAmigo[i + 2, 0];
                    lbl_Nom3.Text = InfoAmigo[i + 3, 0];
                    lbl_Nom4.Text = InfoAmigo[i + 4, 0];
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
                    lbl_Nom2.Text = InfoAmigo[ultimo - 1, 0];
                    lbl_Nom3.Text = InfoAmigo[ultimo, 0];
                }
                if (lbl_Nom4.Text == InfoAmigo[ultimo - 2, 0])
                {
                    lbl_Nom4.Visible = false;
                    pic_Nom4.Visible = false;
                    lbl_Nom1.Text = InfoAmigo[ultimo - 1, 0];
                    lbl_Nom2.Text = InfoAmigo[ultimo, 0];
                    lbl_Nom3.Visible = false;
                    pic_Nom3.Visible = false;
                }
                if (lbl_Nom4.Text == InfoAmigo[ultimo - 1, 0])
                {
                    lbl_Nom4.Visible = false;
                    pic_Nom4.Visible = false;
                    lbl_Nom1.Text = InfoAmigo[ultimo, 0];
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
        }

        private void btn_AgregarAmigo_Click(object sender, EventArgs e)
        {
            AgregarAmigo form = new AgregarAmigo();
            form.Show();
            this.Close();
        }
    }
}

