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
    public class FacturaHelp:Help
    {
      //  InventarioDbContext _context;
        ExistenciaHelp _existenciaHelp; 
        public FacturaHelp  (InventarioDbContext context,ExistenciaHelp existenciaHelp )
        {
            _context = context;
            _existenciaHelp = existenciaHelp;
        }
        public decimal TotalesFacturas
        {
            get
            {
                decimal total = 0;
                foreach (var item in FacturaEncabezados.Where (x=>x.EstadoId !=4).ToList())
                {
                    total += item.TotalPagar;
                }
                return total;
            }
        }
        public List  <FacturaEncabezado>FacturaEncabezados
        {
            get
            {
                var query = (from fact in _context.FacturaEncabezados join cli in _context.Clientes
                            on fact.ClienteId equals cli.Id join usu in _context.Usuarios on fact.UsuarioId
                            equals usu.Id  join formapago in _context.FormaPagos on fact.FormapagoId equals formapago.Id
                            join tipodoc in _context.TipoDocumentos on fact.TipoDocumentoId equals tipodoc.Id
                            join est in _context .Estados on fact.EstadoId equals est .Id
                            select new
                            {
                                fact.Id,
                                fact.Codigo ,                              
                                fact.Fecha ,
                                fact .Observaciones ,
                                 fact .Descuento ,
                                 fact.Recibido ,
                                 fact.Usuario,
                                 fact.UsuarioId ,
                                fact.ClienteId,
                                fact.Cliente,
                                fact.TipoDocumento,
                                fact.TipoDocumentoId,
                                fact.FormaPago,
                                fact.FormapagoId,
                                factdetalles = _context .FacturaDetalles .Where(x=>x.FacturaId ==fact .Id )
                                                          .ToList (),
                                fact.EstadoId ,
                                fact.Estado 
                            });
                List<FacturaEncabezado> facturas = new List<FacturaEncabezado>();
                foreach ( var fact in query .ToList ())
                {

                    fact.Usuario.Empresa.TipoRegimen = _context.TipoRegimens.Find(fact.Usuario.Empresa.TipoRegimenId);
                    fact.Usuario.Empleados = _context.Empleados.Where(x => x.UsuarioId == fact.UsuarioId).ToList();
                    fact.Cliente.TipoIdentificacion = _context.TipoIdentificacions.Find(fact.Cliente.TipoIdentificacionId);
                    foreach (var detalles in fact.factdetalles)
                    {
                        detalles.Producto = _context.Productos.Find(detalles.ProductoId);

                    }                    
                    FacturaEncabezado facturaEncabezado = new FacturaEncabezado
                    {
                        Id = fact.Id,
                        Codigo =fact.Codigo ,
                        ClienteId = fact.ClienteId,
                        Cliente = fact.Cliente,
                        TipoDocumento = fact.TipoDocumento,
                        TipoDocumentoId = fact.TipoDocumentoId,
                        FormaPago = fact.FormaPago,
                        FormapagoId = fact.FormapagoId,
                        Impuestos =  _context.Empresas.Where(x => x.Id == fact.Usuario.EmpresaId).FirstOrDefault().TipoRegimenId == 2 ? _context.Impuestos.ToList() : null,
                        Detalles = fact.factdetalles,
                        EstadoId = fact.EstadoId,
                        Estado = fact.Estado,
                        Observaciones = fact.Observaciones,
                        Descuento = fact.Descuento,
                        Recibido = fact.Recibido,
                        Usuario = fact.Usuario,
                       
                        UsuarioId = fact.UsuarioId,
                        Fecha = fact.Fecha,

                    };
                    facturas.Add(facturaEncabezado);                    
                }
                return facturas;
            }

        }
        public override DataTable Table { get; }

        public List< FacturaEncabezado> GetFacturas()
        {
            List <FacturaEncabezado > facturaEncabezados = _context.FacturaEncabezados.ToList();
            List<FacturaEncabezado> facturaEncabezadosNew = new List<FacturaEncabezado>();
            foreach (FacturaEncabezado fact in facturaEncabezados)
            {               
                fact.Usuario = _context.Usuarios.Find(fact.UsuarioId);
                var empresa = _context.Empresas.Find(fact.Usuario.EmpresaId);
                fact.Cliente = _context.Clientes.Find(fact.ClienteId);
                fact.TipoDocumento = _context.TipoDocumentos.Find(fact.TipoDocumentoId);
                fact.FormaPago = _context.FormaPagos.Find(fact.FormapagoId);
                fact.Impuestos = empresa.TipoRegimenId == 2 ? _context.Impuestos.ToList() : null;
                fact.Detalles = _context.FacturaDetalles.Where(x => x.FacturaId == fact.Id).ToList();
                List<FacturaDetalle> detalleNew = new List<FacturaDetalle>();

                foreach(FacturaDetalle detalle in fact.Detalles )
                {
                    detalle.Producto = _context.Productos.Find(detalle.ProductoId);
                    detalleNew.Add(detalle);
                    
                }
                fact.Detalles = detalleNew;
                
                facturaEncabezadosNew.Add(fact);
            }           
            return facturaEncabezadosNew;
        }
        public FacturaEncabezado GetFacturaEncabezado (string codigo)
        {
            var factura = FacturaEncabezados.Where(x => x.Codigo == codigo).FirstOrDefault ();
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
            _context.FacturaEncabezados.Add(factura);
            _context.SaveChanges();
            var fact = _context.FacturaEncabezados
                                        .Where(x => x.Codigo == factura.Codigo)
                                        .FirstOrDefault();
            foreach(var item in  fact.Detalles)
            {
                item.FacturaId = fact.Id;
                _context.FacturaDetalles.Add(item);
                _context.SaveChanges();
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
