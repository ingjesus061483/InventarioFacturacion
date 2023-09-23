using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public class CompraHelp : Help
    {

        ExistenciaHelp _existenciaHelp;
        public CompraHelp (InventarioDbContext context ,  ExistenciaHelp existenciaHelp )
        {
            _context = context;
            _existenciaHelp = existenciaHelp;
            
        }
        IQueryable Queryable
        {
            get
            {
                return  (from compra in _context.OrdenCompras
                                    join prov in _context.Proveedors on compra.ProveedorId equals prov.Id join usu in _context.Usuarios on compra.UsuarioId
                                    equals usu.Id join formapago in _context.FormaPagos on compra.FormapagoId equals formapago.Id into fp from subformaPago in 
                                    fp.DefaultIfEmpty() join tipodoc in _context.TipoDocumentos on compra.TipoDocumentoId equals tipodoc.Id join est in 
                                    _context.Estados on compra.EstadoId equals est.Id
                                    select new
                                    {
                                        compra.Id,
                                        compra.Codigo,
                                        compra.Fecha,
                                        compra.FechaEntrega,
                                        compra.Observaciones,
                                        compra.Usuario,
                                        compra.UsuarioId,
                                        compra.ProveedorId,
                                        compra.Proveedor,
                                        compra.TipoDocumento,
                                        compra.TipoDocumentoId,
                                       formapago=subformaPago !=null? subformaPago  :null ,
                                        compra.FormapagoId,
                                        subtotal = _context.OrdenCompraDetalles.
                                                                                Where(x => x.OrdenCompraId == compra.Id).
                                                                                Select(x => new {subtotal =x.Cantidad *x.ValorUnitario }).
                                                                                Sum (x=>x.subtotal ),    
                                        impuesto=(bool)compra . Proveedor .PersonaNatural ?0: _context .Impuestos .
                                                                                    Select(x=>new {impuesto=_context.OrdenCompraDetalles.
                                                                                    Where(c => c.OrdenCompraId == compra.Id).
                                                                                    Select(z =>new{ subtotal = z.Cantidad *
                                                                                    z.ValorUnitario}).
                                                                                    Sum(z => z.subtotal)*x.Valor/100 }).
                                                                                    Sum(y=>y.impuesto ),
                                       compra.Descuento,
                                       TotalPagar= _context.OrdenCompraDetalles.
                                                            Where(x => x.OrdenCompraId == compra.Id).
                                                            Select(x => new { subtotal = x.Cantidad * x.ValorUnitario }).
                                                            Sum(x => x.subtotal)
                                                            +
                                                            ((bool)compra.Proveedor.PersonaNatural ? 0 : 
                                                                                _context.Impuestos.Select(x => new {
                                                                                                    impuesto = _context.OrdenCompraDetalles.
                                                                                                                        Where(c => c.OrdenCompraId == compra.Id).
                                                                                                                        Select(z => new {subtotal = z.Cantidad *z.ValorUnitario}).
                                                                                                                        Sum(z => z.subtotal) * x.Valor / 100 }).
                                                                                                                        Sum(y => y.impuesto)) - compra.Descuento,
                                        compra.Recibido,
                                        compra.EstadoId,
                                        compra.Estado
                                    });
            } 
        }
        public override DataTable Table 
        {
            get
            { 
                return _context.GetDataTable(Queryable.ToString ()); 
            } 
        }
        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            gridView.DataSource = null;
            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            int fila = columns.GetLength(0);
            for (int i = 0; i <= fila - 1; i++)
            {
                var DataGridViewTextBoxColumn = GetDataGridViewTextBoxColumn(columns[i, 0],
                                                                             columns[i, 0],
                                                                             columns[i, 0],
                                                                             bool.Parse(columns[i, 1]));
                dataGridViewTextBoxColumns.Add(DataGridViewTextBoxColumn);
            }

            gridView.Columns.AddRange(dataGridViewTextBoxColumns.ToArray());
        }
        bool Validar(OrdenCompra compra)
        {
            if (compra .ProveedorId  == 0)
            {
                MessageBox.Show("El campo cliente no puede ser vacio ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .UsuarioId == 0)
            {
                MessageBox.Show("El campo usuario no puede ser vacio", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .TipoDocumentoId == 0)
            {
                MessageBox.Show("El campo tipo documento no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .Detalles.Count == 0)
            {
                MessageBox.Show("No hay productos en el detalle", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .TotalPagar <= 0)
            {
                MessageBox.Show("El campo total pagar no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void guardarCompra(OrdenCompra compra )
        {
            if(!Validar (compra))
            {
                return;
            }
            _context.OrdenCompras .Add(compra );
            _context.SaveChanges();
            var compr = _context.OrdenCompras
                                            .Where(x => x.Codigo == compra .Codigo)
                                            .FirstOrDefault();
            foreach (var item in compr .Detalles)
            {
                item.OrdenCompraId  = compr .Id;
                _context.OrdenCompraDetalles .Add(item);
                _context.SaveChanges();
            }
        }
        public void RecibirMercancia (string codigo ,DateTime  fechaEntrega,string  observacion,int formapagoid, int estadoId)
        {
            OrdenCompra compra = _context.OrdenCompras.Where(x => x.Codigo == codigo)
                                                      .FirstOrDefault();
            compra.FormapagoId = formapagoid;
            compra.EstadoId = estadoId;
            compra.Observaciones = observacion;
            compra.FechaEntrega = fechaEntrega;
            _context.SaveChanges();
            foreach (OrdenCompraDetalle item in compra.Detalles )
            {
                Existencia existencia = new Existencia
                {
                    Cantidad = item.Cantidad,
                    ProductoId = item.ProductoId,
                    Concepto = "Entrada " + item.Producto.Nombre,
                    Entrada = true,
                    Fecha = DateTime.Now
                };
                _existenciaHelp.GuardarExistencias(existencia);
            }
        }
        public OrdenCompra BuscarCompra(int id)
        {
           var compra = _context.OrdenCompras.Where(x => x.Id  == id)
                                          .FirstOrDefault();
            compra.Proveedor = _context.Proveedors.Where(x => x.Id == compra.ProveedorId).FirstOrDefault();
            compra.Usuario = _context.Usuarios.Where(x => x.Id == compra.UsuarioId).FirstOrDefault();
            compra.Impuestos = (bool)compra.Proveedor.PersonaNatural ? null : _context.Impuestos.ToList();
            compra.Detalles = _context.OrdenCompraDetalles.Where(x => x.OrdenCompraId == compra.Id).ToList();

            return compra;

        }
        public OrdenCompra BuscarCompra(string  codigo)
        {
            var compra = _context.OrdenCompras.Where(x => x.Codigo  == codigo)
                                              .FirstOrDefault();
            compra.Usuario = _context.Usuarios.Where(x => x.Id == compra.UsuarioId).FirstOrDefault ();
            compra.Proveedor = _context.Proveedors.Where(x => x.Id == compra.ProveedorId).FirstOrDefault();
            compra.Impuestos =(bool)compra.Proveedor .PersonaNatural?null:  _context.Impuestos.ToList();
            compra.Detalles = _context.OrdenCompraDetalles.Where(x => x.OrdenCompraId == compra.Id).ToList();
            return compra;
        }
        public void AnularCompra(int id, List<OrdenCompraDetalle> detalles)
        {
            foreach (var item in detalles)
            {
                Existencia existencia = new Existencia
                {
                    Cantidad = item.Cantidad,
                    ProductoId = item.ProductoId,
                    Concepto = "Salida " + item.Producto.Nombre,
                    Entrada = false,
                    Fecha = DateTime.Now
                };
                _existenciaHelp.GuardarExistencias(existencia);
            }
            var compra = _context.OrdenCompras.Find(id);
            compra .EstadoId = 4;
            compra .Observaciones = "Se ha anulado la compra";
            _context.SaveChanges();
        }


    }
}
