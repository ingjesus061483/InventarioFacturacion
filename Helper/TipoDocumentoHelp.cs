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
    public  class TipoDocumentoHelp:IHelp<TipoDocumento>
    {
        readonly InventarioDbContext _context;
        public TipoDocumentoHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public  IQueryable<TipoDocumento > Queryable
        {
            get
            {
                return _context.TipoDocumentos .AsQueryable();
            }
        }
        public void Actualizar(int id, TipoDocumento entity)
        {
            throw new NotImplementedException();
        }
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public void Guardar(TipoDocumento entity)
        {
            throw new NotImplementedException();
        }
    }
}
