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
    public class DevolucionCompraHelp :IHelp<DevolucionCompra>
    {
        readonly InventarioDbContext _context;
        IQueryable<DevolucionCompra> IHelp<DevolucionCompra>.Queryable => throw new NotImplementedException();
        public DevolucionCompraHelp(InventarioDbContext context)
        {
            _context = context;
        }
        
        public void Guardar(DevolucionCompra devolucionCompra)
        {
            
            _context.DevolucionCompras .Add(devolucionCompra );
            _context.SaveChanges();
        }

        public void Actualizar(int id, DevolucionCompra entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Validar(DevolucionCompra entity)
        {
            throw new NotImplementedException();
        }
    }
}
