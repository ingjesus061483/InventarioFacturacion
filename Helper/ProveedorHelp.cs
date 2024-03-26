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
    public class ProveedorHelp:Help 
    {
        
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
        public void GuardarProveedor(Proveedor Proveedor)
        {
            if (!Validar(Proveedor))
            {
                return;
            }
            _context.Proveedors.Add(Proveedor);
            _context.SaveChanges();
            MessageBox.Show("El Proveedor ha sido guardado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void ActualizarProveedor(int id, Proveedor Proveedor)
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

            MessageBox.Show("El Proveedor ha sido actualizado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EliminarProveedor(int id)
        {
            var Proveedor = BuscarProveedor(id);
            _context.Proveedors.Remove(Proveedor);
            _context.SaveChanges();

        }
    /*    public bool EmailBienEscrito(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }*/
        bool Validar(Proveedor Proveedor)
        {
            if (string.IsNullOrEmpty(Proveedor.Identificacion))
            {
                MessageBox.Show("El campo identificacion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(Proveedor.Nombre))
            {
                MessageBox.Show("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;

            }
            if (string.IsNullOrEmpty(Proveedor.Direccion))
            {
                MessageBox.Show("El campo direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (string.IsNullOrEmpty(Proveedor.Telefono))
            {
                MessageBox.Show("El campo telefono no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrEmpty(Proveedor.Email))
            {
                MessageBox.Show("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (!EmailBienEscrito(Proveedor.Email))
            {
                MessageBox.Show("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (Proveedor.TipoIdentificacionId == -1)
            {
                MessageBox.Show("Debe seleccionar un valor para el campo  tipoidentificacion ", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
