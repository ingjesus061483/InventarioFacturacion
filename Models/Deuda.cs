using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Deuda : Credito
    {
        public override int Id { get; set; }
        public int FacturaId{ get; set; }
        public FacturaEncabezado FacturaEncabezado { get; set; }
        public override DateTime Fecha { get ; set ; }
        public override int Tiempo { get ; set ; }
        public override decimal Interes { get ; set ; }
        public override decimal Saldo { get; set ; }
        public override int TipocobroId { get ; set ; }
        public override TipoCobro TipoCobro { get ; set ; }
        public  List <DetalleCredito >DetalleCreditos { get; set; }
        public override int EstadoId { get; set ; }
        public override Estado Estado { get ; set ; }
        public override decimal Monto 
        { 
            get
            {
                return FacturaEncabezado.TotalPagar; 
            } 
        }
        decimal  _totalPago=0;
        public decimal TotalSaldo
        {
            get
            {
                foreach (DetalleCredito item in DetalleCreditos)
                {
                    _totalPago += item.Total;

                }
                return _totalPago;

            }
        }
        
    }
}
