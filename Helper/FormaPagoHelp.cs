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
    public class FormaPagoHelp:IHelp<FormaPago>
    {
        readonly InventarioDbContext _context;
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
        public void Actualizar(int id, FormaPago entity)
        {
            throw new NotImplementedException();
        }
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public void Guardar(FormaPago entity)
        {
            throw new NotImplementedException();
        }
    }
}
