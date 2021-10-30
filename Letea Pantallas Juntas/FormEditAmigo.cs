using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormEditAmigo : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public FormEditAmigo()
        {
            InitializeComponent();
        }

        private void FormEditAmigo_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
            string consulta = "SELECT [Nombre] , [Apellido] , [Foto] FROM Amigos WHERE Id = " + FormGrupo.RowPaciente + "";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "InfoAmigo");
            MemoryStream ms = new MemoryStream((byte[])ds.Tables["InfoAmigo"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            btn_agregarfoto.Image = bm;
            lbl_Nombre.Text = ds.Tables["InfoAmigo"].Rows[0][0].ToString();
            lbl_Apellido.Text = ds.Tables["InfoAmigo"].Rows[0][1].ToString();

        }
    }
}
