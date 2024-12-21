
using Helper;
using Helper.DTO;
using Models;

namespace Inventario
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.Empleado = new Inventario.BusquedaCliente();
            this.Proveedorbuscar = new Inventario.BusquedaCliente();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtvalorunit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Producto = new Inventario.BusquedaCliente();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.Detalles = new Inventario.Detalles();
            this.busquedaCliente1 = new Inventario.BusquedaCliente();
            this.customPanel1 = new Inventario.CustomPanel();
            this.customPanel2 = new Inventario.CustomPanel();
            this.customPanel3 = new Inventario.CustomPanel();
            this.customPanel4 = new Inventario.CustomPanel();
            this.customPanel5 = new Inventario.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empleado
            // 
            this.Empleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empleado.Cliente = null;
            this.Empleado.clienteHelp = null;
            this.Empleado.Empleado = null;
            this.Empleado.empleadoHelp = null;
            this.Empleado.Location = new System.Drawing.Point(115, 138);
            this.Empleado.Motivo = null;
            this.Empleado.MotivoHelp = null;
            this.Empleado.Name = "Empleado";
            this.Empleado.Producto = null;
            this.Empleado.productoHelp = null;
            this.Empleado.Proveedor = null;
            this.Empleado.proveedorHelp = null;
            this.Empleado.Size = new System.Drawing.Size(688, 61);
            this.Empleado.TabIndex = 87;
            this.Empleado.TextoBoton = null;
            // 
            // Proveedorbuscar
            // 
            this.Proveedorbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Proveedorbuscar.Cliente = null;
            this.Proveedorbuscar.clienteHelp = null;
            this.Proveedorbuscar.Empleado = null;
            this.Proveedorbuscar.empleadoHelp = null;
            this.Proveedorbuscar.Location = new System.Drawing.Point(114, 81);
            this.Proveedorbuscar.Motivo = null;
            this.Proveedorbuscar.MotivoHelp = null;
            this.Proveedorbuscar.Name = "Proveedorbuscar";
            this.Proveedorbuscar.Producto = null;
            this.Proveedorbuscar.productoHelp = null;
            this.Proveedorbuscar.Proveedor = null;
            this.Proveedorbuscar.proveedorHelp = null;
            this.Proveedorbuscar.Size = new System.Drawing.Size(688, 64);
            this.Proveedorbuscar.TabIndex = 86;
            this.Proveedorbuscar.TextoBoton = null;
            this.Proveedorbuscar.Load += new System.EventHandler(this.Proveedor_Load);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(215, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(585, 30);
            this.txtCodigo.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 85;
            this.label10.Text = "Codigo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(32, 243);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 24);
            this.Label1.TabIndex = 65;
            this.Label1.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Location = new System.Drawing.Point(215, 239);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(582, 30);
            this.dtpFechaEntrega.TabIndex = 64;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(12, 279);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(193, 24);
            this.Label9.TabIndex = 63;
            this.Label9.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(215, 276);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(582, 31);
            this.cmbTipoDocumento.TabIndex = 62;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(140, 207);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(67, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(218, 203);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(580, 30);
            this.dtpfecha.TabIndex = 58;
            // 
            // TextBox4
            // 
            this.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox4.Location = new System.Drawing.Point(0, 0);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox4.Size = new System.Drawing.Size(350, 228);
            this.TextBox4.TabIndex = 97;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(764, 1095);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 94;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.Location = new System.Drawing.Point(699, 1095);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(60, 60);
            this.btninsertar.TabIndex = 92;
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(58, 63);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(89, 24);
            this.lblsubtotal.TabIndex = 95;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(164, 60);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(207, 30);
            this.txtsubtotal.TabIndex = 88;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(50, 102);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(97, 24);
            this.Label5.TabIndex = 87;
            this.Label5.Text = "Impuesto";
            // 
            // txtiva
            // 
            this.txtiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtiva.BackColor = System.Drawing.SystemColors.Control;
            this.txtiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiva.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(164, 96);
            this.txtiva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(207, 30);
            this.txtiva.TabIndex = 89;
            this.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(30, 135);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 24);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "Total pagar";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalpagar.BackColor = System.Drawing.SystemColors.Control;
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(164, 132);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(207, 30);
            this.txttotalpagar.TabIndex = 90;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(171, 101);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.ReadOnly = true;
            this.txtexistencia.Size = new System.Drawing.Size(72, 30);
            this.txtexistencia.TabIndex = 67;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(42, 103);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 24);
            this.Label6.TabIndex = 68;
            this.Label6.Text = "Existencias";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(171, 137);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(632, 30);
            this.txtcantidad.TabIndex = 60;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(56, 143);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 24);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Cantidad";
            // 
            // txtvalorunit
            // 
            this.txtvalorunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalorunit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunit.Location = new System.Drawing.Point(400, 101);
            this.txtvalorunit.Name = "txtvalorunit";
            this.txtvalorunit.ReadOnly = true;
            this.txtvalorunit.Size = new System.Drawing.Size(403, 30);
            this.txtvalorunit.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(252, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 24);
            this.Label3.TabIndex = 65;
            this.Label3.Text = "Valor Unitario";
            // 
            // Producto
            // 
            this.Producto.Cliente = null;
            this.Producto.clienteHelp = null;
            this.Producto.Empleado = null;
            this.Producto.empleadoHelp = null;
            this.Producto.Location = new System.Drawing.Point(16, 19);
            this.Producto.Motivo = null;
            this.Producto.MotivoHelp = null;
            this.Producto.Name = "Producto";
            this.Producto.Producto = null;
            this.Producto.productoHelp = null;
            this.Producto.Proveedor = null;
            this.Producto.proveedorHelp = null;
            this.Producto.Size = new System.Drawing.Size(767, 55);
            this.Producto.TabIndex = 88;
            this.Producto.TextoBoton = null;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(803, 582);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 60);
            this.btnQuitar.TabIndex = 100;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadir.BackgroundImage")));
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(740, 582);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(60, 60);
            this.btnAñadir.TabIndex = 101;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Detalles
            // 
            this.Detalles.compraHelp = null;
            this.Detalles.DevolucionVentaHelp = null;
            this.Detalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detalles.facturaHelp = null;
            this.Detalles.Location = new System.Drawing.Point(0, 0);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(829, 200);
            this.Detalles.TabIndex = 102;
            this.Detalles.Load += new System.EventHandler(this.Detalles_Load);
            // 
            // busquedaCliente1
            // 
            this.busquedaCliente1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaCliente1.Cliente = null;
            this.busquedaCliente1.clienteHelp = null;
            this.busquedaCliente1.Empleado = null;
            this.busquedaCliente1.empleadoHelp = null;
            this.busquedaCliente1.Location = new System.Drawing.Point(30, 37);
            this.busquedaCliente1.Motivo = null;
            this.busquedaCliente1.MotivoHelp = null;
            this.busquedaCliente1.Name = "busquedaCliente1";
            this.busquedaCliente1.Producto = null;
            this.busquedaCliente1.productoHelp = null;
            this.busquedaCliente1.Proveedor = null;
            this.busquedaCliente1.proveedorHelp = null;
            this.busquedaCliente1.Size = new System.Drawing.Size(773, 58);
            this.busquedaCliente1.TabIndex = 88;
            this.busquedaCliente1.TextoBoton = null;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.Empleado);
            this.customPanel1.Controls.Add(this.label10);
            this.customPanel1.Controls.Add(this.Proveedorbuscar);
            this.customPanel1.Controls.Add(this.dtpfecha);
            this.customPanel1.Controls.Add(this.txtCodigo);
            this.customPanel1.Controls.Add(this.lblfecha);
            this.customPanel1.Controls.Add(this.cmbTipoDocumento);
            this.customPanel1.Controls.Add(this.Label1);
            this.customPanel1.Controls.Add(this.Label9);
            this.customPanel1.Controls.Add(this.dtpFechaEntrega);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.Location = new System.Drawing.Point(34, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(829, 354);
            this.customPanel1.TabIndex = 103;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.busquedaCliente1);
            this.customPanel2.Controls.Add(this.txtexistencia);
            this.customPanel2.Controls.Add(this.Label3);
            this.customPanel2.Controls.Add(this.Label6);
            this.customPanel2.Controls.Add(this.txtvalorunit);
            this.customPanel2.Controls.Add(this.txtcantidad);
            this.customPanel2.Controls.Add(this.Label4);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel2.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel2.Location = new System.Drawing.Point(34, 379);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(829, 200);
            this.customPanel2.TabIndex = 104;
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.Detalles);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel3.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel3.Location = new System.Drawing.Point(34, 650);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(829, 200);
            this.customPanel3.TabIndex = 105;
            // 
            // customPanel4
            // 
            this.customPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.lblsubtotal);
            this.customPanel4.Controls.Add(this.txtsubtotal);
            this.customPanel4.Controls.Add(this.txttotalpagar);
            this.customPanel4.Controls.Add(this.Label5);
            this.customPanel4.Controls.Add(this.Label2);
            this.customPanel4.Controls.Add(this.txtiva);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 90F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel4.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel4.Location = new System.Drawing.Point(468, 859);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(395, 228);
            this.customPanel4.TabIndex = 106;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.TextBox4);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 90F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel5.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel5.Location = new System.Drawing.Point(34, 859);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(350, 228);
            this.customPanel5.TabIndex = 107;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 912);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cmbTipoDocumento;
        internal System.Windows.Forms.Label lblfecha;
        internal System.Windows.Forms.DateTimePicker dtpfecha;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.Label lblsubtotal;
        internal System.Windows.Forms.TextBox txtsubtotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtiva;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txttotalpagar;
        internal System.Windows.Forms.TextBox txtexistencia;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtvalorunit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label10;
        private BusquedaCliente Empleado;
        private BusquedaCliente Proveedorbuscar;
        private BusquedaCliente Producto;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnAñadir;
        private Detalles Detalles;
        int tipodocumento;
        UsuarioDTO usuario;
        Producto producto;
        Proveedor proveedor;
        ProveedorHelp _proveedorHelp;
        EmpleadoHelp _empleadoHelp;
        ProductoHelp _productoHelp;
        CompraHelp _compraHelp;
        ImpuestoHelp _impuestoHelp;
        UsuarioHelp _usuarioHelp;
        FormaPagoHelp _formaPagoHelp;
        TipoDocumentoHelp _tipoDocumentoHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;
        private BusquedaCliente busquedaCliente1;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private CustomPanel customPanel4;
        private CustomPanel customPanel5;

        public OrdenCompraDTO Compra { get; set; }
    }
  
}