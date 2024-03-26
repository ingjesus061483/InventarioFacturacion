using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.View
{
    public class ProductoView
    {
       public int Id { get; set; }
       public string Codigo { get; set; }
       public string Nombre { get; set; }
       public string Costo { get; set; }
      public string Precio { get; set; }
              public decimal TotalEntrada { get; set; }
              public decimal TotalSalida { get; set; }
               public decimal TotalExistencia { get; set; }
              public string Descripcion { get; set; }
                public int CategoriaId { get; set; }
               public string Categoria { get; set; }
               public int UnidadMedidaId { get; set; }
               public string UnidadMedida { get; set; }


    }
}
