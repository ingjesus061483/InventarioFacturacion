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
    public class ExistenciaHelp:IHelp<Existencia>
    {
        readonly InventarioDbContext _context;

        public ExistenciaHelp (InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<Existencia> Queryable => throw new NotImplementedException();

        public void Actualizar(int id, Existencia entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Existencia>  GetExistencias(int productoId)
        {
            return  _context.Existencias.Where(x => x.ProductoId == productoId).ToList();
           
        }
        public void  Guardar(Existencia existencia)
        {
            if(!Validar(existencia ))
            {
                return;
            }
            _context.Existencias.Add(existencia);
            _context.SaveChanges();
            Utilities .GetDialogResult("Se ha guardado la existencia", "",
    MessageBoxButtons.OK, MessageBoxIcon.Information );


        }
        public bool Validar(Existencia existencia )
        {
            if (existencia.Cantidad == 0)
            {
                Utilities .GetDialogResult ("El campo existencia no puede ser vacio ni contener letras", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

      
    }
}
