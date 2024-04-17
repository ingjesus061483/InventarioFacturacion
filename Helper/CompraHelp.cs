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
    public class CompraHelp : IHelp<OrdenCompraDTO>
    {
        ExistenciaHelp _existenciaHelp;
        readonly InventarioDbContext _context;
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
        public bool Validar(OrdenCompraDTO compra)
        {
            if (compra .ProveedorId  == 0)
            {
               Utilities .GetDialogResult("El campo cliente no puede ser vacio ", "",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .UsuarioId == 0)
            {
                Utilities .GetDialogResult ("El campo usuario no puede ser vacio", "",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .TipoDocumentoId == 0)
            {
                Utilities .GetDialogResult ("El campo tipo documento no puede ser vacio ni contener letras", "",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .Detalles.Count == 0)
            {
                Utilities .GetDialogResult ("No hay productos en el detalle", "",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (compra .TotalPagar <= 0)
            {
                Utilities .GetDialogResult ("El campo total pagar no puede ser vacio ni contener letras", "",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void Guardar(OrdenCompraDTO compraDTO  )
        {
            if(!Validar (compraDTO ))
            {
                return;
            }
            OrdenCompra compra = new OrdenCompra
            {
                Codigo =compraDTO .Codigo , 
                Fecha =compraDTO .Fecha ,
                FechaEntrega=compraDTO .FechaEntrega ,
                UsuarioId =compraDTO .UsuarioId,
                ProveedorId=compraDTO .ProveedorId ,
                TipoDocumentoId=compraDTO .TipoDocumentoId  ,
                FormapagoId =compraDTO .FormapagoId ,
                Observaciones =compraDTO .Observaciones ,
                Recibido =compraDTO.Recibido ,
                Descuento=compraDTO .Descuento ,
                EstadoId=compraDTO.EstadoId 
            }; 
            _context.OrdenCompras .Add(compra );
            _context.SaveChanges();
            var compr = Queryable.Where(x => x.Codigo == compra .Codigo)
                                 .FirstOrDefault();
            foreach (var item in compr .Detalles)
            {
                OrdenCompraDetalle ordenCompraDetalle = new OrdenCompraDetalle
                {
                    OrdenCompraId = compr.Id,
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    ValorUnitario = item.ValorUnitario,
                };
                
                _context.OrdenCompraDetalles .Add(ordenCompraDetalle );
                _context.SaveChanges();
            }
        }
        public void  Actualizar(int id,OrdenCompraDTO compraDTO)
        {
            OrdenCompra  compraold = _context.OrdenCompras.Where(x => x.Id  == id)
                                                      .FirstOrDefault();
            compraold.FormapagoId =compraDTO.FormapagoId ;
            compraold.EstadoId =compraDTO .EstadoId ;
            compraold.Observaciones = compraDTO .Observaciones;
            compraold.FechaEntrega = compraDTO .FechaEntrega ;
            _context.SaveChanges();

        }
        public void RecibirMercancia (string codigo )
        {
            OrdenCompraDTO compra =Queryable.Where(x=>x.Codigo .Contains( codigo)).FirstOrDefault();
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
                _existenciaHelp.Guardar(existencia);
            }
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
                _existenciaHelp.Guardar(existencia);
            }
            var compra = _context.OrdenCompras.Find(id);
            compra .EstadoId = 4;
            compra .Observaciones = "Se ha anulado la compra";
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
