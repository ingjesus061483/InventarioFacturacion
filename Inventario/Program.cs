using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataAccess;
using Helper;

namespace Inventario
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServiceCollection services =new ServiceCollection();
            Configservice(services);
            //using var servicesprovider = services.BuildServiceProvider();
            var servicesprovider = services.BuildServiceProvider();
            var frmPrincipal = servicesprovider.GetRequiredService<frmPrincipal>();
            Application.Run(frmPrincipal);
        }
        static void Configservice(ServiceCollection services)
        {        
            services.AddScoped<ProductoHelp>();
            services.AddScoped<UnidaMedidaHelp>();
            services.AddScoped<CategoriaHelp>();
            services.AddScoped<InventarioDbContext>();
            services.AddScoped<frmPrincipal>();
            services.AddScoped<RoleHelp>();
            services.AddScoped<ExistenciaHelp>();
            services.AddScoped<TipoIdentificacionHelp>();
            services.AddScoped<ClienteHelp>();
            services.AddScoped<TipoRegimenHelp>();
            services.AddScoped<EmpresaHelp>();
            services.AddScoped<ProveedorHelp>();
            services.AddScoped<EmpleadoHelp>();
            services.AddScoped<ImpuestoHelp>();
            services.AddScoped<UsuarioHelp>();
            services.AddScoped<TipoDocumentoHelp>();
            services.AddScoped<FormaPagoHelp>();
            services.AddScoped<FacturaHelp>();
            services.AddScoped<ImpresoraHelp>();
            services.AddScoped<CompraHelp>();
            services.AddScoped<MotivoHelp>();
            services.AddScoped<DevolucionVentaHelp>();
            services.AddScoped<DevolucionCompraHelp>();
            services.AddScoped<EstadoHelp>();
            services.AddScoped<EmailHelp>();
        }
    }
}
