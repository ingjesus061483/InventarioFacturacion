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
    public class EmpresaHelp : IHelp<EmpresaDTO>
    {
        readonly InventarioDbContext _context;

        public EmpresaHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<EmpresaDTO> Queryable
        {
            get
            {
                return (from empresa in _context.Empresas 
                        join tipoRegimen in _context.TipoRegimens  on empresa.TipoRegimenId  equals tipoRegimen .Id 
                        select new EmpresaDTO 
                        {
                            Id = empresa. Id,
                            Nit = empresa.Nit,
                            Nombre = empresa. Nombre,
                            CamaraComercio = empresa.CamaraComercio ,
                            Direccion = empresa.Direccion ,
                            Telefono = empresa.Telefono ,
                            Email = empresa.Email ,
                            Contacto = empresa.Contacto ,
                            Logo = empresa.Logo,
                            Slogan = empresa.Slogan ,
                            TipoRegimenId = empresa.TipoRegimenId ,
                            TipoRegimen= tipoRegimen
                        });
            }
        }
        public Empresa BuscarEmpresa(int id)
        {
            return Queryable .Where (x=>x.Id== id).AsEnumerable().Select(x=>new Empresa
            {
                Id = x.Id,
                Nit = x.Nit,
                Nombre = x.Nombre,
                CamaraComercio = x.CamaraComercio,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                Contacto = x.Contacto,
                Logo = x.Logo,
                Slogan = x.Slogan,
                TipoRegimenId = x.TipoRegimenId,
                TipoRegimen =x. TipoRegimen

            }).FirstOrDefault()           ;

        }
        public Empresa BuscarEmpresa(string nit)
        {

            return Queryable.Where(x => x.Nit == nit).AsEnumerable().Select(x => new Empresa
            {
                Id = x.Id,
                Nit = x.Nit,
                Nombre = x.Nombre,
                CamaraComercio = x.CamaraComercio,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Email = x.Email,
                Contacto = x.Contacto,
                Logo = x.Logo,
                Slogan = x.Slogan,
                TipoRegimenId = x.TipoRegimenId,
                TipoRegimen = x.TipoRegimen

            }).FirstOrDefault();
        }
        public void Guardar(EmpresaDTO empresaDTO) 
        {   
            if (!Validar(empresaDTO))
            {
                return;
            }
            Empresa empresa = new Empresa
            {                
                Nit = empresaDTO.Nit,
                Nombre = empresaDTO.Nombre,
                CamaraComercio = empresaDTO.CamaraComercio,
                Direccion = empresaDTO.Direccion,
                Telefono = empresaDTO.Telefono,
                Email = empresaDTO.Email,
                Contacto = empresaDTO.Contacto,
                Logo = empresaDTO.Logo,
                Slogan = empresaDTO.Slogan,
                TipoRegimenId = empresaDTO.TipoRegimenId
            };
            _context.Empresas.Add(empresa);
            _context.SaveChanges();

            Utilities .GetDialogResult ("La empresa ha sido guardada", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Actualizar(int id, EmpresaDTO Empresa)
        {
            if (!Validar(Empresa))
            {
                return;
            }
            var empresa = BuscarEmpresa(id);
            empresa.Nombre = Empresa.Nombre;
            empresa.CamaraComercio = Empresa.CamaraComercio;
            empresa.Direccion = Empresa.Direccion;
            empresa.Telefono = Empresa.Telefono;
            empresa.Email = Empresa.Email;
            empresa.Contacto = Empresa.Contacto;
            empresa.Logo = Empresa.Logo;
            empresa.Slogan = Empresa.Slogan;
            empresa.TipoRegimenId = Empresa.TipoRegimenId;
            _context.SaveChanges();
            Utilities.GetDialogResult("La empresa ha sido Actualizada", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Eliminar(int id)
        {
            var empresa = BuscarEmpresa(id);
            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
        }
        bool Validar(EmpresaDTO empresa)
        {

            if (string.IsNullOrEmpty(empresa.Nit))
            {
                Utilities .GetDialogResult ("El campo Nit no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;

            }
            if (string.IsNullOrEmpty(empresa. Nombre))
            {
            Utilities .GetDialogResult ("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (empresa. TipoRegimenId == -1)
            {
                Utilities .GetDialogResult ("El campo tipo regimen no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(empresa.Direccion))
            {
                Utilities .GetDialogResult ("El campo Direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;
            }
            if (string.IsNullOrEmpty( empresa. CamaraComercio))
            {
                Utilities .GetDialogResult ("El campo camara de comercio no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Email))
            {
                Utilities .GetDialogResult ("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (!Utilities . EmailBienEscrito(empresa. Email))
            {
                Utilities .GetDialogResult ("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Contacto))
            {
                Utilities .GetDialogResult ("El campo cotacto no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Telefono))
            {
                Utilities .GetDialogResult ("El campo telefono no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            return true;
        }      
    }
}
