﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Existencia
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        public string Concepto { get; set; }
        
        [Required]
        [Column(TypeName = "decimal")]
        public decimal Cantidad { get; set; }
        
        public bool Entrada { get; set; }

        [Required]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

      /*  public string NombreProducto
        {
            get
            {
                return Producto.Codigo + " - " + Producto.Nombre;
            }
        }*/
    }
}
