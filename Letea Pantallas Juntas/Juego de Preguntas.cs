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
                
            }

            else if (preguntas[0] == "¿Cuál es el nombre de esta persona?")
            {
                //FALTA PONER QUE ELIJA LOS AMIGOS DEL PACIENTE ESPECIFICO
                string sql2 = "SELECT Id FROM Amigos";
                OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                da2.Fill(ds, "IdCorrecta");

                int[] IdCorrecta = new int[ds.Tables["IdCorrecta"].Rows.Count];
                for (int i = 0; i < ds.Tables["IdCorrecta"].Rows.Count; i++)
                {
                    IdCorrecta[i] = Convert.ToInt32(ds.Tables["IdCorrecta"].Rows[i]["Id"]);
                }

                Random(IdCorrecta);

                string sql3 = "SELECT * FROM Amigos WHERE Id = " + IdCorrecta[0] + "";
                OleDbCommand cmd3 = new OleDbCommand(sql3, conexion);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3);
                da3.Fill(ds, "InfoCorrecta");

                string NombreCorrecto = Convert.ToString(ds.Tables["InfoCorrecta"].Rows[0]["Nombre"]);

                MemoryStream ms = new MemoryStream((byte[])ds.Tables["InfoCorrecta"].Rows[0]["Foto"]);

                Bitmap bm = new Bitmap(ms);

                pic_Persona.Image = bm;
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
    }
}
