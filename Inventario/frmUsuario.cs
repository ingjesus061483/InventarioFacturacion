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
    public partial class frmUsuario : Form
    {

        UsuarioHelp _usuarioHelp;
        EmpresaHelp _empresaHelp;
        RoleHelp _roleHelp;
        Empresa empresa;
        public UsuarioDTO Usuario { get; set; }
        public frmUsuario(UsuarioHelp usuarioHelp ,
                          EmpresaHelp empresaHelp,
                          RoleHelp roleHelp  )
        {
            _roleHelp = roleHelp;
            _usuarioHelp = usuarioHelp;
            _empresaHelp = empresaHelp;
            InitializeComponent();
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_empresaHelp);
            frmBusqueda.ShowDialog();
            empresa = _empresaHelp.BuscarEmpresa(frmBusqueda.Id);
            if( empresa == null) 
            {
                return;
            }
            txtNit.Text = empresa.Nit;
            txtNombre.Text = empresa.Nombre;
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Utilities .Cmb(cmbRole,_roleHelp.Queryable .ToList());
            if (Usuario !=null)
            {
                Cargar();
            }            
        }
        void Cargar()
        {
            txtUsuario.Text = Usuario.Name;
            txtEmail.Text = Usuario.Email;
            txtNit.Text = Usuario.Empresa.Nit;
            cmbRole.SelectedValue = Usuario.RoleId;
            btnProducto.Enabled = false;
            cmbRole.Enabled = false;
            txtNombre.Enabled = false;
            txtNit.Enabled = false;
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            empresa = _empresaHelp.BuscarEmpresa(txtNit.Text);
            if (empresa != null)
            {
                txtNit.Text = empresa.Nit;
                txtNombre .Text = empresa.Nombre;
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmarPassword.Text)
            {
                MessageBox.Show("Las contraseñas no son iguales", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Usuario == null)
            {
                Usuario = new UsuarioDTO
                {
                    Name = txtUsuario.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    RoleId = cmbRole.SelectedValue != null ? int.Parse(cmbRole.SelectedValue.ToString()) : -1,
                    EmpresaId =empresa!=null? empresa.Id:-1
                };
                _usuarioHelp.Guardar(Usuario);
                Usuario = _usuarioHelp.Queryable.Where (x=>x.Name .Contains ( Usuario.Name)).FirstOrDefault();                
            }
            else
            {
                Usuario.Name = txtUsuario.Text;
                Usuario.Email = txtEmail.Text;
                Usuario.Password = txtPassword.Text;
                Usuario.RoleId = cmbRole.SelectedValue != null ? int.Parse(cmbRole.SelectedValue.ToString()) : -1;
                Usuario.EmpresaId = empresa != null ? empresa.Id : -1;
                _usuarioHelp.Actualizar(Usuario.Id, Usuario);
            }
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
