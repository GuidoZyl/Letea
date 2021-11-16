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
    public partial class Bienvenido : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            Delay();
            Empezar();
            
        }
        void Delay()
        {
            Task.Delay(2000).Wait();
        }
        void Empezar()
        {
            string sql = "SELECT * FROM Admin";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "checkeo");
            if (ds.Tables["checkeo"].Rows.Count > 0)
            {
                FormPantallaLogIn form = new FormPantallaLogIn();
                form.Show();
                this.Hide();
            }
            else
            {
                FormNuevaContra form = new FormNuevaContra();
                form.Show();
                this.Hide();
            }
        }
    }
}
