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
    public class TipoRegimenHelp:IHelp<TipoRegimen >
    {
        readonly InventarioDbContext _context;
        public TipoRegimenHelp(InventarioDbContext context )
        {
            _context = context;
        }
        public IQueryable<TipoRegimen> Queryable
        {
            get
            {
                return _context.TipoRegimens.AsQueryable();            
            }
        }
        public void Actualizar(int id, TipoRegimen entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoRegimen entity)
        {
            throw new NotImplementedException();
        }

        public bool Validar(TipoRegimen entity)
        {
            throw new NotImplementedException();
        }
    }
}
