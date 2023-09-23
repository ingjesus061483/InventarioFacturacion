using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoBarra;
namespace Helper
{

    public class ImpresoraHelp : Help
    {
        CodigoBarras _CodigoBarras;
        private PrintDocument printer;
        public ImpresoraHelp()
        {
           printer  = new PrintDocument();
        }
        int linea_actual = 0;

        public override DataTable Table => throw new NotImplementedException();   
        public override void GetDatagrid(System.Windows.Forms.DataGridView gridView, string[,] columns)
        {
            throw new NotImplementedException();
        }
        public void ImprimirVenta(FacturaEncabezado factura)
        {           
            StreamWriter sw = CrearArchivo();
            try
            {

                if (factura  == null)
                {

                    return;
                }
                var cliente = factura.Cliente;
                var empresa = factura.Usuario.Empresa;
                sw.WriteLine("========= Datos de Empresa ==============");
                sw.WriteLine("=" + empresa.Nombre);
                sw.WriteLine("Nit:" + empresa.Nit);
                sw.WriteLine("Direccion:" + empresa.Direccion);
                sw.WriteLine("=Tipo de regimen:" + empresa.TipoRegimen.Nombre);
                sw.WriteLine("Telefono:" + empresa.Telefono);
                sw.WriteLine("=========================================");
                sw.WriteLine("========== Encabezado ====================");
                sw.WriteLine("Tipo de Documento: " + factura.TipoDoc  + " No. " + factura.Codigo );
                sw.WriteLine("Fecha: " + factura.Fecha);
                sw.WriteLine("Forma de pago:" + factura.Formapag );
                sw.WriteLine("Estado:" + factura.EstadoNombre);
                sw.WriteLine("=========================================");
                if (cliente != null) {
                    sw.WriteLine("===== Informacion Cliente ===========");
                    sw.WriteLine("Tipo de identificacion:" + cliente.TipoIdentificacion.Nombre  );
                    sw.WriteLine("Identifcacion: " + cliente.Identificacion);
                    sw.WriteLine("Nombre Completo: " + cliente.NombreCompleto );
                    sw.WriteLine("Direccion: " + cliente.Direccion);
                    sw.WriteLine("Telefono: " + cliente.Telefono);
                    sw.WriteLine("=====================================");
                }
                decimal sumdetalle = 0;
                if (factura.Detalles.Count != 0)
                {
                    sw.WriteLine("==============  Detalle   ==================");
                    foreach (var item in factura.Detalles)
                    {
                        var arti = item.Producto;
                        sw.WriteLine("= codigo: " + arti.Codigo);
                        sw.WriteLine("= Articulo: " + arti.Nombre );
                        sw.WriteLine("Cantidad: " + item.Cantidad);
                        sw.WriteLine("Valor Unitario: $" + item.ValorUnitario);
                        sw.WriteLine("Total: $" + item.Total);
                        sumdetalle += item.Total;
                    }
                    sw.WriteLine("=========================================");
                }
                sw.WriteLine("=============== Totales ===================");
                sw.WriteLine("= Subtotal: $" + factura.Subtotal);
                sw.WriteLine("= Total impuesto $" + factura.Impuesto );
                sw.WriteLine("= Descuento $" + factura.Descuento);                
                sw.WriteLine("= Total a pagar $" + factura.TotalPagar );
                sw.WriteLine("= Recibido: $" + factura.Recibido);
                sw.WriteLine("= Cambio: $" + factura.Cambio);
                sw.WriteLine("==========================================");
                if (!string.IsNullOrEmpty(empresa.Slogan ))
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("  " + empresa.Slogan);
                    sw.WriteLine("==========================================");
                }
                sw.WriteLine("==========================================");
                sw.WriteLine("=          GRACIAS POR SU COMPRA         =");
                sw.WriteLine("==========================================");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
                printer.PrintPage += Printer_PrintPage;

                printer.Print();

            }
        }
       public  void ImprimirCodigoBarras( CodigoBarras codigoBarras )
        {
           
            _CodigoBarras=codigoBarras;

            printer.PrintPage += Printer_PrintPage1;
            printer.Print();
        }

        private void Printer_PrintPage1(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Printer_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            int pagina = 0;

            Font Fuente = new Font("arial", 10, FontStyle.Regular);
        int salto_linea =int.Parse ( Fuente.GetHeight(e.Graphics).ToString()) ;
            //     Dim lineHeight As Single
            //   lineHeight = Fuente.GetHeight(e.Graphics)
            e.HasMorePages = false;
            linea_actual += 1;
            // CopiarPictureBox()
            // e.Graphics.DrawImage(imgEAN.Image, 10, 10)
            _CodigoBarras.DibujarCodigoBarras(e.Graphics);
            linea_actual += 1;
            if (linea_actual * salto_linea >= e.MarginBounds.Bottom) 
            {
                pagina += 1;
                linea_actual = 0;
                e.HasMorePages = true;
            }


        }
        private void Printer_PrintPage(object sender, PrintPageEventArgs e)
        {
            StreamReader sreader = LeerArchivo();
            try
            {
                Font font = new Font("arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                float tam = font.Size + 5;
                float y = 0;
                string line = "";
                line = sreader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    if (line.IndexOf("=") == -1)
                    {
                        font = new Font("arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                        e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y, 3000, 20));
                    }
                    else
                    {
                        font = new Font("arial", 8, FontStyle.Bold, GraphicsUnit.Point);
                        e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y, 3000, 20));
                    }
                    line = sreader.ReadLine();
                    y += tam;
                }
            }

            catch (Exception ex)
            {
                e.Cancel = true;
                throw ex;
            }
            finally
            {
                sreader.Close();
                EliminarArchivo();
            }
        }
    }
}
