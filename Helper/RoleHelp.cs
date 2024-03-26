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
    public class RoleHelp:Help
    {
        public RoleHelp(InventarioDbContext context  )
        {
            _context = context;

        }
        public IQueryable<Role>  Queryable 
        {
            get
            {
                return _context.Roles.AsQueryable();
            }
        }
  
     
        public Role BuscarRole(int id)
        {
            return _context.Roles.Find(id);
        }
        public void  GuardarRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }
        public void  ActualizarRole(int id ,Role rol)
        {
            var role = BuscarRole(id);
            role.Nombre = rol.Nombre;
            role.Descripcion = rol.Descripcion;
            _context.SaveChanges();
        }
        public void EliminarRole(int id)
        {
            var role = BuscarRole(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
