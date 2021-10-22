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
using System.IO;

namespace Pantalla_Contraseña
{
    public partial class FormPantallaLogIn : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public FormPantallaLogIn()
        {
            InitializeComponent();
            txtbox_Contraseña.UseSystemPasswordChar = true;
        }

        private void FormPantallaLogIn_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string sql = "SELECT Foto FROM Admin";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);

            data.Fill(ds, "foto");

            MemoryStream ms = new MemoryStream((byte[])ds.Tables["foto"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            pic_Administrador.Image = bm;
        }

        private void click_vercontraseña(object sender, EventArgs e)
        {
            txtbox_Contraseña.UseSystemPasswordChar = false;
            btn_Vercontraseña.Visible = false;
            btn_NoVercontraseña.Visible = true;
        }

        private void click_novercontraseña(object sender, EventArgs e)
        {
            txtbox_Contraseña.UseSystemPasswordChar = true;
            btn_Vercontraseña.Visible = true;
            btn_NoVercontraseña.Visible = false;
        }

        private void btn_ingresaradmin_Click(object sender, EventArgs e)
        {
            string sql = "Select Contraseña from Admin";
            OleDbCommand comando = new OleDbCommand(sql, conexion); 
            OleDbDataAdapter data = new OleDbDataAdapter(comando);
            
            data.Fill(ds, "contraseña");
            string contraseña = ds.Tables["contraseña"].Rows[0]["Contraseña"].ToString();
            if (txtbox_Contraseña.Text == contraseña)
            {
                conexion.Close();
                FormPacientes form = new FormPacientes();

                form.Show();
                this.Hide();
            }            
            
            else
            {
                this.Cursor = default;
                lbl_ContraseñaIncorrecta.Visible = true;
                Task.Delay(2000).Wait();
                lbl_ContraseñaIncorrecta.Visible = false;

            }
        }

        private void txtbox_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
