using Helper;
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
       ExportarHelp _exportarHelp;
        ImportarHelp _importarHelp;
        DataTable dt;
        DataSet db;
        public frmImpExp(ExportarHelp  impExpHelp,ImportarHelp importarHelp)
        {
            _importarHelp = importarHelp;
            _exportarHelp = impExpHelp;
            InitializeComponent();
           

        }

        private void frmImpExp_Load(object sender, EventArgs e)
        {
           Utilities .Cmb(cmbTabla,_exportarHelp.Table);
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var item in ListExportar.Items)
            {
                if(item==cmbTabla.SelectedItem)
                {
                    encontrado = true;
                    break;
                }                
            }
            if(!encontrado && cmbTabla.SelectedItem!=null)
            {
                ListExportar.Items.Add(cmbTabla.SelectedItem);
            }  
            cmbTabla.SelectedIndex = -1;


        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                db  = new DataSet();  
                if(ListExportar.Items.Count==0&&string .IsNullOrEmpty(txtQuery.Text ))
                {
                    Utilities.GetDialogResult("", "",
MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    return;
                }
                foreach (var item in ListExportar.Items)
                {
                    DataTable table =_exportarHelp.GetTable("select * from "+ item.ToString());
                    table.TableName = item.ToString();
                    if (table.Rows.Count > 0)
                    {
                        db.Tables.Add(table );
                    }
                }
                if(dt!=null)
                {
                    db.Tables.Add(dt);
                }
               _exportarHelp.Exportar(db);                
            }
            catch(Exception ex)
            {
                Utilities .GetDialogResult(ex.Message, "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                nuevo();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void nuevo()
        {
            dt = null;
            ListExportar.Items.Clear();
            cmbTabla.SelectedIndex = -1;
            txtQuery.Text = string.Empty;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQuery.Text))
                {
                    Utilities.GetDialogResult("Digite una consulta valida  ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dt =_exportarHelp.GetTable(txtQuery.Text);
                frmVistaPrevia frmVistaPrevia = new frmVistaPrevia { Table = dt };
                frmVistaPrevia.ShowDialog();
                
            }
            catch(Exception ex)
            {
                Utilities.GetDialogResult(ex.Message, "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog
                {
                    Filter = "Excel files (*.xls)|*.xls;*.xlsx",
                    InitialDirectory = Application.StartupPath
                };
                DialogResult resp = OpenFileDialog.ShowDialog();
                if (string.IsNullOrEmpty(OpenFileDialog.FileName))
                {
                    Utilities.GetDialogResult("Se ha cancelado la accion  ", "",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                db = _importarHelp .LeerDatosExcel(OpenFileDialog.FileName);
                cmbTablaImp.Items.Clear();
                foreach (DataTable dt in db.Tables)
                {
                    cmbTablaImp.Items.Add(dt.TableName);
                }
            }
            catch (Exception ex)
            {
                Utilities.GetDialogResult(ex.Message, "",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cmbTablaImp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dvver.DataSource = db.Tables[cmbTablaImp.SelectedIndex];
            }
            catch (Exception ex)
            {
                Utilities.GetDialogResult(ex.Message, "",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void btnimportar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _importarHelp.Importar(db);
            }
            catch(Exception ex)
            {
                Utilities.GetDialogResult(ex.Message, "",
MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
