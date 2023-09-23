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
        public  IQueryable<Role> QueryRole
        {
            get
            {
                return _context.Roles.AsQueryable();
            }
        }
        public override  DataTable Table
        {
            get
            {
                return _context.GetDataTable(QueryRole.ToString());
            }
        }
      /*  public void Cmb(ComboBox cmb)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = dtRole;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }*/
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
