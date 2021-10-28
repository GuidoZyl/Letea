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
    public partial class FormGrupo : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public static int ultimo;
        string[,] InfoAmigo = new string[ultimo + 1, 4];
        public FormGrupo()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormGruposAmigos form = new FormGruposAmigos();
            form.Show();
            this.Hide();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion form = new Configuracion();
            form.Show();
        }

        private void FormGrupo_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string consulta = "SELECT Nombre FROM GruposAmigos WHERE Id = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "Nombregrupo");
            lbl_NomGrupo.Text = ds.Tables["Nombregrupo"].Rows[0][0].ToString();
            string consulta1 = "SELECT [Nombre],[Apellido],[Fecha de Nacimiento],[Lugar Donde la conoció] FROM Amigos WHERE IdGruposDeAmigos = " + FormGruposAmigos.IDGrupo + "";
            OleDbCommand comando1 = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data1 = new OleDbDataAdapter(comando1);
            data1.Fill(ds, "Amigo");
            ultimo = Convert.ToInt32(ds.Tables["Amigo"].Rows.Count - 1);
        }

        private void lbl_NomGrupo_Click(object sender, EventArgs e)
        {

        }
    }
}
