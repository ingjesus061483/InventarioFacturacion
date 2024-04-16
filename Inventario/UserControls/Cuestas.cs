using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Inventario.UserControls
{
    public partial class Cuestas : UserControl
    {
        public CompraHelp CompraHelp { get; set; }
        public  ProductoHelp  ProductoHelp { get; set; }
        public FacturaHelp FacturaHelp { get; set; }
        public ExistenciaHelp ExistenciaHelp { get; set; }
        public delegate void DataSourceChanged(object sender, EventArgs e);
        public delegate void DataGridViewCell(object sender, DataGridViewCellEventArgs e);
        public DataTable Table;
        public string[] NameButtons { get; set; }
        // Declare the event.
        public event DataSourceChanged DataSource;
        public event DataGridViewCell CellClick;
        string[,] _existencias ={{"Id","false"} ,{"Fecha","true" },
                                 {"Concepto","true" },{ "Cantidad", "true" },
                                 { "Entrada", "false" }, {"ProductoId","false" },
                                 {"Producto","true" }
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
                                         {"Usuario","true" }, 
                                         {"ClienteId","false" },{"Cliente","true" },
                                         {"TipoDocumentoId","false" },
                                         {"TipoDocumento","true" },
                                         {"FormapagoId","false" },{"FormaPago","true" },
                                         {"Observaciones","false" },
                                         {"Subtotal","true" },
                                         {"Impuesto","true" },{"Descuento","true" },
                                         {"Detalles","false" },{"TotalPagar","true" },
                                         {"Recibido","true" },{"Cambio","true" },
                                         {"Estado","true" },{"EstadoId","false" },                                
        };
 

  



        public Cuestas()
        {
            InitializeComponent();
        }
        public void MostrarDatos(object datasource)
        {
            if (FacturaHelp != null)
            {
                Utilities .GetDatagrid(dgFacturas, _facturaEncabezado);
            }
            else if (ProductoHelp != null)
            {
                Utilities.GetDatagrid(dgFacturas, _producto);
            }
            else if (ExistenciaHelp != null)
            {
                Utilities .GetDatagrid(dgFacturas, _existencias);
            }
            else if(CompraHelp != null)
            {
                Utilities .GetDatagrid(dgFacturas, _existencias);
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
            DataSource.Invoke(gridView, e);
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
