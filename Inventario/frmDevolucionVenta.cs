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
    public partial class frmDevolucionVenta : Form
    {
        public  FacturaDTO Factura{ get; set; }        
        Motivo Motivo;
        FacturaHelp _facturaHelp;
        MotivoHelp _motivoHelp;
        DevolucionVentaHelp _devolucionVentaHelp;
        public frmDevolucionVenta(FacturaHelp facturaHelp,
                               DevolucionVentaHelp devolucionVentaHelp,
                              MotivoHelp motivoHelp)
        { 
            _facturaHelp = facturaHelp;
            _devolucionVentaHelp = devolucionVentaHelp;
            _motivoHelp = motivoHelp;
            InitializeComponent();
            busquedaMotivo.MostrarEvent += BusquedaMotivo_MostrarEvent; 
        }

        private void BusquedaMotivo_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            var motivo = busquedaCliente.Motivo ;
            if (motivo== null)
            {
                return;
            }
            Motivo =motivo;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            if (Factura == null)
            {
                return;
            }
            txtCodigoFactura.Text = Factura.Codigo;
            dgDetalle.DataSource = Factura.Detalles;         
        }
        private void busquedaCliente2_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.MotivoHelp = _motivoHelp ;
            busquedaCliente.TextoBoton = "Motivo";
            busquedaCliente.LoadEvent();
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            List <FacturaDetalle> detalles = Factura.Detalles;
            foreach (FacturaDetalle  detalle  in detalles )
            {
                DevolucionVenta devolucionVenta = new DevolucionVenta
                {
                    Cliente = Factura.Cliente,
                    ClienteId = Factura.Cliente.Id,
                    Codigo = Factura.Codigo,
                    Producto =detalle . Producto,
                    Fecha = DateTime.Now,
                    ProductoId =detalle . ProductoId,
                    Motivo = Motivo,
                    MotivoId = Motivo.Id
                };
                _devolucionVentaHelp.Guardar(devolucionVenta);
            }
            _facturaHelp.AnularFactura(Factura.Id,detalles  );
        }
    }
}
