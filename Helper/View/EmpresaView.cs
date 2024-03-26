using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.View
{
    public class EmpresaView
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string CamaraComercio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string  Logo { get; set; }
        public string Slogan { get; set; }
        public int TipoRegimenId { get; set; }
        public string TipoRegimen { get; set; }
    }
}
