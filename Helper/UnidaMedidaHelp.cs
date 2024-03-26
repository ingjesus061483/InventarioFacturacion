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
    public class UnidaMedidaHelp:Help
    {
        
        public UnidaMedidaHelp (InventarioDbContext context )
        {
            _context = context;
        }
        public  IQueryable <UnidadMedida> Queryable
        {
            get
            {
                return _context.UnidadMedidas.AsQueryable();
            }
        }
 
        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
  
    }
}
