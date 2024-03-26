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
    public partial class frmProveedores : Form
    {
        Proveedor proveedor;
        ProveedorHelp _proveedorHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;

        public frmProveedores(ProveedorHelp proveedorHelp , TipoIdentificacionHelp tipoIdentificacionHelp )
        {
            _proveedorHelp = proveedorHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;


            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            _tipoIdentificacionHelp.Cmb(cmbTipoIdentificacion,_tipoIdentificacionHelp.Queryable.ToList());
            Nuevo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_proveedorHelp );
            frmBusqueda.ShowDialog();
            int id = frmBusqueda.Id;
            proveedor  = _proveedorHelp .BuscarProveedor(id);
            if (proveedor  == null)
            {
                Nuevo();
                return;
            }
            txtIdentificacion.Text = proveedor.Identificacion;
            txtNombre.Text = proveedor.Nombre;
            chkPersonaNatural.Checked = (bool)proveedor.PersonaNatural;
            txtDireccion.Text = proveedor.Direccion;
            txtTelefono.Text = proveedor.Telefono;
            txtApellido.Text = proveedor.Apellido;
            txtEmail.Text = proveedor.Email;
            cmbTipoIdentificacion.SelectedValue = proveedor.TipoIdentificacionId;
        }
        void Nuevo()
        {
            proveedor = null;
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbTipoIdentificacion.SelectedIndex = -1;
            txtIdentificacion.Focus();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (proveedor == null)
            {
                proveedor = new Proveedor
                {
                    Identificacion = txtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    PersonaNatural =chkPersonaNatural .Checked ,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    TipoIdentificacionId = cmbTipoIdentificacion.SelectedValue != null
                                           ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString())
                                           : -1
                };
                _proveedorHelp.GuardarProveedor(proveedor);
                Nuevo();
            }
            else
            {
                proveedor.Nombre = txtNombre.Text;
                proveedor.Apellido = txtApellido.Text;
                proveedor.Direccion = txtDireccion.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Email = txtEmail.Text;
                proveedor.PersonaNatural = chkPersonaNatural.Checked;
                proveedor.TipoIdentificacionId = int.Parse(cmbTipoIdentificacion.SelectedValue.ToString());
                _proveedorHelp.ActualizarProveedor(proveedor.Id, proveedor);
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
