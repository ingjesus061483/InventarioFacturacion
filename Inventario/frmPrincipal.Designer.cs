
using Helper;

namespace Inventario
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportarEImportarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasPorCobrarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DevolucionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchvoToolStripMenuItem,
            this.VentasToolStripMenuItem,
            this.ComprasToolStripMenuItem,
            this.SistemaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(800, 33);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ArchvoToolStripMenuItem
            // 
            this.ArchvoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticuloToolStripMenuItem,
            this.ClienteToolStripMenuItem,
            this.EmpleadoToolStripMenuItem,
            this.ProveedorToolStripMenuItem,
            this.ExportarEImportarToolStripMenuItem1,
            this.EmpresaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.impuestosToolStripMenuItem,
            this.motivosToolStripMenuItem});
            this.ArchvoToolStripMenuItem.Name = "ArchvoToolStripMenuItem";
            this.ArchvoToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.ArchvoToolStripMenuItem.Text = "Administracion";
            this.ArchvoToolStripMenuItem.Click += new System.EventHandler(this.ArchvoToolStripMenuItem_Click);
            // 
            // ArticuloToolStripMenuItem
            // 
            this.ArticuloToolStripMenuItem.Name = "ArticuloToolStripMenuItem";
            this.ArticuloToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.ArticuloToolStripMenuItem.Text = "Articulo";
            this.ArticuloToolStripMenuItem.Click += new System.EventHandler(this.ArticuloToolStripMenuItem_Click);
            // 
            // ClienteToolStripMenuItem
            // 
            this.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            this.ClienteToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.ClienteToolStripMenuItem.Text = "Cliente";
            this.ClienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // EmpleadoToolStripMenuItem
            // 
            this.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem";
            this.EmpleadoToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.EmpleadoToolStripMenuItem.Text = "Empleado";
            this.EmpleadoToolStripMenuItem.Click += new System.EventHandler(this.EmpleadoToolStripMenuItem_Click);
            // 
            // ProveedorToolStripMenuItem
            // 
            this.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem";
            this.ProveedorToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.ProveedorToolStripMenuItem.Text = "Proveedor";
            this.ProveedorToolStripMenuItem.Click += new System.EventHandler(this.ProveedorToolStripMenuItem_Click);
            // 
            // ExportarEImportarToolStripMenuItem1
            // 
            this.ExportarEImportarToolStripMenuItem1.Name = "ExportarEImportarToolStripMenuItem1";
            this.ExportarEImportarToolStripMenuItem1.Size = new System.Drawing.Size(273, 34);
            this.ExportarEImportarToolStripMenuItem1.Text = "Exportar e importar";
            this.ExportarEImportarToolStripMenuItem1.Click += new System.EventHandler(this.ExportarEImportarToolStripMenuItem1_Click);
            // 
            // EmpresaToolStripMenuItem
            // 
            this.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem";
            this.EmpresaToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.EmpresaToolStripMenuItem.Text = "Empresa";
            this.EmpresaToolStripMenuItem.Click += new System.EventHandler(this.EmpresaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            this.impuestosToolStripMenuItem.Click += new System.EventHandler(this.impuestosToolStripMenuItem_Click);
            // 
            // motivosToolStripMenuItem
            // 
            this.motivosToolStripMenuItem.Name = "motivosToolStripMenuItem";
            this.motivosToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.motivosToolStripMenuItem.Text = "Motivos Devolucion";
            this.motivosToolStripMenuItem.Click += new System.EventHandler(this.motivosToolStripMenuItem_Click);
            // 
            // VentasToolStripMenuItem
            // 
            this.VentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FacturaToolStripMenuItem,
            this.DevolucionesToolStripMenuItem,
            this.CuentasPorCobrarMenuItem});
            this.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem";
            this.VentasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.VentasToolStripMenuItem.Text = "Ventas";
            // 
            // FacturaToolStripMenuItem
            // 
            this.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem";
            this.FacturaToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.FacturaToolStripMenuItem.Text = "Facturacion";
            this.FacturaToolStripMenuItem.Click += new System.EventHandler(this.FacturaToolStripMenuItem_Click);
            // 
            // DevolucionesToolStripMenuItem
            // 
            this.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem";
            this.DevolucionesToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.DevolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // CuentasPorCobrarMenuItem
            // 
            this.CuentasPorCobrarMenuItem.Name = "CuentasPorCobrarMenuItem";
            this.CuentasPorCobrarMenuItem.Size = new System.Drawing.Size(266, 34);
            this.CuentasPorCobrarMenuItem.Text = "Cuentas por cobrar";
            // 
            // ComprasToolStripMenuItem
            // 
            this.ComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComprasToolStripMenuItem1,
            this.DevolucionesToolStripMenuItem1,
            this.CuentasPorPagarToolStripMenuItem});
            this.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem";
            this.ComprasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.ComprasToolStripMenuItem.Text = "Compras";
            // 
            // ComprasToolStripMenuItem1
            // 
            this.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1";
            this.ComprasToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.ComprasToolStripMenuItem1.Text = "Compras";
            this.ComprasToolStripMenuItem1.Click += new System.EventHandler(this.ComprasToolStripMenuItem1_Click);
            // 
            // DevolucionesToolStripMenuItem1
            // 
            this.DevolucionesToolStripMenuItem1.Name = "DevolucionesToolStripMenuItem1";
            this.DevolucionesToolStripMenuItem1.Size = new System.Drawing.Size(261, 34);
            this.DevolucionesToolStripMenuItem1.Text = "Devoluciones";
            // 
            // CuentasPorPagarToolStripMenuItem
            // 
            this.CuentasPorPagarToolStripMenuItem.Name = "CuentasPorPagarToolStripMenuItem";
            this.CuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.CuentasPorPagarToolStripMenuItem.Text = "Cuentas por pagar";
            // 
            // SistemaToolStripMenuItem
            // 
            this.SistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambioDeContraseñaToolStripMenuItem,
            this.SalirToolStripMenuItem,
            this.envioDeCorreoToolStripMenuItem});
            this.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem";
            this.SistemaToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.SistemaToolStripMenuItem.Text = "Sistema";
            // 
            // CambioDeContraseñaToolStripMenuItem
            // 
            this.CambioDeContraseñaToolStripMenuItem.Name = "CambioDeContraseñaToolStripMenuItem";
            this.CambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.CambioDeContraseñaToolStripMenuItem.Text = "Informacion del usuario";
            this.CambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambioDeContraseñaToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // envioDeCorreoToolStripMenuItem
            // 
            this.envioDeCorreoToolStripMenuItem.Name = "envioDeCorreoToolStripMenuItem";
            this.envioDeCorreoToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.envioDeCorreoToolStripMenuItem.Text = "Envio de correo";
            this.envioDeCorreoToolStripMenuItem.Click += new System.EventHandler(this.envioDeCorreoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_CerrarForm);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ArchvoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ArticuloToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ClienteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EmpleadoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProveedorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportarEImportarToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem EmpresaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VentasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FacturaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DevolucionesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CuentasPorCobrarMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ComprasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ComprasToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DevolucionesToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem CuentasPorPagarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SistemaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CambioDeContraseñaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeCorreoToolStripMenuItem;


        readonly ExistenciaHelp _existenciaHelp;
        readonly ProductoHelp _productContext;
        readonly CategoriaHelp _categoryHelp;
        readonly UnidaMedidaHelp _unidaMedidaHelp;
        readonly RoleHelp _roleHelp;
        readonly TipoIdentificacionHelp _tipoIdentificacionHelp;
        readonly ClienteHelp _clienteHelp;
        readonly TipoRegimenHelp _tipoRegimenHelp;
        readonly EmpresaHelp _empresaHelp;
        readonly ProveedorHelp _proveedorHelp;
        readonly EmpleadoHelp _empleadoHelp;
        readonly UsuarioHelp _usuarioHelp;
        readonly ImpuestoHelp _impuestoHelp;
        readonly TipoDocumentoHelp _tipoDocumentoHelp;
        readonly FormaPagoHelp _formaPagoHelp;
        readonly FacturaHelp _facturaHelp;
        readonly ImpresoraHelp _impresoraHelp;
        readonly CompraHelp _compraHelp;
        readonly MotivoHelp _motivoHelp;
        readonly DevolucionVentaHelp _devolucionVentaHelp;
        readonly EstadoHelp _estadoHelp;
        readonly DevolucionCompraHelp _devolucionCompraHelp;
        readonly EmailHelp _emailHelp;
        readonly ExportarHelp _impExpHelp;
        readonly ImportarHelp _importarHelp;
    }
}