using Helper;
using Inventario.UserControls;
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
    public partial class frmCompras : Form
    {
      
        DataSet Db;
        public frmCompras(ProveedorHelp proveedorHelp,
                         EmpleadoHelp empleadoHelp,
                         ProductoHelp productoHelp,
                         CompraHelp compraHelp,
                         UsuarioHelp usuarioHelp,
                         TipoIdentificacionHelp tipoIdentificacionHelp,
                         FormaPagoHelp formaPagoHelp,
                         TipoDocumentoHelp tipoDocumentoHelp,
                         ImpuestoHelp impuestoHelp,
                         DevolucionCompraHelp devoluvionCompraHelp,
                            MotivoHelp motivoHelp,
                            ExportarHelp impExpHelp)
        {
             _motivoHelp=motivoHelp ;
            _devoluvionCompraHelp = devoluvionCompraHelp;
            _impuestoHelp = impuestoHelp;
            _formaPagoHelp = formaPagoHelp;
            _tipoDocumentoHelp = tipoDocumentoHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            _proveedorHelp = proveedorHelp;
            _empleadoHelp = empleadoHelp;
            _productoHelp = productoHelp;
            _compraHelp = compraHelp;
            _usuarioHelp = usuarioHelp;
            _ImpExpHelp = impExpHelp;
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            dgCompras.DataSource = _compraHelp.Queryable.AsEnumerable().Select( x=> new {
                x.Id,
                x.Codigo,
                Fecha=  x.Fecha.ToString("yyyy-MM-dd"),
                FechaEntrega=x.FechaEntrega.ToString("yyyy-MM-dd"),
                x.Observaciones,
                x.NombreUsuario,
                x.UsuarioId,
                x.NombreProveedor ,
                x.ProveedorId ,
                x.TipoDocumentoNombre ,
                x.TipoDocumentoId,
                x.FormaPagoNombre,
                x.FormapagoId,
                Subtotal=String .Format("{0:C}",     x.Subtotal),
                Descuento=   String.Format("{0:C}", x.Descuento ),
                Recibido= String.Format("{0:C}", x.Recibido),
                Impuesto = String.Format("{0:C}", x.Impuesto),
                TotalPagar = String.Format("{0:C}", x.TotalPagar) ,                
                x.EstadoId ,
                x.EstadoNombre
            }). ToList();
           // dgCompras.DataSource = _compraHelp.Table;
            Db = new DataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;

           int id =int.Parse ( datagridview.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var compra = _compraHelp.Queryable.Where (x=>x.Id== id).FirstOrDefault ();
            int col = e.ColumnIndex;
            switch (col)
            {
                case 0:
                    {
                        frmCompra frmCompra = new frmCompra(_proveedorHelp,
                                                    _empleadoHelp,
                                                    _productoHelp,
                                                    _compraHelp,
                                                    _usuarioHelp,
                                                    _tipoIdentificacionHelp,
                                                    _formaPagoHelp,
                                                    _tipoDocumentoHelp, _impuestoHelp);
                        frmCompra.Compra = compra;
                        frmCompra .ShowDialog();
                        break;
                    }
                case 1:
                    {
                        
                       // var factura = Facturas.Where(x => x.Codigo == codigo).FirstOrDefault();
                       // _impresoraHelp.ImprimirVenta(factura);
                        break;
                    }
                case 3: 
                    {
                       switch (compra.EstadoId )
                        {
                            case 3:
                                {


                                    frmRecibir frmRecibir = new frmRecibir(_compraHelp, _formaPagoHelp) {
                                        Compra = compra,
                                    };
                                    frmRecibir.ShowDialog();
                                    break;
                                }
                            case 4:
                                {
                                    MessageBox.Show("la compra ya fue anulada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                        }
                        MessageBox.Show("la mercancia ya fue recibida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case 4:
                    {

                        frmDevolucionCompra frmDevolucionCompra = new frmDevolucionCompra(_devoluvionCompraHelp, _motivoHelp, _compraHelp);
                        frmDevolucionCompra.Compra = compra;
                        frmDevolucionCompra.ShowDialog();
                        break;
                    }

            }
           dgCompras .DataSource  = _compraHelp.Queryable.AsEnumerable().Select(x => new {
               x.Id,
               x.Codigo,
               Fecha = x.Fecha.ToString("yyyy-MM-dd"),
               FechaEntrega = x.FechaEntrega.ToString("yyyy-MM-dd"),
               x.Observaciones,
               x.NombreUsuario,
               x.UsuarioId,
               x.NombreProveedor,
               x.ProveedorId,
               x.TipoDocumentoNombre,
               x.TipoDocumentoId,
               x.FormaPagoNombre,
               x.FormapagoId,
               Subtotal = String.Format("{0:C}", x.Subtotal),
               Descuento = String.Format("{0:C}", x.Descuento),
               Recibido = String.Format("{0:C}", x.Recibido),
               Impuesto = String.Format("{0:C}", x.Impuesto),
               TotalPagar = String.Format("{0:C}", x.TotalPagar),
               x.EstadoId,
               x.EstadoNombre
           }).ToList(); 


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCompra frmCompra = new frmCompra(_proveedorHelp,
                                        _empleadoHelp,
                                        _productoHelp,
                                        _compraHelp,
                                        _usuarioHelp,
                                        _tipoIdentificacionHelp,
                                        _formaPagoHelp,
                                        _tipoDocumentoHelp, _impuestoHelp);
            frmCompra.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(chkPeriodo .Checked)
            {
                dgCompras.DataSource = _compraHelp.Queryable.Where(x=>  x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value) .AsEnumerable().Select(x => new {
                    x.Id,
                    x.Codigo,
                    Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                    FechaEntrega = x.FechaEntrega.ToString("yyyy-MM-dd"),
                    x.Observaciones,
                    x.NombreUsuario,
                    x.UsuarioId,
                    x.NombreProveedor,
                    x.ProveedorId,
                    x.TipoDocumentoNombre,
                    x.TipoDocumentoId,
                    x.FormaPagoNombre,
                    x.FormapagoId,
                    Subtotal = String.Format("{0:C}", x.Subtotal),
                    Descuento = String.Format("{0:C}", x.Descuento),
                    Recibido = String.Format("{0:C}", x.Recibido),
                    Impuesto = String.Format("{0:C}", x.Impuesto),
                    TotalPagar = String.Format("{0:C}", x.TotalPagar),
                    x.EstadoId,
                    x.EstadoNombre
                }).ToList();
            }
            else
            {
                dgCompras.DataSource = _compraHelp.Queryable.Where(x=>x.Codigo .Contains(txtNofactura .Text )).AsEnumerable().Select(x => new {
                    x.Id,
                    x.Codigo,
                    Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                    FechaEntrega = x.FechaEntrega.ToString("yyyy-MM-dd"),
                    x.Observaciones,
                    x.NombreUsuario,
                    x.UsuarioId,
                    x.NombreProveedor,
                    x.ProveedorId,
                    x.TipoDocumentoNombre,
                    x.TipoDocumentoId,
                    x.FormaPagoNombre,
                    x.FormapagoId,
                    Subtotal = String.Format("{0:C}", x.Subtotal),
                    Descuento = String.Format("{0:C}", x.Descuento),
                    Recibido = String.Format("{0:C}", x.Recibido),
                    Impuesto = String.Format("{0:C}", x.Impuesto),
                    TotalPagar = String.Format("{0:C}", x.TotalPagar),
                    x.EstadoId,
                    x.EstadoNombre
                }).ToList();                
            }       
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicio.Visible = chkPeriodo.Checked;
            dtpFechaFin.Visible = chkPeriodo.Checked;
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
             try
            {
                this.Cursor = Cursors.WaitCursor;

               var Compras=chkPeriodo.Checked?  _compraHelp.Queryable.Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value).AsEnumerable().Select(x => new {
                   x.Id,
                   x.Codigo,
                   Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                   FechaEntrega = x.FechaEntrega.ToString("yyyy-MM-dd"),
                   x.Observaciones,
                   x.NombreUsuario,
                   x.UsuarioId,
                   x.NombreProveedor,
                   x.ProveedorId,
                   x.TipoDocumentoNombre,
                   x.TipoDocumentoId,
                   x.FormaPagoNombre,
                   x.FormapagoId,
                   Subtotal = String.Format("{0:C}", x.Subtotal),
                   Descuento = String.Format("{0:C}", x.Descuento),
                   Recibido = String.Format("{0:C}", x.Recibido),
                   Impuesto = String.Format("{0:C}", x.Impuesto),
                   TotalPagar = String.Format("{0:C}", x.TotalPagar),
                   x.EstadoId,
                   x.EstadoNombre
               }).ToList(): _compraHelp.Queryable.Where(x => x.Codigo.Contains(txtNofactura .Text )).AsEnumerable().Select(x => new {
                   x.Id,
                   x.Codigo,
                   Fecha = x.Fecha.ToString("yyyy-MM-dd"),
                   FechaEntrega = x.FechaEntrega.ToString("yyyy-MM-dd"),
                   x.Observaciones,
                   x.NombreUsuario,
                   x.UsuarioId,
                   x.NombreProveedor,
                   x.ProveedorId,
                   x.TipoDocumentoNombre,
                   x.TipoDocumentoId,
                   x.FormaPagoNombre,
                   x.FormapagoId,
                   Subtotal = String.Format("{0:C}", x.Subtotal),
                   Descuento = String.Format("{0:C}", x.Descuento),
                   Recibido = String.Format("{0:C}", x.Recibido),
                   Impuesto = String.Format("{0:C}", x.Impuesto),
                   TotalPagar = String.Format("{0:C}", x.TotalPagar),
                   x.EstadoId,
                   x.EstadoNombre
               }).ToList()               ;
                DataTable dt = Utilities .GetTable(Compras);
                dt.TableName = "compras";
                Db.Tables.Add(dt);
                _ImpExpHelp.Exportar(Db);
                Db.Tables.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source,
MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Cursor = Cursors.Default;
                Db.Tables.Clear();
            }
        }

        private void dgCompras_DataSourceChanged(object sender, EventArgs e)
        {
            var TotalCompras = chkPeriodo.Checked ? _compraHelp.Queryable.Where(x => x.Fecha >= dtpFechaInicio.Value && x.Fecha <= dtpFechaFin.Value).AsEnumerable().Select(x => new {
              
                x.TotalPagar,
                
            }).Sum(x=>x.TotalPagar ) : _compraHelp.Queryable.Where(x => x.Codigo.Contains(txtNofactura.Text)).AsEnumerable().Select(x => new {
                
                 x.TotalPagar,
                
            }).Sum(x=>x.TotalPagar);
            txtTotalVentas.Text = String.Format("{0:C}", TotalCompras);
        }
    }
}
