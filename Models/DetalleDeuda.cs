using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class DetalleDeuda : DetalleCredito
    {
        public override int Id { get; set; }
        public int DeudaId { get; set; }
        public Deuda Deuda  { get; set; }
        public override DateTime Fecha { get ; set ; }
        public override decimal Capital { get; set ; }
        public override decimal Interes { get ; set ; }

    }
}
