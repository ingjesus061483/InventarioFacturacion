using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Helper
{
   public  class DevolucionVentaHelp : Help
    {
        
        public DevolucionVentaHelp(InventarioDbContext context)
        {
            _context = context;

        }
        public override DataTable Table => throw new NotImplementedException();
        public void GuardarDevolucion(DevolucionVenta devolucionVenta)
        {
            _context.DevolucionVentas.Add(devolucionVenta);
            _context.SaveChanges();
        }
        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            gridView.DataSource = null;
            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            int fila = columns.GetLength(0);
            for (int i = 0; i <= fila - 1; i++)
            {
                var DataGridViewTextBoxColumn = GetDataGridViewTextBoxColumn(columns[i, 0],
                                                                             columns[i, 0],
                                                                             columns[i, 0],
                                                                             bool.Parse(columns[i, 1]));
                dataGridViewTextBoxColumns.Add(DataGridViewTextBoxColumn);
            }

            gridView.Columns.AddRange(dataGridViewTextBoxColumns.ToArray());


        }
    }
}
