using DataAccess;
using Helper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCategoria : Form
    {
        readonly CategoriaHelp _context;
        Dictionary<string, object> collection;
        string message = "";       
        private Categoria categoria;
        public frmCategoria(CategoriaHelp  context)
        {
            _context = context;
            InitializeComponent();
        }
        void Nuevo()
        {
            categoria = null;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Focus();
        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre .Text ))
            {
                MessageBox.Show("Este campo no puede ser vacio", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            collection = new Dictionary<string, object>
            {
                { "nombre", txtNombre.Text },
                { "descripcion", txtDescripcion.Text }
            };            
            if (categoria==null)
            {
                _context.Guardar(collection);// Categorias.Add(categoria);
                message = "la categoria ha sido guardada";
                
            }
            else
            {
                _context.Actualizar(categoria.Id, collection);
            
                message = "la categoria ha sido editada";


            }
            MessageBox.Show(message, "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            categoria = null;

            Nuevo();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //     string query=  _context.Categorias.AsQueryable().ToString();    
       //     DataTable dt = _context .Table ;
            frmBusqueda frmBusqueda = new frmBusqueda(_context                );
            frmBusqueda.ShowDialog();
            int id = frmBusqueda.Id;
            categoria = _context.Queryable.Where(x=>x.Id == id).FirstOrDefault();
            if (categoria == null)
            {
                Nuevo();
                return;
            }
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(categoria==null)
            {
                MessageBox.Show("Debe seleccionar una categoria", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             var resp=MessageBox.Show("Desea elminar esta categoria", "",
                 MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (resp==DialogResult.Yes)
            {
                _context.Eliminar  (categoria.Id );

                MessageBox.Show("La categoria fue eliminada", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Nuevo();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
