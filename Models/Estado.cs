﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Estado
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        public List<FacturaEncabezado> FacturaEncabezados { get; set; }
        public List<OrdenCompra> OrdenCompras { get; set; }

    }
}
