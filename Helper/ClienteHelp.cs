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
    public class ClienteHelp:Help
    {
        public ClienteHelp (InventarioDbContext context)
        {
            _context = context;
        }
      public   IQueryable<ClienteDTO>   Queryable
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
                            FechaNacimiento=cli.FechaNacimiento ,
                            PersonaNatural=cli .PersonaNatural ,
                            TipoIdentificacionId = cli.TipoIdentificacionId,
                            TipoIdentificacion = cli.TipoIdentificacion
                        });
            }
        }
        

        
        public Cliente GetCliente(int id)
        {
            return Queryable.Where (x =>x.Id== id).AsEnumerable().Select(x=>new Cliente {
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
            }).FirstOrDefault() ;
        } 
        public Cliente GetCliente(string  identificacion)
        {
            return Queryable.Where(x => x.Identificacion  ==identificacion ).AsEnumerable().Select(x => new Cliente
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
        }
        public void Guardar(Dictionary<string, object> collection)
        {
            if (!Validar(collection))
            {
                return;
            }
            Cliente cliente = new Cliente
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido =collection ["Apellido"].ToString(),
                Direccion =collection["Direccion"].ToString(),
                Telefono = collection["Telefono"].ToString(),
                Email =collection["Email"].ToString(),
                FechaNacimiento =(DateTime )collection["FechaNacimiento"],
                PersonaNatural=(bool)collection["PersonaNatural"],
                TipoIdentificacionId =int.Parse (collection["TipoIdentificacionId"].ToString()),
            };
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            MessageBox.Show("El cliente ha sido guardado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Actualizar(int id, Dictionary<string, object> collection)
        {
            if (!Validar(collection ))
            {
                return;
            }
            var cliente = GetCliente(id);
            cliente.Nombre = collection["Nombre"].ToString();
            cliente.Apellido = collection["Apellido"].ToString();
            cliente.Direccion = collection["Direccion"].ToString();
            cliente.Telefono = collection["Telefono"].ToString();
            cliente.Email = collection["Email"].ToString();
            cliente.FechaNacimiento = (DateTime)collection["FechaNacimiento"];
            cliente.PersonaNatural = (bool)collection["PersonaNatural"];
            cliente.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            _context.SaveChanges();

            MessageBox.Show("El cliente ha sido actualizado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Eliminar(int id)
        {
            var cliente = GetCliente(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

        }
      
        bool Validar(Dictionary<string, object> collection )
        {
            if (string.IsNullOrEmpty(collection ["Identificacion"].ToString ()))
            {
                MessageBox.Show("El campo identificacion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(collection["Nombre"].ToString()))
            {
                MessageBox.Show("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;

            }
            if (string.IsNullOrEmpty(collection["Direccion"].ToString()))
            {
                MessageBox.Show("El campo direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (string.IsNullOrEmpty(collection["Telefono"].ToString ()))
            {
                MessageBox.Show("El campo telefono no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                return false ;
            }

            if (string.IsNullOrEmpty(collection["Email"].ToString ()))
            {
                MessageBox.Show("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (!EmailBienEscrito(collection["Email"].ToString()))
            {
                MessageBox.Show("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (int.Parse(collection["TipoIdentificacionId"].ToString())== -1)
            {
                MessageBox.Show("Debe seleccionar un valor para el campo  tipoidentificacion ", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            return true;
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }

}
