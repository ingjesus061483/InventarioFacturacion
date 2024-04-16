using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Helper
{
    public static class Utilities
    {
        public static bool EmailBienEscrito(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!Regex.IsMatch(email, expresion))
            {
                return false;
            }
            return Regex.Replace(email, expresion, string.Empty).Length == 0;            
        }
        public static void Cmb(ComboBox cmb, object lst)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = lst;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }
        public static void Cmb(ComboBox cmb, DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                cmb.Items.Add(row[0]);
            }
        }

        public static string CargarImagen(PictureBox picture)
        {
            try
            {
                Image image;
                OpenFileDialog OpenFile = new OpenFileDialog { Filter = "Imagenes (JPG)|*.jpg" }; //filtro de archivos del OpenFileDialog
                if (OpenFile.ShowDialog() == DialogResult.OK)// en caso de que se aplaste el boton cancelar salga y no haga nada
                {
                    image = Image.FromFile(OpenFile.FileName);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage; //establecemos como se visualiza la imagen
                    picture.Load(OpenFile.FileName); //visualizamos abriendo el archivo seleccionado
                    return OpenFile.FileName;
                }
                picture.Image = null;
                return string.Empty;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static string Encriptar(string password)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            string result = Convert.ToBase64String(encryted);
            return result;
        }
        public static void GetDatagrid(DataGridView gridView, string[,] columns)
        {
            gridView.DataSource = null;
            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            int fila = columns.GetLength(0);
            for (int i = 0; i <= fila - 1; i++)
            {
                var DataGridViewTextBoxColumn =GetDataGridViewTextBoxColumn(columns[i, 0],
                                                                             columns[i, 0],
                                                                             columns[i, 0],
                                                                             bool.Parse(columns[i, 1]));
                dataGridViewTextBoxColumns.Add(DataGridViewTextBoxColumn);
            }

            gridView.Columns.AddRange(dataGridViewTextBoxColumns.ToArray());
        }
        public static void GetDialogResult(string message ,string title,MessageBoxButtons buttons,MessageBoxIcon icon )
        {
             MessageBox.Show(message ,title ,buttons, icon);
        }
        public static  DataGridViewTextBoxColumn GetDataGridViewTextBoxColumn(string HeaderText, string DataPropertyName, string Name, bool Visible)
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
        public static DataTable GetTable(object lst)
        {
            string json = JsonConvert.SerializeObject(lst);
            DataTable pDt = JsonConvert.DeserializeObject<DataTable>(json);
            return pDt;
        }      
    }
}
