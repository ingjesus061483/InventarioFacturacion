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
    public class UsuarioHelp:Help 
    {        
        public Usuario Login { get; set; }
        public UsuarioHelp(InventarioDbContext context)
        {
            _context = context;
        }
        IQueryable queryable
        {
            get
            {
                return (from us in _context.Usuarios
                        join emp in _context.Empresas
                        on us.EmpresaId equals emp.Id
                        join role in _context.Roles on
                        us.RoleId equals role.Id
                        select new
                        {
                            us.Id,
                            us.Name,
                            us.Email,
                            us.Password,
                            emp,
                            role
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
        public Usuario BuscarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            return usuario;
        }
        public Usuario BuscarUsuario(string name)
        {
            var usuario = _context.Usuarios.Where(x => x.Name == name).FirstOrDefault ();
            return usuario;
        }
        public void GuardarUsuario(Usuario usuario)
        {
            if(!Validar(usuario ))
            {
                return;
            }
            usuario.Password = Encriptar(usuario.Password);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
        bool Validar(Usuario usuario )
        {
            if(string .IsNullOrEmpty (  usuario .Name ))
            {
                MessageBox.Show("El nombre del usuario es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string .IsNullOrEmpty ( usuario .Email))
            {
                MessageBox.Show("El email es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!EmailBienEscrito( usuario.Email ))
            {
                MessageBox.Show("El email no esta escrito correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string .IsNullOrEmpty ( usuario .Password))
            {
                MessageBox.Show("El password es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(usuario .RoleId == -1)
            {
                MessageBox.Show("El role es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(usuario .EmpresaId ==-1)
            {
                MessageBox.Show("La empresa es obligatoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public string Encriptar(string password)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public Usuario login(string name ,string password)
        {
            var pass = Encriptar(password);
            var usu = (from us in _context.Usuarios
                           join emp in _context.Empresas
                           on us.EmpresaId equals emp.Id
                           join role in _context.Roles on
                           us.RoleId equals role.Id
                           select new
                           {
                               Id = us.Id,
                               Name = us.Name,
                               Email = us.Email,
                               Password = us.Password,
                               Empresa = emp,
                               Role = role,
                               Empleados = _context.Empleados.Where(x => x.UsuarioId == us.Id).ToList(),
                               EmpresaId = emp.Id,
                               RoleId = role.Id
                           })
                           .Where(x => x.Name == name && x.Password == pass)
                           .FirstOrDefault();
            Usuario usuario = null;
            if (usu != null)
            {
                usuario = new Usuario
                {  
                    Id = usu.Id,
                    Name = usu.Name,
                    Email = usu.Email,
                    Password = usu.Password,
                    Empresa = usu.Empresa,
                    Role = usu.Role,
                    Empleados = usu .Empleados ,
                    EmpresaId = usu.EmpresaId,
                    RoleId = usu.RoleId
                };
            }
            return usuario;
        }
        public void ActualizarUsuario(int id, Usuario usuario)
        {
            var us = BuscarUsuario(id);
            us.Password = Encriptar(usuario.Password);
            us.EmpresaId = usuario.EmpresaId;
            us.RoleId = usuario.RoleId;
            _context.SaveChanges();
        }
        public void EliminarUsuario(int id)
        {
            Usuario usuario = BuscarUsuario(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
