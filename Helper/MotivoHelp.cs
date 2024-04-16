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
    public class MotivoHelp : IHelp<Motivo >
    {
        readonly InventarioDbContext _context;
        public MotivoHelp (InventarioDbContext context  )
        {
            _context = context;
        }
        public IQueryable<Motivo > Queryable 
        {
            get
            {
                return _context.Motivos.AsQueryable();
            }
        }
        public  Motivo BuscarMotivos(int id)
        {
            return _context.Motivos.Find(id);
        }
        public Motivo BuscarMotivos(string codigo)
        {
            return _context.Motivos.Where(x=>x.Codigo ==codigo ).FirstOrDefault();
        }
        public void Guardar(Motivo motivo)
        {
            if(!Validar(motivo))
            {
                return;
            }
            _context.Motivos.Add(motivo);
            _context.SaveChanges();
        }
        public void Actualizar(int id, Motivo motivo)
        {
            if (!Validar(motivo))
            {
                return;
            }
            var mot = BuscarMotivos(id);
            mot.Concepto = motivo.Concepto;
            mot.Descripcion = motivo.Descripcion;            
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            var mot = BuscarMotivos(id);
            _context.Motivos.Remove(mot);
            _context.SaveChanges();
        }
        public bool Validar(Motivo motivo)
        {
            if (string .IsNullOrEmpty ( motivo.Codigo  ))
            {
                Utilities .GetDialogResult ("El campo codigo no puede ser vacio ", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(motivo.Concepto ))
            {
               Utilities.GetDialogResult ("El campo conepto no puede ser vacio ", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(motivo.Descripcion ))
            {
                Utilities.GetDialogResult ("El campo Descripcion no puede ser vacio", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
