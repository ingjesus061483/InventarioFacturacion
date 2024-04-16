using Helper;
using Helper.DTO;
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
        public UsuarioDTO Usuario { get; set; }
        public frmLogin(UsuarioHelp  usuarioHelp  )
        {
            _usuarioHelp = usuarioHelp;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string pwd = Utilities.Encriptar(txtPassword.Text);
            Usuario=_usuarioHelp.Queryable.Where (x=>x.Name .Contains ( txtUsuario.Text)&& x.Password .Contains (pwd)).FirstOrDefault ();
            if( Usuario ==null)
            {
                MessageBox.Show("Usuario o contraseña invalida","",MessageBoxButtons.OK ,MessageBoxIcon.Warning );
                this.Cursor = Cursors.Default;
                return;
            }

            this.Close();
            this.Cursor = Cursors.Default;
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
