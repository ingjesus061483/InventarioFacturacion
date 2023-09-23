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
    public partial class frmCliente : Form
    {
        Cliente cliente;
        ClienteHelp _clienteHelp;
        TipoIdentificacionHelp _TipoIdentificacionHelp;
        public frmCliente(ClienteHelp clienteHelp,
                          TipoIdentificacionHelp tipoIdentificacionHelp)
        {
            _clienteHelp = clienteHelp;
            _TipoIdentificacionHelp = tipoIdentificacionHelp;
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            _TipoIdentificacionHelp.Cmb(cmbTipoIdentifcacion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var dt = _clienteHelp.Table ;
            frmBusqueda frmBusqueda = new frmBusqueda(dt);
            frmBusqueda.ShowDialog();
            int id = frmBusqueda.Id;
            cliente = _clienteHelp.BuscarCliente(id);
            if (cliente == null)
            {
                Nuevo();
                return;
            }
            txtIdentificacion.Text = cliente.Identificacion;
            txtNombre.Text = cliente.Nombre;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono;
            txtApellido.Text = cliente.Apellido;
            txtEmail.Text = cliente.Email;
            chkPersonaNatural.Checked =(bool) cliente.PersonaNatural;
            dtpfechaNacimiento.Value = (DateTime)cliente.FechaNacimiento;
            cmbTipoIdentifcacion.SelectedValue = cliente.TipoIdentificacionId;
        }
        void Nuevo()
        {
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbTipoIdentifcacion.SelectedIndex = -1;
            txtIdentificacion.Focus();
            cliente = null;




        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
        
            if (cliente == null)
            {
                cliente = new Cliente
                {
                    Identificacion = txtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpfechaNacimiento.Value ,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    TipoIdentificacionId = cmbTipoIdentifcacion.SelectedValue!=null
                                           ?int.Parse(cmbTipoIdentifcacion.SelectedValue.ToString())
                                           :-1,
                    PersonaNatural=chkPersonaNatural .Checked 

                };
                _clienteHelp.GuardarCliente(cliente);               
                Nuevo();
            }
            else
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;
                cliente.PersonaNatural = chkPersonaNatural.Checked;
                cliente.FechaNacimiento = dtpfechaNacimiento.Value;
                cliente.TipoIdentificacionId = int.Parse(cmbTipoIdentifcacion.SelectedValue.ToString());
                _clienteHelp.ActualizarCliente(cliente.Id, cliente);               
            }
       

          
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpfechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            int edad = (DateTime.Now - dateTimePicker.Value).Days / 365;
            txtEdad.Text = edad.ToString() + " años ";
        }
    }
}
