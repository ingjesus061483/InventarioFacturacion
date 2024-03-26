using Helper;
using Helper.View;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmBusqueda : Form
    {
        List<Motivo> motivos;
        List<PersonaView> personas;
        List<Impuesto> impuestos;
        List<Categoria> categorias;
        List<EmpresaView> empresas;
        List<ProductoView> productos;
        List<PersonaView> empleados;
        List<PersonaView> clientes;
        List<PersonaView> proveedores;
        List<Role> roles;
        public DataGridViewRow Row { get; set; }

        public int Id { get; set; }
        public frmBusqueda(EmailHelp emailHelp)
        {
            InitializeComponent();
            personas =emailHelp . Queryable.ToList();
            var persona  = emailHelp .Queryable.FirstOrDefault();
            var properties = persona.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
            emailHelp.Cmb(cmbColumnas, properties);
        }
        public frmBusqueda(EmpresaHelp empresaHelp)
        {
            InitializeComponent();
            var queryable = empresaHelp .Queryable.AsEnumerable().Select(x => new EmpresaView
            {
                Id = x.Id,
                Nit = x.Nit,
                Nombre = x.Nombre,
                CamaraComercio = x.CamaraComercio,
                Direccion = x.Direccion ,
                Telefono = x.Telefono,
                Email = x.Email,
                Contacto = x.Contacto,
                Logo = x.Logo,
                Slogan = x.Slogan,
                TipoRegimenId = x.TipoRegimenId,
                TipoRegimen = x.TipoRegimen.Nombre 
            }).ToList();
            var empresa = queryable.FirstOrDefault();
            var properties = empresa .GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
        empresaHelp .    Cmb(cmbColumnas, properties);
            empresas  = queryable.ToList();
        }
        public frmBusqueda (ImpuestoHelp impuestoHelp)
        {
            InitializeComponent();
           impuestos=impuestoHelp .Queryable.ToList();
            var impuesto = impuestoHelp .Queryable.FirstOrDefault();
            var properties = impuesto .GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           impuestoHelp . Cmb(cmbColumnas, properties);

        }
        public frmBusqueda (MotivoHelp motivoHelp)
        {
            InitializeComponent();
            motivos  = motivoHelp .Queryable.ToList();
            var motivo = motivoHelp .Queryable.FirstOrDefault();
            var properties = motivo .GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           motivoHelp . Cmb(cmbColumnas, properties);

        }
        public frmBusqueda(ProductoHelp productoHelp)
        {
            InitializeComponent();
            var queryable = productoHelp.Queryable.AsEnumerable().Select(x => new ProductoView
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = String.Format("{0:C}", x.Costo),
                Precio = String.Format("{0:C}", x.Precio),
                TotalEntrada = x.TotalEntrada,
                TotalSalida = x.TotalSalida,
                TotalExistencia = x.TotalExistencia,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria = x.Categoria.Nombre,
                UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida = x.UnidadMedida.Nombre
            }).ToList();
            var prod = queryable.FirstOrDefault();
            var properties = prod.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           productoHelp . Cmb(cmbColumnas, properties);
           productos = queryable.ToList();
        }
        public frmBusqueda(ProveedorHelp proveedorHelp)
        {
            InitializeComponent();
            var queryble = proveedorHelp .Queryable.AsEnumerable().Select(x => new PersonaView
            {
                Id = x.Id,
                FechaNacimiento = x.FechaNacimiento,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion.Nombre,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
            });
            var proveedor = queryble.FirstOrDefault();
            var properties = proveedor.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           proveedorHelp . Cmb(cmbColumnas, properties);
            proveedores = queryble.ToList();
        }
        public frmBusqueda (ClienteHelp clienteHelp)
        {
            InitializeComponent();
            var queryble = clienteHelp.Queryable.AsEnumerable().Select(x => new PersonaView
            {
                Id = x.Id,
                FechaNacimiento = x.FechaNacimiento,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion.Nombre,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,                
            });
            var cliente = queryble.FirstOrDefault();
            var properties = cliente .GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           clienteHelp . Cmb(cmbColumnas, properties);
            clientes = queryble.ToList();
        }
       public frmBusqueda(EmpleadoHelp empleadoHelp)
        {
            InitializeComponent();
           var queryble = empleadoHelp.Queryable.AsEnumerable(). Select(x=>new PersonaView {
                Id = x.Id,
                FechaNacimiento = x.FechaNacimiento,
                TipoIdentificacionId = x.TipoIdentificacionId,
                TipoIdentificacion = x.TipoIdentificacion.Nombre ,
                Identificacion = x.Identificacion,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                Telefono = x.Telefono,
                Usuario = x.Usuario .Name ,
                UsuarioId =x.UsuarioId ,
            });
            var empleado = queryble.FirstOrDefault();
            var properties =empleado .GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           empleadoHelp . Cmb(cmbColumnas, properties);
            empleados = queryble.ToList();
            
        }
        public frmBusqueda(RoleHelp roleHelp)
        {
            InitializeComponent();
            roles =roleHelp .Queryable.ToList();
            var role =roleHelp .Queryable.FirstOrDefault();
            var properties = role.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           roleHelp . Cmb(cmbColumnas, properties);
            

        }
        public frmBusqueda(DataTable dt)
        {
            InitializeComponent();
            
        }
        public frmBusqueda(CategoriaHelp  categoriaHelp )
        {
            InitializeComponent();
            categorias = categoriaHelp.Queryable.ToList();
            var categoria=categoriaHelp.Queryable .FirstOrDefault();
            var properties = categoria.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();
           categoriaHelp . Cmb(cmbColumnas, properties);
          

        }
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            if(personas!=null)
            {
                dgVer.DataSource = personas;
            }
            if (empresas !=null )
            {
                dgVer.DataSource = empresas;
            }
            if(categorias !=null)
            {
                dgVer.DataSource = categorias;
            }
            if(roles!=null)
            {
                dgVer.DataSource = roles;
            }
            if(empleados !=null)
            {
                dgVer.DataSource = empleados ;

            }
            if(clientes!=null)
            {
                dgVer.DataSource = clientes;
            }
            if(proveedores !=null)
            {
                dgVer.DataSource = proveedores;
            }
            if(productos!=null)
            {
                dgVer.DataSource = productos;
            }
            if(motivos!=null)
            {
                dgVer.DataSource = motivos;
            }
            if(impuestos!=null)
            {
                dgVer.DataSource = impuestos;
            }
        }
        object GetResult(string property, string search)
        {
            if(personas!=null)
            {
                List<PersonaView > result = personas.Where(x => x.GetType().GetProperty(property)
                                                                      .GetValue(x).ToString()
                                                                      .Contains(search)).ToList();
                return result.Count == 0 ? personas : result;
            }
            if(empresas !=null)
            {
                List<EmpresaView > result = empresas.Where(x => x.GetType().GetProperty(property)
                                                                       .GetValue(x).ToString()
                                                                       .Contains(search)).ToList();
                return result.Count == 0 ? empresas  : result;
            }
            if (categorias != null)
            {
                List<Categoria> result = categorias.Where(x => x.GetType().GetProperty(property)
                                                                       .GetValue(x).ToString()
                                                                       .Contains(search)).ToList();
                return result.Count == 0 ? categorias : result;
            }
            if (roles != null)
            {
                List<Role> result = roles.Where(x => x.GetType().GetProperty(property)
                                                                        .GetValue(x).ToString()
                                                                        .Contains(search)).ToList();
                return result.Count == 0 ? roles : result;
            }
            if (empleados != null)
            {
                List<PersonaView> result = empleados.Where(x => x.GetType().GetProperty(property)
                                                                       .GetValue(x).ToString()
                                                                       .Contains(search)).ToList();
                return result.Count == 0 ? empleados : result;
            }
            if (clientes != null)
            {
                List<PersonaView> result = clientes.Where(x => x.GetType().GetProperty(property)
                                                                       .GetValue(x).ToString()
                                                                       .Contains(search)).ToList();
                return result.Count == 0 ? clientes : result;
            }
            if (proveedores != null)
            {
                List<PersonaView> result = proveedores.Where(x => x.GetType().GetProperty(property)
                                                                      .GetValue(x).ToString()
                                                                      .Contains(search)).ToList();
                return result.Count == 0 ? proveedores : result;
            }
            if (motivos != null)
            {
                List<Motivo> result = motivos.Where(x => x.GetType().GetProperty(property)
                                                                     .GetValue(x).ToString()
                                                                     .Contains(search)).ToList();
                return result.Count == 0 ? motivos : result;
            }
            if (impuestos!=null)
            {
                List<Impuesto> result = impuestos .Where(x => x.GetType().GetProperty(property)
                                                              .GetValue(x).ToString()
                                                              .Contains(search)).ToList();
                return result.Count == 0 ? impuestos  : result;
            }

            return null;
        }

        private void dgVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                Id = int.Parse(dgVer.Rows[e.RowIndex].Cells[0].Value.ToString());
                Row = dgVer.Rows[e.RowIndex];
                this.Close();
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
      //      DataTable tblresult = Busqueda(cmbColumnas.Text, txtFiltro.Text, _dt);
            dgVer.DataSource = GetResult(cmbColumnas.Text ,txtFiltro.Text);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
