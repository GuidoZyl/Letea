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
            string sql = "Select Nombre completo from Usuario";
            OleDbCommand comando = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "nombre completo");
            int ultimo = Convert.ToInt32(ds.Tables["nombre completo"].Rows.Count) - 1;
            for (int i = 0; i <= ultimo; i++)
            {
                string[] nombrecompleto = new string[ultimo];
                nombrecompleto[i] = ds.Tables["nombre completo"].Rows[i].ToString();

                Label temp = new Label();

                if (i % 4 == 0) {
                    temp.Height =
                    temp.Width =
                }
            }
            
        }
    }
}
