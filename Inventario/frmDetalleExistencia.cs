using Helper;
using Inventario.UserControls;
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
using Newtonsoft.Json;
using Helper.DTO;

namespace Inventario
{
    public partial class frmDetalleExistencia : Form
    {
        public ProductoDTO Producto { get; set; }
        ExportarHelp _ImpExpHelp;
        ExistenciaHelp _existenciaHelp;
        DataSet Db;

        public frmDetalleExistencia(ExistenciaHelp existenciaHelp,ExportarHelp impExpHelp )
        {
            _ImpExpHelp = impExpHelp;
            _existenciaHelp = existenciaHelp;
            InitializeComponent();
            Entradas.DataSource += Entradas_DataSource;
            Salidas.DataSource += Salidas_DataSource;
        }

        private void Salidas_DataSource(object sender, EventArgs e)
        {
            
        }

        private void Entradas_DataSource(object sender, EventArgs e)
        {
            
        }

        void Llenar()
        {
            Db = new DataSet();
            var entradas = Producto.Entradas.Select(x => new {
               x.Id,
                x.Fecha ,
                x.Cantidad ,
                x.Entrada,
                x.Concepto ,
               Producto= Producto.Nombre,
            }).ToList();
            var salidas = Producto.Salidas.Select(x => new
            {
                x.Id,
                x.Fecha,
                x.Cantidad,
                x.Entrada,
                x.Concepto,
                x.ProductoId ,
                Producto = Producto.Nombre,
            }).ToList();
            Entradas.MostrarDatos( entradas  );
            Salidas. MostrarDatos ( salidas);
            txtCategoria.Text = Producto.Categoria.Nombre;
            txtCodigo.Text = Producto.Codigo;
            txtNombre.Text = Producto.Nombre;
            txtCosto.Text = Producto.Costo.ToString();
            txtPrecio.Text = Producto.Precio.ToString();
            txtUnidaMedida.Text = Producto.UnidadMedida.Nombre;
            pbImagen .SizeMode = PictureBoxSizeMode.StretchImage; //establecemos como se visualiza la imagen
            pbImagen.Load(Producto.RutaImagen);


            txtTotalEntrada.Text = Producto.TotalEntrada.ToString();
            txtToalSalida.Text = Producto.TotalSalida.ToString();
            txtTotalExistencia.Text = Producto.TotalExistencia.ToString();
        }

        private void frmDetalleExistencia_Load(object sender, EventArgs e)
        {
            if (Producto==null)
            {
                this.Close();
                
            }
            Llenar();

        }

        private void Entradas_Load(object sender, EventArgs e)
        {
            Cuestas cuestas = (Cuestas)sender;
            cuestas.ExistenciaHelp =_existenciaHelp;
        }

        private void Salidas_Load(object sender, EventArgs e)
        {
            Cuestas cuestas = (Cuestas)sender;
            cuestas.ExistenciaHelp = _existenciaHelp;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            
            var entradas = Producto.Entradas.Select(x => new {
                x.Id,
                x.Fecha,
                x.Cantidad,
                x.Entrada,
                x.Concepto,
                Producto = Producto.Nombre,
            }).ToList();
            var salidas = Producto.Salidas.Select(x => new
            {
                x.Id,
                x.Fecha,
                x.Cantidad,
                x.Entrada,
                x.Concepto,
                x.ProductoId,
                Producto = Producto.Nombre,
            }).ToList();           
            Db.Tables.Add(Utilities .GetTable(entradas));
            Db.Tables.Add(Utilities .GetTable(salidas));
            _ImpExpHelp.Create (Db);
            Db.Tables.Clear();
        }
    }
}
