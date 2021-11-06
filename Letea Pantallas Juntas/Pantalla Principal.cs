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
    public partial class FormPrincipal : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        public void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!FormPantallaLogIn.ModoAdmin) {
                btn_Config.Visible = false;
                btn_CrearPaciente.Visible = false;
                btn_Salir.Visible = true;
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Show();           
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            conexion.Close();

            FormPacientes2 form = new FormPacientes2();
            form.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Amigos_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string consulta = "SELECT IDUsuario FROM GruposdeAmigos WHERE IDUsuario = "+FormPacientes2.IDPaciente+"";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "idusuario");
            int ultimo = Convert.ToInt32(ds.Tables["idusuario"].Rows.Count);
            if (ultimo > 0)
            {
                conexion.Close();

                FormGruposAmigos form = new FormGruposAmigos();
                form.Show();
                this.Hide();
            }

            else
            {
                conexion.Close();

                FormCrearGruposAmigos form = new FormCrearGruposAmigos();
                form.Show();
                this.Hide();
            }
        }
    }
}
