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
    public class EstadoHelp : Help
    {
        public    EstadoHelp(InventarioDbContext context )
        {
            _context = context;

        }
        IQueryable<Estado> Queryable 
        {
            get
            {
                return _context.Estados.AsQueryable();
            } 
        }

        public override DataTable Table
        {
            get
            {
                return _context.GetDataTable(Queryable.ToString());
            }
        }

        public override void GetDatagrid(System.Windows.Forms.DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
