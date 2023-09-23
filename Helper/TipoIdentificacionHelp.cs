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
    public class TipoIdentificacionHelp:Help
    {
        
        public TipoIdentificacionHelp(InventarioDbContext context)
        {
            _context = context;
        }
        IQueryable<TipoIdentificacion> TipoIdentificacions
        {
            get
            {
                return _context.TipoIdentificacions.AsQueryable();
            }
        }
        public override  DataTable Table
        {
            get
            {
                return _context.GetDataTable(TipoIdentificacions.ToString());
            }
        }
    /*    public void Cmb(ComboBox cmb)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = dtTipoIdentificacion ;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }*/

        public override void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
    }
}
