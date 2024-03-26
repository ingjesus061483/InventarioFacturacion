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
    public  class ImpuestoHelp:Help
    {        
        public ImpuestoHelp(InventarioDbContext context)
        {
            _context = context;
        }

 public   IQueryable<Impuesto >  Queryable  { get { return _context.Impuestos.AsQueryable(); } }
        public Impuesto BuscarImpuesto(int id)
        {
            return _context.Impuestos.Find(id);

        }
        public  void GuardarImpuesto(Impuesto impuesto)
        {
            _context.Impuestos.Add(impuesto);
            _context.SaveChanges();
        }
        public void ActualizarImpuesto(int id, Impuesto impuesto)
        {
            var imp = BuscarImpuesto(id);
            imp.Nombre = impuesto.Nombre;
            imp.Descripcion = impuesto.Descripcion;
            imp.Valor = impuesto.Valor;
            _context.SaveChanges();        
        }
        public void EliminarImpuesto( Impuesto impuesto)
        {
            _context.Impuestos.Remove(impuesto);
            _context.SaveChanges();
        }

        public override void GetDatagrid(System.Windows.Forms.DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
