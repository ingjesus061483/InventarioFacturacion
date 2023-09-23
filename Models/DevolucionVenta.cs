using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class DevolucionVenta:Devolucion 
    {
        public override  int Id { get; set; }
        
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public override string Codigo { get; set; }
        
        [Required ]
        public override  int ProductoId { get; set; }
        public override  Producto Producto { get; set; }

        [Required ]
        public override  int MotivoId { get; set; }
        public override  Motivo Motivo { get; set; }       
        public override DateTime Fecha { get ; set ; }

        public string ClienteNombre
        {
            get
            {
                return Cliente.NombreCompleto;
            }
        }

    }
}
