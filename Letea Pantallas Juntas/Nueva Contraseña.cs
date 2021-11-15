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
    public partial class FormNuevaContra : Form
    {
        OleDbConnection conexion = new OleDbConnection();

        public FormNuevaContra()
        {
            InitializeComponent();
        }

        private void ver_nuevacontraseña(object sender, EventArgs e)
        {
            txtbox_nuevacontraseña.UseSystemPasswordChar = false;
            btn_ojonueva.Visible = false;
            btn_noojonueva.Visible = true;
        }
    
        

        private void ver_confirmarcontraseña(object sender, EventArgs e)
        {             
            txtbox_confirmarcontraseña.UseSystemPasswordChar = false;
            btn_ojoconfirmar.Visible = false;
            btn_noojoconfirmar.Visible = true;
        }

        private void click_siguiente(object sender, EventArgs e)
        {
            if (txtbox_confirmarcontraseña.Text == txtbox_nuevacontraseña.Text && txtbox_confirmarcontraseña.Text != "")
            {
                string sql = "Insert into Admin (Contraseña) values ('" + txtbox_confirmarcontraseña.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();

                conexion.Close();

                FormFotoAdmin FotoAdmin = new FormFotoAdmin();
                FotoAdmin.Show();
                this.Hide();
                
            }

            else if (txtbox_confirmarcontraseña.Text == "" || txtbox_nuevacontraseña.Text == "")
            {
                this.Cursor = default;
                lbl_IngreseContra.Visible = true;
                Task.Delay(2000).Wait();
                lbl_IngreseContra.Visible = false;
            }
           
            else
            {
                this.Cursor = default;
                lbl_NoCoincide.Visible = true;
                Task.Delay(2000).Wait();
                lbl_NoCoincide.Visible = false;
            }
        }

        private void no_ver_contraseña_nueva(object sender, EventArgs e)
        {
            txtbox_nuevacontraseña.UseSystemPasswordChar = true;
            btn_ojonueva.Visible = true;
            btn_noojonueva.Visible = false;
        }

        private void no_ver_contraseña_confirmar(object sender, EventArgs e)
        {
            txtbox_confirmarcontraseña.UseSystemPasswordChar = true;
            btn_ojoconfirmar.Visible = true;
            btn_noojoconfirmar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox_confirmarcontraseña.UseSystemPasswordChar = true;
            txtbox_nuevacontraseña.UseSystemPasswordChar = true;

            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
        }
    }
}
