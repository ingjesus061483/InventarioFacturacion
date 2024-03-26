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
    public class FacturaHelp:Help
    {
      //  InventarioDbContext _context;
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
        bool Validar(FacturaEncabezado factura )
        {
            if(factura.ClienteId ==0)
            {
                MessageBox.Show("El campo cliente no puede ser vacio ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura .UsuarioId==0)
            {
                MessageBox.Show("El campo usuario no puede ser vacio", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.FormapagoId == 0)
            {
                MessageBox.Show("El campo forma pago no puede ser vacio ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.TipoDocumentoId == 0)
            {
                MessageBox.Show("El campo tipo documento no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(factura .Detalles .Count == 0)
            {
                MessageBox.Show("No hay productos en el detalle", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura.TotalPagar <= 0)
            {
                MessageBox.Show("El campo recivido no puede ser vacio ni contener letras", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (factura .Recibido <= 0)
            {
                MessageBox.Show("El campo recivido no puede ser vacio ni contener letras", "",
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
                _existenciaHelp.GuardarExistencias(existencia);
            }
            var fact = _context.FacturaEncabezados.Find(id);
            fact.EstadoId = 4;
            fact.Observaciones = "Se ha anulado la factura";
            _context.SaveChanges();
        }
        public void GuardarFactura(FacturaEncabezado factura)
        {
            if(!Validar(factura))
            {
                return;
            }
            var detalles = factura.Detalles;
            factura.Detalles = null;
            _context.FacturaEncabezados.Add(factura);
            _context.SaveChanges();
         
            foreach(var item in  detalles)
            {
                var producto = item.Producto;
                item.Producto = null;
                item.FacturaId = factura.Id;
                _context.FacturaDetalles.Add(item);
                _context.SaveChanges();
                Existencia existencia = new Existencia
                {
                    Cantidad = item.Cantidad,
                    ProductoId = item.ProductoId,
                    Concepto = "Salida " + producto.Nombre,
                    Entrada = false,
                    Fecha = DateTime.Now
                };
                _existenciaHelp.GuardarExistencias(existencia);
            }
           
        }
        
        public override void GetDatagrid(DataGridView gridView,string [,]columns)
        {
            gridView.DataSource = null;
            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            int fila = columns.GetLength(0);
            for (int i = 0; i <= fila  - 1; i++)
            {
                var DataGridViewTextBoxColumn = GetDataGridViewTextBoxColumn(columns[i, 0],
                                                                             columns[i, 0],
                                                                             columns[i, 0],
                                                                             bool.Parse(columns[i, 1]));
                bool encontrado = false;
                foreach(DataGridViewColumn dataGridViewColumn in gridView .Columns )
                {
                    if (dataGridViewColumn .Name ==DataGridViewTextBoxColumn .Name )
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    gridView.Columns.Add(DataGridViewTextBoxColumn);
                }
                dataGridViewTextBoxColumns.Add(DataGridViewTextBoxColumn);
            }

        }     
    }
}
