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
    public partial class FormPreguntas : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        string NombreCorrecto;
        string GrupoCorrecto;
        int Pregunta;

        public FormPreguntas()
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

        void NuevaPregunta()
        {
            lbl_Nom.Visible = false;
            string sql = "SELECT * FROM JuegoPreguntas";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "Preguntas");

            string[] preguntas = new string[ds.Tables["Preguntas"].Rows.Count];

            for (int i = 0; i < ds.Tables["Preguntas"].Rows.Count; i++)
            {
                preguntas[i] = Convert.ToString(ds.Tables["Preguntas"].Rows[i]["Pregunta"]);
            }

            Random(preguntas);

            lbl_Pregunta.Text = preguntas[0];

            if (preguntas[0] == "¿Qué parentesco tiene esta persona con usted?")
            {
                
            }

            else if (preguntas[0] == "¿De dónde conoce usted a esta persona?")
            {
                string check = "SELECT * FROM GruposdeAmigos WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
                OleDbCommand comando = new OleDbCommand(check, conexion);
                OleDbDataAdapter data = new OleDbDataAdapter(comando);
                data.Fill(ds, "Checkeo");

                if (ds.Tables["Checkeo"].Rows.Count > 3)
                {
                    ds.Tables["Checkeo"].Clear();
                    Pregunta = 2;

                    string sql2 = "SELECT Id FROM GruposdeAmigos WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
                    OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                    da2.Fill(ds, "IdGrupoCorrecta");

                    int[] IdGrupoCorrecta = new int[ds.Tables["IdGrupoCorrecta"].Rows.Count];
                    for (int i = 0; i < ds.Tables["IdGrupoCorrecta"].Rows.Count; i++)
                    {
                        IdGrupoCorrecta[i] = Convert.ToInt32(ds.Tables["IdGrupoCorrecta"].Rows[i]["Id"]);
                    }

                   //  Random(IdGrupoCorrecta);
                    Random rnd = new Random();
                    int PosicionCorrecta = rnd.Next(0, ds.Tables["IdGrupoCorrecta"].Rows.Count);

                    string query = "SELECT * FROM GruposdeAmigos WHERE Id = " + IdGrupoCorrecta[PosicionCorrecta] + " AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                    OleDbCommand comando2 = new OleDbCommand(query, conexion);
                    OleDbDataAdapter data2 = new OleDbDataAdapter(comando2);
                    data2.Fill(ds, "NombreGrupoCorrecto");

                    GrupoCorrecto = Convert.ToString(ds.Tables["NombreGrupoCorrecto"].Rows[0]["Nombre"]);

                    string sql3 = "SELECT * FROM Amigos WHERE IDGruposDeAmigos = " + IdGrupoCorrecta[PosicionCorrecta] + " AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                    OleDbCommand cmd3 = new OleDbCommand(sql3, conexion);
                    OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                    da3.Fill(ds, "IdCorrecta");

                    int[] IdCorrecta = new int[ds.Tables["IdCorrecta"].Rows.Count];
                    for (int i = 0; i < ds.Tables["IdCorrecta"].Rows.Count; i++)
                    {
                        IdCorrecta[i] = Convert.ToInt32(ds.Tables["IdCorrecta"].Rows[i]["Id"]);
                    }

                    Random(IdCorrecta);
                    int PosicionCorrecta2 = rnd.Next(0, ds.Tables["IdCorrecta"].Rows.Count);

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables["IdCorrecta"].Rows[PosicionCorrecta2]["Foto"]);
                    Bitmap bm = new Bitmap(ms);

                    pic_Persona.Image = bm;
                    lbl_Nom.Visible = true;
                    lbl_Nom.Text = Convert.ToString(ds.Tables["IdCorrecta"].Rows[PosicionCorrecta2]["Nombre"]);

                    string sql4 = "SELECT * FROM GruposdeAmigos WHERE NOT Id = " + IdGrupoCorrecta[PosicionCorrecta] + " AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                    OleDbCommand cmd4 = new OleDbCommand(sql4, conexion);
                    OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                    da4.Fill(ds, "IdIncorrecta");

                    int[] IdIncorrectaTemp = new int[ds.Tables["IdIncorrecta"].Rows.Count];
                    for (int i = 0; i < ds.Tables["IdIncorrecta"].Rows.Count; i++)
                    {
                        IdIncorrectaTemp[i] = Convert.ToInt32(ds.Tables["IdIncorrecta"].Rows[i]["Id"]);
                    }

                    Random(IdIncorrectaTemp);

                    int[] PosicionesRandom = { 0, 1, 2 };
                    Random(PosicionesRandom);

                    int[] IdIncorrecta = new int[3];
                    for (int i = 0; i < 3; i++)
                    {
                        IdIncorrecta[i] = IdIncorrectaTemp[PosicionesRandom[i]];
                    }

                    string sql5 = "SELECT * FROM GruposdeAmigos WHERE (Id = " + IdIncorrecta[0] + " OR Id = " + IdIncorrecta[1] + " OR Id = " + IdIncorrecta[2] + ") AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                    OleDbCommand cmd5 = new OleDbCommand(sql5, conexion);
                    OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                    da5.Fill(ds, "InfoIncorrecta");

                    string[] Opciones = new string[4];
                    for (int i = 0; i < 3; i++)
                    {
                        Opciones[i] = Convert.ToString(ds.Tables["InfoIncorrecta"].Rows[i]["Nombre"]);
                    }
                    Opciones[3] = GrupoCorrecto;

                    Random(Opciones);

                    lbl_Res1.Text = Opciones[0];
                    lbl_Res2.Text = Opciones[1];
                    lbl_Res3.Text = Opciones[2];
                    lbl_Res4.Text = Opciones[3];

                    ds.Tables["IdGrupoCorrecta"].Clear();
                    ds.Tables["IdCorrecta"].Clear();
                    ds.Tables["IdIncorrecta"].Clear();
                    ds.Tables["InfoIncorrecta"].Clear();
                    ds.Tables["NombreGrupoCorrecto"].Clear();
                }

                else
                {
                    ds.Tables["Checkeo"].Clear();
                    NuevaPregunta();
                }
            }

            else if (preguntas[0] == "¿Cuál es el nombre de esta persona?")
            {
                Pregunta = 3;
                string sql2 = "SELECT Id FROM Amigos WHERE IDUsuario = " + FormPacientes2.IDPaciente + "";
                OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(ds, "IdCorrecta");

                int[] IdCorrecta = new int[ds.Tables["IdCorrecta"].Rows.Count];
                for (int i = 0; i < ds.Tables["IdCorrecta"].Rows.Count; i++)
                {
                    IdCorrecta[i] = Convert.ToInt32(ds.Tables["IdCorrecta"].Rows[i]["Id"]);
                }

                Random(IdCorrecta);

                Random rnd = new Random();
                int PosicionCorrecta = rnd.Next(0, ds.Tables["IdCorrecta"].Rows.Count);

                string sql3 = "SELECT * FROM Amigos WHERE Id = " + IdCorrecta[PosicionCorrecta] + " AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                OleDbCommand cmd3 = new OleDbCommand(sql3, conexion);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(ds, "InfoCorrecta");

                NombreCorrecto = Convert.ToString(ds.Tables["InfoCorrecta"].Rows[0]["Nombre"]);

                MemoryStream ms = new MemoryStream((byte[])ds.Tables["InfoCorrecta"].Rows[0]["Foto"]);

                Bitmap bm = new Bitmap(ms);

                pic_Persona.Image = bm;

                string sql4 = "SELECT Id FROM Amigos WHERE NOT Id = " + IdCorrecta[PosicionCorrecta] + " AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                OleDbCommand cmd4 = new OleDbCommand(sql4, conexion);
                OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                da4.Fill(ds, "IdIncorrecta");

                int[] IdIncorrectaTemp = new int[ds.Tables["IdIncorrecta"].Rows.Count];
                for (int i = 0; i < ds.Tables["IdIncorrecta"].Rows.Count; i++)
                {
                    IdIncorrectaTemp[i] = Convert.ToInt32(ds.Tables["IdIncorrecta"].Rows[i]["Id"]);
                }

                Random(IdIncorrectaTemp);

                int[] PosicionesRandom = { 0, 1, 2 };
                Random(PosicionesRandom);

                int[] IdIncorrecta = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    IdIncorrecta[i] = IdIncorrectaTemp[PosicionesRandom[i]];
                }

                string sql5 = "SELECT * FROM Amigos WHERE (Id = " + IdIncorrecta[0] + " OR Id = " + IdIncorrecta[1] + " OR Id = " + IdIncorrecta[2] + ") AND IDUsuario = " + FormPacientes2.IDPaciente + "";
                OleDbCommand cmd5 = new OleDbCommand(sql5, conexion);
                OleDbDataAdapter da5 = new OleDbDataAdapter(cmd5);
                da5.Fill(ds, "InfoIncorrecta");

                string[] Opciones = new string[4];
                for (int i = 0; i < 3; i++)
                {
                    Opciones[i] = Convert.ToString(ds.Tables["InfoIncorrecta"].Rows[i]["Nombre"]);
                }
                Opciones[3] = NombreCorrecto;

                Random(Opciones);

                lbl_Res1.Text = Opciones[0];
                lbl_Res2.Text = Opciones[1];
                lbl_Res3.Text = Opciones[2];
                lbl_Res4.Text = Opciones[3];

                ds.Tables["IdCorrecta"].Clear();
                ds.Tables["InfoCorrecta"].Clear();
                ds.Tables["IdIncorrecta"].Clear();
                ds.Tables["InfoIncorrecta"].Clear();
            }
        }

        private void Juego_de_Preguntas_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            NuevaPregunta();
        }

        private void pic_Persona_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, pic_Persona.Width, pic_Persona.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 70;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pic_Persona.Region = new Region(gp);
        }

        private void lbl_Res1_Click(object sender, EventArgs e)
        {
            Label LabelClicked = sender as Label;
            if (Pregunta == 3)
            {
                if (LabelClicked.Text == NombreCorrecto)
                {
                    MessageBox.Show("Correcto");
                    NuevaPregunta();
                }
                else
                {
                    MessageBox.Show("Inténtelo de nuevo");
                }
            }

            else if (Pregunta == 2)
            {
                if (LabelClicked.Text == GrupoCorrecto)
                {
                    MessageBox.Show("Correcto");
                    NuevaPregunta();
                }
                else
                {
                    MessageBox.Show("Inténtelo de nuevo");
                }
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
