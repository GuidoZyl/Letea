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
            int i = 0;

            data.Fill(ds, "NombreCompleto");
            int ultimo = Convert.ToInt32(ds.Tables["NombreCompleto"].Rows.Count) - 1;
            string[,] nombrecompleto = new string[ultimo,1];
            nombrecompleto[i,0] = ds.Tables["NombreCompleto"].Rows[i][0].ToString();

            

            if ((ultimo-3) % 4 == 0)
            {
                for (i = 0; i <= ultimo; i++)
                {


                    Label temp = new Label();
                    temp.AutoSize = true;

                    temp.Font = new Font("Serif", 35);
                    if (i % 4 == 0)
                    {
                        temp.Text = "pepe argentoiiiiiiiiiiiii";
                        temp.Location = new Point(650 , 425 );
                    }
                    if ((i - 1) % 4 == 0)
                    {
                        temp.Text = "Ariel Ricardo Alejandro Alzogaray Flores";
                        temp.Location = new Point(1100, 425);
                    }
                    if ((i - 2) % 4 == 0)
                    {
                        temp.Text = "carlos";
                        temp.Location = new Point(650 , 825 );

                    }
                    if ((i - 3) % 4 == 0)
                    {
                        temp.Text = "andres";
                        temp.Location = new Point(1100, 825);
                    }
                    Controls.Add(temp);
                }
            }
            
            if ((ultimo) % 4 == 0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                Controls.Add(nombre_ultimo);
                nombre_ultimo.Location = new Point(950, 475);
                for (int j=0; j<=ultimo - 1;j++)
                {
                    Label temp = new Label();
                    temp.AutoSize = true;
                    if (j % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(650 , 425 );
                    }
                    if ((j - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1100, 425);
                    }
                    if ((j - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(650 , 825 );

                    }
                    if ((j - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[j,0];
                        temp.Location = new Point(1100, 825 );
                    }
                    Controls.Add(temp);
                }
            }
            if ((ultimo - 1)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(650, 475);
                Label nombre_anteultimo = new Label();
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1,0];
                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);
                nombre_anteultimo.Location = new Point(1100, 475);
                for (int k = 0; k <= ultimo - 2; k++)
                {
                    Label temp = new Label();
                    temp.AutoSize = true;
                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(650 , 425 );
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1100, 425 );
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(650, 825 );

                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1100 , 825);
                    }
                    Controls.Add(temp);
                }

            }
            if ((ultimo - 2)%4==0)
            {
                Label nombre_ultimo = new Label();
                nombre_ultimo.Text = nombrecompleto[ultimo,0];
                nombre_ultimo.Location = new Point(550 , 475);
                Label nombre_anteultimo = new Label();
                nombre_anteultimo.Text = nombrecompleto[ultimo - 1,0];
                nombre_anteultimo.Location = new Point(1050 , 475);
                Label nombre_antepenultimo = new Label();
                nombre_antepenultimo.Text = nombrecompleto[ultimo - 2,0];
                nombre_antepenultimo.Location = new Point(1550 , 475);
                Controls.Add(nombre_ultimo);
                Controls.Add(nombre_anteultimo);
                Controls.Add(nombre_antepenultimo);
                

                for (int k = 0; k <= ultimo - 3; k++)
                {
                    Label temp = new Label();
                    temp.AutoSize = true;
                    temp.TextAlign = CenterToParent;
                    if (k % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(650 , 425 );
                    }
                    if ((k - 1) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1100 , 425);
                    }
                    if ((k - 2) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(650 , 825);

                    }
                    if ((k - 3) % 4 == 0)
                    {
                        temp.Text = nombrecompleto[k,0];
                        temp.Location = new Point(1100 , 825 );
                    }
                    Controls.Add(temp);
                }
                
                
                    
                    
                    
            }
            
        }
    }
}
