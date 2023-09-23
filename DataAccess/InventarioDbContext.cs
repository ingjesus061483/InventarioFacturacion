using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataAccess
{
    public class InventarioDbContext : DbContext
    {       
        public InventarioDbContext() : base(ConfigurationManager.ConnectionStrings["Inventario"].ConnectionString )
        {

        }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet <Empresa > Empresas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Existencia> Existencias { get; set; }
        public  DbSet<Categoria> Categorias { get; set; }
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }
        public  DbSet<UnidadMedida> UnidadMedidas { get; set; }
        public DbSet<TipoRegimen> TipoRegimens { get; set; }
        public DbSet<Cliente >Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Usuario >Usuarios { get; set; }
        public DbSet <Impuesto > Impuestos { get; set; }
        public DbSet <TipoDocumento >TipoDocumentos { get; set; }
        public DbSet<FormaPago >FormaPagos { get; set; }
        public DbSet <FacturaEncabezado> FacturaEncabezados { get; set; }
        public DbSet <FacturaDetalle >FacturaDetalles { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet <OrdenCompra > OrdenCompras { get;set; }
        public DbSet<OrdenCompraDetalle >OrdenCompraDetalles { get; set; }
        public DbSet<Motivo >Motivos { get; set; }
        public DbSet <DevolucionVenta >DevolucionVentas { get; set; }
        public DbSet<DevolucionCompra> DevolucionCompras { get; set; }
    }
}
