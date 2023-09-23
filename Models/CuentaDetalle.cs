using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public abstract  class CuentaDetalle
    {

        public abstract  int ProductoId { get; set; }
        public abstract  Producto Producto { get; set; }

        public  abstract  decimal Cantidad { get; set; }
        
        public abstract  decimal ValorUnitario { get; set; }

        decimal _total;
        public decimal Total
        {
            get
            {
                _total = Cantidad * ValorUnitario;
                return _total;
            }
        }
        public string NombreProducto
        {
            get
            {
                return Producto.Codigo + " - " + Producto.Nombre;
            }
        }

    }
}
