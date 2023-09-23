using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FacturaDetalle:CuentaDetalle 
    {
        public int  Id { get; set; }

        [Required]
        public int FacturaId { get; set; }
        public FacturaEncabezado FacturaEncabezado { get; set; }
        
        [Required]
        public override  int ProductoId { get; set; }        
        public override  Producto   Producto { get; set; }
        
        [Required ]
        [Column( TypeName = "decimal")]
        public override  decimal  Cantidad { get; set; }
    
        [Required]
        [Column(TypeName = "decimal")]
        public override  decimal ValorUnitario { get; set; }     
    }
}
