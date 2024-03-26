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
    public partial class frmFactura : Form
    {
        int formapago;
        int tipodocumento;
        Cliente cliente;       
        Usuario usuario;
        Producto producto;
        decimal recibido;     
        FacturaEncabezado Factura { get; set; }
        TipoDocumentoHelp _TipoDocumentoHelp;
        FormaPagoHelp _FormaPagoHelp;
        UsuarioHelp _usuarioHelp;
        ClienteHelp _clienteHelp;
        EmpleadoHelp _empleadoHelp;
        ProductoHelp _productoHelp;
        ImpuestoHelp _impuestoHelp;
        FacturaHelp _facturaHelp;        
        TipoIdentificacionHelp _tipoIdentificacionHelp;
        public frmFactura(TipoDocumentoHelp tipoDocumentoHelp,
                          FormaPagoHelp formaPagoHelp,
                          UsuarioHelp usuarioHelp,
                          ClienteHelp clienteHelp,
                          TipoIdentificacionHelp tipoIdentificacionHelp,                          
                          EmpleadoHelp empleadoHelp,
                          ProductoHelp productoHelp,
                          ImpuestoHelp impuestoHelp,
                          FacturaHelp facturaHelp,FacturaEncabezado factura )
        {
            _FormaPagoHelp = formaPagoHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            _clienteHelp = clienteHelp;
            _empleadoHelp = empleadoHelp;
            _usuarioHelp = usuarioHelp;
            _TipoDocumentoHelp = tipoDocumentoHelp;
            _productoHelp = productoHelp;
            _impuestoHelp = impuestoHelp;
            _facturaHelp = facturaHelp;
            Factura = factura;
            InitializeComponent();
            busquedaCliente1.MostrarEvent += BusquedaCliente1_MostrarEvent;
            BusquedaEmpleado.MostrarEvent += BusquedaEmpleado_MostrarEvent;
            busquedaProducto.MostrarEvent += BuquedaProducto1_MostrarEvent;
        }
        void GetRecibido( decimal cambio, TextBox cajaTexto)
        {
            if (cambio < 0)
            {
               cajaTexto .ForeColor = Color.Red;
            }
            else
            {
                cajaTexto .ForeColor = Color.Green;
            }
            cajaTexto.Text = cambio.ToString();
        }
        decimal GetImpuesto(List<Impuesto> impuestos,Empresa  empresa)
        {
            decimal impuesto = 0;
            if (empresa.TipoRegimenId == 2)
            {
                Factura.Empresa = empresa;
                Factura.Impuestos = impuestos;
                impuesto = Factura.Impuesto;
            }
            return impuesto;
        }
        void Cargar()
        {
            txtCodigo.Text = Factura.Codigo;
            busquedaCliente1.Subir(Factura.Cliente.Identificacion, Factura.Cliente.NombreCompleto, false);
            busquedaProducto.Disable();
            dtpfecha.Value = Factura .Fecha;

            BusquedaEmpleado.Subir(Factura.Usuario.Empleados[0].Identificacion, Factura.Usuario.Empleados[0].Nombre, false);
            cmbFormapago.SelectedValue = Factura.FormapagoId;
            cmbTipoDocumento.SelectedValue = Factura.TipoDocumentoId;
            txtsubtotal.Text = Factura.Subtotal.ToString();
            txtiva.Text = Factura.Impuesto.ToString();
            txtDescuento.Text = Factura.Descuento.ToString();
            txttotalpagar.Text = Factura.TotalPagar.ToString();
            txtRecibido.Text = Factura.Recibido.ToString();
            btnAñadir.Enabled = false;
            btnQuitar.Enabled = false;
            btninsertar.Enabled = false;
            cbodescuento.Enabled = false;
        }
        void Nuevo()
        {
            usuario = _usuarioHelp.Login;
            Factura = new FacturaEncabezado();
            if (usuario != null)
            {
                BusquedaEmpleado.Subir(usuario.Empleados[0].Identificacion, usuario.Empleados[0].Nombre);
                Factura.UsuarioId = usuario.Id;
            }
            Factura.Codigo = DateTime.Now.ToOADate().ToString();
            txtCodigo.Text = Factura.Codigo;
            Factura.Detalles = new List<FacturaDetalle>();
        }
        private void BusquedaEmpleado_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            var empleado =busquedaCliente .Empleado;
            if (empleado == null)
            {
                Factura.UsuarioId = 0;
                usuario = null;
                return;
            }
            usuario = empleado.Usuario;
            Factura.UsuarioId = usuario.Id;
        }
        private void BusquedaCliente1_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            cliente = busquedaCliente.Cliente;
            if (cliente == null)
            {
                frmCliente frmCliente = new frmCliente(_clienteHelp, _tipoIdentificacionHelp);
                frmCliente.ShowDialog();                                
                return;
            }            
            Factura.ClienteId = cliente .Id;
        }

        private void BuquedaProducto1_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaProducto = (BusquedaCliente)sender;
            producto = busquedaProducto.Producto;
            if (producto == null)
            {
                txtvalorunit.Text = string .Empty ;
                txtexistencia.Text = string .Empty ;
                return;
            }
            txtvalorunit.Text = producto .Precio.ToString () ;
            txtexistencia.Text = producto .TotalExistencia .ToString ()  ;
            txtcantidad.Focus();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {        
            if (Factura == null)
            {
                Nuevo();
                _TipoDocumentoHelp.Cmb(cmbTipoDocumento,_TipoDocumentoHelp.Queryable .ToList ());
                _FormaPagoHelp.Cmb(cmbFormapago,_FormaPagoHelp.Queryable .ToList());   
            }
            else
            {
                _TipoDocumentoHelp.Cmb(cmbTipoDocumento,_TipoDocumentoHelp.Queryable.ToList());
                _FormaPagoHelp.Cmb(cmbFormapago,_FormaPagoHelp.Queryable .ToList());
                Cargar();
            }
            Detalles.MostrarDatos(Factura.Detalles);
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                return;
            }
            decimal.TryParse(txtcantidad.Text, out decimal cantidad);
            Factura.AñadirDetalles(producto, cantidad);
            decimal subtotal = Factura.Subtotal;
            txtsubtotal.Text = subtotal.ToString();
            txtiva.Text = GetImpuesto(_impuestoHelp.Queryable.ToList(), usuario.Empresa).ToString();
            decimal totalPagar = Factura.TotalPagar;
            txttotalpagar.Text = totalPagar.ToString();
            txtvalorunit.Text = string.Empty;
            txtexistencia.Text = string.Empty;
            busquedaProducto.Subir ("","");
            txtRecibido.Focus();
            producto = null;
            Detalles.MostrarDatos(Factura.Detalles);
        }
       
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Factura.EliminarDetalles();            
            decimal subtotal = Factura.Subtotal;
            txtsubtotal.Text = subtotal.ToString();
            txtiva.Text = GetImpuesto(_impuestoHelp.Queryable.ToList(), usuario.Empresa).ToString();
            decimal totalPagar = Factura.TotalPagar;
            txttotalpagar.Text = totalPagar.ToString();
            Detalles.MostrarDatos(Factura.Detalles);
        }
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==Convert.ToChar(Keys.Enter ))
            {
                btnAñadir.PerformClick();
            }
        }
        private void cbodescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            decimal.TryParse(comboBox .Text, out decimal descuento);
            Factura.Descuento = (Factura.Subtotal * descuento) / 100;
            decimal totalpagar = Factura.TotalPagar;
            txttotalpagar.Text =totalpagar  .ToString();
            txtDescuento.Text = Factura.Descuento.ToString();
            txtRecibido.Focus();
            decimal.TryParse(txtRecibido.Text, out recibido);
            Factura.Recibido = recibido;
            decimal cambio = Factura.Cambio;
            GetRecibido(cambio  , txtCambio );
        }
        
        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            decimal.TryParse(textBox .Text, out recibido);
            Factura.Recibido = recibido;
            decimal cambio = Factura.Cambio;
            GetRecibido(cambio  , txtCambio );
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Factura.FormapagoId = formapago;
            Factura.TipoDocumentoId = tipodocumento;
            Factura.Fecha = dtpfecha.Value;
            _facturaHelp.GuardarFactura(Factura);
            this.Close();
        }
        private void cmbFormapago_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse (  cmbFormapago.SelectedValue!=null? cmbFormapago.SelectedValue.ToString ():"",out formapago) ;
            switch (formapago)
            {
                case 1:
                    {
                        Factura.EstadoId = 1;
                        break;
                    }
                case 2:
                    {
                        Factura.EstadoId = 2;
                        break;
                    }                
            }
        }

        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbTipoDocumento .SelectedValue != null ? 
                cmbTipoDocumento .SelectedValue.ToString() : "",out  tipodocumento);
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
        private void busquedaCliente1_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.clienteHelp = _clienteHelp;
            busquedaCliente.TextoBoton = "Clientes";
            busquedaCliente.LoadEvent();
        }

        private void BusquedaEmpleado_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.empleadoHelp = _empleadoHelp;
            busquedaCliente.TextoBoton = "Empleados";
            busquedaCliente.LoadEvent();
        }

        private void busquedaProducto_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.productoHelp  = _productoHelp ;
            busquedaCliente.TextoBoton = "Productos";
            busquedaCliente.LoadEvent();
        }

        private void detalles1_Load(object sender, EventArgs e)
        {
            Detalles detalles = (Detalles)sender;
            detalles.facturaHelp = _facturaHelp;  
        }

 
    }
}
