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
        List< FacturaEncabezado> Facturas { get; set; }
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
                          EstadoHelp estadoHelp )
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
            InitializeComponent();
            cuestas1.CellClick += dgFacturas_CellContentClick;
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
                                                      _facturaHelp,"");
            frmFactura.ShowDialog();
            Facturas = _facturaHelp.FacturaEncabezados;
//            _facturaHelp.GetDatagrid(dgFacturas, _facturaHelp.FacturaEncabezado);
  //          dgFacturas.DataSource = Facturas;
            cuestas1.MostrarDatos(Facturas);

        }
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            Facturas = _facturaHelp.FacturaEncabezados;
            Db = new DataSet();
            _estadoHelp.Cmb(cmbEstado);
            txtTotalVentas.Text = _facturaHelp.TotalesFacturas .ToString(); 
            cuestas1.MostrarDatos(Facturas);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(chkPeriodo.Checked)
            {
                Facturas = _facturaHelp.FacturaEncabezados.
                                          Where(x => x.Fecha  >= dtpFechaInicio.Value && x.Fecha <=dtpFechaFin .Value ).
                                          ToList();
            }
            else
            {
               Facturas = _facturaHelp.FacturaEncabezados.
                                                         Where(x => x.Codigo == txtNofactura.Text).
                                                         ToList();
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
            switch (col)
            {
                case 0:
                    {
                        var codigo = datagridview.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                        var factura = Facturas.Where(x => x.Codigo == codigo).FirstOrDefault();
                        if (factura.EstadoId == 4)
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
                                                                  codigo);                        
                        frmFactura.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        var codigo = datagridview.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                        var factura = Facturas.Where(x => x.Codigo == codigo).FirstOrDefault();
                        if (factura.EstadoId == 4)
                        {
                            MessageBox.Show("La Factura ya se encuentra anulada", "",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                            
                        }
                        switch(factura.TipoDocumentoId )
                        {
                            case 1:
                                {
                                    List<ReportDataSource> sources = new List<ReportDataSource>();
                                    var fact =Facturas.Where(x => x.Codigo == codigo).ToList ();
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
                                    frmVistaPrevia frmVistaPrevia = new frmVistaPrevia
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
                                    _impresoraHelp.ImprimirVenta(factura);
                                    break;
                                }

                        }                      
                        break;
                    }
                case 3:
                    {
                        var codigo = datagridview.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                        var factura = Facturas.Where(x => x.Codigo == codigo).FirstOrDefault();
                        if(factura.EstadoId ==4)
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
                            Factura = factura
                        };
                        frmDevoluciones.ShowDialog();

                        break;
                    }
            }
            Facturas = _facturaHelp.FacturaEncabezados;
            cuestas1.MostrarDatos(Facturas);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                Db.Tables.Add(cuestas1.Table);
                _facturaHelp.ExportarDatos( Db);


            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message , ex.Source ,
MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
            finally
            {
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
            List<FacturaEncabezado> facturaEncabezados = chkPeriodo.Checked ? _facturaHelp.FacturaEncabezados.
                Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value && x.EstadoId!=4).ToList() :
                _facturaHelp.FacturaEncabezados.Where(x=>x.EstadoId !=4).ToList();
            List<ReportDataSource> sources = new List<ReportDataSource>();
            List<Empresa> empresas = new List<Empresa>
            {
                _usuarioHelp.Login.Empresa
            };
            sources.Add(new ReportDataSource { Name = "Facturas", Value = facturaEncabezados });
            sources.Add(new ReportDataSource { Name = "Empresa", Value =empresas  });
            frmVistaPrevia frmVistaPrevia = new frmVistaPrevia
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
            int.TryParse(cmbEstado.SelectedValue != null ? cmbEstado.SelectedValue.ToString() : string.Empty, out int estado);
            if (estado == 0)
            {

                return;
            }
            cuestas1.MostrarDatos(Facturas.Where(x => x.EstadoId == estado).ToList());

        }
    }
}
