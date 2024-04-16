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
    public class CategoriaHelp:IHelp<Categoria >
    {
        readonly   InventarioDbContext _context;
        public CategoriaHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable <Categoria> Queryable
        {
            get
            {
                return _context.Categorias;
            }
        }
        

        public void Guardar( Categoria categoria )            
        {
            if (!Validar(categoria ))
            {
                return;
            }
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }
        public  void Actualizar(int id, Categoria categoria )
        {
            if (!Validar(categoria))
            {
                return;
            }

            var category =Queryable.Where(x=>x.Id == id).FirstOrDefault();
            category.Nombre =categoria .Nombre;
            category.Descripcion = categoria .Descripcion;
            _context.SaveChanges();

        }
        public void  Eliminar(int id)
        {
            var categoria = Queryable.Where(x => x.Id == id).FirstOrDefault();
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }

        public bool Validar(Categoria entity)
        {
            if (string.IsNullOrEmpty(entity .Nombre ))
            {
                Utilities .GetDialogResult ("Este campo no puede ser vacio", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }
            return true;
        }
    }
}
