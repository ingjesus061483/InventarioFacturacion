using DataAccess;
using Helper.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public class ProveedorHelp:IHelp <ProveedorDTO>
    {
        readonly InventarioDbContext _context;

        public ProveedorHelp(InventarioDbContext context  )
        {
            _context = context;
        }
       public  IQueryable<ProveedorDTO> Queryable
        {
            get
            {
                return (from prov in _context.Proveedors 
                        join tipo in _context.TipoIdentificacions on prov.TipoIdentificacionId equals tipo.Id
                        select new ProveedorDTO
                        {
                            Id = prov.Id,
                           Identificacion = prov .Identificacion,
                           Nombre= prov .Nombre,
                            Apellido = prov.Apellido,
                            Direccion = prov.Direccion,
                            Telefono = prov.Telefono,
                            Email = prov.Email,
                            PersonaNatural = prov.PersonaNatural ,
                            TipoIdentificacionId = prov.TipoIdentificacionId,
                            TipoIdentificacion = prov.TipoIdentificacion
                        });
            }
        }
   
        public Proveedor BuscarProveedor(int id)
        {
            return Queryable.Where(x=> x.Id==id).AsEnumerable ().Select(x=>new Proveedor {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault() ;
        }
        public Proveedor BuscarProveedor(string identificacion)
        {
            return Queryable.Where(x => x.Identificacion  == identificacion ).AsEnumerable().Select(x => new Proveedor
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault();
        }
        public void Guardar(ProveedorDTO Proveedor)
        {
            if (!Validar(Proveedor))
            {
                return;
            }
            var prov = new Proveedor
            {
                Identificacion=Proveedor .Identificacion ,
                Nombre = Proveedor.Nombre,
                Apellido = Proveedor.Apellido,
                Direccion = Proveedor.Direccion,
                Telefono = Proveedor.Telefono,
                Email = Proveedor.Email,
                TipoIdentificacionId = Proveedor.TipoIdentificacionId
            };
            _context.Proveedors.Add(prov );
            _context.SaveChanges();
            Utilities.GetDialogResult ("El Proveedor ha sido guardado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Actualizar(int id, ProveedorDTO Proveedor)
        {
            if (!Validar(Proveedor))
            {
                return;
            }
            var prov = BuscarProveedor(id);
            prov.Nombre = Proveedor.Nombre;
            prov.Apellido = Proveedor.Apellido;
            prov.Direccion = Proveedor.Direccion;
            prov.Telefono = Proveedor.Telefono;
            prov.Email = Proveedor.Email;
            prov.TipoIdentificacionId = Proveedor.TipoIdentificacionId;
            _context.SaveChanges();

            Utilities.GetDialogResult ("El Proveedor ha sido actualizado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Eliminar(int id)
        {
            var Proveedor = BuscarProveedor(id);
            _context.Proveedors.Remove(Proveedor);
            _context.SaveChanges();

        }
        bool Validar(ProveedorDTO Proveedor)
        {
            if (string.IsNullOrEmpty(Proveedor.Identificacion))
            {
                Utilities .GetDialogResult ("El campo identificacion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(Proveedor.Nombre))
            {
                Utilities.GetDialogResult ("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;

            }
            if (string.IsNullOrEmpty(Proveedor.Direccion))
            {
                Utilities .GetDialogResult ("El campo direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (string.IsNullOrEmpty(Proveedor.Telefono))
            {
                Utilities.GetDialogResult("El campo telefono no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrEmpty(Proveedor.Email))
            {
                Utilities.GetDialogResult("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (!Utilities . EmailBienEscrito(Proveedor.Email))
            {
                Utilities.GetDialogResult("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (Proveedor.TipoIdentificacionId == -1)
            {
                Utilities.GetDialogResult("Debe seleccionar un valor para el campo  tipoidentificacion ", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
