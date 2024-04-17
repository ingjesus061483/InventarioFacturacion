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
    public class FacturaHelp:IHelp<FacturaDTO>
    {
        readonly  InventarioDbContext _context;
        ExistenciaHelp _existenciaHelp; 
        public FacturaHelp  (InventarioDbContext context,ExistenciaHelp existenciaHelp )
        {
            _context = context;
            _existenciaHelp = existenciaHelp;
        }
        public IQueryable<FacturaDTO> Queryable
        {
            get
            {
                return (from factura in _context.FacturaEncabezados
                        join prov in _context.Clientes on factura.ClienteId equals prov.Id
                        join usu in _context.Usuarios on factura.UsuarioId equals usu.Id
                        join empresa in _context .Empresas on usu.EmpresaId equals empresa.Id
                        join formapago in _context.FormaPagos on factura.FormapagoId equals formapago.Id into fp
                        from subformaPago in fp.DefaultIfEmpty()
                        join tipodoc in _context.TipoDocumentos on factura.TipoDocumentoId equals tipodoc.Id
                        join est in _context.Estados on factura.EstadoId equals est.Id
                        select new FacturaDTO
                        {
                            Id = factura.Id,
                            Codigo = factura.Codigo,
                            Fecha = factura.Fecha,                        
                            Observaciones = factura.Observaciones,
                            Usuario = factura.Usuario,
                            Empresa=empresa ,
                            UsuarioId = factura.UsuarioId,
                            ClienteId = factura.ClienteId ,
                            Cliente = factura.Cliente,
                            TipoDocumento = factura.TipoDocumento,
                            TipoDocumentoId = factura.TipoDocumentoId,
                            FormaPago = subformaPago,
                            FormapagoId = factura.FormapagoId,
                            Detalles = _context.FacturaDetalles .Where(x => x.FacturaId == factura.Id)
                                                                  .ToList(),
                            Impuestos = _context.Impuestos
                                               .ToList(),
                            Descuento = factura.Descuento,
                            Recibido = factura.Recibido,
                            EstadoId = factura.EstadoId,
                            Estado = factura.Estado
                        });
            }
        }
        public FacturaEncabezado Buscar (string codigo)
        {
            var factura =Queryable .Where(x => x.Codigo == codigo).AsEnumerable ().Select(x=>new FacturaEncabezado {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Observaciones = x.Observaciones,
                Usuario = x.Usuario,
                Empresa =x. Empresa,
                UsuarioId = x.UsuarioId,
                ClienteId = x.ClienteId,
                Cliente = x.Cliente,
                TipoDocumento = x.TipoDocumento,
                TipoDocumentoId = x.TipoDocumentoId,
                FormaPago =x.FormaPago,
                FormapagoId = x.FormapagoId,
                Detalles = x.Detalles,
                Impuestos = x.Impuestos,
                Descuento = x.Descuento,
                Recibido = x.Recibido,
                EstadoId = x.EstadoId,
                Estado = x.Estado
            }). FirstOrDefault ();
            return factura;
        }
        public bool Validar(FacturaDTO factura )
        {
            if(factura.ClienteId ==0)
            {
                Utilities .GetDialogResult ("El campo cliente no puede ser vacio ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura .UsuarioId==0)
            {
                Utilities .GetDialogResult ("El campo usuario no puede ser vacio", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.FormapagoId == 0)
            {
                Utilities .GetDialogResult ("El campo forma pago no puede ser vacio ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.TipoDocumentoId == 0)
            {
                Utilities.GetDialogResult ("El campo tipo documento no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(factura .Detalles .Count == 0)
            {
                Utilities.GetDialogResult ("No hay productos en el detalle", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.TotalPagar <= 0)
            {
                Utilities.GetDialogResult ("El campo recivido no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura .Recibido <= 0)
            {
                Utilities.GetDialogResult ("El campo recivido no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void AnularFactura(int id  ,List<FacturaDetalle > detalles)
        {
            foreach (var item in detalles)
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
            var fact = _context.FacturaEncabezados.Find(id);
            fact.EstadoId = 4;
            fact.Observaciones = "Se ha anulado la factura";
            _context.SaveChanges();
        }
        public void Guardar(FacturaDTO facturaDTO)
        {
            if(!Validar(facturaDTO))
            {
                return;
            }
            var detalles = facturaDTO.Detalles;
            FacturaEncabezado factura = new FacturaEncabezado {
                Codigo = facturaDTO.Codigo,
                Fecha = facturaDTO.Fecha,
                UsuarioId = facturaDTO.UsuarioId,
                ClienteId  = facturaDTO.ClienteId ,
                TipoDocumentoId = facturaDTO.TipoDocumentoId ,
                FormapagoId = facturaDTO.FormapagoId,
                Observaciones = facturaDTO.Observaciones,
                Recibido = facturaDTO.Recibido,
                Descuento = facturaDTO.Descuento,
                EstadoId = facturaDTO.EstadoId
            };
            _context.FacturaEncabezados.Add(factura);
            _context.SaveChanges();
            var fact = Queryable.Where(x => x.Codigo == facturaDTO.Codigo).FirstOrDefault();
         
            foreach(var item in  detalles)
            {                
                FacturaDetalle facturaDetalle = new FacturaDetalle
                {
                    FacturaId=fact .Id ,
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    ValorUnitario = item.ValorUnitario,
                };
                _context.FacturaDetalles.Add(facturaDetalle );
                _context.SaveChanges();
                Existencia existencia = new Existencia
                {
                    Cantidad = item.Cantidad,
                    ProductoId = item.ProductoId,
                    Concepto = "Salida " +item .Producto.Nombre,
                    Entrada = false,
                    Fecha = DateTime.Now
                };
                _existenciaHelp.Guardar(existencia);
            }           
        }
        public void Actualizar(int id, FacturaDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
