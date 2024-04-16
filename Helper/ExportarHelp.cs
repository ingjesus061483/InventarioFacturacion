using DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Helper
{
    public class ExportarHelp :IOperacion
    {
        InventarioDbContext _context;
        public DataTable Table
        {
            get
            {
                return _context.GetDataTable("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");
            }
        }
        public ExportarHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public void AddColumn(DataTable table, Excel.Worksheet worksheet)
        {
            int col = 1;
            foreach (DataColumn column in table.Columns)
            {
                worksheet.Cells[ 1, col].value = column.ColumnName;
                col += 1;
            }           
        }
        public   void AddRow( DataTable table, Excel.Worksheet worksheet)
        {     
            int iRowCnt = 2;
            foreach (DataRow row in table.Rows)
            {
               int col = 1;
                foreach (DataColumn column in table.Columns)
                {
                    worksheet.Cells[iRowCnt, col] = row[column];
                    col += 1;
                }
                iRowCnt += 1;
            }
        }
        Excel.Worksheet GetSheet(Excel.Application ExcelApp, string  hoja,string TableName  )
        {
            Excel.Worksheet worksheet = ExcelApp.Sheets[hoja ];
            worksheet.Name = TableName;
            return worksheet;
        }
        void AddBook(Excel.Application ExcelApp )
        {            
            ExcelApp.Workbooks.Add();
        }
        public void Create(DataSet db)
        {
            try
            {
                int cont = 1;
                string hoja = "Hoja";
                Excel.Application ExcelApp = new Excel.Application();
                AddBook(ExcelApp);
                foreach (DataTable table in db.Tables)
                {
                    Excel.Worksheet worksheet =GetSheet( ExcelApp,hoja  + cont.ToString(),table.TableName );                    
                    AddColumn( table,worksheet);
                    AddRow( table, worksheet);
                    //   ExcelApp.ActiveCell.Worksheet.Cells(1, 1).AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList3)
                    cont += 1;
                    ExcelApp.Sheets.Add();
                }
                Excel.Worksheet WorkSheet = ExcelApp.Sheets[hoja + cont.ToString()];
                WorkSheet.Delete();
                ExcelApp.Visible = true;
                ExcelApp = null;
                WorkSheet = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTable(object lst)
        {
            string json = JsonConvert.SerializeObject(lst);
            DataTable pDt = JsonConvert.DeserializeObject<DataTable>(json);
            return pDt;

        }
        public DataTable GetTable(string query)
        {
            DataTable pDt = _context.GetDataTable(query);
            return pDt;

        }
        /*      public override void GetDatagrid(System.Windows.Forms.DataGridView gridView, string[,] columns)
              {
                  throw new NotImplementedException();
              }*/
    }
}
