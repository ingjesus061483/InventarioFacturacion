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
    public  class TipoDocumentoHelp:Help
    {
        public TipoDocumentoHelp(InventarioDbContext context)
        {
            _context = context;
        }
        IQueryable<TipoDocumento> TipoDocumento
        {
            get
            {
                return _context.TipoDocumentos .AsQueryable();
            }
        }
        public override DataTable Table        
        {
            get
            {
                return _context.GetDataTable(TipoDocumento.ToString());
            }
        }

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
        /*public void Cmb(ComboBox cmb)
{
   string[] arr = { "Id", "Nombre" };
   cmb.DataSource = dtTipoIdentificacion;
   cmb.ValueMember = arr.GetValue(0).ToString();
   cmb.DisplayMember = arr.GetValue(1).ToString();
   cmb.SelectedIndex = -1;
}*/
    }
}
