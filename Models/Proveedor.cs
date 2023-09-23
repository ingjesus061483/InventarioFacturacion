using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Proveedor:Persona
    {
        public override  int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public override  string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        public override  string Nombre { get; set; }


        [MaxLength(50)]
        public override  string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public override  string Direccion { get; set; }

        [Required]
        [MaxLength(50)]

        public override  string Telefono { get; set; }

        [Required]
        [MaxLength(50)]
        public   string Email { get; set; }

        [Required]
        public override  int TipoIdentificacionId { get; set; }
        public override  TipoIdentificacion TipoIdentificacion { get; set; }

        public override DateTime? FechaNacimiento { get ; set; }
      
        [Required ]
        public override bool? PersonaNatural { get ; set; }

    }
}
