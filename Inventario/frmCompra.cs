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
    public partial class frmCompra : Form
    {
        public frmCompra(ProveedorHelp proveedorHelp,
                         EmpleadoHelp empleadoHelp,
                         ProductoHelp productoHelp,
                         CompraHelp compraHelp,
                         UsuarioHelp usuarioHelp,
                         TipoIdentificacionHelp tipoIdentificacionHelp,
                         FormaPagoHelp formaPagoHelp,
                         TipoDocumentoHelp tipoDocumentoHelp,
                         ImpuestoHelp impuestoHelp)
        {
            _impuestoHelp = impuestoHelp;
            _formaPagoHelp = formaPagoHelp;
            _tipoDocumentoHelp = tipoDocumentoHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            _proveedorHelp = proveedorHelp;
            _empleadoHelp = empleadoHelp;
            _productoHelp = productoHelp;
            _compraHelp = compraHelp;
            _usuarioHelp = usuarioHelp;

            InitializeComponent();
            Empleado.Load += BusquedaEmpleado_Load;
            Empleado.MostrarEvent += Empleado_MostrarEvent;
            Producto.MostrarEvent += Producto_MostrarEvent;
            Proveedorbuscar.MostrarEvent += Proveedorbuscar_MostrarEvent;
            Producto.Load += BusquedaProducto_Load;
        }

        decimal GetImpuesto(List<Impuesto> impuestos, bool PersonaNatural)
        {
            decimal impuesto = 0;
            if (!PersonaNatural)
            {
                Compra.Impuestos = impuestos;
                impuesto = Compra.Impuesto;
            }
            return impuesto;
        }
        void Nuevo()
        {
            usuario = _usuarioHelp.Usuario;
            Compra = new OrdenCompraDTO();
            if (usuario != null)
            {
                Empleado.Subir(usuario.Empleados[0].Identificacion, usuario.Empleados[0].Nombre);
                Compra.UsuarioId = usuario.Id;
            }
            Compra.Codigo = DateTime.Now.ToOADate().ToString();
            txtCodigo.Text = Compra.Codigo;
            Compra.Detalles = new List<OrdenCompraDetalle>();
        }
        private void Proveedorbuscar_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            proveedor = busquedaCliente.Proveedor;
            if (proveedor == null)
            {
                frmProveedores frmProveedores = new frmProveedores(_proveedorHelp, _tipoIdentificacionHelp);
                frmProveedores.ShowDialog();
                return;
            }
            Compra.ProveedorId = proveedor.Id;
            Compra.Proveedor = proveedor;
        }

        private void Producto_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaProducto = (BusquedaCliente)sender;
            producto = busquedaProducto.Producto;
            if (producto == null)
            {
                txtvalorunit.Text = string.Empty;
                txtexistencia.Text = string.Empty;
                return;
            }
            txtvalorunit.Text = producto.Costo .ToString();
            txtexistencia.Text = producto.TotalExistencia.ToString();
            txtcantidad.Focus();
        }

        private void Empleado_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            var empleado = busquedaCliente.Empleado;
            if (empleado == null)
            {
                Compra.UsuarioId = 0;
                usuario = null;
                return;
            }
            usuario =_usuarioHelp .Queryable .Where (x=>x.Id == empleado.Usuario.Id ).FirstOrDefault() ;
            Compra.UsuarioId = usuario.Id;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BusquedaEmpleado_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.empleadoHelp = _empleadoHelp;
            busquedaCliente.TextoBoton = "Empleados";
            busquedaCliente.LoadEvent();
        }

        private void BusquedaProducto_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.productoHelp = _productoHelp;
            busquedaCliente.TextoBoton = "Productos";
            busquedaCliente.LoadEvent();
        }

        private void detalles1_Load(object sender, EventArgs e)
        {
            Detalles detalles = (Detalles)sender;
            detalles.compraHelp = _compraHelp;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

            Utilities .Cmb(cmbTipoDocumento,_tipoDocumentoHelp .Queryable.ToList ());
            if (Compra == null)
            {
                Nuevo();
            }
            else
            {
                Cargar();
            }
            Detalles.MostrarDatos(Compra .Detalles);

        }
        void Cargar()
        {
            txtCodigo.Text = Compra.Codigo;
        Proveedorbuscar .Subir(Compra.Proveedor .Identificacion, Compra .Proveedor .NombreCompleto, false);
            Producto.Disable();
            dtpfecha.Value = Compra.Fecha;
            dtpFechaEntrega.Value = Compra.FechaEntrega;
            Empleado.Subir(Compra .Usuario.Empleados[0].Identificacion, Compra.Usuario.Empleados[0].Nombre, false);
            cmbTipoDocumento.SelectedValue = Compra .TipoDocumentoId;
            txtsubtotal.Text = Compra  .Subtotal.ToString();
            txtiva.Text = Compra .Impuesto.ToString();            
            txttotalpagar.Text = Compra .TotalPagar.ToString();            
            btnAñadir.Enabled = false;
            btnQuitar.Enabled = false;
            btninsertar.Enabled = false;
        }
        private void Proveedor_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.proveedorHelp = _proveedorHelp;
            busquedaCliente.TextoBoton = "Proveedor";
            busquedaCliente.LoadEvent();

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (producto == null|| proveedor ==null)
            {
                return;
            }
            decimal.TryParse(txtcantidad.Text, out decimal cantidad);
            Compra.AñadirDetalles(producto, cantidad);
            decimal subtotal = Compra.Subtotal;
            txtsubtotal.Text = subtotal.ToString();
            txtiva.Text = GetImpuesto(_impuestoHelp.Queryable.ToList(), (bool)proveedor.PersonaNatural).ToString();
            decimal totalPagar = Compra.TotalPagar;
            txttotalpagar.Text = totalPagar.ToString();
            txtvalorunit.Text = string.Empty;
            txtexistencia.Text = string.Empty;
            Producto.Subir("", "");
            producto = null;
            Detalles.MostrarDatos(Compra.Detalles);
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            Detalles detalles = (Detalles)sender;
            detalles.compraHelp = _compraHelp ;

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Compra.EliminarDetalles();
            decimal subtotal = Compra .Subtotal;
            txtsubtotal.Text = subtotal.ToString();
            txtiva.Text = GetImpuesto(_impuestoHelp.Queryable.ToList(), (bool)proveedor.PersonaNatural ).ToString();
            decimal totalPagar = Compra .TotalPagar;
            txttotalpagar.Text = totalPagar.ToString();
            Detalles.MostrarDatos(Compra .Detalles);
        }
        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbTipoDocumento.SelectedValue != null ?
                    cmbTipoDocumento.SelectedValue.ToString() : "", out tipodocumento);          
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            Compra.EstadoId = 3;
            Compra.TipoDocumentoId = tipodocumento;
            Compra.Fecha = dtpfecha.Value ;
            Compra.FechaEntrega = dtpFechaEntrega.Value;
            _compraHelp.Guardar(Compra);
            if(Compra.Fecha == Compra.FechaEntrega)
            {

                frmRecibir frmRecibir = new frmRecibir(_compraHelp, _formaPagoHelp);
                frmRecibir.Compra = Compra;
                frmRecibir.ShowDialog();

            }
            this.Close();

        }

    }
}
