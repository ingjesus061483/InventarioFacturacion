using Helper;
using Helper.View;
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
        ExportarHelp _impExpHelp;
        DataSet  Db;
        public frmInventarioProducto( ProductoHelp productoHelp,
                                      CategoriaHelp categoriaHelp,
                                      ExistenciaHelp existenciaHelp,
                                      UnidaMedidaHelp unidaMedidaHelp ,
                                      ExportarHelp impExpHelp)
        {
            _unidaMedidaHelp = unidaMedidaHelp;
            _categoriaHelp = categoriaHelp;
            _productoHelp = productoHelp;
            _existenciaHelp = existenciaHelp;
            _impExpHelp = impExpHelp;
            InitializeComponent();
        }
        private void Cuestas1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            int col = e.ColumnIndex; 
            var codigo = gridView.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            int.TryParse( gridView.Rows[e.RowIndex].Cells["id"].Value.ToString(),out int id);
            var producto = _productoHelp.BuscarProducto(codigo);
            switch (col)
            {
                case 0:
                    {
                     

                        frmDetalleExistencia frmFactura = new frmDetalleExistencia(_existenciaHelp ,_impExpHelp)
                        {
                            Producto = producto
                        };
                        frmFactura.ShowDialog();
                        break;
                    }
                case 1:
                    {

                        frmExistencia frmExistencia = new frmExistencia(_productoHelp, _existenciaHelp);
                        frmExistencia.producto = producto;
                        frmExistencia.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        frmProducto frmProducto = new frmProducto(_productoHelp,
                                              _categoriaHelp,
                                              _unidaMedidaHelp,
                                              _existenciaHelp);
                        frmProducto.Producto  = producto ;
                        frmProducto.ShowDialog();
                        break;


                    }
                case 3:

                    { 
                        DialogResult result = MessageBox.Show("Desea eliminar este producto?", "",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _productoHelp.EliminarProducto(id);
                        }
                        break;
                    }               
            }
            mostrarProducto();
        }

        private void cuestas1_Load(object sender, EventArgs e)
        {
            Cuestas cuestas = (Cuestas)sender;
            cuestas.ProductoHelp = _productoHelp;
        }
        void mostrarProducto()
        {
            dgProdctos.DataSource = _productoHelp.Queryable.Where(x => x.CategoriaId == categoria).AsEnumerable().Select(x => new ProductoView {
               Id= x.Id,
               Codigo=  x.Codigo,
                Nombre =  x.Nombre,
                Costo = String.Format("{0:C}", x.Costo),
                Precio = String.Format("{0:C}", x.Precio),
                 TotalEntrada = x.TotalEntrada,
                TotalSalida = x.TotalSalida,
              TotalExistencia=  x.TotalExistencia,
               Descripcion= x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria = x.Categoria.Nombre,
               UnidadMedidaId= x.UnidadMedidaId,
                UnidadMedida = x.UnidadMedida.Nombre
            }).ToList();
        }
        private void frmInventarioProducto_Load(object sender, EventArgs e)
        {
            Db = new DataSet();
            mostrarProducto();

            _categoriaHelp.Cmb(cmbCategoria,_categoriaHelp.Queryable .ToList());

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            int.TryParse(combo.SelectedValue !=null? combo.SelectedValue.ToString():string .Empty , out categoria);
            if (categoria != 0)
            {
                mostrarProducto();
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {

            var productos = _productoHelp.Queryable.Where(x => x.CategoriaId == categoria).AsEnumerable().Select(x => new ProductoView
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = String.Format("{0:C}", x.Costo),
                Precio = String.Format("{0:C}", x.Precio),
                TotalEntrada = x.TotalEntrada,
                TotalSalida = x.TotalSalida,
                TotalExistencia = x.TotalExistencia,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria = x.Categoria.Nombre,
                UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida = x.UnidadMedida.Nombre
            }).ToList();
            Db.Tables.Add(_productoHelp .GetTable (productos ));
            _impExpHelp .Exportar(Db);
            Db.Clear();

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
            mostrarProducto();
        }
  
        private void dgProdctos_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            txtTotalVentas.Text = _productoHelp.Queryable.Where(x => x.CategoriaId == categoria).AsEnumerable()
                                                   .Sum(x => x.TotalExistencia).ToString ();
            txtNofactura.Text = string.Empty;
            txtNofactura.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgProdctos.DataSource = _productoHelp.Queryable.Where(x => x.Codigo.Contains(txtNofactura.Text)&& x.CategoriaId ==categoria ).AsEnumerable().Select(x =>new   ProductoView {
                Id = x.Id,
               Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = String.Format("{0:C}", x.Costo),
                Precio = String.Format("{0:C}", x.Precio),
                 TotalEntrada = x.TotalEntrada,
                TotalSalida = x.TotalSalida,
              TotalExistencia = x.TotalExistencia,
               Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria = x.Categoria.Nombre,
               UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida = x.UnidadMedida.Nombre
            
        }).ToList();
            if (dgProdctos.Rows.Count  == 0)
            {
                mostrarProducto();
            }
       

        }

        private void txtNofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar ==(char)Keys.Enter) {
                btnBuscar.PerformClick();
            }
        }

        private void btnTotatizar_Click(object sender, EventArgs e)
        {
            List < Producto >productos =  _productoHelp.Queryable.Where(x => x.CategoriaId == categoria).AsEnumerable().Select(x => new Producto  {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = x.Costo,
                Precio = x.Precio,
                Existencias = x.Existencias,
                RutaImagen = x.RutaImagen,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria =x.Categoria ,
                UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida =x.UnidadMedida             }).ToList(); 
            List<ReportDataSource> reportDataSources = new List<ReportDataSource>();
            reportDataSources.Add(new ReportDataSource{ Name = "Productos",
                                                        Value = categoria != 0 ? productos.Where(x => x.CategoriaId == categoria)
                                                                                          .ToList() : productos}
            );
            List<Empresa> empresas = new List<Empresa>();
            empresas.Add(Empresa);
            reportDataSources.Add(new ReportDataSource { Name = "Empresa", Value = empresas });

            frmReporte frmVistaPrevia = new frmReporte
            {
                ruta =Application .StartupPath + "\\Reportes\\ExistenciasProdocto.rdlc",
                ReportDataSources = reportDataSources ,
                WindowState =  FormWindowState.Maximized 
                
            };
            frmVistaPrevia.Show();

        }
    }
}
