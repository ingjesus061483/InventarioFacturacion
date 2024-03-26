
using Helper;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Inventario
{
    public partial class frmPrincipal : Form
    {
        Usuario Usuario;

        public frmPrincipal(ProductoHelp productContext,
                            CategoriaHelp categoriaHelp,
                            UnidaMedidaHelp unidaMedidaHelp,
                            RoleHelp roleHelp,
                            TipoIdentificacionHelp tipoIdentificacionHelp, 
                            ClienteHelp clienteHelp ,
                            ExistenciaHelp existenciaHelp,
                            TipoRegimenHelp tipoRegimenHelp,
                            EmpresaHelp empresaHelp ,
                            ProveedorHelp proveedorHelp,
                            EmpleadoHelp empleadoHelp,
                            ImpuestoHelp impuestoHelp ,
                            UsuarioHelp usuarioHelp ,
                            TipoDocumentoHelp tipoDocumentoHelp,
                            FormaPagoHelp formaPagoHelp,
                            FacturaHelp facturaHelp,
                            ImpresoraHelp impresoraHelp ,
                            CompraHelp compraHelp ,
                            MotivoHelp motivoHelp,
                            DevolucionVentaHelp devolucionVentaHelp ,
                            EstadoHelp estadoHelp ,
                            DevolucionCompraHelp devoluvionCompraHelp,
                            EmailHelp emailHelp)
        {
            _estadoHelp = estadoHelp;
            _compraHelp = compraHelp;
            _impuestoHelp = impuestoHelp;
            _facturaHelp = facturaHelp;
            _existenciaHelp = existenciaHelp;
            _tipoRegimenHelp = tipoRegimenHelp;
            _tipoIdentificacionHelp = tipoIdentificacionHelp;
            _categoryHelp = categoriaHelp;
            _clienteHelp = clienteHelp;
            _unidaMedidaHelp = unidaMedidaHelp;
            _productContext = productContext;
            _roleHelp = roleHelp;
            _empresaHelp = empresaHelp;
            _proveedorHelp = proveedorHelp;
            _empleadoHelp = empleadoHelp;
            _usuarioHelp = usuarioHelp;
            _formaPagoHelp = formaPagoHelp;
            _tipoDocumentoHelp = tipoDocumentoHelp;
            _impresoraHelp = impresoraHelp;
            _motivoHelp = motivoHelp;
            _devolucionVentaHelp = devolucionVentaHelp;
            _devolucionCompraHelp = devoluvionCompraHelp;
            _emailHelp = emailHelp;
            InitializeComponent();
        }

        private void FrmPrincipal_CerrarForm(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Salir de la aplicacion", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                e.Cancel = false;
    //            this.Close();
            }
            else 
            {

                e.Cancel = true;
            }
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(_usuarioHelp);
            frmLogin.ShowDialog();
            Usuario = frmLogin.Login;
            _usuarioHelp.Login = Usuario;
            if (Usuario == null)
            {
                this.Close();
                return;
            }
          
            this.BackgroundImage = Usuario.Empresa.Logo == "" ? null : Image.FromFile(Usuario.Empresa.Logo); 
            this.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();

        }
        
        private void ArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  frmProducto frmArticulo = new frmProducto(_productContext,_categoryHelp , _unidaMedidaHelp,_existenciaHelp  );
            frmInventarioProducto frmInventarioProducto = new frmInventarioProducto(_productContext,
                                                                                    _categoryHelp,
                                                                                    _existenciaHelp,
                                                                                    _unidaMedidaHelp);
            frmInventarioProducto.Empresa = Usuario.Empresa; 
            if (!BuscarFormulariosAbiertos(frmInventarioProducto ))
            {
                MostrarFormulario(frmInventarioProducto );
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria(_categoryHelp);
            if (!BuscarFormulariosAbiertos(frmCategoria))
            {
                MostrarFormulario(frmCategoria);
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRole frmRole = new frmRole(_roleHelp);
            if (!BuscarFormulariosAbiertos(frmRole))
            {
                MostrarFormulario(frmRole);
            }
        }


        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(_clienteHelp, _tipoIdentificacionHelp);
            if (!BuscarFormulariosAbiertos(frmCliente))
            {
                MostrarFormulario(frmCliente);
            }
        }

        private void ArchvoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa(_tipoRegimenHelp, _empresaHelp);
            if (!BuscarFormulariosAbiertos(frmEmpresa))
            {
                MostrarFormulario(frmEmpresa);
            }
        }

        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores  frmProveedores  = new frmProveedores (_proveedorHelp , _tipoIdentificacionHelp);
            if (!BuscarFormulariosAbiertos(frmProveedores))
            {
                MostrarFormulario(frmProveedores);
            }
        }

        private void EmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado(_empleadoHelp,
                                                      _tipoIdentificacionHelp,
                                                      _usuarioHelp,
                                                      _empresaHelp,
                                                      _roleHelp );
            if (!BuscarFormulariosAbiertos(frmEmpleado))
            {
                MostrarFormulario(frmEmpleado);
            }
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpuesto frmImpuesto = new frmImpuesto(_impuestoHelp);
            if (!BuscarFormulariosAbiertos(frmImpuesto))
            {
                MostrarFormulario(frmImpuesto);
            }
        }

        private void FacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion frmFacturacion = new frmFacturacion(_tipoDocumentoHelp,
                                                   _formaPagoHelp,
                                                   _usuarioHelp,
                                                   _clienteHelp,
                                                   _tipoIdentificacionHelp,
                                                   _empleadoHelp,
                                                   _productContext,
                                                   _impuestoHelp,
                                                   _facturaHelp,
                                                   _impresoraHelp,
                                                   _devolucionVentaHelp,
                                                   _motivoHelp,
                                                   _estadoHelp);
            if (!BuscarFormulariosAbiertos(frmFacturacion))
            {
                MostrarFormulario(frmFacturacion);
            }
                
        }
        void MostrarFormulario(Form form)
        {
            form.MdiParent = this;
            form.Show();

        }
        bool BuscarFormulariosAbiertos(Form form)
        {
            var forms = Application.OpenForms;
            var esencontrado = false;
            foreach (Form open in forms)
            {
                if (open.Name == form.Name)
                {
                    esencontrado = true;
                    break;
                }
            }
            return esencontrado;
        }

        private void ComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras(_proveedorHelp ,
                                                _empleadoHelp ,
                                                _productContext ,
                                                _compraHelp ,
                                                _usuarioHelp,
                                                _tipoIdentificacionHelp ,
                                                _formaPagoHelp ,
                                                _tipoDocumentoHelp ,_impuestoHelp,
                                                _devolucionCompraHelp,
                                                _motivoHelp);
            if (!BuscarFormulariosAbiertos(frmCompras ))
            {
                MostrarFormulario(frmCompras);
            }
        }

        private void CambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoUsuario frmInfoUsuario = new frmInfoUsuario(_usuarioHelp,_empresaHelp,_roleHelp );
            frmInfoUsuario.Usuario = Usuario;
               
            if (!BuscarFormulariosAbiertos(frmInfoUsuario ))
            {
                MostrarFormulario(frmInfoUsuario );
            }

        }

        private void motivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotivo frmMotivo = new frmMotivo(_motivoHelp);
            if(!BuscarFormulariosAbiertos(frmMotivo))
            {
                MostrarFormulario(frmMotivo);
            }
        }

        private void envioDeCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmail frmEmail = new frmEmail(_emailHelp)
            {
                Usuario = Usuario
            };
            frmEmail.ShowDialog();
            frmEnvioEmail frmEnvioEmail = new frmEnvioEmail(_emailHelp)
            {
                Usuario = Usuario 

            };
            if (!BuscarFormulariosAbiertos(frmEnvioEmail))
            {
                MostrarFormulario(frmEnvioEmail);
            }


            

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
