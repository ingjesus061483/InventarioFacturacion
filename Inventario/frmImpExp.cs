using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmImpExp : Form
    {
        InventarioDbContext _context;
        public frmImpExp(InventarioDbContext context )
        {
            _context = context;
            InitializeComponent();
            

        }
    }
}
