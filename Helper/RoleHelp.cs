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
    public class RoleHelp:IHelp<Role>
    {
        readonly InventarioDbContext _context;
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
        public void  Guardar(Role role)
        {
            if (!Validar (role))
            {
                return;
            }
                _context.Roles.Add(role);
            _context.SaveChanges();
        }
        public void  Actualizar(int id ,Role rol)
        {            
            if (!Validar(rol))
            {
                return;
            }
            var role = BuscarRole(id);
            role.Nombre = rol.Nombre;
            role.Descripcion = rol.Descripcion;
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            var role = BuscarRole(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
        }

        public bool Validar(Role entity)
        {
            if (string.IsNullOrEmpty(entity .Nombre ))
            {
                Utilities.GetDialogResult("Este campo no puede ser vacio", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }
            return true;
        }
    }
}
