using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public class CategoriaHelp:Help
    {
        //InventarioDbContext _context;
        public CategoriaHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<Categoria> QueryCategoria
        {
            get
            {
                return _context.Categorias.AsQueryable();
            }
        }
   /*     public  void Cmb(ComboBox cmb )
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = dtCategoria;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }*/
        public override  DataTable Table
        {
            get
            {
                return _context.GetDataTable(QueryCategoria.ToString());
            }
        }
        public Categoria BuscarCategoria(int id)
        {
            var categoria = _context.Categorias.Find(id);
            return categoria;
        }
        public void GuardarCategoria(Categoria categoria )
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }
        public void ActualizarCategoria(int id ,Categoria categoria)
        {
            var category = BuscarCategoria(id);
            category.Nombre = categoria.Nombre;
            category.Descripcion = categoria.Descripcion;
            _context.SaveChanges();

        }
        public void  EliminarCategoria(int id)
        {
            var categoria = BuscarCategoria(id);
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
