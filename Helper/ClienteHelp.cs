using DataAccess;
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
        IQueryable queryable
        {
            get
            {
                return (from cli in _context.Clientes
                        join tipo in _context.TipoIdentificacions
                        on cli.TipoIdentificacionId equals tipo.Id
                        select new
                        {
                            cli.Id,
                            cli.Identificacion,
                            cli.Nombre,
                            cli.Apellido,
                            cli.Direccion,
                            cli.Telefono,
                            cli.Email,
                            cli.TipoIdentificacionId,
                            cli.TipoIdentificacion
                        });
            }
        }
        

        public override DataTable Table 
        {
            get 
            { 
                return _context.GetDataTable(queryable.ToString()); 
            }
        }

        public Cliente BuscarCliente(int id)
        {
            return _context.Clientes.Find(id);
        } 
        public Cliente BuscarCliente(string  identificacion)
        {
            return _context.Clientes.Where (x=>x.Identificacion== identificacion )
                                    .FirstOrDefault();
        }
        public void GuardarCliente(Cliente cliente)
        {
            if(!Validar(cliente ))
            {
                return;
            }
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            MessageBox.Show("El cliente ha sido guardado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void ActualizarCliente(int id,Cliente cliente)
        {
            if (!Validar(cliente))
            {
                return;
            }
            var client = BuscarCliente(id);
            client.Nombre = cliente.Nombre;
            client.Apellido = cliente.Apellido;
            client.Direccion = cliente.Direccion;
            client.Telefono = cliente.Telefono;
            client.Email = cliente.Email;
            client.TipoIdentificacionId = cliente.TipoIdentificacionId;
            _context.SaveChanges();

            MessageBox.Show("El cliente ha sido actualizado", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EliminarCliente(int id)
        {
            var cliente = BuscarCliente(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

        }
      /*  public bool EmailBienEscrito(string email)
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
        }  */
        bool Validar(Cliente cliente )
        {
            if (string.IsNullOrEmpty(cliente . Identificacion))
            {
                MessageBox.Show("El campo identificacion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(cliente . Nombre))
            {
                MessageBox.Show("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;

            }
            if (string.IsNullOrEmpty(cliente . Direccion))
            {
                MessageBox.Show("El campo direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (string.IsNullOrEmpty(cliente.  Telefono))
            {
                MessageBox.Show("El campo telefono no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                return false ;
            }

            if (string.IsNullOrEmpty(cliente . Email))
            {
                MessageBox.Show("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (!EmailBienEscrito(cliente . Email))
            {
                MessageBox.Show("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (cliente . TipoIdentificacionId== -1)
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
