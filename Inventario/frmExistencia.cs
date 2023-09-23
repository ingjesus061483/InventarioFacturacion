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
    public partial class frmExistencia : Form
    {
        public Producto producto { get; set; }
        ExistenciaHelp _ExistenciaHelp;
        public frmExistencia(ProductoHelp productoHelp ,ExistenciaHelp existenciaHelp )
        {
            InitializeComponent();
            _ExistenciaHelp = existenciaHelp;


        }    


 
        private void frmExistencia_Load(object sender, EventArgs e)
        {
            if( producto != null)
            {
                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtCosto.Text = producto.Costo.ToString ();
                 

            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtcantidad.Text, out decimal decCantidad);
            if(producto==null)
            {
                MessageBox.Show("Escoge el producto antes de realizar esta operacion", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }
            Existencia existencia = new Existencia
            {
                ProductoId =producto !=null? producto.Id:0,
                Cantidad = decCantidad,
                Entrada =true,
                Fecha = DateTime.Now,
                Concepto = producto != null ? "Entrada " + producto.Nombre:""
            };
            _ExistenciaHelp.GuardarExistencias(existencia);
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        

   
    }
}
