﻿using Helper;
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
                            MotivoHelp motivoHelp)
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

            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            dgCompras.DataSource = _compraHelp.Table;
            Db = new DataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;

           int id =int.Parse ( datagridview.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var compra = _compraHelp.BuscarCompra(id);
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


                                    frmRecibir frmRecibir = new frmRecibir(_compraHelp, _formaPagoHelp);
                                    frmRecibir.Compra = compra;
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
           dgCompras .DataSource  = _compraHelp .Table ;
            

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
            DataTable table;
            if(chkPeriodo .Checked)
            {
              table =  _compraHelp.Busqueda("Fecha", dtpFechaInicio .Value ,dtpFechaFin .Value );
            }
            else
            {
                table = _compraHelp.Busqueda("Codigo", txtNofactura .Text );
            }
            dgCompras.DataSource = table;

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
                Db.Tables.Add(_compraHelp.Table);
                _compraHelp.ExportarDatos(Db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source,
MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Db.Tables.Clear();
            }
        }
    }
}
