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
    public partial class FormGruposAmigos : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public static int IDGrupo;
        //public static FormGrupo form = new FormGrupo();

        int ultimo;
        string[,] nombrecompleto;
        

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

            string sql = "Select [Nombre], [Foto] from GruposdeAmigos WHERE IDUsuario = "+FormPacientes2.IDPaciente+"";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "NombreGrupo");
            ultimo = Convert.ToInt32(ds.Tables["NombreGrupo"].Rows.Count) - 1;

            nombrecompleto = new string[ultimo + 1, 2];
            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["NombreGrupo"].Rows[canti][0].ToString();
            }


            if (ultimo == 0)
            {
                lbl_Nom5.Visible = true;
                pic_Nom5.Visible = true;

                lbl_Nom5.Text = nombrecompleto[0, 0];
                MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[0]["Foto"]);

                Bitmap bm1 = new Bitmap(pic1);

                pic_Nom5.Image = bm1;
            }

            else if (ultimo == 1)
            {
                lbl_Nom6.Visible = true;
                lbl_Nom7.Visible = true;
                pic_Nom6.Visible = true;
                pic_Nom7.Visible = true;

                lbl_Nom6.Text = nombrecompleto[0, 0];
                MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[0]["Foto"]);

                Bitmap bm2 = new Bitmap(pic2);

                pic_Nom6.Image = bm2;
                lbl_Nom7.Text = nombrecompleto[1, 0];
                MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[1]["Foto"]);

                Bitmap bm3 = new Bitmap(pic3);

                pic_Nom7.Image = bm3;
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
                MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[0]["Foto"]);

                Bitmap bm4 = new Bitmap(pic4);

                pic_Nom1.Image = bm4;
                lbl_Nom2.Text = nombrecompleto[1, 0];
                MemoryStream pic5 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[1]["Foto"]);

                Bitmap bm5 = new Bitmap(pic5);

                pic_Nom2.Image = bm5;
                lbl_Nom8.Text = nombrecompleto[2, 0];
                MemoryStream pic6 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[2]["Foto"]);

                Bitmap bm6 = new Bitmap(pic6);

                pic_Nom8.Image = bm6;
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
                MemoryStream pic7 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[0]["Foto"]);

                Bitmap bm7 = new Bitmap(pic7);

                pic_Nom1.Image = bm7;
                lbl_Nom2.Text = nombrecompleto[1, 0];
                MemoryStream pic8 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[1]["Foto"]);

                Bitmap bm8 = new Bitmap(pic8);

                pic_Nom2.Image = bm8;
                lbl_Nom3.Text = nombrecompleto[2, 0];
                MemoryStream pic9 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[2]["Foto"]);

                Bitmap bm9 = new Bitmap(pic9);

                pic_Nom3.Image = bm9;
                lbl_Nom4.Text = nombrecompleto[3, 0];
                MemoryStream pic10 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[3]["Foto"]);

                Bitmap bm10 = new Bitmap(pic10);

                pic_Nom4.Image = bm10;
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
                            MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i+1]["Foto"]);

                            Bitmap bm1 = new Bitmap(pic1);

                            pic_Nom1.Image = bm1;
                            lbl_Nom2.Text = nombrecompleto[i + 2, 0];
                            MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i+2]["Foto"]);

                            Bitmap bm2 = new Bitmap(pic2);

                            pic_Nom2.Image = bm2;
                            lbl_Nom3.Text = nombrecompleto[i + 3, 0];
                            MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i+3]["Foto"]);

                            Bitmap bm3 = new Bitmap(pic3);

                            pic_Nom3.Image = bm3;
                            lbl_Nom4.Text = nombrecompleto[i + 4, 0];
                            MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i+4]["Foto"]);

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
                            MemoryStream pic5 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo-2]["Foto"]);

                            Bitmap bm5 = new Bitmap(pic5);

                            pic_Nom1.Image = bm5;
                            lbl_Nom2.Text = nombrecompleto[ultimo - 1, 0];
                            MemoryStream pic6 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo-1]["Foto"]);

                            Bitmap bm6 = new Bitmap(pic6);

                            pic_Nom2.Image = bm6;
                            lbl_Nom8.Text = nombrecompleto[ultimo, 0];
                            MemoryStream pic7 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo]["Foto"]);

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
                            MemoryStream pic8 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo - 1]["Foto"]);

                            Bitmap bm8 = new Bitmap(pic8);

                            pic_Nom6.Image = bm8;
                            lbl_Nom7.Text = nombrecompleto[ultimo, 0];
                            MemoryStream pic9 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo]["Foto"]);

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
                            MemoryStream pic10 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[ultimo]["Foto"]);

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
                        MemoryStream pic1 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i - 4]["Foto"]);

                        Bitmap bm1 = new Bitmap(pic1);

                        pic_Nom1.Image = bm1;
                        lbl_Nom2.Text = nombrecompleto[i - 3, 0];
                        MemoryStream pic2 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i - 3]["Foto"]);

                        Bitmap bm2 = new Bitmap(pic2);

                        pic_Nom2.Image = bm2;
                        lbl_Nom3.Text = nombrecompleto[i - 2, 0];
                        MemoryStream pic3 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i - 2]["Foto"]);

                        Bitmap bm3 = new Bitmap(pic3);

                        pic_Nom3.Image = bm3;
                        lbl_Nom4.Text = nombrecompleto[i - 1, 0];
                        MemoryStream pic4 = new MemoryStream((byte[])ds.Tables["NombreGrupo"].Rows[i + 1]["Foto"]);

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

     

        private void pic_Nom1_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom1.Width, pic_Nom1.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom1.Region = new Region(gp);
        }

        private void pic_Nom2_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom2.Width, pic_Nom2.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom2.Region = new Region(gp);
        }

        private void pic_Nom3_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom3.Width, pic_Nom3.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom3.Region = new Region(gp);
        }

        private void pic_Nom4_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom4.Width, pic_Nom4.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom4.Region = new Region(gp);
        }

        private void pic_Nom5_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom5.Width, pic_Nom5.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom5.Region = new Region(gp);
        }

        private void pic_Nom6_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom6.Width, pic_Nom6.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom6.Region = new Region(gp);
        }

        private void pic_Nom7_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom7.Width, pic_Nom7.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom7.Region = new Region(gp);
        }

        private void pic_Nom8_Paint(object sender, PaintEventArgs pe)
        {
            Rectangle r = new Rectangle(0, 0, pic_Nom8.Width, pic_Nom8.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 80;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Nom8.Region = new Region(gp);
        }

        private void btn_Volver_Click_1(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void btn_Jugar_Click(object sender, EventArgs e)
        {
            JuegosAmigos form = new JuegosAmigos();
            form.Show();
            this.Hide();
        }
    }
}
