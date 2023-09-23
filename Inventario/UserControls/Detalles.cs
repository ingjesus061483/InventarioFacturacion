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
    public partial class Detalles : UserControl
    {
        public FacturaHelp facturaHelp { get; set; }
        public CompraHelp compraHelp { get; set; }
        public DevolucionVentaHelp DevolucionVentaHelp { get; set; }
        string[,] _facturadetalle ={
                                        {"Id","false" },{ "FacturaId","false" },
                                        { "FacturaEncabezado","false" },{ "ProductoId","false" },
                                        {"Producto","false" },{ "Cantidad","true"},
                                        { "NombreProducto","true" },{ "ValorUnitario", "true" },
                                        { "Total","true" }
                                   };
        string[,] _compradetalle ={
                                        {"Id","false" },{ "OrdenCompraId","false" },
                                        { "OrdenCompra","false" },{ "ProductoId","false" },
                                        {"Producto","false" },{ "Cantidad","true"},
                                        { "NombreProducto","true" },{ "ValorUnitario", "true" },
                                        { "Total","true" }
                                   };
        string[,] _devolucion = {
            { "Id","false"},{"ClienteId","false" },
            {"Cliente","false"},{"Codigo","true" },
            {"Fecha","true" },
            {"ProductoId" ,"false" },{"Producto","false" },
            {"MotivoId","false" },{"Motivo","false" },
            { "NombreProducto" ,"true"},{"DescripcionMotivo","true"},
            { "ClienteNombre","true" }

        };
        public Detalles()
        {
            InitializeComponent();
            
        }
        public void MostrarDatos(object datasource)
        {
            if (facturaHelp != null)
            {
                facturaHelp.GetDatagrid(dgDetalles, _facturadetalle);
            }
            else if(compraHelp!=null)
            {
                compraHelp .GetDatagrid(dgDetalles, _compradetalle );
            }
            else if(DevolucionVentaHelp !=null)
            {
                DevolucionVentaHelp .GetDatagrid(dgDetalles, _devolucion);
            }
            dgDetalles.DataSource = datasource ;
        }
        private void Detalles_Load(object sender, EventArgs e)
        {
        }
    }
}
