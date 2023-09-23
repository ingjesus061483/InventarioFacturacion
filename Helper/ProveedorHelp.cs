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
    public class ProveedorHelp:Help 
    {
        
        public ProveedorHelp(InventarioDbContext context  )
        {
            _context = context;
        }
        IQueryable queryable
        {
            get
            {
                return (from prov in _context.Proveedors 
                        join tipo in _context.TipoIdentificacions on prov.TipoIdentificacionId equals tipo.Id
                        select new
                        {
                            prov.Id,
                            prov .Identificacion,
                            prov .Nombre,
                            prov .Apellido,
                            prov .Direccion,
                            prov .Telefono,
                            prov.Email,
                            prov.PersonaNatural ,
                            prov .TipoIdentificacionId,
                            prov .TipoIdentificacion
                        });
            }
        }
        public override  DataTable Table
        {
            get
            {
                return _context.GetDataTable(queryable.ToString());
            }
        }
        public Proveedor BuscarProveedor(int id)
        {
            return _context.Proveedors.Find(id);
        }
        public Proveedor BuscarProveedor(string identificacion)
        {
            return _context.Proveedors.Where(x => x.Identificacion == identificacion)
                                    .FirstOrDefault();
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
