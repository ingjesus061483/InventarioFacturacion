using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.View
{
    public class PersonaView
    {
       public int Id { get; set; }
       public DateTime? FechaNacimiento { get; set; }
       public int TipoIdentificacionId { get; set; }
       public string TipoIdentificacion { get; set; }
       public string Identificacion { get; set; }
       public string Nombre { get; set; }
       public string Apellido { get; set; }
    public string  Direccion { get; set; }
public string Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
       public int  UsuarioId { get; set; }

    }
}
