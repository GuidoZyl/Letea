using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.OleDb;

namespace Pantalla_Contraseña
{
    public partial class FormCrearPaciente : Form
    {
        OleDbConnection conexion = new OleDbConnection();

        public FormCrearPaciente()
        {
            InitializeComponent();
        }

        private void FormCrearPaciente_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (txtbox_NombreUsuario.Text != "")
            {
                string sql = "Insert into Usuario (Nombre completo) values ('" + txtbox_NombreUsuario.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Listo");

                FormFotoUsuarioRegistro form = new FormFotoUsuarioRegistro();
                form.Show();
                this.Hide();
            }

            else
            {
                this.Cursor = default;
                lbl_IngreseNombre.Visible = true;
                Task.Delay(2000).Wait();
                lbl_IngreseNombre.Visible = false;
            }            
        }
    }
}
