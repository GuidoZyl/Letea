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
using System.IO;
using System.Drawing.Drawing2D;

namespace Pantalla_Contraseña
{
    public partial class UnirSinFlechas : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        string[] Nombres = new string[6];
        int[] NombresTag = new int[6];
        int[] Numero = new int[6];
        
        public UnirSinFlechas()
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
        void Juego()
        {
            
            string sql = "SELECT * FROM Amigos";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "Amigo");
            int[] RowAmigo = new int[ds.Tables["Amigo"].Rows.Count];
            for (int i = 0; i < ds.Tables["Amigo"].Rows.Count; i++)
            {
                RowAmigo[i] = i;
            }

            int[,] apsdad = new int[2, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    apsdad[k, i] = i;
                }
            }

            Random(RowAmigo);
            
            string sql2 = "SELECT [Foto],[Nombre], FROM Amigos";
            OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
            da2.Fill(ds, "FotoPersona1");

            MemoryStream ms = new MemoryStream((byte[])ds.Tables["FotoPersona1"].Rows[RowAmigo[0]]["Foto"]);


            Bitmap bm = new Bitmap(ms);

            btn_Foto1.Image = bm;
            btn_Foto1.Tag = RowAmigo[0];

            Nombres[0] = ds.Tables["FotoPersona1"].Rows[RowAmigo[0]]["Nombre"].ToString();
            NombresTag[0] = RowAmigo[0];

            string sql3 = "SELECT [Foto],[Nombre] FROM Amigos";
            OleDbCommand cmd3 = new OleDbCommand(sql3, conexion);
            OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
            da3.Fill(ds, "FotoPersona2");

            MemoryStream ms1 = new MemoryStream((byte[])ds.Tables["FotoPersona2"].Rows[RowAmigo[1]]["Foto"]);

            Bitmap bm1 = new Bitmap(ms1);

            btn_Foto2.Image = bm1;
            btn_Foto2.Tag = RowAmigo[1];

            Nombres[1] = ds.Tables["FotoPersona2"].Rows[RowAmigo[1]]["Nombre"].ToString();
            NombresTag[1] = RowAmigo[1];

            string sql4 = "SELECT [Foto],[Nombre] FROM Amigos";
            OleDbCommand cmd4 = new OleDbCommand(sql4, conexion);
            OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
            da4.Fill(ds, "FotoPersona3");

            MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["FotoPersona3"].Rows[RowAmigo[2]]["Foto"]);

            Bitmap bm2 = new Bitmap(ms2);

            btn_Foto3.Image = bm2;
            btn_Foto3.Tag = RowAmigo[2];

            Nombres[2] = ds.Tables["FotoPersona3"].Rows[RowAmigo[2]]["Nombre"].ToString();
            NombresTag[2] = RowAmigo[2];

            string sql5 = "SELECT [Foto],[Nombre] FROM Amigos";
            OleDbCommand cmd5 = new OleDbCommand(sql5, conexion);
            OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
            da5.Fill(ds, "FotoPersona4");

            MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["FotoPersona4"].Rows[RowAmigo[3]]["Foto"]);

            Bitmap bm3 = new Bitmap(ms3);

            btn_Foto4.Image = bm3;
            btn_Foto4.Tag = RowAmigo[3];

            Nombres[3] = ds.Tables["FotoPersona4"].Rows[RowAmigo[3]]["Nombre"].ToString();
            NombresTag[3] = RowAmigo[3];

            string sql6 = "SELECT [Foto],[Nombre] FROM Amigos";
            OleDbCommand cmd6 = new OleDbCommand(sql6, conexion);
            OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
            da6.Fill(ds, "FotoPersona5");

            MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["FotoPersona5"].Rows[RowAmigo[4]]["Foto"]);

            Bitmap bm4 = new Bitmap(ms4);

            btn_Foto5.Image = bm4;
            btn_Foto5.Tag = RowAmigo[4];

            Nombres[4] = ds.Tables["FotoPersona5"].Rows[RowAmigo[4]]["Nombre"].ToString();
            NombresTag[4] = RowAmigo[4];

            string sql7 = "SELECT [Foto],[Nombre] FROM Amigos";
            OleDbCommand cmd7 = new OleDbCommand(sql7, conexion);
            OleDbDataAdapter da7 = new OleDbDataAdapter(cmd7);
            da7.Fill(ds, "FotoPersona6");

            MemoryStream ms5 = new MemoryStream((byte[])ds.Tables["FotoPersona6"].Rows[RowAmigo[5]]["Foto"]);

            Bitmap bm5 = new Bitmap(ms5);

            btn_Foto6.Image = bm5;
            btn_Foto6.Tag = RowAmigo[5];

            Nombres[5] = ds.Tables["FotoPersona6"].Rows[RowAmigo[5]]["Nombre"].ToString();
            NombresTag[5] = RowAmigo[5];

            int[] PosicionesRandom = { 0, 1, 2, 3, 4, 5};

            Random(PosicionesRandom);

            lbl_Res1.Text = Nombres[PosicionesRandom[0]];
            lbl_Res2.Text = Nombres[PosicionesRandom[1]];
            lbl_Res3.Text = Nombres[PosicionesRandom[2]];
            lbl_Res4.Text = Nombres[PosicionesRandom[3]];
            lbl_Res5.Text = Nombres[PosicionesRandom[4]];
            lbl_Res6.Text = Nombres[PosicionesRandom[5]];

            lbl_Res1.Tag = NombresTag[PosicionesRandom[0]];
            lbl_Res2.Tag = NombresTag[PosicionesRandom[1]];
            lbl_Res3.Tag = NombresTag[PosicionesRandom[2]];
            lbl_Res4.Tag = NombresTag[PosicionesRandom[3]];
            lbl_Res5.Tag = NombresTag[PosicionesRandom[4]];
            lbl_Res6.Tag = NombresTag[PosicionesRandom[5]];

            /*Numero[0] = RowAmigo[0];
            Numero[1] = RowAmigo[1];
            Numero[2] = RowAmigo[2];
            Numero[3] = RowAmigo[3];
            Numero[4] = RowAmigo[4];
            Numero[5] = RowAmigo[5];

            Random(Numero);
            btn_Respuesta1.Tag = Numero[0];
            btn_Respuesta2.Tag = Numero[1];
            btn_Respuesta3.Tag = Numero[2];
            btn_Respuesta4.Tag = Numero[3];
            btn_Respuesta5.Tag = Numero[4];
            btn_Respuesta6.Tag = Numero[5];
            if (btn_Foto1.Tag == btn_Respuesta1.Tag)
            {

            }*/
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            JuegosAmigos form = new JuegosAmigos();
            form.Show();
            this.Hide();
        }

        private void btn_RespuestaClick(object sender, EventArgs e)
        {

        }

        private void btn_FotoClick(object sender, EventArgs e)
        {

        }

        private void UnirSinFlechas_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            Juego();
        }

        private void btn_Foto1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto1.Width, btn_Foto1.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto1.Region = new Region(gp);
        }

        private void btn_Foto2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto2.Width, btn_Foto2.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto2.Region = new Region(gp);
        }

        private void btn_Foto3_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto3.Width, btn_Foto3.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto3.Region = new Region(gp);
        }

        private void btn_Foto4_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto4.Width, btn_Foto4.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto4.Region = new Region(gp);
        }

        private void btn_Foto5_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto5.Width, btn_Foto5.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto5.Region = new Region(gp);
        }

        private void btn_Foto6_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, btn_Foto6.Width, btn_Foto6.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 35;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn_Foto6.Region = new Region(gp);
        }
    }
}
