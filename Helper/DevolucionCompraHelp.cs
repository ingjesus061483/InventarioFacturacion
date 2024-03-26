using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class DevolucionCompraHelp : Help
    {
        


        protected IQueryable Queryable => throw new NotImplementedException();

        public DevolucionCompraHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public override void GetDatagrid(System.Windows.Forms.DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
        public void GuardarDevolucion(DevolucionCompra devolucionCompra)
        {
            
            _context.DevolucionCompras .Add(devolucionCompra );
            _context.SaveChanges();
        }

    }
}
