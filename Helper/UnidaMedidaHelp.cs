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
    public class UnidaMedidaHelp:Help
    {
        
        public UnidaMedidaHelp (InventarioDbContext context )
        {
            _context = context;
        }
        public IQueryable <UnidadMedida> QueryUnidadMedida
        {
            get
            {
                return _context.UnidadMedidas.AsQueryable();
            }
        }
        public override  DataTable Table
        {
            get
            {
                return _context.GetDataTable(QueryUnidadMedida.ToString());
            }
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
        /*public void Cmb(ComboBox cmb)
{
   string[] arr = { "Id", "Nombre" };
   cmb.DataSource = dtUnidadMedida ;
   cmb.ValueMember = arr.GetValue(0).ToString();
   cmb.DisplayMember = arr.GetValue(1).ToString();
   cmb.SelectedIndex = -1;
}*/
    }
}
