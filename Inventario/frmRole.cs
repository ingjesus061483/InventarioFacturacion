using DataAccess;
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
    public partial class frmRole : Form
    {
       RoleHelp _context;
        Role role;
        string message = "";
        public frmRole(RoleHelp  context)
        {
            _context = context;
            InitializeComponent();
        }
        void Nuevo()
        {
            role = null;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Focus();
        }
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_context);
            frmBusqueda.ShowDialog();
            int id = frmBusqueda.Id;
            role = _context.BuscarRole(id);
            if (role == null)
            {
                Nuevo();
                return;
            }
            txtNombre.Text = role.Nombre;
            txtDescripcion.Text = role.Descripcion;
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Este campo no puede ser vacio", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (role == null)
            {
                role = new Role
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };
                _context.GuardarRole(role);
                message = "la categoria ha sido guardada";

            }
            else
            {
                role.Nombre = txtNombre.Text;
                role.Descripcion = txtDescripcion.Text;
                _context.ActualizarRole(role.Id, role);
                message = "la categoria ha sido editada";


            }
            MessageBox.Show(message, "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            Nuevo();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (role == null)
            {
                MessageBox.Show("Debe seleccionar una categoria", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var resp = MessageBox.Show("Desea elminar esta categoria", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                _context.EliminarRole (role.Id );                
                MessageBox.Show("La categoria fue eliminada", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Nuevo();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
