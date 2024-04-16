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
    public class ClienteHelp:IHelp<ClienteDTO>
    {
        readonly  InventarioDbContext _context;
        public ClienteHelp (InventarioDbContext context)
        {
            _context = context;
        }
        public  IQueryable<ClienteDTO>   Queryable
        {
            get
            {
                return (from cli in _context.Clientes
                        join tipo in _context.TipoIdentificacions
                        on cli.TipoIdentificacionId equals tipo.Id
                        select new ClienteDTO
                        {
                            Id = cli.Id,
                            Identificacion = cli.Identificacion,
                            Nombre = cli.Nombre,
                            Apellido = cli.Apellido,
                            Direccion = cli.Direccion,
                            Telefono = cli.Telefono,
                            Email = cli.Email,
                            FechaNacimiento = cli.FechaNacimiento,
                            PersonaNatural = cli.PersonaNatural,
                            TipoIdentificacionId = cli.TipoIdentificacionId,
                            TipoIdentificacion = cli.TipoIdentificacion
                        });
                        
            }
        }
        public  void Guardar(ClienteDTO clienteDTO )
        {
            if (!Validar(clienteDTO ))
            {
                return;
            }
            Cliente cliente = new Cliente
            {
                Identificacion = clienteDTO .Identificacion,
                Nombre =clienteDTO.Nombre,
                Apellido =clienteDTO.Apellido,
                Direccion =clienteDTO .Direccion,
                Telefono =clienteDTO .Telefono,
                Email =clienteDTO .Email,
                FechaNacimiento =clienteDTO .FechaNacimiento,
                PersonaNatural= clienteDTO  .PersonaNatural,
                TipoIdentificacionId =int.Parse (clienteDTO  .TipoIdentificacionId.ToString ()),
            };
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            Utilities .GetDialogResult ("El cliente ha sido guardado", "",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Actualizar(int id, ClienteDTO collection)
        {
            if (!Validar(collection ))
            {
                return;
            }
            var cliente = Queryable.Where(x => x.Id == id).AsEnumerable().Select(x => new Cliente
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                FechaNacimiento = x.FechaNacimiento,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault(); 
            cliente.Nombre = collection.Nombre;
            cliente.Apellido = collection.Apellido;
            cliente.Direccion = collection.Direccion;
            cliente.Telefono = collection.Telefono;
            cliente.Email = collection.Email;
            cliente.FechaNacimiento = collection.FechaNacimiento;
            cliente.PersonaNatural = collection.PersonaNatural;
            cliente.TipoIdentificacionId = collection.TipoIdentificacionId;
            _context.SaveChanges();
            Utilities .GetDialogResult ("El cliente ha sido actualizado", "",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public  void Eliminar(int id)
        {
            var cliente = Queryable.Where(x => x.Id == id).AsEnumerable().Select(x => new Cliente
            {
                Id = x.Id,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                FechaNacimiento = x.FechaNacimiento,
                PersonaNatural = x.PersonaNatural,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion
            }).FirstOrDefault(); 
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

        }      
        bool Validar(ClienteDTO collection )
        {
            if (string.IsNullOrEmpty(collection.Identificacion))
            {
                Utilities .GetDialogResult ("El campo identificacion no puede ser vacio", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(collection.Nombre))
            {
                Utilities .GetDialogResult ("El campo Nombre no puede ser vacio", "",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;

            }
            if (string.IsNullOrEmpty(collection.Direccion ))
            {
                Utilities .GetDialogResult ("El campo direccion no puede ser vacio", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (string.IsNullOrEmpty(collection.Telefono))
            {
                Utilities .GetDialogResult ("El campo telefono no puede ser vacio", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                return false ;
            }

            if (string.IsNullOrEmpty(collection.Email))
            {
                Utilities .GetDialogResult ("El campo email no puede ser vacio", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (!Utilities .EmailBienEscrito(collection.Email))
            {
                Utilities .GetDialogResult ("El campo email esta mal escrito", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (collection.TipoIdentificacionId== -1)
            {
                Utilities.GetDialogResult("Debe seleccionar un valor para el campo  tipoidentificacion ", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            return true;
        }        
    }

}
