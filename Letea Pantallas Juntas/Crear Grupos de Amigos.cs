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
    public partial class FormCrearGruposAmigos : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public FormCrearGruposAmigos()
        {
            InitializeComponent();
        }

        private void Amigos_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            //string sql = ""
        }

        private void txt_Nom_Click(object sender, EventArgs e)
        {
            if (txt_Nom.Text == "Introduzca el nombre del grupo")
            {
                txt_Nom.Text = "";
                txt_Nom.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void FormCrearGruposAmigos_Click(object sender, EventArgs e)
        {
            /*if (txt_Nom.Text == "")
            {
                txt_Nom.Text = "Introduzca el nombre del grupo";
                txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }*/
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Nom.Text != null && txt_Nom.Text != "Introduzca el nombre del grupo")
            {
                string sql = "INSERT into GruposdeAmigos (Nombre, IDUsuario) values ('" + txt_Nom.Text + "'," + FormPacientes2.IDPaciente + "";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();
            }
            else { }
        }
    }
}
