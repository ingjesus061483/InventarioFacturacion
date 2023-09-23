namespace DataAccess.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.InventarioDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =  true;
            AutomaticMigrationDataLossAllowed = true;            
        }

        protected override void Seed(DataAccess.InventarioDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //  
            
            Estado[] estados ={
                new Estado { Nombre ="Pago"},
                new Estado {Nombre="Credito"},
                new Estado {Nombre="En tramite"},
                new Estado {Nombre ="Anulado"}
            };
            context.Estados.AddOrUpdate(estados);
            UnidadMedida[] unidadMedidas  = {
                new UnidadMedida { Nombre = "litro" },
                new UnidadMedida { Nombre = "gramo" },
                new UnidadMedida { Nombre = "Unidad" }
            };
            context.UnidadMedidas.AddOrUpdate (unidadMedidas );
         
            FormaPago [] formaPagos ={
                new FormaPago { Nombre="Contado"},
                new FormaPago { Nombre = "Credito" }
            };
            context.FormaPagos.AddOrUpdate (formaPagos);
            
            TipoDocumento[] tipoDocumentos = {
            new TipoDocumento  { Nombre="Factura"},
                new TipoDocumento { Nombre = "Ticket pos" },
                new TipoDocumento { Nombre = "Compra" }
            };
            context.TipoDocumentos.AddOrUpdate (tipoDocumentos);

            TipoIdentificacion[] tipoIdentificacions =
            {
                new TipoIdentificacion{Nombre="Cedula"},
                new TipoIdentificacion{ Nombre ="Nit"}
            };            
            context.TipoIdentificacions.AddOrUpdate (tipoIdentificacions);
           
            TipoRegimen[] tipoRegimens =
            {
                new TipoRegimen{Nombre ="Simplificado"},
                new TipoRegimen{Nombre="Comun"}
            };
            context.TipoRegimens.AddOrUpdate (tipoRegimens);
            
            Role role = new Role { Nombre = "Administrador" };
            context.Roles.AddOrUpdate (role);
            
            context.SaveChanges();   
            
            var tipoidentificacion = context.TipoIdentificacions.FirstOrDefault();
            var tipoRegimen = context.TipoRegimens.FirstOrDefault();                     
            role = context.Roles.FirstOrDefault();

            Empresa empresa = new Empresa {
                Nit = "1111",
                Nombre = "empresa",
                CamaraComercio = "2222",
                Direccion = "b7quilla",
                Telefono = "111",
                Email = "aaa",
                Contacto = "ffff",
                TipoRegimenId = tipoRegimen.Id

            };

            context.Empresas.AddOrUpdate (empresa);
            context.SaveChanges();
            empresa = context.Empresas.FirstOrDefault();
            Usuario usuario = new Usuario {
                Name = "admin",
                Email = "admin@example.com",
                Password = "admin1234.",
                RoleId = role.Id,
                EmpresaId = empresa.Id

            };
            context.Usuarios.AddOrUpdate (usuario);
            context.SaveChanges();
            usuario = context.Usuarios.FirstOrDefault();

            Empleado empleado = new Empleado
            {
                Identificacion = "111",
                Nombre = "administrador",
                Apellido = "administrador",
                Direccion ="b/quilla",
                Telefono ="444",
                FechaNacimiento =DateTime .Now ,
                PersonaNatural =true,
                TipoIdentificacionId =tipoidentificacion .Id ,
                UsuarioId =usuario .Id 
            };

            context.Empleados.AddOrUpdate (empleado);
            context.SaveChanges();


        }
    }
}
