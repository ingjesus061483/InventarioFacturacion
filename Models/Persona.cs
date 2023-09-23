using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Persona
    {
        public abstract int Id { get; set; }

        public abstract string Identificacion { get; set; }

        public abstract string Nombre { get; set; }

        public abstract string Apellido { get; set; }

        public abstract string Direccion { get; set; }

        public abstract string Telefono { get; set; }

        public abstract DateTime? FechaNacimiento { get; set; }

        public abstract bool? PersonaNatural { get; set; }

        public abstract int TipoIdentificacionId { get; set; }
        public abstract TipoIdentificacion TipoIdentificacion { get; set; }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }

        }
        int _edad;
        public double Edad
        {
            get
            {
                _edad = (DateTime.Now - FechaNacimiento).Value.Days / 365;
                return _edad;

            }
        }

    }
}
