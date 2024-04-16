using DataAccess;
using Helper.DTO;
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
    public class UsuarioHelp:IHelp <UsuarioDTO >
    {
        readonly InventarioDbContext _context;
        public UsuarioDTO Usuario { get; set; }
        public UsuarioHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public  IQueryable<UsuarioDTO > Queryable
        {
            get
            {
                return (from us in _context.Usuarios
                        join emp in _context.Empresas
                        on us.EmpresaId equals emp.Id
                        join role in _context.Roles on
                        us.RoleId equals role.Id
                        select new UsuarioDTO
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
                        });

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
        public void Guardar(UsuarioDTO usuario)
        {
            if(!Validar(usuario ))
            {
                return;
            }
            var us = new Usuario
            {
                Name = usuario.Name ,
                Email =usuario .Email ,               
                Password = Utilities.Encriptar(usuario.Password),
                EmpresaId = usuario.EmpresaId,
                RoleId = usuario.RoleId,
            };
            
            _context.Usuarios.Add(us);
            _context.SaveChanges();
        }
        public bool Validar(UsuarioDTO usuario )
        {
            if(string .IsNullOrEmpty (  usuario .Name ))
            {
              Utilities .GetDialogResult  ("El nombre del usuario es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string .IsNullOrEmpty ( usuario .Email))
            {
               Utilities .GetDialogResult ( "El email es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!Utilities . EmailBienEscrito( usuario.Email ))
            {
               Utilities.GetDialogResult( "El email no esta escrito correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string .IsNullOrEmpty ( usuario .Password))
            {
               Utilities.GetDialogResult("El password es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(usuario .RoleId == -1)
            {
                Utilities .GetDialogResult("El role es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(usuario .EmpresaId ==-1)
            {
                Utilities.GetDialogResult("La empresa es obligatoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }   
        public Usuario Login(string name ,string password)
        {
            var pass =Utilities . Encriptar(password);
            Usuario usuario = Queryable.Where(x => x.Name == name && x.Password == pass)
                                       .AsEnumerable()
                                       .Select(x => new Usuario{
                                           Id = x.Id,
                                           Name = x.Name,
                                           Email = x.Email,
                                           Password = x.Password,
                                           Empresa = x.Empresa,
                                           Role = x.Role,
                                           Empleados = x.Empleados,
                                           EmpresaId = x.EmpresaId,
                                           RoleId = x.RoleId
                                       }).FirstOrDefault();
            if (usuario != null)
            {
                usuario.Empresa.TipoRegimen = _context.TipoRegimens
                                                      .Where(x => x.Id == usuario.Empresa.TipoRegimenId)
                                                      .FirstOrDefault();                
            }
            return usuario;
        }
        public void Actualizar(int id, UsuarioDTO usuario)
        {
            var us = BuscarUsuario(id);
            us.Password =Utilities. Encriptar(usuario.Password);
            us.EmpresaId = usuario.EmpresaId;
            us.RoleId = usuario.RoleId;
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Usuario usuario = BuscarUsuario(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

    }
}
