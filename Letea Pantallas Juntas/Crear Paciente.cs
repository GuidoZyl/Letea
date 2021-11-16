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
        DataSet ds = new DataSet();

        public static int IDPacienteTemp;

        public FormCrearPaciente()
        {
            InitializeComponent();
        }

        private void FormCrearPaciente_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string sql = "SELECT * FROM Usuario";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "checkeo");
           
            if (Convert.ToInt32(ds.Tables["checkeo"].Rows.Count) > 0)
            {
                btn_Volver.Visible = true;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (txtbox_NombreUsuario.Text != "")
            {
                string sql = "Insert into Usuario (NombreCompleto) values ('" + txtbox_NombreUsuario.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();

                string sql2 = "SELECT Id FROM Usuario WHERE NombreCompleto = '" + txtbox_NombreUsuario.Text + "'";
                OleDbCommand cmd2 = new OleDbCommand(sql2, conexion);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd2);

                da.Fill(ds, "Usuario");

                IDPacienteTemp = Convert.ToInt32(ds.Tables["Usuario"].Rows[0]["Id"]);

                conexion.Close();

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

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormPacientes2 form = new FormPacientes2();
            form.Show();
            this.Hide();
        }
    }
}
