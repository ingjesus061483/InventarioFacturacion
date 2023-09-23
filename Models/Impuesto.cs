using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public   class Impuesto
    {
        public int  Id { get; set; }

        [Required]
        public string  Nombre { get; set; }

        [Required ]
        public decimal  Valor { get; set; }

        public string Descripcion { get; set; }
    }
}
