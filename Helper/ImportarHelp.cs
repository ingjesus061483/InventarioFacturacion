using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace Helper
{
    public class ImportarHelp 
    {
        InventarioDbContext _context;
        public ImportarHelp(InventarioDbContext context)
        {
            _context = context;
        } 
        void AddColumn(DataTable table , Excel.Worksheet sheet)
        {
            int col = 1;
            while (!string.IsNullOrEmpty(sheet.Cells[ 1, col].value))
            {
                table.Columns.Add(sheet.Cells[ 1, col].value);
                col += 1;
            }
        }
        void AddRow(DataTable table, Excel.Worksheet sheet)
        {
            int iRowCnt = 2;
            while (!string.IsNullOrEmpty(Convert.ToString(sheet.Cells[iRowCnt, 1].value)))
            {
                DataRow row = table .NewRow();
                int j = 0;
                for (int i = 1; i <= table .Columns.Count ; i++)
                {
                    string value = Convert.ToString(sheet.Cells[iRowCnt, i].value);
                    row[j] = value;
                    j += 1;
                }
                table.Rows.Add(row);
                iRowCnt += 1;
            }
        }
        public DataSet LeerDatosExcel(string filename)
        {
            Excel.Application ExcelApp = new Excel.Application();                
            Excel.Workbook workbook = ExcelApp.Workbooks.Open(filename);
            Excel.Sheets sheetDatos = workbook.Sheets;
            try
            {
                DataSet bd = new DataSet();                 
                foreach (Excel.Worksheet sheet in sheetDatos)
                {                   
                    DataTable tbl = new DataTable { TableName = sheet .Name };
                    AddColumn(tbl, sheet);
                    AddRow(tbl, sheet);
                    bd.Tables.Add(tbl);
                }
                return bd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {       
                workbook = null;
                sheetDatos = null;
                ExcelApp.Quit();
            }
        }
        string PrepararQueryInsert(DataTable table, out string[] param)
        {
            string query;
            string column = "";
            string parameters = "";
            foreach (DataColumn col in table.Columns)
            {
                column = column + col.ColumnName + ",";
                parameters = parameters + "@" + col.ColumnName + ",";
            }
            column = column.Substring(0, column.Length - 1);
            parameters = parameters.Substring(0, parameters.Length - 1);
            query = "insert into " + table.TableName + "(" + column + ")values(" + parameters + ")";
            param = parameters.Split(',');
            return query;
        }
        void CreateParameter(DbCommand command, string column,DbType type , List< DbParameter> parameters)
        {
            DbParameter param = command.CreateParameter();
            param.ParameterName = column;
            param.DbType = type;
            parameters.Add(param);
        }
        List<DbParameter> GetParameters(DbCommand command, string[] column, string table)
        {
            try
            {
                List<DbParameter> parameters = new List<DbParameter>();
                for (int i = 0; i <= column.Length - 1; i++)
                {
                    DataRow row = _context.GetColumn(table, column[i]);                    
                    string type = row["tipo"].ToString();
                    switch (type)
                    {
                        case "int":
                            {
                                CreateParameter(command, column[i], DbType.Int32, parameters);                                
                                break;
                            }
                        case "decimal":
                            {
                                CreateParameter(command, column[i], DbType.Decimal, parameters);
                                break;
                            }
                        case "nvarchar":
                            {
                                CreateParameter(command, column[i], DbType.String ,  parameters);
                                break;
                            }
                        case "datetime":
                            {
                                CreateParameter(command, column[i], DbType.DateTime, parameters);
                                break;
                            }
                        case "varbinary":
                            {
                                CreateParameter(command, column[i], DbType.Binary, parameters);
                                break;
                            }
                        case "bit":
                            {
                                CreateParameter(command, column[i], DbType.Boolean , parameters);
                                break;
                            }
                    }
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Importar(DataSet db)
        {
            try
            {
                foreach (DataTable table in db.Tables)
                {
                    _context.EjecutarComando("truncate table " + table.TableName);
                    _context.EjecutarComando("SET IDENTITY_INSERT " + table.TableName + " ON;");
                    string query = PrepararQueryInsert(table, out string[] param);
                    DbCommand command = _context.GetCommand(query);
                    List<DbParameter> parameters = GetParameters(command, param, table.TableName);
                    ExecuteComand(command, parameters, table);
                    _context.EjecutarComando("SET IDENTITY_INSERT " + table.TableName + " Off;");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        void ExecuteComand(DbCommand command, List<DbParameter> parameters, DataTable table)
        {
            try
            {
                command.Parameters.AddRange(parameters.ToArray());
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        command.Parameters[col.ColumnName].Value = row[col];
                    }
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
