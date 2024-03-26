using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DTO
{
    public class EmpleadoDTO
    {
            public  int Id { get; set; }

            [Required]
            [MaxLength(50)]
            [Index(IsUnique = true)]
            public  string Identificacion { get; set; }

            [Required]
            [MaxLength(50)]
            public string Nombre { get; set; }

            [Required]
            [MaxLength(50)]
            public  string Apellido { get; set; }

            [Required]
            [MaxLength(50)]
            public  string Direccion { get; set; }

            [Required]
            [MaxLength(50)]
            public  string Telefono { get; set; }

            [Required]
            public int UsuarioId { get; set; }
            public Usuario Usuario { get; set; }

            [Required]
            public  int TipoIdentificacionId { get; set; }
            public  TipoIdentificacion TipoIdentificacion { get; set; }

            [Required]
            public  DateTime? FechaNacimiento { get; set; }

            [Required]
            public  bool? PersonaNatural { get; set; }

        
    }
}
