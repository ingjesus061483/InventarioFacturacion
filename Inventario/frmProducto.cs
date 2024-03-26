using DataAccess;
using Helper;
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
    public partial class frmProducto : Form
    {
        string ruta;
        public int CategoriaId { get; set; }
        CategoriaHelp _categoriaContext;
        UnidaMedidaHelp _UnidaMedidaContext;
        ExistenciaHelp  _existenciaHelp ;
        ProductoHelp _context;
public Producto Producto { get; set; }
        public frmProducto(ProductoHelp context,CategoriaHelp categoriaContext,
                            UnidaMedidaHelp unidaMedidaContext,
                            ExistenciaHelp existenciaHelp  )
        {

            InitializeComponent();
            _existenciaHelp  = existenciaHelp ;
            _categoriaContext = categoriaContext;
            _UnidaMedidaContext = unidaMedidaContext ;
            _context = context;
        }
  
        private void frmArticulo_Load(object sender, EventArgs e)
        {            
            _categoriaContext.Cmb(cmbCategoria,_categoriaContext.Queryable .ToList ());
           _UnidaMedidaContext. Cmb(cmbUnidadMedida,_UnidaMedidaContext.Queryable .ToList());
   
            if( Producto==null)
            {
                Nuevo();
            }
            else
            {
                Cargar();
            }
            if (CategoriaId != 0)
            {
                cmbCategoria.SelectedValue = CategoriaId;
                txtCodigo.Focus();
            }
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ruta =_context . CargarImagen(PictureBox1);
        }

        private void Cargar()
        {
            txtCodigo.Text = Producto.Codigo;
            txtNombre.Text = Producto.Nombre;
            txtCosto.Text = Producto.Costo.ToString();
            txtPrecio.Text = Producto.Precio.ToString();
            txtDescripcion.Text = Producto.Descripcion;
            txtExistencia.Text = Producto.TotalExistencia.ToString();
            ruta = Producto.RutaImagen;        
            cmbCategoria.SelectedValue= Producto.CategoriaId;
            cmbUnidadMedida.SelectedValue = Producto.UnidadMedidaId;
            txtExistencia.Text = Producto.TotalExistencia.ToString();
            if (!string.IsNullOrEmpty(ruta))
            {
                PictureBox1.Load(ruta);
            }
        }
        void Nuevo()
        {
            Producto = null;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtExistencia.Text = string.Empty;
            PictureBox1.Image = null;
            ruta = "";
            cmbCategoria.SelectedIndex = -1;
            cmbUnidadMedida.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtCosto.Text, out decimal costo);
            decimal.TryParse(txtPrecio.Text, out decimal precio);
            decimal.TryParse(txtExistencia.Text, out decimal existencia);

            if (Producto == null)
            {
                Producto = new Producto
                {
                    RutaImagen = ruta,
                    CategoriaId = cmbCategoria.SelectedValue != null ? int.Parse(cmbCategoria.SelectedValue.ToString()) : -1,
                    UnidadMedidaId = cmbUnidadMedida.SelectedValue != null ? int.Parse(cmbUnidadMedida.SelectedValue.ToString()) : -1,
                    Costo = costo,
                    Codigo = txtCodigo.Text,
                    Precio = precio,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };
                _context.guardarProducto(Producto);
            }
            else
            {
                Producto.RutaImagen = ruta;
                Producto.CategoriaId = int.Parse(cmbCategoria.SelectedValue.ToString());
                Producto.UnidadMedidaId = int.Parse(cmbUnidadMedida.SelectedValue.ToString());
                Producto.Costo = costo;
                Producto.Precio = precio;
                Producto .Nombre = txtNombre.Text;
                Producto .Descripcion = txtDescripcion.Text;        
                _context .ActualizarProducto(Producto.Id,Producto ) ;
            }
            this.Close();
        }

 

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
