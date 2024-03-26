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
    public class ExistenciaHelp:Help
    {
        
        public ExistenciaHelp (InventarioDbContext context)
        {
            _context = context;
        }


        protected  IQueryable Queryable => throw new NotImplementedException();

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

        public List<Existencia>  GetExistencias(int productoId)
        {
            return  _context.Existencias.Where(x => x.ProductoId == productoId).ToList();
           
        }
        public void  GuardarExistencias(Existencia existencia)
        {
            if(!Validar(existencia ))
            {
                return;
            }
            _context.Existencias.Add(existencia);
            _context.SaveChanges();
            MessageBox.Show("Se ha guardado la existencia", "",
    MessageBoxButtons.OK, MessageBoxIcon.Information );


        }
        bool Validar(Existencia existencia )
        {
            if (existencia.Cantidad == 0)
            {
                MessageBox.Show("El campo existencia no puede ser vacio ni contener letras", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
