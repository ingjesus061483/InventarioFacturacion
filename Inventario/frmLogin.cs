﻿using Helper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmLogin : Form
    {
        UsuarioHelp _usuarioHelp;
        public Usuario Login;
        public frmLogin(UsuarioHelp  usuarioHelp  )
        {
            _usuarioHelp = usuarioHelp;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Login=_usuarioHelp.login(txtUsuario.Text, txtPassword.Text);
            if( Login==null)
            {
                MessageBox.Show("Usuario o contraseña invalida","",MessageBoxButtons.OK ,MessageBoxIcon.Warning );
                return;
            }

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==Convert .ToChar(Keys.Enter))
            {
                btnLogin.PerformClick();
            }

        }
    }
}
