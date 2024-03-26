using DataAccess;
using Helper.DTO;
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
        public IQueryable<OrdenCompraDTO> Queryable
        {
            get
            {
                return (from compra in _context.OrdenCompras
                        join prov in _context.Proveedors on compra.ProveedorId equals prov.Id
                        join usu in _context.Usuarios on compra.UsuarioId equals usu.Id
                        join formapago in _context.FormaPagos on compra.FormapagoId equals formapago.Id into fp
                        from subformaPago in fp.DefaultIfEmpty()
                        join tipodoc in _context.TipoDocumentos on compra.TipoDocumentoId equals tipodoc.Id
                        join est in _context.Estados on compra.EstadoId equals est.Id
                        select new OrdenCompraDTO
                        {
                            Id = compra.Id,
                            Codigo = compra.Codigo,
                            Fecha = compra.Fecha,
                            FechaEntrega = compra.FechaEntrega,
                            Observaciones = compra.Observaciones,
                            Usuario = compra.Usuario,
                            UsuarioId = compra.UsuarioId,
                            ProveedorId = compra.ProveedorId,
                            Proveedor = compra.Proveedor,
                            TipoDocumento = compra.TipoDocumento,
                            TipoDocumentoId = compra.TipoDocumentoId,
                            FormaPago = subformaPago,
                            FormapagoId = compra.FormapagoId,
                            Detalles= _context.OrdenCompraDetalles.Where(x => x.OrdenCompraId == compra.Id)
                                                                  .ToList(),
                            Impuestos =_context.Impuestos
                                               .ToList (),
                            Descuento= compra.Descuento,
                            Recibido =  compra.Recibido,                            
                            EstadoId = compra.EstadoId,
                            Estado = compra.Estado
                        });
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
        public void  ActualizarCompra(string codigo,OrdenCompra compra)
        {
            OrdenCompra  compraold = _context.OrdenCompras.Where(x => x.Codigo == codigo)
                                                      .FirstOrDefault();
            compraold.FormapagoId =compra.FormapagoId ;
            compraold.EstadoId =compra .EstadoId ;
            compraold.Observaciones = compra .Observaciones;
            compraold.FechaEntrega = compra .FechaEntrega ;
            _context.SaveChanges();

        }
        public void RecibirMercancia (string codigo )
        {
            OrdenCompra compra = BuscarCompra(codigo);
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
            var compra = Queryable.Where(x => x.Id == id) .AsEnumerable().Select(
                x => new OrdenCompra  {
                    Id =      x.Id,
                    Codigo= x.Codigo,
                    Fecha=  x.Fecha,
                    FechaEntrega=x.FechaEntrega,
                    Observaciones = x.Observaciones,
                    Usuario=x.Usuario,
                    UsuarioId = x.UsuarioId,
                    Proveedor = x.Proveedor ,
                    ProveedorId = x.ProveedorId ,
                    TipoDocumento=x.TipoDocumento,                    
                    TipoDocumentoId=x.TipoDocumentoId,
                    Impuestos=x.Impuestos,
                    FormaPago=x. FormaPago,
                    FormapagoId = x.FormapagoId,             
                    Descuento=   x.Descuento ,
                    Recibido=  x.Recibido,                
                    Detalles=x.Detalles,
                    EstadoId= x.EstadoId ,
                    Estado=   x.Estado
                }).FirstOrDefault();
        
            return compra;

        }
        public OrdenCompra BuscarCompra(string  codigo)
        {
            var compra =  Queryable.Where(x => x.Codigo  == codigo ).Select(
                x => new OrdenCompra
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    Fecha = x.Fecha,
                    FechaEntrega = x.FechaEntrega,
                    Observaciones = x.Observaciones,
                    Usuario = x.Usuario,
                    UsuarioId = x.UsuarioId,
                    Proveedor = x.Proveedor,
                    ProveedorId = x.ProveedorId,
                    TipoDocumento = x.TipoDocumento,
                    TipoDocumentoId = x.TipoDocumentoId,
                    FormaPago = x.FormaPago,
                    FormapagoId = x.FormapagoId,
                    Descuento = x.Descuento,
                    Recibido = x.Recibido,
                    Detalles = x.Detalles,
                    EstadoId = x.EstadoId,
                    Estado = x.Estado
                }).FirstOrDefault();

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
