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
    public partial class frmVistaPrevia : Form
    {
         public DataTable Table { get; set; }
        public frmVistaPrevia()
        {
            InitializeComponent();
        }

        private void frmVistaPrevia_Load(object sender, EventArgs e)
        {
            DgVer.DataSource = Table;
        }
    }
}
