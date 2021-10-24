﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Contraseña
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!FormPantallaLogIn.ModoAdmin) {
                btn_Config.Visible = false;
                btn_CrearPaciente.Visible = false;
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Show();
            
        }
    }
}
