using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Helper
{
    public abstract class Help
    {
        protected   InventarioDbContext _context;

        public abstract DataTable Table { get; }    

        public abstract void GetDatagrid(DataGridView gridView, string[,] columns);
        protected StreamWriter CrearArchivo()
        {
            try
            {
                string ruta = Application.StartupPath+"\\Imprimir";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                 ruta +="\\Imprimir.txt";
                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                }
                FileStream fs = File.Create(ruta);
                StreamWriter sWriter = new StreamWriter(fs);
                return sWriter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected  StreamReader LeerArchivo() 
        {
            try
            {
                string ruta = Application.StartupPath+"\\Imprimir";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                ruta += "\\Imprimir.txt";
                FileStream fs;
                StreamReader sReader = null;
                if (File.Exists(ruta))
                {
                    fs = File.OpenRead(ruta);
                    sReader = new StreamReader(fs);
                }
                return sReader;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        protected  void EliminarArchivo()
        {
            try
            {
                string ruta = Application.StartupPath + "\\Imprimir\\Imprimir.txt";
                if (File.Exists(ruta))
                    File.Delete(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Cmb(ComboBox cmb)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = Table ;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }
        public  string CargarImagen(PictureBox picture)
        {
            try
            {
                //Dim bytes As Byte()
                OpenFileDialog OpenFile = new OpenFileDialog { Filter = "Imagenes (JPG)|*.jpg" }; //filtro de archivos del OpenFileDialog
                if (OpenFile.ShowDialog() == DialogResult.OK)// en caso de que se aplaste el boton cancelar salga y no haga nada
                {
                    picture.SizeMode = PictureBoxSizeMode.StretchImage; //establecemos como se visualiza la imagen
                    picture.Load(OpenFile.FileName); //visualizamos abriendo el archivo seleccionado
                    //Dim FileStream As New FileStream(OpenFile.FileName, FileMode.Open, FileAccess.Read) 'instanciamos en Stream indicandole la ruta del arvhivo,el modo de acceso y si es de lectura o escritura
                    //ReDim bytes(FileStream.Length) 'llenamos el arreglo
                    //FileStream.Read(bytes, 0, CInt(FileStream.Length)) 'llenamos el arreglo
                    return OpenFile.FileName;
                }
                else
                {
                    picture.Image = null;
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

   public bool EmailBienEscrito(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        protected DataGridViewTextBoxColumn GetDataGridViewTextBoxColumn(string HeaderText, string DataPropertyName, string Name, bool Visible)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                HeaderText = HeaderText,
                DataPropertyName = DataPropertyName,
                Name = Name,
                Visible = Visible,
            };
            return column;

        }
       public DataTable Busqueda(string filtro, string  valor)
        {
            try
            {
                DataTable DatosResult = null ;
                var columnas = Table.Columns;                
                string tipo = "";
                foreach (DataColumn column in columnas)
                {
                    if (column.ColumnName == filtro)
                    {
                        tipo = column.DataType.Name;
                        break;
                    }
                }

                switch (tipo)
                {

                    case "Int32":
                        {
                            var query = (from DataRow row in Table.AsEnumerable()
                                         where row.Field<int>(filtro) == int.Parse(valor)
                                         select row);

                                DatosResult = query.Count() > 0? query.CopyToDataTable():Table ;
                           
                            break;
                        }
                    case "String":
                        {
                            var query = (from DataRow row in Table.AsEnumerable()
                                         where row.Field<string>(filtro).Contains(valor.ToString())
                                         select row);
                            DatosResult = query.Count() > 0 ? query.CopyToDataTable() : Table;
                            break;
                        }
                    default:
                        {
                            DatosResult = Table;
                            break;
                        }
                
            
                }
                return DatosResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Busqueda(string filtro, object valor1,object valor2)
        {
            try
            {
                DataTable DatosResult = null;
                var columnas = Table.Columns;
                string tipo = "";
                foreach (DataColumn column in columnas)
                {
                    if (column.ColumnName == filtro)
                    {
                        tipo = column.DataType.Name;
                        break;
                    }
                }

                switch (tipo)
                {

                    case "Int32":
                        {
                            var query = (from DataRow row in Table.AsEnumerable()
                                         where row.Field<int>(filtro) == int.Parse(valor1.ToString ())
                                         select row);

                            DatosResult = query.Count() > 0 ? query.CopyToDataTable() : Table;

                            break;
                        }
                    case "String":
                        {
                            var query = (from DataRow row in Table.AsEnumerable()
                                         where row.Field<string>(filtro).Contains(valor1.ToString())
                                         select row);
                            DatosResult = query.Count() > 0 ? query.CopyToDataTable() : Table;
                            break;
                        }
                    case "DateTime":
                        {
                            DateTime.TryParse(valor1.ToString(), out DateTime fecha1);
                            DateTime.TryParse(valor2.ToString(), out DateTime fecha2);
                            var query = (from DataRow row in Table.AsEnumerable()
                                         where row.Field<DateTime>(filtro) >=fecha1 && row.Field<DateTime>(filtro) <=fecha2  
                                         select row);
                            DatosResult = query.Count() > 0 ? query.CopyToDataTable() : Table;
                            break;
                        }
                    default:
                        {
                            DatosResult = Table;
                            break;
                        }


                }
                return DatosResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTable( DataGridView gridView )
        {
            DataTable table = new DataTable();
            foreach (DataGridViewColumn item in gridView .Columns)
            {
                if (item is DataGridViewTextBoxColumn && item.Visible)
                {
                    table.Columns.Add(item.Name);
                }
            }
            foreach (DataGridViewRow row in gridView .Rows)
            {
                var rowtable = table.NewRow();
                foreach (DataColumn column in table.Columns)
                {
                    rowtable[column] = row.Cells[column.ColumnName].Value;
                }
                table.Rows.Add(rowtable);
            }
            return table;

        }
        public void ExportarDatos(DataSet db)
        {
            try
            {
                int cont = 1;           
                int iRowCnt;
                string hoja = "Hoja";
                int col = 1;
                var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Workbooks.Add();
                foreach (DataTable table in db.Tables)
                {
                    Microsoft .Office.Interop .Excel .Worksheet worksheet  = ExcelApp.Sheets[hoja + cont.ToString()];
                    worksheet.Name = table.TableName;
                    col = 1;
                    iRowCnt = 2;
                    foreach (DataColumn column in table.Columns)
                    {
                        worksheet.Cells[iRowCnt - 1, col].value = column.ColumnName;
                        col += 1;
                    }
                    foreach (DataRow row in table.Rows)
                    {
                        col = 1;
                        foreach (DataColumn column2 in table.Columns)
                        {
                            // worksheet.Cells[iRowCnt - 1, col].value = column2.ColumnName;
                            worksheet.Cells[iRowCnt, col] = row[column2];
                            col += 1;
                        }
                        iRowCnt += 1;
                    }
                    
                    //   ExcelApp.ActiveCell.Worksheet.Cells(1, 1).AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList3)
                    cont += 1;
                    ExcelApp.Sheets.Add();
                }
                Microsoft .Office .Interop .Excel .Worksheet  WorkSheet = ExcelApp.Sheets[hoja + cont.ToString()];
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
    
    }
}
