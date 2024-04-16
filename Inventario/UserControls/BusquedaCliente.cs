using Helper;
using Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Inventario
{
    public partial class BusquedaCliente : UserControl
    {
        public string TextoBoton { get; set; }

        public Motivo Motivo { get; set; }
        public MotivoHelp MotivoHelp { get; set; }
        
        public Cliente Cliente { get; set; }
        public ClienteHelp clienteHelp { get; set; }

        public Empleado Empleado { get; set; }
        public EmpleadoHelp empleadoHelp { get; set; }

        public  Proveedor Proveedor { get; set; }
        public ProveedorHelp proveedorHelp { get; set; }

        public Producto Producto { get; set; }
        public ProductoHelp productoHelp { get; set; }


        frmBusqueda frmBusqueda ;

        public delegate void ShowEvent(object sender, EventArgs e);

        // Declare the event.
        public event ShowEvent MostrarEvent;

        public BusquedaCliente()     
        {
            InitializeComponent();
        }
        public void Subir(string identificacion, string nombre,bool enable=true)
        {
            txtNombre.Text = nombre;
            txtIdentificacion.Text = identificacion;
            button.Enabled = enable ;
        }
        public void Disable()
        {
            button .Enabled = false;
        }
        public void LoadEvent()
        {
            button.Text = TextoBoton;
            if (clienteHelp != null)
            {
                button.Click += btnCliente_Click;
                txtIdentificacion.TextChanged += txtIdentificacionCliente_TextChanged;
            }
            else if (empleadoHelp != null)
            {
                button.Click += btnEmpleado_Click;
                txtIdentificacion.TextChanged += txtIdentificacionEmpleado_TextChanged;
            }
            else if(proveedorHelp !=null)
            {
                button.Click += btnProveedor_Click;
                txtIdentificacion.TextChanged += txtIdentificacionProveedor_TextChanged;
            }
            else if (productoHelp  !=null)
            {
                button.Click += btnProducto_Click;
                txtIdentificacion.TextChanged += txtCodigoProducto_TextChanged;

            }
            else if(MotivoHelp !=null)
            {
                button.Click += btnMotivo_Click;
                txtIdentificacion.TextChanged += txtCodigoMotivo_TextChanged;
            }



        }
        private void txtCodigoMotivo_TextChanged(object sender, EventArgs e)
        {
            Motivo  = MotivoHelp .BuscarMotivos (txtIdentificacion.Text);
            if (Motivo  == null)
            {
                txtNombre.Text = string.Empty;
                return;
            }
            txtIdentificacion.Text =Motivo  .Codigo;
            txtNombre.Text = Motivo .Concepto ;
            MostrarEvent.Invoke(this, new EventArgs());
        }
        private void btnMotivo_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(MotivoHelp);
            frmBusqueda.ShowDialog();
           Motivo  = MotivoHelp.BuscarMotivos (frmBusqueda.Id);
            if (Motivo  == null)
            {
                txtIdentificacion.Text = string.Empty;
                txtNombre.Text = string.Empty;
                MostrarEvent.Invoke(this, new EventArgs());
                return;
            }
            txtIdentificacion.Text = Motivo .Codigo;
            txtNombre.Text = Motivo.Concepto;
            MostrarEvent.Invoke(this, new EventArgs());
        }    
        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(productoHelp);
            frmBusqueda.ShowDialog();
            Producto = productoHelp.BuscarProducto(frmBusqueda.Id);
            if (Producto == null)
            {
                txtIdentificacion .Text = string.Empty;
                txtNombre.Text = string.Empty;
                MostrarEvent.Invoke(this, new EventArgs());
                return;
            }
            txtIdentificacion .Text = Producto.Codigo;
            txtNombre.Text = Producto.Nombre;
            MostrarEvent.Invoke(this, new EventArgs());

        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            Producto = productoHelp.BuscarProducto(txtIdentificacion .Text);
            if (Producto == null)
            {
                txtNombre.Text = string.Empty;
                return;
            }
          txtIdentificacion . Text = Producto.Codigo;
            txtNombre.Text = Producto.Nombre;
            MostrarEvent.Invoke(this, new EventArgs());
        }


        private void btnProveedor_Click(object sender, EventArgs e)
        {

            frmBusqueda = new frmBusqueda(proveedorHelp);
            frmBusqueda.ShowDialog();
           Proveedor =proveedorHelp .BuscarProveedor (frmBusqueda.Id);
            if (Proveedor == null)
            {
                txtNombre.Text = string.Empty;
                MostrarEvent.Invoke(this, new EventArgs());
                return;
            }
            txtIdentificacion.Text = Proveedor .Identificacion;
            txtNombre.Text=Proveedor .NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());
        }
        private void txtIdentificacionProveedor_TextChanged(object sender, EventArgs e)
        {
            Proveedor  =proveedorHelp .BuscarProveedor (txtIdentificacion.Text);
            if (Proveedor  == null)
            {
                txtNombre.Text = string.Empty;
                return;
            }
            txtIdentificacion.Text = Proveedor .Identificacion;
            txtNombre.Text = Proveedor .NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmBusqueda = new frmBusqueda(clienteHelp );


            frmBusqueda.ShowDialog();
            Cliente = clienteHelp. Queryable.Where(x => x.Id == frmBusqueda.Id).AsEnumerable().Select(x => new Cliente
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                FechaNacimiento = x.FechaNacimiento,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault();

            
            if (Cliente == null)
            {                
                txtNombre.Text = string.Empty;
                MostrarEvent.Invoke(this, new EventArgs());
                return;
            }
            txtIdentificacion.Text = Cliente.Identificacion;
            txtNombre.Text = Cliente.NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());

       
        }
        private void txtIdentificacionCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente = clienteHelp.Queryable.Where  ( x=>x.Identificacion .Contains ( txtIdentificacion.Text)).AsEnumerable().Select(x => new Cliente
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                FechaNacimiento = x.FechaNacimiento,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault(); ;
            if (Cliente == null)
            {
                txtNombre.Text = string.Empty;
                return;
            }
            txtIdentificacion.Text = Cliente.Identificacion;
            txtNombre.Text = Cliente.NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());

        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmBusqueda = new frmBusqueda(empleadoHelp);
            frmBusqueda.ShowDialog();
            Empleado = empleadoHelp.BuscarEmpleado(frmBusqueda.Id);
            if (Empleado == null)
            {
                txtNombre.Text = string.Empty;
                txtIdentificacion.Text = string.Empty;
                MostrarEvent.Invoke(this, new EventArgs());
                return;
            }
            txtIdentificacion.Text = Empleado.Identificacion;
            txtNombre.Text = Empleado.NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());
        }

        private void txtIdentificacionEmpleado_TextChanged(object sender, EventArgs e)
        {
          Empleado = empleadoHelp.BuscarEmpleado(txtIdentificacion.Text);
            if (Empleado == null)
            {
                txtNombre .Text = string.Empty;
                return;
            }
            txtIdentificacion.Text = Empleado.Identificacion;
            txtNombre.Text = Empleado.NombreCompleto;
            MostrarEvent.Invoke(this, new EventArgs());
        }
    }
}
