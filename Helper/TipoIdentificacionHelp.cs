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
    public class TipoIdentificacionHelp:IHelp<TipoIdentificacion >
    {
        readonly InventarioDbContext _context;


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

        public void Actualizar(int id, TipoIdentificacion entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoIdentificacion entity)
        {
            throw new NotImplementedException();
        }
    }
}
