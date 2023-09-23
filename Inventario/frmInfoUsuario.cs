using Helper;
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
    public partial class frmInfoUsuario : Form
    {
        UsuarioHelp _usuarioHelp;
        EmpresaHelp _empresaHelp;
        RoleHelp _roleHelp;
        public Usuario Usuario { get; set; }
        public frmInfoUsuario(UsuarioHelp usuarioHelp,
                          EmpresaHelp empresaHelp,
                          RoleHelp roleHelp)
        {
            _usuarioHelp = usuarioHelp;
            _empresaHelp = empresaHelp;
            _roleHelp = roleHelp;
            InitializeComponent();
        }

        private void frmInfoUsuario_Load(object sender, EventArgs e)
        {
            Empleado empleado = Usuario.Empleados[0];
            txtIdentificacion.Text = empleado.Identificacion;
            txtNombre.Text = empleado.NombreCompleto;
            txtDireccion.Text = empleado.Direccion;
            txtTelefono.Text = empleado.Telefono;
            txtEmail.Text = Usuario.Email;
            txtUsuario.Text = Usuario.Name;
            txtCargo.Text = Usuario.Role.Nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario(_usuarioHelp, _empresaHelp, _roleHelp);
            frmUsuario.Usuario = Usuario;
            frmUsuario.ShowDialog();
            if (MessageBox.Show("Desea salir de la sesion", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void bttncerrarSesion_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Desea salir de la sesion", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes )
            {
                Application.Restart();
            }


        }
    }
}
