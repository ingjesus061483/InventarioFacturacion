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
    public class EstadoHelp : IHelp<Estado>
    {
        readonly InventarioDbContext _context;

        public EstadoHelp(InventarioDbContext context )
        {
            _context = context;

        }
      public   IQueryable <Estado> Queryable 
        {
            get
            {
                return _context.Estados.AsQueryable();
            } 
        }

        public void Actualizar(int id, Estado entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Estado entity)
        {
            throw new NotImplementedException();
        }
    }
}
