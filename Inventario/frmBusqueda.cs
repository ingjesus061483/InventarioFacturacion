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
    public partial class frmBusqueda : Form
    {
        readonly DataTable _dt;
        public DataGridViewRow  Row { get; set; }
        public int Id { get; set; }
        public frmBusqueda(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }
        void Cmb(ComboBox cmb, DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                if (col.DataType.Name == "String")
                {
                    cmb.Items.Add(col.ColumnName);
                }
            }
            cmb.SelectedIndex = 0;
        }
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            dgVer.DataSource = _dt;
            Cmb(cmbColumnas, _dt);
        }

        private void dgVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                Id = int.Parse(dgVer.Rows[e.RowIndex].Cells[0].Value.ToString());
                Row = dgVer.Rows[e.RowIndex];
                this.Close();
            }
        }
        DataTable Busqueda(string filtro, string valor, DataTable table)
        {
            try {
                DataTable DatosResult;
                var columnas = table.Columns;
                string tipo = "";
                foreach (DataColumn column in columnas) {
                    if (column.ColumnName == filtro)
                    {
                        tipo = column.DataType.Name;
                        break;
                    }
                }
                if (tipo != "String")
                {
                    var query = (from DataRow row in table.AsEnumerable()
                                 where row.Field<double>(filtro) == double.Parse(valor)
                                 select row);
                    if (query.ToList().Count > 0)
                        DatosResult = query.CopyToDataTable();
                    else
                        DatosResult  = table;
                }
                else
                {
                    var query = (from DataRow row in table.AsEnumerable()
                                 where row.Field<string>(filtro).Contains(valor)
                                 select row);
                    if (query.ToList().Count > 0)
                        DatosResult  = query.CopyToDataTable();
                    else
                        DatosResult  = table;
                }
                return DatosResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            DataTable tblresult = Busqueda(cmbColumnas.Text, txtFiltro.Text, _dt);
            dgVer.DataSource = tblresult;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
