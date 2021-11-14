using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormEditFamiliar : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        bool ModoEdit = false;

        public FormEditFamiliar()
        {
            InitializeComponent();
            txt_Nom.Visible = false;
            txt_Apellido.Visible = false;
            cmb_Relacion.Visible = false;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            ArbolGenealogico form = new ArbolGenealogico();
            form.Show();
            this.Hide();
        }

        private void btn_agregarfoto_Click(object sender, EventArgs e)
        {
            if (ModoEdit)
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen |*.jpg;*.jpeg";

                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Titulo del Dialogo";

                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    String Direccion = BuscarImagen.FileName;

                    btn_agregarfoto.ImageLocation = Direccion;

                    btn_agregarfoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void FormEditFamiliar_Load(object sender, EventArgs e)
        {
            if (FormPantallaLogIn.ModoAdmin)
            {
                btn_EditarAmigo.Visible = true;
                btn_Eliminar.Visible = true;
            }

            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();

            string sql = "SELECT * FROM Relaciones";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "Relaciones");

            string[] relaciones = new string[ds.Tables["Relaciones"].Rows.Count];

            for (int i = 0; i < ds.Tables["Relaciones"].Rows.Count; i++)
            {
                relaciones[i] = ds.Tables["Relaciones"].Rows[i]["Relacion"].ToString();
                cmb_Relacion.Items.Add(relaciones[i]);
            }

            string consulta = "SELECT [Nombre], [Apellido], [Foto], [FechadeNacimiento], [RelaciondeParentesco] FROM Familia WHERE Id = " + ArbolGenealogico.IDFamiliar + "";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter data = new OleDbDataAdapter(comando);

            data.Fill(ds, "InfoAmigo");
            MemoryStream ms = new MemoryStream((byte[])ds.Tables["InfoAmigo"].Rows[0]["Foto"]);

            Bitmap bm = new Bitmap(ms);

            btn_agregarfoto.Image = bm;
            lbl_Nombre.Text = ds.Tables["InfoAmigo"].Rows[0][0].ToString();
            lbl_Apellido.Text = ds.Tables["InfoAmigo"].Rows[0][1].ToString();
            this.dateTimePicker1.Text = ds.Tables["InfoAmigo"].Rows[0][3].ToString();
            lbl_RelacionParentesco.Text = ds.Tables["InfoAmigo"].Rows[0][4].ToString();
            cmb_Relacion.Text = ds.Tables["InfoAmigo"].Rows[0][4].ToString();
        }

        private void btn_EditarAmigo_Click(object sender, EventArgs e)
        {
            btn_Guardar.Visible = true;
            txt_Nom.Visible = true;
            txt_Apellido.Visible = true;
            txt_Apellido.Text = lbl_Apellido.Text;
            txt_Nom.Text = lbl_Nombre.Text;
            lbl_Apellido.Visible = false;
            lbl_Nombre.Visible = false;
            txt_Nom.Enabled = true;
            txt_Apellido.Enabled = true;
            dateTimePicker1.Enabled = true;
            btn_EditarAmigo.Visible = false;
            btn_agregarfoto.Cursor = Cursors.Hand;
            cmb_Relacion.Visible = true;
            cmb_Relacion.Enabled = true;
            lbl_RelacionParentesco.Visible = false;

            ModoEdit = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Familia set [Nombre] = '" + txt_Nom.Text + "', [Apellido] = '" + txt_Apellido.Text + "', [Foto] = @foto, [FechadeNacimiento] = '" + this.dateTimePicker1.Text + "', [RelaciondeParentesco] = '"+cmb_Relacion.SelectedItem+"' WHERE Id = " + ArbolGenealogico.IDFamiliar + "";

            MemoryStream ms = new MemoryStream();
            btn_agregarfoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            OleDbCommand cmd = new OleDbCommand(sql, conexion);

            cmd.Parameters.AddWithValue("Foto", aByte);
            cmd.ExecuteNonQuery();

            btn_EditarAmigo.Visible = true;
            lbl_Apellido.Text = txt_Apellido.Text;
            lbl_Nombre.Text = txt_Nom.Text;
            lbl_RelacionParentesco.Text = cmb_Relacion.SelectedItem.ToString();

            lbl_Apellido.Visible = true;
            lbl_Nombre.Visible = true;
            txt_Nom.Enabled = false;
            txt_Apellido.Enabled = false;
            dateTimePicker1.Enabled = false;
            btn_Guardar.Visible = false;
            btn_agregarfoto.Cursor = Cursors.Default;
            cmb_Relacion.Visible = false;
            cmb_Relacion.Enabled = false;
            lbl_RelacionParentesco.Visible = true;

            ModoEdit = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Familia WHERE Id = " + ArbolGenealogico.IDFamiliar + "";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            Task.Delay(1500).Wait();
            ArbolGenealogico form = new ArbolGenealogico();
            form.Show();
            this.Hide();
        }

        private void btn_agregarfoto_Paint(object sender, PaintEventArgs pe)
        {
            int borderSize = 6;
            Color borderColor = Color.CornflowerBlue;
            Color borderColor2 = Color.HotPink;
            DashStyle borderLineStyle = DashStyle.Solid;
            DashCap borderCapStyle = DashCap.Flat;
            float gradientAngle = 50F;

            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(btn_agregarfoto.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize + 3, -borderSize + 3);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(btn_agregarfoto.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);

                btn_agregarfoto.Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
