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
    public partial class frmInventarioProducto : Form
    {
        int categoria;
        public Empresa Empresa { get; set; }
        ProductoHelp _productoHelp;
        CategoriaHelp _categoriaHelp;
        UnidaMedidaHelp _unidaMedidaHelp;
        ExistenciaHelp _existenciaHelp;        
        DataSet  Db;
//        List <Producto> Productos { get; set; }
        public frmInventarioProducto( ProductoHelp productoHelp,
                                      CategoriaHelp categoriaHelp,
                                      ExistenciaHelp existenciaHelp,
                                      UnidaMedidaHelp unidaMedidaHelp )
        {
            _unidaMedidaHelp = unidaMedidaHelp;
            _categoriaHelp = categoriaHelp;
            _productoHelp = productoHelp;
            _existenciaHelp = existenciaHelp;
            InitializeComponent();
        }

        private void Cuestas1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            int col = e.ColumnIndex;
            switch (col)
            {
                case 0:
                    {
                        var codigo = gridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        var producto = _productoHelp.BuscarProducto(codigo);

                        frmDetalleExistencia frmFactura = new frmDetalleExistencia(_existenciaHelp )
                        {
                            producto = producto
                        };
                        frmFactura.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        var codigo = gridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        var producto = _productoHelp.BuscarProducto(codigo);
                        frmProducto frmProducto = new frmProducto(_productoHelp,
                                              _categoriaHelp,
                                              _unidaMedidaHelp,
                                              _existenciaHelp);
                        frmProducto.Producto  = producto ;
                        frmProducto.ShowDialog();
                        break;


                    }
                case 1:
                    {
                        var codigo = gridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        frmExistencia frmExistencia = new frmExistencia(_productoHelp,_existenciaHelp );
                        frmExistencia.producto = _productoHelp  .BuscarProducto (codigo);
                        frmExistencia.ShowDialog();
                        break;
                    }
            }

            cmbCategoria.SelectedIndex = -1;
           dgProdctos .DataSource =_productoHelp.Table ;

        }

        private void cuestas1_Load(object sender, EventArgs e)
        {
            Cuestas cuestas = (Cuestas)sender;
            cuestas.ProductoHelp = _productoHelp;
        }

        private void frmInventarioProducto_Load(object sender, EventArgs e)
        {
            Db = new DataSet();

            //Productos = _productoHelp.GetProductos(0);
            dgProdctos.DataSource = _productoHelp.Table ;     
            _categoriaHelp.Cmb(cmbCategoria);

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            int.TryParse(combo.SelectedValue !=null? combo.SelectedValue.ToString():string .Empty , out categoria);
            if (categoria != 0)
            {
               dgProdctos .DataSource = _productoHelp.Busqueda ("CategoriaId",categoria.ToString () );
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Db.Tables.Add(_productoHelp .Table);
            _productoHelp.ExportarDatos(Db);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto =new frmProducto(_productoHelp,
                                                     _categoriaHelp,
                                                     _unidaMedidaHelp, 
                                                     _existenciaHelp);
            if(cmbCategoria.SelectedValue != null)
            {
                frmProducto.CategoriaId = int.Parse(cmbCategoria.SelectedValue.ToString());          
            }
            frmProducto.ShowDialog();
            dgProdctos.DataSource = _productoHelp.Table;
        }

        private void dgProdctos_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            txtTotalVentas.Text = _productoHelp.calucarExistencias(dgProdctos).ToString ();
            txtNofactura.Text = string.Empty;
            txtNofactura.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgProdctos.DataSource = _productoHelp.Busqueda("Codigo", txtNofactura .Text );
            if (dgProdctos.Rows.Count  == 0)
                dgProdctos.DataSource = _productoHelp.Table;

        }

        private void txtNofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar ==(char)Keys.Enter) {
                btnBuscar.PerformClick();
            }
        }

        private void btnTotatizar_Click(object sender, EventArgs e)
        {
            List < Producto >productos  = _productoHelp.GetProductos();
            List<ReportDataSource> reportDataSources = new List<ReportDataSource>();
            reportDataSources.Add(new ReportDataSource{ Name = "Productos",
                                                        Value = categoria != 0 ? productos.Where(x => x.CategoriaId == categoria)
                                                                                          .ToList() : productos}
            );
            List<Empresa> empresas = new List<Empresa>();
            empresas.Add(Empresa);
            reportDataSources.Add(new ReportDataSource { Name = "Empresa", Value = empresas });

            frmVistaPrevia frmVistaPrevia = new frmVistaPrevia
            {
                ruta =Application .StartupPath + "\\Reportes\\ExistenciasProdocto.rdlc",
                ReportDataSources = reportDataSources ,
                WindowState =  FormWindowState.Maximized 
                
            };
            frmVistaPrevia.Show();

        }
    }
}
