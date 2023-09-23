using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public abstract  class Credito
    {
        public abstract  int Id { get; set; }
        public abstract  DateTime Fecha { get; set; }
        public abstract decimal Monto { get; }
        public abstract int Tiempo { get; set; }
        public abstract decimal Interes { get; set; }
        public abstract decimal Saldo { get; set; }
        public abstract int TipocobroId { get; set; }
        public abstract  TipoCobro TipoCobro { get; set; }
        public abstract int EstadoId { get; set;  }
        public abstract Estado Estado { get; set; }

        public decimal ValorCancelar
        {
            get
            {
                return Monto / Tiempo * (1 + Interes);
            }
        }
        public string TipoCobroNombre
        {
            get
            {
                return TipoCobro.Nombre;
            }
        }
        public string EstadoNombre
        {
            get
            {
                return Estado.Nombre;
            }
        }
    

    }
}
