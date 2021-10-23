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
    public partial class FormPacientes : Form
    {
        
        
OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        Label[] NombresPacientes = new Label[10000];
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string sql = "Select NombreCompleto from Usuario";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "NombreCompleto");
            int ultimo = Convert.ToInt32(ds.Tables["NombreCompleto"].Rows.Count) - 1;
            string[,] nombrecompleto = new string[ultimo + 1,1];

            byte[,] foto = new byte[ultimo + 1, 1];

            

            int i = 0;

            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["NombreCompleto"].Rows[canti][0].ToString();
            }           

            //Para 4
            if ((ultimo-3) % 4 == 0)
            {
                for (i = 0; i <= ultimo; i++)
                {
                    Label temp = new Label();
                    temp.Tag = i;
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);
                    NombresPacientes[i] = temp;

                    PictureBox tmp = new PictureBox();
                    tmp.Tag = i;

                    if (i % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(350, 371);

                        string sqlFoto = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                        OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                        dataPic.Fill(ds, "foto");
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[0]["Foto"]);
                        Bitmap bm = new Bitmap(ms);

                        tmp.Image = bm;
                        tmp.Location = new Point(500, 70);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                        
                    }
                    if ((i - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(1000, 371);

                        string sqlFoto = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                        OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                        dataPic.Fill(ds, "foto2");
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto2"].Rows[0]["Foto"]);
                        Bitmap bm = new Bitmap(ms);

                        tmp.Image = bm;
                        tmp.Location = new Point(1150, 70);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((i - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(350, 850);

                        string sqlFoto = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                        OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                        dataPic.Fill(ds, "foto3");
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto3"].Rows[0]["Foto"]);
                        Bitmap bm = new Bitmap(ms);

                        tmp.Image = bm;
                        tmp.Location = new Point(500, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((i - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(1000, 850);

                        string sqlFoto = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                        OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                        dataPic.Fill(ds, "foto4");
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto4"].Rows[0]["Foto"]);
                        Bitmap bm = new Bitmap(ms);

                        tmp.Image = bm;
                        tmp.Location = new Point(1150, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Controls.Add(temp);
                    Controls.Add(tmp);
                    for (int v = 0; v <= ultimo; v++)
                    {
                        if (Convert.ToInt32(temp.Tag) == v) { temp.Visible = false; }
                    }
                    for (int w = 0; w <= 3; w++)
                    {
                        if (Convert.ToInt32(temp.Tag) == w) { temp.Visible = true; }
                    }
                    for (int x = 0; x <= ultimo; x++)
                    {
                        if (Convert.ToInt32(tmp.Tag) == x) { tmp.Visible = false; }
                    }
                    for (int y = 0; y <= 3; y++)
                    {
                        if (Convert.ToInt32(tmp.Tag) == y) { tmp.Visible = true; }
                    }
                  
                }
            }
            
            //Para 1 o 5
            if ((ultimo) % 4 == 0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Tag = ultimo;
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);
                nombre_ultimo.Text = nombrecompleto[ultimo, 0];
                nombre_ultimo.Location = new Point(650, 550);
                NombresPacientes[ultimo] = nombre_ultimo;
                PictureBox foto_ultimo = new PictureBox();
                string sqlFoto = "Select Foto from Usuario where NombreCompleto = '" + nombre_ultimo.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                dataPic.Fill(ds, "foto");
                MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[0]["Foto"]);
                Bitmap bm = new Bitmap(ms);

                foto_ultimo.Image = bm;
                foto_ultimo.Location = new Point(800, 250);
                foto_ultimo.Size = new Size(300, 300);
                foto_ultimo.SizeMode = PictureBoxSizeMode.StretchImage;
                foto_ultimo.Tag = ultimo;

                Controls.Add(nombre_ultimo);
                Controls.Add(foto_ultimo);

                for (int j = 0; j <= ultimo - 1; j++)
                {
                    Label temp = new Label();
                    temp.Tag = j;
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);
                    NombresPacientes[j] = temp;
                    PictureBox tmp = new PictureBox();
                    tmp.Tag = j;

                    if (j % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(350 , 371 );

                        string sqlFoto2 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                        OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                        dataPic2.Fill(ds, "foto2");
                        MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto2"].Rows[0]["Foto"]);
                        Bitmap bm2 = new Bitmap(ms2);

                        tmp.Image = bm2;
                        tmp.Location = new Point(500, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((j - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1000, 371);

                        string sqlFoto2 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                        OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                        dataPic2.Fill(ds, "foto3");
                        MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto3"].Rows[0]["Foto"]);
                        Bitmap bm2 = new Bitmap(ms2);

                        tmp.Image = bm2;
                        tmp.Location = new Point(1150, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((j - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(350 , 850);

                        string sqlFoto2 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                        OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                        dataPic2.Fill(ds, "foto4");
                        MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto4"].Rows[0]["Foto"]);
                        Bitmap bm2 = new Bitmap(ms2);

                        tmp.Image = bm2;
                        tmp.Location = new Point(500, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((j - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1000, 850);

                        string sqlFoto2 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                        OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                        dataPic2.Fill(ds, "foto5");
                        MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto5"].Rows[0]["Foto"]);
                        Bitmap bm2 = new Bitmap(ms2);

                        tmp.Image = bm2;
                        tmp.Location = new Point(1150, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Controls.Add(temp);
                    Controls.Add(tmp);
                    for (int v = 0; v <= ultimo; v++)
                    {
                        if (Convert.ToInt32(temp.Tag) == v) { temp.Visible = false; }
                    }
                    for (int w = 0; w <= 3; w++)
                    {
                        if (Convert.ToInt32(temp.Tag) == w) { temp.Visible = true; }
                    }
                    if (ultimo == 0)
                    {
                        nombre_ultimo.Visible = true;
                    }
                    if (ultimo > 0)
                    {
                        nombre_ultimo.Visible = false;
                    }
                    for (int x = 0; x <= ultimo; x++)
                    {
                    NombresPacientes[x].Visible = false; 
                    }
                    for (int y = 0; y <= 3; y++)
                    {
                      NombresPacientes[y].Visible = true; 
                    }
                    if (ultimo == 0)
                    {
                        NombresPacientes[ultimo].Visible = true;
                    }
                    if (ultimo > 0)
                    {
                        NombresPacientes[ultimo].Visible = false;
                    }
                }
            }
            //Para 2 o 6
            if ((ultimo - 1)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Tag = ultimo;
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(300, 550);
                NombresPacientes[ultimo] = nombre_ultimo;
                PictureBox foto_ultimo = new PictureBox();
                string sqlFoto = "SELECT Foto FROM Usuario WHERE [NombreCompleto] = '" + nombre_ultimo.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                dataPic.Fill(ds, "foto");
                MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[0]["Foto"]);
                Bitmap bm = new Bitmap(ms);

                foto_ultimo.Image = bm;
                foto_ultimo.Location = new Point(450, 250);
                foto_ultimo.Size = new Size(300, 300);
                foto_ultimo.SizeMode = PictureBoxSizeMode.StretchImage;
                foto_ultimo.Tag = ultimo;

                Label nombre_anteultimo = new Label();
                nombre_anteultimo.Tag = ultimo - 1;
                nombre_anteultimo.AutoSize = false;
                nombre_anteultimo.Width = 600;
                nombre_anteultimo.Height = 108;
                nombre_anteultimo.BackColor = Color.Transparent;
                nombre_anteultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_anteultimo.Font = new Font("Serif", 35);
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1, 0];
                nombre_anteultimo.Location = new Point(1050, 550);
                NombresPacientes[ultimo - 1] = nombre_anteultimo;
                PictureBox foto_anteultimo = new PictureBox();
                string sqlFoto2 = "SELECT Foto FROM Usuario WHERE [NombreCompleto] = '" + nombre_anteultimo.Text + "'";
                OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                dataPic2.Fill(ds, "foto2");
                MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto2"].Rows[0]["Foto"]);
                Bitmap bm2 = new Bitmap(ms2);

                foto_anteultimo.Image = bm2;
                foto_anteultimo.Location = new Point(1200, 250);
                foto_anteultimo.Size = new Size(300, 300);
                foto_anteultimo.SizeMode = PictureBoxSizeMode.StretchImage;
                foto_anteultimo.Tag = ultimo - 1;

                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);
                Controls.Add(foto_anteultimo);
                Controls.Add(foto_ultimo);

                for (int k = 0; k <= ultimo - 2; k++)
                {
                    Label temp = new Label();
                    temp.Tag = k;
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);
                    NombresPacientes[k] = temp;
                    PictureBox tmp = new PictureBox();
                    tmp.Tag = k;

                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 371 );

                        string sqlFoto3 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd3 = new OleDbCommand(sqlFoto3, conexion);
                        OleDbDataAdapter dataPic3 = new OleDbDataAdapter(cmd3);
                        dataPic3.Fill(ds, "foto3");
                        MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["foto3"].Rows[0]["Foto"]);
                        Bitmap bm3 = new Bitmap(ms3);

                        tmp.Image = bm3;
                        tmp.Location = new Point(500, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000, 371 );

                        string sqlFoto3 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd3 = new OleDbCommand(sqlFoto3, conexion);
                        OleDbDataAdapter dataPic3 = new OleDbDataAdapter(cmd3);
                        dataPic3.Fill(ds, "foto4");
                        MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["foto4"].Rows[0]["Foto"]);
                        Bitmap bm3 = new Bitmap(ms3);

                        tmp.Image = bm3;
                        tmp.Location = new Point(1150, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350, 850 );

                        string sqlFoto3 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd3 = new OleDbCommand(sqlFoto3, conexion);
                        OleDbDataAdapter dataPic3 = new OleDbDataAdapter(cmd3);
                        dataPic3.Fill(ds, "foto5");
                        MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["foto5"].Rows[0]["Foto"]);
                        Bitmap bm3 = new Bitmap(ms3);

                        tmp.Image = bm3;
                        tmp.Location = new Point(500, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 850);

                        string sqlFoto3 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd3 = new OleDbCommand(sqlFoto3, conexion);
                        OleDbDataAdapter dataPic3 = new OleDbDataAdapter(cmd3);
                        dataPic3.Fill(ds, "foto6");
                        MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["foto6"].Rows[0]["Foto"]);
                        Bitmap bm3 = new Bitmap(ms3);

                        tmp.Image = bm3;
                        tmp.Location = new Point(1150, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Controls.Add(temp);
                    Controls.Add(tmp);
                    for (int v = 0; v <= ultimo; v++)
                    {
                        if (Convert.ToInt32(temp.Tag) == v) { temp.Visible = false; }
                    }
                    for (int w = 0; w <= 3; w++)
                    {
                        if (Convert.ToInt32(temp.Tag) == w) { temp.Visible = true; }
                    }
                    if (ultimo == 1)
                    {
                        nombre_ultimo.Visible = true;
                        nombre_anteultimo.Visible = true;
                    }
                    if (ultimo > 1)
                    {
                        nombre_ultimo.Visible = false;
                        nombre_anteultimo.Visible = false;
                    }
                    for (int x = 0; x <= ultimo; x++)
                    {
                    NombresPacientes[x].Visible = false; 
                    }
                    for (int y = 0; y <= 3; y++)
                    {
                      NombresPacientes[y].Visible = true; 
                    }
                    if (ultimo == 1)
                    {
                        NombresPacientes[ultimo].Visible = true;
                        NombresPacientes[ultimo - 1].Visible = true;
                    }
                    if (ultimo > 1)
                    {
                        NombresPacientes[ultimo].Visible = false;
                        NombresPacientes[ultimo - 1].Visible = false;
                    }
                }
            }

            //Para 3 o 7
            if ((ultimo - 2)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Tag = ultimo;
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(350 , 371);
                NombresPacientes[ultimo] = nombre_ultimo;
                PictureBox foto_ultimo = new PictureBox();
                string sqlFoto = "SELECT Foto FROM Usuario WHERE [NombreCompleto] = '" + nombre_ultimo.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sqlFoto, conexion);
                OleDbDataAdapter dataPic = new OleDbDataAdapter(cmd);
                dataPic.Fill(ds, "foto");
                MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[0]["Foto"]);
                Bitmap bm = new Bitmap(ms);

                foto_ultimo.Image = bm;
                foto_ultimo.Location = new Point(500, 71);
                foto_ultimo.Size = new Size(300, 300);
                foto_ultimo.SizeMode = PictureBoxSizeMode.StretchImage;

                Label nombre_anteultimo = new Label();
                nombre_anteultimo.Tag = ultimo - 1;
                nombre_anteultimo.AutoSize = false;
                nombre_anteultimo.Width = 600;
                nombre_anteultimo.Height = 108;
                nombre_anteultimo.BackColor = Color.Transparent;
                nombre_anteultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_anteultimo.Font = new Font("Serif", 35);
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1,0];
                nombre_anteultimo.Location = new Point(1000 , 371);
                NombresPacientes[ultimo - 1] = nombre_anteultimo;
                PictureBox foto_anteultimo = new PictureBox();
                string sqlFoto2 = "SELECT Foto FROM Usuario WHERE [NombreCompleto] = '" + nombre_anteultimo.Text + "'";
                OleDbCommand cmd2 = new OleDbCommand(sqlFoto2, conexion);
                OleDbDataAdapter dataPic2 = new OleDbDataAdapter(cmd2);
                dataPic2.Fill(ds, "foto2");
                MemoryStream ms2 = new MemoryStream((byte[])ds.Tables["foto2"].Rows[0]["Foto"]);
                Bitmap bm2 = new Bitmap(ms2);

                foto_anteultimo.Image = bm2;
                foto_anteultimo.Location = new Point(1200, 250);
                foto_anteultimo.Size = new Size(300, 300);
                foto_anteultimo.SizeMode = PictureBoxSizeMode.StretchImage;
               

                Label nombre_antepenultimo = new Label();
                nombre_antepenultimo.Tag = ultimo - 2;
                nombre_antepenultimo.AutoSize = false;
                nombre_antepenultimo.Width = 600;
                nombre_antepenultimo.Height = 108;
                nombre_antepenultimo.BackColor = Color.Transparent;
                nombre_antepenultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_antepenultimo.Font = new Font("Serif", 35);
                nombre_antepenultimo.Text = nombrecompleto[ultimo - 2,0];
                nombre_antepenultimo.Location = new Point(675 , 850);
                NombresPacientes[ultimo - 2] = nombre_antepenultimo;

                PictureBox foto_antepenultimo = new PictureBox();
                string sqlFoto3 = "SELECT Foto FROM Usuario WHERE [NombreCompleto] = '" + nombre_anteultimo.Text + "'";
                OleDbCommand cmd3 = new OleDbCommand(sqlFoto3, conexion);
                OleDbDataAdapter dataPic3 = new OleDbDataAdapter(cmd3);
                dataPic2.Fill(ds, "foto3");
                MemoryStream ms3 = new MemoryStream((byte[])ds.Tables["foto3"].Rows[0]["Foto"]);
                Bitmap bm3 = new Bitmap(ms3);

                foto_antepenultimo.Image = bm3;
                foto_antepenultimo.Location = new Point(825, 550);
                foto_antepenultimo.Size = new Size(300, 300);
                foto_antepenultimo.SizeMode = PictureBoxSizeMode.StretchImage;
                
                foto_anteultimo.Tag = ultimo - 1;
                foto_antepenultimo.Tag = ultimo - 2;
                foto_ultimo.Tag = ultimo;

                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);
                Controls.Add(nombre_antepenultimo); 
                Controls.Add(foto_anteultimo);
                Controls.Add(foto_ultimo);
                Controls.Add(foto_antepenultimo);

                for (int k = 0; k <= ultimo - 3; k++)
                {
                    Label temp = new Label();
                    temp.Tag = k;
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);
                    NombresPacientes[k] = temp;
                    PictureBox tmp = new PictureBox();
                    tmp.Tag = k;

                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 371 );

                        string sqlFoto4 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd4 = new OleDbCommand(sqlFoto4, conexion);
                        OleDbDataAdapter dataPic4 = new OleDbDataAdapter(cmd4);
                        dataPic4.Fill(ds, "foto4");
                        MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["foto4"].Rows[0]["Foto"]);
                        Bitmap bm4 = new Bitmap(ms4);

                        tmp.Image = bm4;
                        tmp.Location = new Point(500, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 371);

                        string sqlFoto4 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd4 = new OleDbCommand(sqlFoto4, conexion);
                        OleDbDataAdapter dataPic4 = new OleDbDataAdapter(cmd4);
                        dataPic4.Fill(ds, "foto5");
                        MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["foto5"].Rows[0]["Foto"]);
                        Bitmap bm4 = new Bitmap(ms4);

                        tmp.Image = bm4;
                        tmp.Location = new Point(1150, 71);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 850);

                        string sqlFoto4 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd4 = new OleDbCommand(sqlFoto4, conexion);
                        OleDbDataAdapter dataPic4 = new OleDbDataAdapter(cmd4);
                        dataPic4.Fill(ds, "foto6");
                        MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["foto6"].Rows[0]["Foto"]);
                        Bitmap bm4 = new Bitmap(ms4);

                        tmp.Image = bm4;
                        tmp.Location = new Point(500, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 850 );

                        string sqlFoto4 = "Select Foto from Usuario where NombreCompleto = '" + nombrecompleto[i, 0] + "'";
                        OleDbCommand cmd4 = new OleDbCommand(sqlFoto4, conexion);
                        OleDbDataAdapter dataPic4 = new OleDbDataAdapter(cmd4);
                        dataPic4.Fill(ds, "foto7");
                        MemoryStream ms4 = new MemoryStream((byte[])ds.Tables["foto7"].Rows[0]["Foto"]);
                        Bitmap bm4 = new Bitmap(ms4);

                        tmp.Image = bm4;
                        tmp.Location = new Point(1150, 550);
                        tmp.Size = new Size(300, 300);
                        tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Controls.Add(temp);
                    Controls.Add(tmp);
                  
      
     for (int x = 0; x<=ultimo;x++)
     {
      if (Convert.ToInt32(tmp.Tag) == x) {tmp.Visible = false;}
      }
                    for (int y = 0; y <= 3; y++)
                    {
                         if (Convert.ToInt32(tmp.Tag) == y) { tmp.Visible = true; }
                    }
                    if (ultimo == 2)
                    {
                        foto_ultimo.Visible = true;
                        foto_anteultimo.Visible = true;
                        foto_antepenultimo.Visible = true;
                    }
                    if (ultimo > 2)
                    {
                        foto_ultimo.Visible = false;
                        foto_anteultimo.Visible = false;
                        foto_antepenultimo.Visible = false;
                    }
                    for (int v = 0; v <= ultimo; v++)
                    {
                        NombresPacientes[v].Visible = false;
                    }
                    for (int w = 0; w <= 3; w++)
                    {
                      NombresPacientes[w].Visible = true; 
                    }
                    if (ultimo == 2)
                    {
                        NombresPacientes[ultimo].Visible = true;
                        NombresPacientes[ultimo - 1].Visible = true;
                        NombresPacientes[ultimo - 2].Visible = true;
                    }
                    if (ultimo > 2)
                    {
                        NombresPacientes[ultimo].Visible = false;
                        NombresPacientes[ultimo - 1].Visible = false;
                        NombresPacientes[ultimo - 2].Visible = false;
                    }

                }
            }           
        }

        private void flechaizquierda_click(object sender, EventArgs e)
        {
            if (NombresPacientes[0].Visible == true) 
            { btn_FlechaIzq.Visible = false; }
            else { btn_FlechaIzq.Visible = true; }
        }
    }
}
