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
using System.IO;

namespace Pantalla_Contraseña
{
    public partial class UnirSinFlechas : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
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
            string sql = "SELECT Id FROM Amigos";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "FotoNombre");
            int[] IdAmigos = new int[ds.Tables["FotoNombre"].Rows.Count];
            for (int i = 0; i < ds.Tables["FotoNombre"].Rows.Count; i++)
            {
                IdAmigos[i] = i;
            }
            Random(IdAmigos);
            
            string sql2 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[0] + "";
            OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
            da2.Fill(ds, "FotoPersona1");

            MemoryStream ms = new MemoryStream((byte[])ds.Tables["FotoPersona1"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            btn_Foto1.Image = bm;
            
            string sql3 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[1] + "";
            OleDbCommand cmd3 = new OleDbCommand(sql3, conexion);
            OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
            da3.Fill(ds, "FotoPersona2");

            MemoryStream ms1 = new MemoryStream((byte[])ds.Tables["FotoPersona2"].Rows[0]["Foto"]);

            Bitmap bm1 = new Bitmap(ms1);

            btn_Foto2.Image = bm1;

            string sql4 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[2] + "";
            OleDbCommand cmd4 = new OleDbCommand(sql4, conexion);
            OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
            da4.Fill(ds, "FotoPersona3");

            MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["FotoPersona3"].Rows[0]["Foto"]);

            Bitmap bm2 = new Bitmap(ms2);

            btn_Foto3.Image = bm2;

            string sql5 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[3] + "";
            OleDbCommand cmd5 = new OleDbCommand(sql5, conexion);
            OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
            da5.Fill(ds, "FotoPersona4");

            MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["FotoPersona4"].Rows[0]["Foto"]);

            Bitmap bm3 = new Bitmap(ms3);

            btn_Foto4.Image = bm3;

            string sql6 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[4] + "";
            OleDbCommand cmd6 = new OleDbCommand(sql6, conexion);
            OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
            da6.Fill(ds, "FotoPersona5");

            MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["FotoPersona5"].Rows[0]["Foto"]);

            Bitmap bm4 = new Bitmap(ms4);

            btn_Foto5.Image = bm4;

            string sql7 = "SELECT Foto FROM Amigos WHERE Id = " + IdAmigos[5] + "";
            OleDbCommand cmd7 = new OleDbCommand(sql7, conexion);
            OleDbDataAdapter da7 = new OleDbDataAdapter(cmd7);
            da7.Fill(ds, "FotoPersona6");

            MemoryStream ms5 = new MemoryStream((byte[])ds.Tables["FotoPersona6"].Rows[0]["Foto"]);

            Bitmap bm5 = new Bitmap(ms5);

            btn_Foto6.Image = bm5;
        }
        private void lbl_Res1_Click(object sender, EventArgs e)
        {

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
    }
}
