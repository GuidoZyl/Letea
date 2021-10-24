using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormPacientes2 : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        int ultimo;
        string[,] nombrecompleto;

        public FormPacientes2()
        {
            InitializeComponent();
        }

        private void Elegir_Paciente_2_Load(object sender, EventArgs e)
        {
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

            string sql = "Select NombreCompleto from Usuario";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "NombreCompleto");
            ultimo = Convert.ToInt32(ds.Tables["NombreCompleto"].Rows.Count) - 1;

            nombrecompleto = new string[ultimo + 1, 1];
            for (int canti = 0; canti <= ultimo; canti++)
            {
                nombrecompleto[canti, 0] = ds.Tables["NombreCompleto"].Rows[canti][0].ToString();
            }

            if (ultimo == 0)
            {
                lbl_Nom5.Visible = true;
                pic_Nom5.Visible = true;

                lbl_Nom5.Text = nombrecompleto[0, 0];
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
                    if (lbl_Nom1.Text != nombrecompleto[0, 0])
                    {
                        btn_Izq.Visible = true;
                    }
                }
            }
        }

        private void btn_Izq_Click(object sender, EventArgs e)
        {

            if (lbl_Nom1.Text != nombrecompleto[0, 0])
            {
                
                for (int i = 4; i <= ultimo; i++)
                {
                    
                        if (lbl_Nom1.Text == nombrecompleto[i, 0] || lbl_Nom5.Text == nombrecompleto[i, 0] || lbl_Nom6.Text == nombrecompleto[i, 0])
                        {
                            lbl_Nom1.Text = nombrecompleto[i - 4, 0];
                            lbl_Nom2.Text = nombrecompleto[i - 3, 0];
                            lbl_Nom3.Text = nombrecompleto[i - 2, 0];
                            lbl_Nom4.Text = nombrecompleto[i - 1, 0];
                            


                        if (lbl_Nom1.Text == nombrecompleto[0,0])
                            {
                                btn_Izq.Visible = false;
                            }
                        }
                    
                }
            }
        }
    }
}
