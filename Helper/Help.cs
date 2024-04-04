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
using Newtonsoft.Json;
namespace Helper
{
    public abstract class Help
    {
        protected InventarioDbContext _context;
        public abstract void GetDatagrid(DataGridView gridView, string[,] columns);
        protected StreamWriter CrearArchivo()
        {
            try
            {
                string ruta = Application.StartupPath + "\\Imprimir";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                ruta += "\\Imprimir.txt";
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

        protected StreamReader LeerArchivo()
        {
            try
            {
                string ruta = Application.StartupPath + "\\Imprimir";
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
        protected void EliminarArchivo()
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
        public void Cmb(ComboBox cmb, object lst)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = lst;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }
        public void Cmb(ComboBox cmb, DataTable table)
        {

            foreach (DataRow row in table.Rows)
            {
                cmb.Items.Add(row[0]);
            }

        }
        public string CargarImagen(PictureBox picture)
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

      
    }
}
