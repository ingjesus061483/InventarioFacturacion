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
    public class TipoIdentificacionHelp:Help
    {
        
        public TipoIdentificacionHelp(InventarioDbContext context)
        {
            _context = context;
        }
      public    IQueryable<TipoIdentificacion >  Queryable
        {
            get
            {
                return _context.TipoIdentificacions.AsQueryable();
            }
        }
      
 

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
