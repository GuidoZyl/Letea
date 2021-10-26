﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Pantalla_Contraseña
{
    public partial class FormFotoAdmin : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();
        public FormFotoAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Base de Datos 4.accdb;";
            conexion.Open();
        }

  

        private void click_crearfoto(object sender, EventArgs e)
        {
            if (btn_agregarfoto.Image == null)
            {
                btn_agregarfoto.Image = pic_PerfilDefault.Image;
            }
            
            string sql = "UPDATE Admin set Foto = (@foto)";
            MemoryStream ms = new MemoryStream();
            btn_agregarfoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            OleDbCommand consulta = new OleDbCommand(sql, conexion);
            consulta.Parameters.AddWithValue("Foto", aByte);
            consulta.ExecuteNonQuery();

            FormCrearPaciente form = new FormCrearPaciente();
            form.Show();
            this.Hide();
        }

        private void pic_text_agregarfotodeperfil_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();

            BuscarImagen.Filter = "Archivos de Imagen |*.jpg;*.jpeg";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                String Direccion = BuscarImagen.FileName;

                btn_agregarfoto.ImageLocation = Direccion;

                btn_agregarfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_agregarfoto_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, 400, 400);
            btn_agregarfoto.Region = new System.Drawing.Region(grpath);
        }
    }
}
