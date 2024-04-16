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
    public class UnidaMedidaHelp:IHelp<UnidadMedida>
    {
        readonly InventarioDbContext _context;

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

        public void Actualizar(int id, UnidadMedida entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(UnidadMedida entity)
        {
            throw new NotImplementedException();
        }
    }
}
