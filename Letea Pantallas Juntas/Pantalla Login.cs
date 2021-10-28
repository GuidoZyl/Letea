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
using System.Drawing.Drawing2D;

namespace Pantalla_Contraseña
{
    public partial class FormPantallaLogIn : Form
    {
        public static bool ModoAdmin = false;

        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public FormPantallaLogIn()
        {
            InitializeComponent();
            txtbox_Contraseña.UseSystemPasswordChar = true;
        }

        private void FormPantallaLogIn_Load(object sender, EventArgs e)
        {
            ModoAdmin = false;
            FormFotoUsuarioRegistro.PrimerPaciente = true;

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
                ModoAdmin = true;
                FormPacientes2 form = new FormPacientes2();
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

        private void btn_IngresoPaciente_Click(object sender, EventArgs e)
        {
            FormPacientes2 form = new FormPacientes2();
            form.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Administrador_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(pic_Administrador.ClientRectangle, 0, 0);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(pic_Administrador.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                pic_Administrador.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
