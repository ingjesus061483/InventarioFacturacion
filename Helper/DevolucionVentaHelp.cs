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
   public  class DevolucionVentaHelp : IHelp<DevolucionVenta>
    {
        readonly InventarioDbContext _context;
        public DevolucionVentaHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<DevolucionVenta>  Queryable => throw new NotImplementedException();

        public void Actualizar(int id, DevolucionVenta entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }


        public void Guardar(DevolucionVenta devolucionVenta)
        {
            _context.DevolucionVentas.Add(devolucionVenta);
            _context.SaveChanges();
        }
   
    }
}
