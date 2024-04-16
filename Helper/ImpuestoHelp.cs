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
    public  class ImpuestoHelp:IHelp<Impuesto>
    {
        readonly InventarioDbContext _context;
        public ImpuestoHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<Impuesto >  Queryable  { get { return _context.Impuestos.AsQueryable(); } }
        public Impuesto BuscarImpuesto(int id)
        {
            return _context.Impuestos.Find(id);
        }
        public  void Guardar(Impuesto impuesto)
        {
            _context.Impuestos.Add(impuesto);
            _context.SaveChanges();
        }
        public void Actualizar(int id, Impuesto impuesto)
        {
            var imp = BuscarImpuesto(id);
            imp.Nombre = impuesto.Nombre;
            imp.Descripcion = impuesto.Descripcion;
            imp.Valor = impuesto.Valor;
            _context.SaveChanges();        
        }
        public void Eliminar( int id)
        {
            var imp = BuscarImpuesto(id);
            _context.Impuestos.Remove(imp);
            _context.SaveChanges();
        }

        public bool Validar(Impuesto entity)
        {
            throw new NotImplementedException();
        }
    }
}
