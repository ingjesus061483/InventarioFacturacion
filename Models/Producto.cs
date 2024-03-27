using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{    
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Costo { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Precio { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required]
        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public string RutaImagen { get; set; }
        public string Descripcion { get; set; }

        public List <FacturaDetalle > FacturaDetalles { get; set; }

        public List<Existencia> Existencias { get; set; }

        public List<Existencia> Entradas
        {
            get
            {
                return Existencias!=null?Existencias.Where(x => x.ProductoId == Id && x.Entrada == true).ToList(): null;

            }
            set 
            {

            }
        }

        public List<Existencia> Salidas
        {
            get
            {
                return Existencias!=null  ? Existencias.Where(x => x.ProductoId == Id && x.Entrada == false).ToList():null;
            }        
        }
        decimal _totalEntrada;
        public  decimal TotalEntrada
        {
            get
            {
                _totalEntrada = 0;
                if (Entradas != null)
                {
                    foreach (Existencia existencia in Entradas)
                    {
                        _totalEntrada += existencia.Cantidad;
                    }
                }
                return _totalEntrada;
            }
        }
        decimal _totalSalida;
        public decimal TotalSalida
        {
            get
            {
                if(Salidas!=null)
                {
                    _totalSalida = 0;
                    foreach (Existencia existencia in Salidas)
                    {
                        _totalSalida += existencia.Cantidad;
                    }
                }
                return _totalSalida;
            }
        }
        public  string CategoriaNombre
        {
            get
            {
                return Categoria.Nombre;
            }
        }
        public string Unidad
        {
            get
            {
                return UnidadMedida.Nombre;
            }
        }
        public decimal TotalExistencia
        {
            get
            {
                return TotalEntrada - TotalSalida;
            }
        }
    }
}
