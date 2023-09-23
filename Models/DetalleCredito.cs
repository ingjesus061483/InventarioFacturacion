using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public abstract class DetalleCredito
	{
		public abstract int Id { get; set; }
		public abstract DateTime Fecha { get; set; }
		public abstract  decimal  Capital { get; set; }
		public abstract  decimal  Interes { get; set; }
		public decimal Total
		{
			get
			{
				return Capital - Interes;
			}
		}
	}
}
