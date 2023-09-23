using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class Motivo
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [MaxLength (50)]
        public string Codigo { get; set; }
        
        [Required]
        public string Concepto { get; set; }
        
        [Required ]
        public string Descripcion { get; set; }
        
        public List<DevolucionVenta> DevolucionVentas { get; set; }

    }
}
