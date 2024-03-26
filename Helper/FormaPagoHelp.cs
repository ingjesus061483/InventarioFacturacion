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
    public class FormaPagoHelp:Help
    {
        
        public FormaPagoHelp(InventarioDbContext context)
        {
            _context = context;
        }
     public  IQueryable<FormaPago> Queryable 
        {
            get
            {
                return _context.FormaPagos .AsQueryable();
            }
        }

       

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
