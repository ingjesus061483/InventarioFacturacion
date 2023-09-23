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

namespace Inventario.UserControls
{
    public partial class Cuestas : UserControl
    {
        public CompraHelp CompraHelp { get; set; }
        public  ProductoHelp  ProductoHelp { get; set; }
        public FacturaHelp FacturaHelp { get; set; }
        public ExistenciaHelp ExistenciaHelp { get; set; }
        public delegate void DataGridViewCell(object sender, DataGridViewCellEventArgs e);
        public DataTable Table;
        public string[] NameButtons { get; set; }
        // Declare the event.
        public event DataGridViewCell CellClick;
        string[,] _existencias ={{"Id","false"} ,{"Fecha","true" },
                                 {"Concepto","true" },{ "Cantidad", "true" },
                                 { "Entrada", "false" }, {"ProductoId","false" },
                                 {"Producto","false" }
        };

        string[,] _producto = {
                                {"Id","false" },{"Codigo" ,"true" },
                                {"Nombre","true" },{"Costo","true" },
                                { "Precio","true" },{"Categoria","true"  },
                                {"CategoriaId","false" },{"UnidadMedida","true" },
                                {"UnidadMedidaId","false" },{"RutaImagen", "false" },
                                {"Descripcion","false" },{"TotalEntrada","true" },
                                {"TotalSalida","true" },{"TotalExistencia","true" },

        };
        string[,] _facturaEncabezado = { { "Id", "false" }, { "Codigo", "true" },
                                         { "Fecha", "true" },{"UsuarioId","false" },
                                         {"Usuario","false" }, {"NombreEmpleado","true" },
                                         {"ClienteId","false" },{"Cliente","false" },
                                         {"NombreCliente","true" },{"TipoDocumentoId","false" },
                                         {"TipoDocumento","false" },{"TipoDoc","true" },
                                         {"FormapagoId","false" },{"FormaPago","false" },
                                         {"Formapag","true" },{"Observaciones","false" },
                                         {"Subtotal","true" },{"Impuestos","false"},
                                         {"Impuesto","true" },{"Descuento","true" },
                                         {"Detalles","false" },{"TotalPagar","true" },
                                         {"Recibido","true" },{"Cambio","true" },
                                         {"Estado","false" },{"EstadoId","false" },
                                         {"EstadoNombre","true" }
        };
 

  



        public Cuestas()
        {
            InitializeComponent();
        }
        public void MostrarDatos(object datasource)
        {
            if (FacturaHelp != null)
            {
                FacturaHelp.GetDatagrid(dgFacturas, _facturaEncabezado);
            }
            else if (ProductoHelp != null)
            {
                ProductoHelp.GetDatagrid(dgFacturas, _producto);
            }
            else if (ExistenciaHelp != null)
            {
                ExistenciaHelp.GetDatagrid(dgFacturas, _existencias);
            }
            else if(CompraHelp != null)
            {
                CompraHelp.GetDatagrid(dgFacturas, _existencias);
            }
            dgFacturas.DataSource = datasource;
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            CellClick.Invoke(dataGridView , e);
        }

        private void dgFacturas_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (FacturaHelp != null)
            {
                Table = FacturaHelp.GetTable(gridView);
            }
            else if (ProductoHelp != null)
            {
                Table = ProductoHelp.GetTable(gridView);
            }
            else if (ExistenciaHelp != null)
            {
                Table = ExistenciaHelp.GetTable(gridView);            
            }
            else if (CompraHelp != null)
            {
                Table = CompraHelp.GetTable(gridView);
            }
        }

        private void Cuestas_Load(object sender, EventArgs e)
        {
           if (NameButtons==null)
            {
                return;
            }
            List<DataGridViewButtonColumn> buttonColumns = new List<DataGridViewButtonColumn>();  
            for (int i = 0; i <= NameButtons.Length - 1; i++)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    FlatStyle = FlatStyle.Flat,
                    Name = NameButtons[i],
                    HeaderText =string .Empty,
                    Text =NameButtons[i],
                    UseColumnTextForButtonValue = true,
                    Visible = true,
                };
                buttonColumns.Add(buttonColumn);
            }
            dgFacturas.Columns.AddRange (buttonColumns.ToArray());
        }
    }
}
