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
    public class EmpleadoHelp:Help
    {
        public EmpleadoHelp(InventarioDbContext context)
        {
            _context = context;
        }
        IQueryable queryable
        {
            get
            {
                return (from empl in _context.Empleados
                        join tipo in _context.TipoIdentificacions
                        on empl.TipoIdentificacionId equals tipo.Id
                        join us in _context.Usuarios on empl.UsuarioId equals us.Id
                        join empresa in _context.Empresas on us.EmpresaId equals empresa.Id
                        join role in _context.Roles on us.RoleId equals role.Id
                        select new
                        {
                            empl.Id,
                            empl.TipoIdentificacionId,
                            empl.TipoIdentificacion,
                            empl.Identificacion,
                            empl.Nombre,
                            empl.Apellido,
                            empl.Direccion,
                            empl.Telefono,
                            us,
                            role,
                            empresa
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

        public Empleado BuscarEmpleado(int id)
        {
            var empleado = _context.Empleados.Find(id);
            if (empleado != null)
            {
                empleado.Usuario = _context.Usuarios.Find(empleado.UsuarioId);
                empleado.Usuario.Role = _context.Roles.Find(empleado.Usuario.RoleId);
                empleado.Usuario.Empresa = _context.Empresas.Find(empleado.Usuario.EmpresaId);
            }
            return empleado;
        }
        public Empleado BuscarEmpleado(string identificacion)
        {
         Empleado  empleado = _context.Empleados.Where(x=>x.Identificacion ==identificacion ).FirstOrDefault ();
            if (empleado != null)
            {
                empleado.Usuario = _context.Usuarios.Find(empleado.UsuarioId);
                empleado.Usuario.Role = _context.Roles.Find(empleado.Usuario.RoleId);
                empleado.Usuario.Empresa = _context.Empresas.Find(empleado.Usuario.EmpresaId);
            }
            return empleado;
        }
        public void GuadarEmpleado (Empleado empleado)
        {
            if(!Validar (empleado ))
            {
                return;
            }
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }
        bool Validar(Empleado empleado)
        {
            if ( string.IsNullOrEmpty ( empleado .Nombre))
            {
                MessageBox.Show("El nombre es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string .IsNullOrEmpty (empleado.Apellido))
            {
                MessageBox.Show("El apellido es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty (empleado .Direccion))
            {
                MessageBox.Show("La direccion es obligatoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string .IsNullOrEmpty (empleado.Telefono))
            {
                MessageBox.Show("El telefono es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (empleado .TipoIdentificacionId ==-1)
            {
                MessageBox.Show("El tipo identificacion es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(empleado.UsuarioId == -1)
            {
                MessageBox.Show("El usuario es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void ActualizarEmpleado(int id ,Empleado  empleado )
        {
            if(! Validar(empleado ))
            {
                return;
            }
            var empl = BuscarEmpleado(id);
            empl.Nombre=empleado .Nombre ;
            empl.Apellido = empleado.Apellido;
            empl.Direccion = empleado.Direccion;
            empl.Telefono = empleado.Telefono;
            empl.TipoIdentificacionId = empleado.TipoIdentificacionId;
            _context.SaveChanges();

        }
        public void EliminarEmpleado(int id)
        {
            var empl = BuscarEmpleado(id);
            _context.Empleados.Remove(empl);
            _context.SaveChanges();


        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
