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
            Usuario=_usuarioHelp.Queryable.Where (x=>x.Name == txtUsuario.Text&& x.Password == pwd).FirstOrDefault ();
            if( Usuario ==null)
            {
           Utilities  .GetDialogResult("Usuario o contraseña invalida","",MessageBoxButtons.OK ,MessageBoxIcon.Warning );
                txtUsuario.Focus();
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;
            this.Close();            
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==Convert .ToChar(Keys.Enter))
            {
                btnLogin.PerformClick();
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
