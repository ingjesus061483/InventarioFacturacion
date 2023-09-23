using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract  class Devolucion
    {
        public abstract  int Id { get; set; }
        public abstract  string Codigo { get; set; }
        public abstract  DateTime Fecha { get; set; }
        public abstract  int ProductoId { get; set; }
        public abstract  Producto Producto { get; set; }
        public abstract  int MotivoId { get; set; }
        public abstract  Motivo Motivo { get; set; }
        public string NombreProducto 
        { 
            get
            {
                return Producto.Codigo + " " + Producto.Nombre;

            } 
        }
        public string DescripcionMotivo
        {
            get
            {
                return Motivo.Codigo + " - " + Motivo.Concepto;
            }
        }
    }
}
