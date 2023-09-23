using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Cuenta
    {
        public abstract  int Id { get; set; }

        public abstract  string Codigo { get; set; }

        public abstract  DateTime Fecha { get; set; }

        public  abstract  int UsuarioId { get; set; }
        public abstract  Usuario Usuario { get; set; }

      
        public abstract  int TipoDocumentoId { get; set; }
        public abstract  TipoDocumento TipoDocumento { get; set; }

       
        public abstract  int? FormapagoId { get; set; }
        public abstract  FormaPago FormaPago { get; set; }

        public abstract  string Observaciones { get; set; }

        public abstract  decimal Recibido { get; set; }


        public abstract  decimal Descuento { get; set; }

        public abstract  List<Impuesto> Impuestos { get; set; }
        
        public string NombreEmpleado
        {
            get
            {
                return Usuario.Empleados[0].NombreCompleto;
            }
        }
        public string Formapag
        {
            get
            {
                return FormaPago !=null? FormaPago.Nombre:"";
            }
        }
        public string TipoDoc
        {
            get
            {
                return TipoDocumento.Nombre;
            }
        }


        public abstract  int EstadoId { get; set; }
        public abstract  Estado Estado { get; set; }

        public string EstadoNombre
        {
            get
            {
                return Estado.Nombre;
            }
        }

        public abstract void EliminarDetalles();
        public abstract void AñadirDetalles(Producto Articulo, decimal cantidad);
        
    }
}
