using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DevolucionCompra : Devolucion
    {
        public override int Id { get ; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required]
        [MaxLength(50)]
        public override string Codigo { get ; set ; }

        public override int ProductoId { get ; set ; }
        public override Producto Producto { get ; set ; }

        public override int MotivoId { get ; set ; }
        public override Motivo Motivo { get ; set ; }
        public override DateTime Fecha { get; set ; }
        public string ProveedorNombre
        {
            get
            {
                return Proveedor.NombreCompleto;
            }
        }
    }
}
