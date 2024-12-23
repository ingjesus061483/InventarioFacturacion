﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FacturaEncabezado:Cuenta
    {
        public override  int Id { get; set; }

        [Index(IsUnique = true)]
        [Required ]
        [MaxLength(50)]
        public override  string  Codigo { get; set; }

        [Required ]
        [Column(TypeName = "datetime")]
        public override  DateTime Fecha { get; set; }

        [Required]
        public override  int UsuarioId { get; set; }
        public override  Usuario Usuario { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public override  int TipoDocumentoId { get; set; }
        public override  TipoDocumento TipoDocumento { get; set; }

        [NotMapped]
        public Empresa Empresa { get; set; }


        public override  int? FormapagoId { get; set; }
        public override  FormaPago FormaPago { get; set; }

        public override  string Observaciones { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public override  decimal Recibido { get; set; }

        
        [Column(TypeName = "decimal")]
        public override  decimal Descuento { get; set; }

        public override   List <Impuesto > Impuestos { get; set; }

        decimal _totalImpuesto;
        [Column(TypeName = "decimal")]
        public decimal Impuesto         
        {
            get 
            {
                if (Empresa.TipoRegimenId == 2)
                {
                    _totalImpuesto = 0;
                    foreach(Impuesto item in Impuestos)
                    {
                        decimal calculo =( Subtotal * item.Valor ) / 100;
                        _totalImpuesto += calculo;
                    }
                }
                return _totalImpuesto;
            }
        }
        public string NombreCliente
        {
            get
            {
                return Cliente.NombreCompleto;
            }
        }

        public List<FacturaDetalle> Detalles { get; set; }

        private decimal _sum;
        [Column(TypeName = "decimal")]
        public decimal Subtotal
        {
            get
            {
                _sum = 0;
                foreach (FacturaDetalle item in Detalles)
                {
                    _sum += item.Total;
                }
                return _sum;
            }
        }
        [Column(TypeName = "decimal")]
        public decimal TotalPagar
        {
            get
            {
                return Subtotal + Impuesto - Descuento;
            }
        }
        [Column(TypeName = "decimal")]
        public decimal Cambio
        {
            get
            {
                return Recibido - TotalPagar;
            }
        }
        public override  int EstadoId { get; set; }
        public override  Estado Estado { get; set; }

    
        public override  void EliminarDetalles()
        {
            if (Detalles.Count != 0)
            {
                FacturaDetalle detalle = Detalles.Last();
                Detalles.Remove (detalle );
            }
        }
        public override  void AñadirDetalles(Producto Articulo, decimal cantidad)
        {
            try
            {
                if (Detalles == null)
                {
                    Detalles = new List<FacturaDetalle>();
                }
                if (Detalles.Exists(x => x.Producto.Id == Articulo.Id))
                {
                    Detalles.RemoveAll(x => x.Producto.Id == Articulo.Id);
                }
                decimal existencia = Articulo.TotalExistencia;
                decimal total = existencia - cantidad;
                if (total <= 0)
                {
                    throw new Exception("La cantidad ha sobrepasado el limite minimo en el inventario ");
                }
                FacturaDetalle Facturadetalle = new FacturaDetalle
                {
                    FacturaId = Id,
                    ProductoId = Articulo.Id,
                    Producto = Articulo,
                    ValorUnitario =Articulo .Precio ,
                    Cantidad = cantidad,
                };
                Detalles.Add(Facturadetalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    }
}
