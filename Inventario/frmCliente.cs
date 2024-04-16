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
    public partial class frmCliente : Form
    {
        int id;
        ClienteHelp _clienteHelp;
        ClienteDTO Cliente;
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
            Utilities .Cmb(cmbTipoIdentifcacion, _TipoIdentificacionHelp.Queryable .ToList()) ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_clienteHelp );
            frmBusqueda.ShowDialog();
             id = frmBusqueda.Id;
            Cliente  = _clienteHelp.Queryable .Where(x=>x.Id == id).FirstOrDefault ();
            if ( Cliente == null)
            {
                Nuevo();
                return;
            }
            txtIdentificacion.Text =  Cliente.Identificacion;
            txtNombre.Text =  Cliente.Nombre;
            txtDireccion.Text = Cliente .Direccion;
            txtTelefono.Text =  Cliente .Telefono;
            txtApellido.Text = Cliente .Apellido;
            txtEmail.Text =  Cliente .Email;
            chkPersonaNatural.Checked =(bool) Cliente .PersonaNatural;
            dtpfechaNacimiento.Value = (DateTime) Cliente .FechaNacimiento;
            cmbTipoIdentifcacion.SelectedValue =  Cliente .TipoIdentificacionId;
        }
        void Nuevo()
        {
            id = 0;
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbTipoIdentifcacion.SelectedIndex = -1;
            txtIdentificacion.Focus();
             Cliente  = null;




        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
                
        
            if ( id  == 0)
            {
                Cliente = new ClienteDTO
                {
                    Identificacion = txtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpfechaNacimiento.Value,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,

                    TipoIdentificacionId = cmbTipoIdentifcacion.SelectedValue != null
                                                 ? int.Parse(cmbTipoIdentifcacion.SelectedValue.ToString())
                                                 : -1,
                    PersonaNatural = chkPersonaNatural.Checked
                };
                _clienteHelp.Guardar(Cliente  );               
                
            }
            else
            {
                
                _clienteHelp.Actualizar(id,Cliente  );               
            }
            Nuevo();



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
