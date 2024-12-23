﻿using Helper;
using System;
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
                Utilities .GetDatagrid(dgDetalles, _facturadetalle);
            }
            else if(compraHelp!=null)
            {
                Utilities  .GetDatagrid(dgDetalles, _compradetalle );
            }
            else if(DevolucionVentaHelp !=null)
            {
                Utilities  .GetDatagrid(dgDetalles, _devolucion);
            }
            dgDetalles.DataSource = datasource ;
        }
        private void Detalles_Load(object sender, EventArgs e)
        {
        }
    }
}
