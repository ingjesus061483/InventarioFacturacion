using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [MaxLength (50)]
        public string Name { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Email{ get; set; }

        [Required]        
        public string Password { get; set; }

        [Required]        
        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Required]        
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        
        public List <Empleado >Empleados { get; set; }
        
        public List <FacturaEncabezado > FacturaEncabezados { get; set; }

        public string Encriptar(string password)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryted);
            return result;
        }



    }
}
