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
    public partial class frmEmpleado : Form
    {
        EmpleadoDTO empleado;
        int id;
        EmpleadoHelp _empleadoHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;
        UsuarioHelp _usuarioHelp;
        EmpresaHelp _empresaHelp;
        RoleHelp _roleHelp;
        public frmEmpleado(EmpleadoHelp empleadoHelp,                           
                           TipoIdentificacionHelp tipoIdentificacionHelp ,
                           UsuarioHelp usuarioHelp,
                           EmpresaHelp empresaHelp,
                           RoleHelp roleHelp )



        {
            _roleHelp = roleHelp;
            _empresaHelp = empresaHelp;
            _usuarioHelp = usuarioHelp;
            _empleadoHelp = empleadoHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
           Utilities .Cmb(cmbTipoIdentificacion,_tipoIdentificacionHelp.Queryable.ToList() );
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_empleadoHelp);
            frmBusqueda.ShowDialog();
            id = frmBusqueda.Id;
            empleado = _empleadoHelp.Queryable.Where(x => x.Id == id).FirstOrDefault();
            if(empleado ==null)
            {
                Nuevo();
                return;
            }
            Txtnombre.Text = empleado.Nombre;
            txtapellido.Text = empleado.Apellido;
            txtdireccion.Text = empleado.Direccion;
            Txttelefono.Text = empleado.Telefono;
            dtpfechaNacimiento.Value =(DateTime ) empleado.FechaNacimiento;
           
            cmbTipoIdentificacion.SelectedValue = empleado.TipoIdentificacionId;
            txtcodigo.Text = empleado.Identificacion;
            txtemail.Text = empleado.Usuario.Email;
            txtUsuario.Text = empleado .Usuario .Name;
            txtRole.Text = empleado.Usuario.Role.Nombre;



                
        }
        void Nuevo()
        {
            id = 0;
            empleado = null;
            txtcodigo.Text = string.Empty;
            Txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            Txttelefono.Text = string.Empty;
            cmbTipoIdentificacion.SelectedIndex = -1;
            txtcodigo.Focus();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if( id ==0)
            {
                frmUsuario frmUsuario = new frmUsuario(_usuarioHelp ,_empresaHelp ,_roleHelp  );
                frmUsuario.ShowDialog();
                empleado = new EmpleadoDTO
                {
                    Identificacion = txtcodigo.Text,
                    Nombre = Txtnombre.Text,
                    Apellido = txtapellido.Text,
                    FechaNacimiento = dtpfechaNacimiento.Value ,
                    PersonaNatural =true,
                    Direccion = txtdireccion.Text,
                    Telefono = Txttelefono.Text,
                    TipoIdentificacionId = cmbTipoIdentificacion.SelectedValue != null ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString()) : -1,
                    UsuarioId = frmUsuario.Usuario != null ? frmUsuario.Usuario.Id : -1


                };
                _empleadoHelp.Guardar(empleado);
                Nuevo();

            }
            else
            {
                empleado.Nombre = Txtnombre.Text;
                empleado.FechaNacimiento = dtpfechaNacimiento.Value;
                empleado.Apellido = txtapellido.Text;
                empleado.Telefono = Txttelefono.Text;
                empleado.Direccion = txtdireccion.Text;
                empleado.TipoIdentificacionId = cmbTipoIdentificacion.SelectedValue != null ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString()) : -1;
                _empleadoHelp.Actualizar(id, empleado);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            int edad = (DateTime.Now - dateTimePicker .Value).Days / 365;
            txtEdad.Text = edad.ToString()+" años ";
        }
    }
}
