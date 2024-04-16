using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace Helper
{
    public interface IOperacion
    {
        void AddColumn(DataTable table, Excel.Worksheet sheet);
        void AddRow(DataTable table, Excel.Worksheet sheet);
        void Create(DataSet DB);
    }
}
