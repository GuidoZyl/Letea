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

namespace Pantalla_Contraseña
{
    public partial class FormPacientes : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        
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
            int i = 0;

            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["NombreCompleto"].Rows[canti][0].ToString();
            }           

            if ((ultimo-3) % 4 == 0)
            {
                for (i = 0; i <= ultimo; i++)
                {
                    Label temp = new Label();
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);

                    if (i % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(350, 371);
                    }
                    if ((i - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(1000, 371);
                    }
                    if ((i - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(350, 771);
                    }
                    if ((i - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[i, 0];
                        temp.Location = new Point(1000, 771);
                    }
                    Controls.Add(temp);
                }
            }
            
            if ((ultimo) % 4 == 0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);

                nombre_ultimo.Text = nombrecompleto[ultimo, 0];
                Controls.Add(nombre_ultimo);
                nombre_ultimo.Location = new Point(650, 550);
                for (int j = 0; j <= ultimo - 1; j++)
                {
                    Label temp = new Label();
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);

                    if (j % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(350 , 371 );
                    }
                    if ((j - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1000, 371);
                    }
                    if ((j - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(350 , 800);

                    }
                    if ((j - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1000, 800);
                    }
                    Controls.Add(temp);
                }
            }

            if ((ultimo - 1)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(300, 550);

                Label nombre_anteultimo = new Label();
                nombre_anteultimo.AutoSize = false;
                nombre_anteultimo.Width = 600;
                nombre_anteultimo.Height = 108;
                nombre_anteultimo.BackColor = Color.Transparent;
                nombre_anteultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_anteultimo.Font = new Font("Serif", 35);
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1,0];
                nombre_anteultimo.Location = new Point(1050, 550);

                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);

                for (int k = 0; k <= ultimo - 2; k++)
                {
                    Label temp = new Label();
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);

                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 371 );
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000, 371 );
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350, 800 );

                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 800);
                    }
                    Controls.Add(temp);
                }

            }
            if ((ultimo - 2)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.AutoSize = false;
                nombre_ultimo.Width = 600;
                nombre_ultimo.Height = 108;
                nombre_ultimo.BackColor = Color.Transparent;
                nombre_ultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_ultimo.Font = new Font("Serif", 35);
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(350 , 371);

                Label nombre_anteultimo = new Label();
                nombre_anteultimo.AutoSize = false;
                nombre_anteultimo.Width = 600;
                nombre_anteultimo.Height = 108;
                nombre_anteultimo.BackColor = Color.Transparent;
                nombre_anteultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_anteultimo.Font = new Font("Serif", 35);
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1,0];
                nombre_anteultimo.Location = new Point(1000 , 371);

                Label nombre_antepenultimo = new Label();
                nombre_antepenultimo.AutoSize = false;
                nombre_antepenultimo.Width = 600;
                nombre_antepenultimo.Height = 108;
                nombre_antepenultimo.BackColor = Color.Transparent;
                nombre_antepenultimo.TextAlign = ContentAlignment.MiddleCenter;
                nombre_antepenultimo.Font = new Font("Serif", 35);
                nombre_antepenultimo.Text = nombrecompleto[ultimo - 2,0];
                nombre_antepenultimo.Location = new Point(675 , 800);

                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);
                Controls.Add(nombre_antepenultimo);
                

                for (int k = 0; k <= ultimo - 3; k++)
                {
                    Label temp = new Label();
                    temp.AutoSize = false;
                    temp.Width = 600;
                    temp.Height = 108;
                    temp.BackColor = Color.Transparent;
                    temp.TextAlign = ContentAlignment.MiddleCenter;
                    temp.Font = new Font("Serif", 35);

                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 371 );
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 371);
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(350 , 800);

                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1000 , 800 );
                    }
                    Controls.Add(temp);
                }      
            }           
        }
    }
}
