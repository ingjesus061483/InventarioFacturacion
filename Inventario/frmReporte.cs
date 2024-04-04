using Microsoft.Reporting.WinForms;
using Models;
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
    public partial class frmReporte : Form
    {
        public List< ReportDataSource> ReportDataSources { get; set; }
        public string ruta { get; set; }
        public frmReporte()
        {
            InitializeComponent();
        }
        private void frmVistaPrevia_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = ruta;            
            reportViewer1.LocalReport.DataSources.Clear();
            foreach (ReportDataSource reportDataSource in ReportDataSources)
            {
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            reportViewer1.RefreshReport();
       
        }
    }
}
