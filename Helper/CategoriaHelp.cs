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
        public CategoriaHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public  IQueryable <Categoria> Queryable
        {
            get
            {
                return _context.Categorias;
            }
        }
        public void Guardar( Dictionary <string,object>collection)
        {
            Categoria categoria = new Categoria 
            {
                Nombre=collection["nombre"].ToString(),
                Descripcion=collection["descripcion"].ToString()
            };
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }
        public void Actualizar(int id, Dictionary<string, object> collection)
        {
            var category =Queryable.Where(x=>x.Id == id).FirstOrDefault();
            category.Nombre = collection["nombre"].ToString ();
            category.Descripcion = collection ["descripcion"].ToString();
            _context.SaveChanges();

        }
        public void  Eliminar(int id)
        {
            var categoria = Queryable.Where(x => x.Id == id).FirstOrDefault();
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
