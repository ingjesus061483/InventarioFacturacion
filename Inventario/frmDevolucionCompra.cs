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
    public partial class frmDevolucionCompra : Form
    {
        public OrdenCompra Compra { get; set; }
        MotivoHelp _motivoHelp;
        Motivo Motivo;
        DevolucionCompraHelp _devolucionCompraHelp;
        CompraHelp _compraHelp;
        public frmDevolucionCompra(DevolucionCompraHelp devoluvionCompraHelp, MotivoHelp motivoHelp,CompraHelp compraHelp)
        {
            _devolucionCompraHelp = devoluvionCompraHelp;
            _compraHelp = compraHelp;
            _motivoHelp = motivoHelp;
            InitializeComponent();
            busquedaMotivo.MostrarEvent += BusquedaMotivo_MostrarEvent;

        }
        private void BusquedaMotivo_MostrarEvent(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            var motivo = busquedaCliente.Motivo;
            if (motivo == null)
            {
                return;
            }
            Motivo = motivo;
        }
        private void busquedaMotivo_Load(object sender, EventArgs e)
        {
            BusquedaCliente busquedaCliente = (BusquedaCliente)sender;
            busquedaCliente.MotivoHelp = _motivoHelp;
            busquedaCliente.TextoBoton = "Motivo";
            busquedaCliente.LoadEvent();
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            List<OrdenCompraDetalle> detalles = Compra.Detalles;
            foreach (OrdenCompraDetalle  detalle in detalles)
            {
                DevolucionCompra devolucionCompra = new DevolucionCompra
                {
                    Proveedor = Compra.Proveedor,
                    ProveedorId =Compra .Proveedor .Id,
                    Codigo = Compra .Codigo,
                    Producto = detalle.Producto ,
                    Fecha = DateTime.Now,
                    ProductoId = detalle.ProductoId,
                    Motivo = Motivo,
                    MotivoId = Motivo.Id
                };
                _devolucionCompraHelp .GuardarDevolucion(devolucionCompra );
            }
           _compraHelp .AnularCompra(Compra .Id , detalles);
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDevolucionCompra_Load(object sender, EventArgs e)
        {
            dgDetalle.DataSource = Compra.Detalles;
            txtCodigoFactura.Text = Compra.Codigo;
            switch(Compra.EstadoId)
            {
                case 3:
                    {
                        MessageBox.Show("la compra no ha sido recibida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        break;

                    }
                case 4:
                    {
                        MessageBox.Show("la compra ya fue anulada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        break;

                    }

            }

        }
    }
}
