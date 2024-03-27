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

namespace Inventario
{
    public partial class frmDetalleExistencia : Form
    {
        public Producto producto { get; set; }
        ExistenciaHelp _existenciaHelp;
        DataSet Db;
        public frmDetalleExistencia(ExistenciaHelp existenciaHelp )
        {
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
            Entradas.MostrarDatos( producto.Entradas  );
            Salidas. MostrarDatos ( producto.Salidas);
            txtCategoria.Text = producto.Categoria.Nombre;
            txtCodigo.Text = producto.Codigo;
            txtNombre.Text = producto.Nombre;
            txtCosto.Text = producto.Costo.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtUnidaMedida.Text = producto.UnidadMedida.Nombre;
            pbImagen.Load(producto.RutaImagen);


            txtTotalEntrada.Text = producto.TotalEntrada.ToString();
            txtToalSalida.Text = producto.TotalSalida.ToString();
            txtTotalExistencia.Text = producto.TotalExistencia.ToString();
        }

        private void frmDetalleExistencia_Load(object sender, EventArgs e)
        {
            if (producto!=null)
            {
                Llenar();
            }
            
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
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(producto.Entradas );
            DataTable pDt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(json);
            Db.Tables.Add(pDt);

            Db.Tables.Add(Entradas.Table);
            Db.Tables.Add(Salidas.Table);
            _existenciaHelp.ExportarDatos(Db);

        }
    }
}
