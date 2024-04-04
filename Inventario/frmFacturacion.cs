using Helper;
using Inventario.UserControls;
using Microsoft.Reporting.WinForms;
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
    public partial class frmFacturacion : Form
    {
        DataSet Db;
        int estado;
        public frmFacturacion(TipoDocumentoHelp tipoDocumentoHelp,
                          FormaPagoHelp formaPagoHelp,
                          UsuarioHelp usuarioHelp,
                          ClienteHelp clienteHelp,
                          TipoIdentificacionHelp tipoIdentificacionHelp,
                          EmpleadoHelp empleadoHelp,
                          ProductoHelp productoHelp,
                          ImpuestoHelp impuestoHelp,
                          FacturaHelp facturaHelp,
                          ImpresoraHelp impresoraHelp ,
                          DevolucionVentaHelp devolucionVentaHelp ,
                          MotivoHelp motivoHelp,
                          EstadoHelp estadoHelp,
                          ExportarHelp impExpHelp )
        {

            _FormaPagoHelp = formaPagoHelp;
            _estadoHelp = estadoHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            _clienteHelp = clienteHelp;
            _empleadoHelp = empleadoHelp;
            _usuarioHelp = usuarioHelp;
            _TipoDocumentoHelp = tipoDocumentoHelp;
            _productoHelp = productoHelp;
            _impuestoHelp = impuestoHelp;
            _facturaHelp = facturaHelp;
            _impresoraHelp = impresoraHelp;
            _devolucionVentaHelp = devolucionVentaHelp;
            _motivoHelp = motivoHelp;
            _ImpExpHelp = impExpHelp;
            InitializeComponent();
            cuestas1.CellClick += dgFacturas_CellContentClick;
            cuestas1.DataSource += Cuestas1_DataSource;
        }

        private void Cuestas1_DataSource(object sender, EventArgs e)
        {
            var ventas = chkPeriodo.Checked ? _facturaHelp.Queryable
                                                .Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value)
                                                .Where(x => x.EstadoId == estado)
                                                .AsEnumerable()
                                                .Select(x => new
                                                {
                                                    x.TotalPagar,
                                                })
                                                .Sum(X => X.TotalPagar) :

                                                _facturaHelp.Queryable                                                
                                                   .Where(x => x.EstadoId == estado)
                                                   .AsEnumerable()
                                                   .Select(x => new
                                                   {

                                                       x.TotalPagar,
                                                   }).Sum(x => x.TotalPagar);
            txtTotalVentas .Text  = String.Format("{0:C}", ventas);
                                                   



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura =new frmFactura(_TipoDocumentoHelp,
                                                      _FormaPagoHelp,
                                                      _usuarioHelp,
                                                      _clienteHelp,
                                                      _tipoIdentificacionHelp,
                                                      _empleadoHelp,
                                                      _productoHelp,
                                                      _impuestoHelp,
                                                      _facturaHelp,null);
            frmFactura.ShowDialog();
            cuestas1.MostrarDatos(_facturaHelp.Queryable.Where (x=>x.EstadoId==estado). AsEnumerable().Select(x => new {
                x.Id,
                x.Codigo,
                Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                x.Observaciones,
              usuario=  x.Usuario.Name,
                x.UsuarioId,
                Cliente = x.Cliente.NombreCompleto,
                x.ClienteId,
                TipoDocumento = x.TipoDocumento.Nombre,
                x.TipoDocumentoId,
                FormaPago = x.FormaPago.Nombre,
                x.FormapagoId,
                Subtotal = String.Format("{0:C}", x.Subtotal),
                Descuento = String.Format("{0:C}", x.Descuento),
                Impuesto = String.Format("{0:C}", x.Impuesto),
                TotalPagar = String.Format("{0:C}", x.TotalPagar),
                Recibido = String.Format("{0:C}", x.Recibido),
                Cambio = String.Format("{0:C}", x.Cambio),
                x.EstadoId,
                Estado = x.Estado.Nombre
            }).ToList());

        }
        private void frmFacturacion_Load(object sender, EventArgs e)
        {            
            Db = new DataSet();
            _estadoHelp.Cmb(cmbEstado,_estadoHelp.Queryable.ToList());
            cuestas1.MostrarDatos(_facturaHelp.Queryable.Where(x=>x.EstadoId==estado). AsEnumerable().Select(x => new {
                x.Id,
                x.Codigo,
                Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                x.Observaciones,
                usuario = x.Usuario.Name,
                x.UsuarioId,
                Cliente = x.Cliente.NombreCompleto,
                x.ClienteId,
                TipoDocumento = x.TipoDocumento.Nombre,
                x.TipoDocumentoId,
                FormaPago = x.FormaPago.Nombre,
                x.FormapagoId,
                Subtotal = String.Format("{0:C}", x.Subtotal),
                Descuento = String.Format("{0:C}", x.Descuento),
                Impuesto = String.Format("{0:C}", x.Impuesto),
                TotalPagar = String.Format("{0:C}", x.TotalPagar),
                Recibido = String.Format("{0:C}", x.Recibido),
                Cambio = String.Format("{0:C}", x.Cambio),
                x.EstadoId,
                Estado = x.Estado.Nombre
            }).ToList());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            object Facturas;
            if (chkPeriodo.Checked)
            {
               Facturas = _facturaHelp.Queryable
                                                  .Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value)
                                                  .Where(x=>x.EstadoId==estado )
                                                  .AsEnumerable()
                                                  .Select(x => new {
                                                      x.Id,
                                                      x.Codigo,
                                                      Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                                      x.Observaciones,
                                                      usuario = x.Usuario.Name,
                                                      x.UsuarioId,
                                                      Cliente = x.Cliente.NombreCompleto,
                                                      x.ClienteId,
                                                      TipoDocumento = x.TipoDocumento.Nombre,
                                                      x.TipoDocumentoId,
                                                      FormaPago = x.FormaPago.Nombre,
                                                      x.FormapagoId,
                                                      Subtotal = String.Format("{0:C}", x.Subtotal),
                                                      Descuento = String.Format("{0:C}", x.Descuento),
                                                      Impuesto = String.Format("{0:C}", x.Impuesto),
                                                      TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                                      Recibido = String.Format("{0:C}", x.Recibido),
                                                      Cambio = String.Format("{0:C}", x.Cambio),
                                                      x.EstadoId,
                                                      Estado = x.Estado.Nombre
                                                  }).ToList();
            
            }
            else
            {
                Facturas = _facturaHelp.Queryable
                                                  .Where(x => x.Codigo == txtNofactura.Text)
                                                  .Where(x=>x.EstadoId ==estado)
                                                  .AsEnumerable()
                                                  .Select(x => new {
                                                      x.Id,
                                                      x.Codigo,
                                                      Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                                      x.Observaciones,
                                                      Usuario=x.Usuario.Name,
                                                      x.UsuarioId,
                                                      Cliente = x.Cliente.NombreCompleto,
                                                      x.ClienteId,
                                                      TipoDocumento = x.TipoDocumento.Nombre,
                                                      x.TipoDocumentoId,
                                                      FormaPago = x.FormaPago.Nombre,
                                                      x.FormapagoId,
                                                      Subtotal = String.Format("{0:C}", x.Subtotal),
                                                      Descuento = String.Format("{0:C}", x.Descuento),
                                                      Impuesto = String.Format("{0:C}", x.Impuesto),
                                                      TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                                      Recibido = String.Format("{0:C}", x.Recibido),
                                                      Cambio = String.Format("{0:C}", x.Cambio),
                                                      x.EstadoId,
                                                      Estado = x.Estado.Nombre
                                                  }).ToList();
                
            }
            cuestas1.MostrarDatos(Facturas);
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicio.Visible = chkPeriodo.Checked;
            dtpFechaFin.Visible = chkPeriodo.Checked;
        }
        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            int col = e.ColumnIndex;
            var codigo = datagridview.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            var factura = _facturaHelp.Queryable
                                      .Where(x => x.Codigo == codigo)
                                      .AsEnumerable()
                                      .Select(x => new FacturaEncabezado  {
                                         Id= x.Id,
                                         Codigo = x.Codigo,
                                          Fecha = x.Fecha,
                                          Observaciones =  x.Observaciones,
                                         Usuario = x.Usuario,
                                          UsuarioId = x.UsuarioId,
                                          Cliente = x.Cliente,
                                          ClienteId = x.ClienteId,
                                          TipoDocumento = x.TipoDocumento,
                                          TipoDocumentoId = x.TipoDocumentoId,
                                          FormaPago = x.FormaPago,
                                          FormapagoId = x.FormapagoId,                                         
                                          Descuento =  x.Descuento,
                                          Impuestos = x.Impuestos,                                          
                                          Recibido = x .Recibido,                                          
                                        EstadoId=  x.EstadoId,
                                          Estado = x.Estado,
                                          Empresa=x.Empresa ,
                                          Detalles=x.Detalles                                           
                                      });
            switch (col)
            {
                case 0:
                    {
                        
                            
                        if (factura.FirstOrDefault().EstadoId== 4)
                        {
                            MessageBox.Show("La Factura ya se encuentra anulada", "",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;

                        }
                        frmFactura frmFactura = new frmFactura(_TipoDocumentoHelp,
                                                                  _FormaPagoHelp,
                                                                  _usuarioHelp,
                                                                  _clienteHelp,
                                                                  _tipoIdentificacionHelp,
                                                                  _empleadoHelp,
                                                                  _productoHelp,
                                                                  _impuestoHelp,
                                                                  _facturaHelp,
                                                                 factura.FirstOrDefault ());                        
                        frmFactura.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        if (factura.FirstOrDefault().EstadoId == 4)
                        {
                            MessageBox.Show("La Factura ya se encuentra anulada", "",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                            
                        }
                        switch(factura.FirstOrDefault() .TipoDocumentoId )
                        {
                            case 1:
                                {
                                    List<ReportDataSource> sources = new List<ReportDataSource>();
                                    var fact=factura   .ToList ();
                                    List<Empresa> empresas = new List<Empresa>
                                    {
                                        _usuarioHelp.Login.Empresa
                                    };
                                    List<Cliente> clientes = new List<Cliente>
                                    {
                                        fact[0].Cliente
                                    };
                                    sources.Add(new ReportDataSource { Name = "Encabezado", Value = fact });
                                    sources.Add(new ReportDataSource { Name = "Cliente", Value = clientes });
                                    sources.Add(new ReportDataSource { Name = "Detalle", Value = fact[0].Detalles });
                                    sources.Add(new ReportDataSource { Name = "Empresa", Value = empresas });
                                    frmReporte frmVistaPrevia = new frmReporte
                                    {
                                        ruta = Application.StartupPath + "\\Reportes\\factura.rdlc",
                                        ReportDataSources = sources,
                                        WindowState = FormWindowState.Maximized
                                    };
                                    frmVistaPrevia.Show();
                                    break;
                                }
                            case 2:
                                {
                                    _impresoraHelp.ImprimirVenta(factura.FirstOrDefault());
                                    break;
                                }

                        }                      
                        break;
                    }
                case 3:
                    {
                        if(factura.FirstOrDefault(). EstadoId ==4)
                        {
                            MessageBox.Show("La Factura ya se encuentra anulada", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;

                        }
                        frmDevolucionVenta frmDevoluciones = new frmDevolucionVenta(_facturaHelp, 
                                                                              _devolucionVentaHelp,                                                                            
                                                                              _motivoHelp )
                        {
                            Factura = factura.FirstOrDefault()
                        };
                        frmDevoluciones.ShowDialog();

                        break;
                    }
            }            
            cuestas1.MostrarDatos(_facturaHelp.Queryable                       
                                                  .Where(x=>x.EstadoId==estado)                       
                                                  .AsEnumerable()
                                                  .Select(x => new {
                                                      x.Id,
                                                      x.Codigo,
                                                      Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                                      x.Observaciones,
                                                      Usuario= x.Usuario.Name,
                                                      x.UsuarioId,
                                                      Cliente = x.Cliente.NombreCompleto,
                                                      x.ClienteId,
                                                      TipoDocumento = x.TipoDocumento.Nombre,
                                                      x.TipoDocumentoId,
                                                      FormaPago = x.FormaPago.Nombre,
                                                      x.FormapagoId,
                                                      Subtotal = String.Format("{0:C}", x.Subtotal),
                                                      Descuento = String.Format("{0:C}", x.Descuento),
                                                      Impuesto = String.Format("{0:C}", x.Impuesto),
                                                      TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                                      Recibido = String.Format("{0:C}", x.Recibido),
                                                      Cambio = String.Format("{0:C}", x.Cambio),
                                                      x.EstadoId,
                                                      Estado = x.Estado.Nombre
                                                  }).ToList());
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var facturaEncabezados = chkPeriodo.Checked ? _facturaHelp.Queryable.
                                    Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value && x.EstadoId == estado)
                                    .AsEnumerable()
                                    .Select(x => new 
                                    {
                                        x.Id,
                                        x.Codigo,
                                        Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                        x.Observaciones,
                                        Usuario = x.Usuario.Name,
                                        x.UsuarioId,
                                        Cliente = x.Cliente.NombreCompleto,
                                        x.ClienteId,
                                        TipoDocumento = x.TipoDocumento.Nombre,
                                        x.TipoDocumentoId,
                                        FormaPago = x.FormaPago.Nombre,
                                        x.FormapagoId,
                                        Subtotal = String.Format("{0:C}", x.Subtotal),
                                        Descuento = String.Format("{0:C}", x.Descuento),
                                        Impuesto = String.Format("{0:C}", x.Impuesto),
                                        TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                        Recibido = String.Format("{0:C}", x.Recibido),
                                        Cambio = String.Format("{0:C}", x.Cambio),
                                        x.EstadoId,
                                        Estado = x.Estado.Nombre
                                    }).ToList()
              :
              _facturaHelp.Queryable.
                                    Where(x => x.EstadoId == estado)
                                    .AsEnumerable()
                                    .Select(x => new                                     {
                                        x.Id,
                                        x.Codigo,
                                        Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                        x.Observaciones,
                                        Usuario = x.Usuario.Name,
                                        x.UsuarioId,
                                        Cliente = x.Cliente.NombreCompleto,
                                        x.ClienteId,
                                        TipoDocumento = x.TipoDocumento.Nombre,
                                        x.TipoDocumentoId,
                                        FormaPago = x.FormaPago.Nombre,
                                        x.FormapagoId,
                                        Subtotal = String.Format("{0:C}", x.Subtotal),
                                        Descuento = String.Format("{0:C}", x.Descuento),
                                        Impuesto = String.Format("{0:C}", x.Impuesto),
                                        TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                        Recibido = String.Format("{0:C}", x.Recibido),
                                        Cambio = String.Format("{0:C}", x.Cambio),
                                        x.EstadoId,
                                        Estado = x.Estado.Nombre
                                    }).ToList();
                DataTable dt = _facturaHelp.GetTable(facturaEncabezados);
                dt.TableName = "FacturaEncabezadoes";

                Db.Tables.Add( dt );
                _ImpExpHelp.Exportar( Db);


            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message , ex.Source ,
MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
            finally 
            {
                this.Cursor = Cursors.Default;
                Db.Tables.Clear();
            }

        }
        private void cuestas1_Load(object sender, EventArgs e)
        {
            Cuestas cuestas = (Cuestas)sender;
            cuestas.FacturaHelp = _facturaHelp;
        }

        private void btnTotatizar_Click(object sender, EventArgs e)
        {
            List<FacturaEncabezado> facturaEncabezados = chkPeriodo.Checked ? _facturaHelp.Queryable.
                                      Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value && x.EstadoId == estado )
                                      .AsEnumerable()
                                      .Select(x => new FacturaEncabezado
                                      {
                                          Id = x.Id,
                                          Codigo = x.Codigo,
                                          Fecha = x.Fecha,
                                          Observaciones = x.Observaciones,
                                          Usuario = x.Usuario,
                                          UsuarioId = x.UsuarioId,
                                          Cliente = x.Cliente,
                                          ClienteId = x.ClienteId,
                                          TipoDocumento = x.TipoDocumento,
                                          TipoDocumentoId = x.TipoDocumentoId,
                                          FormaPago = x.FormaPago,
                                          FormapagoId = x.FormapagoId,
                                          Descuento = x.Descuento,
                                          Impuestos = x.Impuestos,
                                          Recibido = x.Recibido,
                                          EstadoId = x.EstadoId,
                                          Estado = x.Estado,
                                          Empresa = x.Empresa,
                                          Detalles = x.Detalles
                                      }).ToList()
                :
                _facturaHelp.Queryable.
                                      Where(x => x.EstadoId == estado )
                                      .AsEnumerable()
                                      .Select(x => new FacturaEncabezado
                                      {
                                          Id = x.Id,
                                          Codigo = x.Codigo,
                                          Fecha = x.Fecha,
                                          Observaciones = x.Observaciones,
                                          Usuario = x.Usuario,
                                          UsuarioId = x.UsuarioId,
                                          Cliente = x.Cliente,
                                          ClienteId = x.ClienteId,
                                          TipoDocumento = x.TipoDocumento,
                                          TipoDocumentoId = x.TipoDocumentoId,
                                          FormaPago = x.FormaPago,
                                          FormapagoId = x.FormapagoId,
                                          Descuento = x.Descuento,
                                          Impuestos = x.Impuestos,
                                          Recibido = x.Recibido,
                                          EstadoId = x.EstadoId,
                                          Estado = x.Estado,
                                          Empresa = x.Empresa,
                                          Detalles = x.Detalles
                                      }).ToList();
            List<ReportDataSource> sources = new List<ReportDataSource>();
            List<Empresa> empresas = new List<Empresa>
            {
                _usuarioHelp.Login.Empresa
            };
            sources.Add(new ReportDataSource { Name = "Facturas", Value = facturaEncabezados });
            sources.Add(new ReportDataSource { Name = "Empresa", Value =empresas  });
            frmReporte frmVistaPrevia = new frmReporte
            {
                ruta =Application .StartupPath + "\\Reportes\\Ventas.rdlc",
                ReportDataSources=sources,
                WindowState = FormWindowState.Maximized
            };
            frmVistaPrevia.Show();

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
        /*    int.TryParse(cmbEstado.SelectedValue != null ? cmbEstado.SelectedValue.ToString() : string.Empty, out int estado);
            if (estado != 0)
            {


                cuestas1.MostrarDatos(Facturas.Where(x => x.EstadoId == estado).ToList());
            }*/

        }

        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbEstado.SelectedValue != null ? cmbEstado.SelectedValue.ToString() : string.Empty, out estado);
            if (estado == 0)
            {

                return;
            }
       
            cuestas1.MostrarDatos(_facturaHelp.Queryable
                                                  .Where(x => x.EstadoId == estado)
                                                  .AsEnumerable()
                                                  .Select(x => new {
                                                      x.Id,
                                                      x.Codigo,
                                                      Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                                                      x.Observaciones,
                                                      Usuario=x.Usuario.Name,
                                                      x.UsuarioId,
                                                      Cliente = x.Cliente.NombreCompleto,
                                                      x.ClienteId,
                                                      TipoDocumento = x.TipoDocumento.Nombre,
                                                      x.TipoDocumentoId,
                                                      FormaPago = x.FormaPago.Nombre,
                                                      x.FormapagoId,
                                                      Subtotal = String.Format("{0:C}", x.Subtotal),
                                                      Descuento = String.Format("{0:C}", x.Descuento),
                                                      Impuesto = String.Format("{0:C}", x.Impuesto),
                                                      TotalPagar = String.Format("{0:C}", x.TotalPagar),
                                                      Recibido = String.Format("{0:C}", x.Recibido),
                                                      Cambio = String.Format("{0:C}", x.Cambio),
                                                      x.EstadoId,
                                                      Estado = x.Estado.Nombre
                                                  }).ToList());           

        }
    }
}
