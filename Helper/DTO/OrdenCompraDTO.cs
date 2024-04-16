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
    public class OrdenCompraDTO
    {
        public  int Id { get; set; }

        [Index(IsUnique = true)]
        [Required]
        [MaxLength(50)]
        public  string Codigo { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public  DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }


        [Required]
        public  int UsuarioId { get; set; }
        public  Usuario Usuario { get; set; }

        [Required]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor  { get; set; }

        [Required]
        public  int TipoDocumentoId { get; set; }
        public  TipoDocumento TipoDocumento { get; set; }

        public    int? FormapagoId { get; set; }
        public   FormaPago FormaPago { get; set; }

        public  string Observaciones { get; set; }

        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Recibido { get; set; }


        [Column(TypeName = "decimal")]
        public  decimal Descuento { get; set; }

        public  List<Impuesto> Impuestos { get; set; }

        decimal _totalImpuesto;
        [Column(TypeName = "decimal")]
        public decimal Impuesto
        {
            get
            {
                if (!(bool)Proveedor.PersonaNatural)
                {
                    _totalImpuesto = 0;
                    foreach (Impuesto item in Impuestos)
                    {
                        decimal calculo = (Subtotal * item.Valor) / 100;
                        _totalImpuesto += calculo;
                    }
                }
                return _totalImpuesto;
            }
        }
        public string NombreProveedor
        {
            get
            {
                return Proveedor .NombreCompleto;
            }
        }
        public string NombreUsuario
        {
            get
            {
                return Usuario.Name;
            }
        }
        public string EstadoNombre
        {
            get
            {
                return Estado.Nombre ;
            }
        }
        public string FormaPagoNombre
        {
            get
            {
                return FormaPago==null?"":FormaPago.Nombre ;
            }
        }
        public string TipoDocumentoNombre
        {
            get
            {
                return TipoDocumento.Nombre;
            }
        }

        public List<OrdenCompraDetalle > Detalles { get; set; }

        private decimal _sum;
        [Column(TypeName = "decimal")]
        public decimal Subtotal
        {
            get
            {
                _sum = 0;
                if (Detalles != null)
                {
                    foreach (OrdenCompraDetalle item in Detalles)
                    {
                        _sum +=  item.Total;
                    }
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

        public void EliminarDetalles()
        {
            if (Detalles.Count != 0)
            {
                OrdenCompraDetalle detalle = Detalles.Last();
                Detalles.Remove(detalle);
            }
        }
        public void AñadirDetalles(Producto Articulo, decimal cantidad)
        {
            try
            {
                if (Detalles == null)
                {
                    Detalles = new List<OrdenCompraDetalle>();
                }
                if (Detalles.Exists(x => x.Producto.Id == Articulo.Id))
                {
                    Detalles.RemoveAll(x => x.Producto.Id == Articulo.Id);
                }
                OrdenCompraDetalle ordenCompraDetalle = new OrdenCompraDetalle
                {
                    OrdenCompraId = Id,
                    ProductoId = Articulo.Id,
                    Producto = Articulo,
                    ValorUnitario = Articulo.Precio,
                    Cantidad = cantidad,
                };
                Detalles.Add(ordenCompraDetalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
