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
    public class TipoRegimenHelp:Help
    {
        
        public  TipoRegimenHelp(InventarioDbContext context )
        {
            _context = context;
        }
        IQueryable<TipoRegimen> queryable
        {
            get
            {
                return _context.TipoRegimens.AsQueryable();            
            }
        }
        public override  DataTable Table 
        {
            get
            {
                return _context.GetDataTable(queryable.ToString());
            } 
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
   
    }
}
