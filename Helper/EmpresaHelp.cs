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
    public class EmpresaHelp : Help
    {

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
        public void GuardarEmpresa(Empresa empresa) 
        {   
            if (!Validar(empresa))
            {
                return;
            }
            _context.Empresas.Add(empresa);
            _context.SaveChanges();

            MessageBox.Show("La empresa ha sido guardada", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ActualizarEmpresa(int id, Empresa Empresa)
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
            MessageBox.Show("La empresa ha sido Actualizada", "",
  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EliminarEmpresa(int id)
        {
            var empresa = BuscarEmpresa(id);
            _context.Empresas.Remove(empresa);
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
        bool Validar(Empresa empresa)
        {

            if (string.IsNullOrEmpty(empresa.Nit))
            {
                MessageBox.Show("El campo Nit no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;

            }
            if (string.IsNullOrEmpty(empresa. Nombre))
            {
                MessageBox.Show("El campo Nombre no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (empresa. TipoRegimenId == -1)
            {
                MessageBox.Show("El campo tipo regimen no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(empresa.Direccion))
            {
                MessageBox.Show("El campo Direccion no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false;
            }
            if (string.IsNullOrEmpty( empresa. CamaraComercio))
            {
                MessageBox.Show("El campo camara de comercio no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Email))
            {
                MessageBox.Show("El campo email no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (!EmailBienEscrito(empresa. Email))
            {
                MessageBox.Show("El campo email esta mal escrito", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Contacto))
            {
                MessageBox.Show("El campo cotacto no puede ser vacio", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return false ;
            }
            if (string.IsNullOrEmpty(empresa . Telefono))
            {
                MessageBox.Show("El campo telefono no puede ser vacio", "",
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
