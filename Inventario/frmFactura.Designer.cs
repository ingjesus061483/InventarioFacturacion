
namespace Inventario
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.busquedaProducto = new Inventario.BusquedaCliente();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtvalorunit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BusquedaEmpleado = new Inventario.BusquedaCliente();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.busquedaCliente1 = new Inventario.BusquedaCliente();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmbFormapago = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.cbodescuento = new System.Windows.Forms.ComboBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.Detalles = new Inventario.Detalles();
            this.customPanel1 = new Inventario.CustomPanel();
            this.customPanel2 = new Inventario.CustomPanel();
            this.customPanel3 = new Inventario.CustomPanel();
            this.customPanel4 = new Inventario.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // busquedaProducto
            // 
            this.busquedaProducto.Cliente = null;
            this.busquedaProducto.clienteHelp = null;
            this.busquedaProducto.Empleado = null;
            this.busquedaProducto.empleadoHelp = null;
            this.busquedaProducto.Location = new System.Drawing.Point(55, 56);
            this.busquedaProducto.Motivo = null;
            this.busquedaProducto.MotivoHelp = null;
            this.busquedaProducto.Name = "busquedaProducto";
            this.busquedaProducto.Producto = null;
            this.busquedaProducto.productoHelp = null;
            this.busquedaProducto.Proveedor = null;
            this.busquedaProducto.proveedorHelp = null;
            this.busquedaProducto.Size = new System.Drawing.Size(693, 66);
            this.busquedaProducto.TabIndex = 81;
            this.busquedaProducto.TextoBoton = null;
            this.busquedaProducto.Load += new System.EventHandler(this.busquedaProducto_Load);
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(222, 127);
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
            this.Label6.Location = new System.Drawing.Point(96, 130);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 24);
            this.Label6.TabIndex = 68;
            this.Label6.Text = "Existencias";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(222, 163);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(526, 30);
            this.txtcantidad.TabIndex = 60;
            this.txtcantidad.Text = "1";
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(116, 166);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 24);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Cantidad";
            // 
            // txtvalorunit
            // 
            this.txtvalorunit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunit.Location = new System.Drawing.Point(484, 127);
            this.txtvalorunit.Name = "txtvalorunit";
            this.txtvalorunit.ReadOnly = true;
            this.txtvalorunit.Size = new System.Drawing.Size(264, 30);
            this.txtvalorunit.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(339, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 24);
            this.Label3.TabIndex = 65;
            this.Label3.Text = "Valor Unitario";
            // 
            // BusquedaEmpleado
            // 
            this.BusquedaEmpleado.Cliente = null;
            this.BusquedaEmpleado.clienteHelp = null;
            this.BusquedaEmpleado.Empleado = null;
            this.BusquedaEmpleado.empleadoHelp = null;
            this.BusquedaEmpleado.Location = new System.Drawing.Point(127, 137);
            this.BusquedaEmpleado.Motivo = null;
            this.BusquedaEmpleado.MotivoHelp = null;
            this.BusquedaEmpleado.Name = "BusquedaEmpleado";
            this.BusquedaEmpleado.Producto = null;
            this.BusquedaEmpleado.productoHelp = null;
            this.BusquedaEmpleado.Proveedor = null;
            this.BusquedaEmpleado.proveedorHelp = null;
            this.BusquedaEmpleado.Size = new System.Drawing.Size(624, 51);
            this.BusquedaEmpleado.TabIndex = 80;
            this.BusquedaEmpleado.TextoBoton = null;
            this.BusquedaEmpleado.Load += new System.EventHandler(this.BusquedaEmpleado_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(231, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(520, 30);
            this.txtCodigo.TabIndex = 78;
            // 
            // busquedaCliente1
            // 
            this.busquedaCliente1.Cliente = null;
            this.busquedaCliente1.clienteHelp = null;
            this.busquedaCliente1.Empleado = null;
            this.busquedaCliente1.empleadoHelp = null;
            this.busquedaCliente1.Location = new System.Drawing.Point(129, 79);
            this.busquedaCliente1.Motivo = null;
            this.busquedaCliente1.MotivoHelp = null;
            this.busquedaCliente1.Name = "busquedaCliente1";
            this.busquedaCliente1.Producto = null;
            this.busquedaCliente1.productoHelp = null;
            this.busquedaCliente1.Proveedor = null;
            this.busquedaCliente1.proveedorHelp = null;
            this.busquedaCliente1.Size = new System.Drawing.Size(622, 54);
            this.busquedaCliente1.TabIndex = 80;
            this.busquedaCliente1.TextoBoton = null;
            this.busquedaCliente1.Load += new System.EventHandler(this.busquedaCliente1_Load);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(25, 265);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(193, 24);
            this.Label9.TabIndex = 63;
            this.Label9.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(227, 264);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(526, 28);
            this.cmbTipoDocumento.TabIndex = 62;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // cmbFormapago
            // 
            this.cmbFormapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormapago.FormattingEnabled = true;
            this.cmbFormapago.Location = new System.Drawing.Point(227, 229);
            this.cmbFormapago.Name = "cmbFormapago";
            this.cmbFormapago.Size = new System.Drawing.Size(526, 28);
            this.cmbFormapago.TabIndex = 60;
            this.cmbFormapago.SelectedValueChanged += new System.EventHandler(this.cmbFormapago_SelectedValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(66, 231);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(152, 24);
            this.Label8.TabIndex = 61;
            this.Label8.Text = "Forma de pago";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(154, 196);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(67, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(227, 193);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(526, 30);
            this.dtpfecha.TabIndex = 58;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(81, 266);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(81, 24);
            this.Label11.TabIndex = 82;
            this.Label11.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(171, 263);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(160, 30);
            this.txtCambio.TabIndex = 83;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(70, 220);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 24);
            this.Label10.TabIndex = 80;
            this.Label10.Text = "Recibido";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.Location = new System.Drawing.Point(172, 217);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(160, 30);
            this.txtRecibido.TabIndex = 81;
            this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(424, 316);
            this.TextBox1.TabIndex = 79;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(760, 1182);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 76;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.Location = new System.Drawing.Point(695, 1182);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(60, 60);
            this.btninsertar.TabIndex = 74;
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // cbodescuento
            // 
            this.cbodescuento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodescuento.FormattingEnabled = true;
            this.cbodescuento.ItemHeight = 23;
            this.cbodescuento.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbodescuento.Location = new System.Drawing.Point(172, 126);
            this.cbodescuento.Name = "cbodescuento";
            this.cbodescuento.Size = new System.Drawing.Size(72, 31);
            this.cbodescuento.TabIndex = 78;
            this.cbodescuento.SelectedIndexChanged += new System.EventHandler(this.cbodescuento_SelectedIndexChanged);
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(73, 37);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(89, 24);
            this.lblsubtotal.TabIndex = 77;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(52, 130);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(111, 24);
            this.Label7.TabIndex = 75;
            this.Label7.Text = "Descuento";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(172, 33);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(160, 30);
            this.txtsubtotal.TabIndex = 69;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(52, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(108, 24);
            this.Label5.TabIndex = 70;
            this.Label5.Text = "Impuestos";
            // 
            // txtiva
            // 
            this.txtiva.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(172, 82);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(160, 30);
            this.txtiva.TabIndex = 71;
            this.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(28, 175);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 24);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "Total a pagar";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(172, 171);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(160, 30);
            this.txttotalpagar.TabIndex = 72;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(250, 126);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(81, 30);
            this.txtDescuento.TabIndex = 84;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadir.BackgroundImage")));
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(698, 611);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(60, 60);
            this.btnAñadir.TabIndex = 78;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(766, 611);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 60);
            this.btnQuitar.TabIndex = 78;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Detalles
            // 
            this.Detalles.compraHelp = null;
            this.Detalles.DevolucionVentaHelp = null;
            this.Detalles.facturaHelp = null;
            this.Detalles.Location = new System.Drawing.Point(25, 676);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(801, 168);
            this.Detalles.TabIndex = 80;
            this.Detalles.Load += new System.EventHandler(this.detalles1_Load);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.BusquedaEmpleado);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.dtpfecha);
            this.customPanel1.Controls.Add(this.txtCodigo);
            this.customPanel1.Controls.Add(this.lblfecha);
            this.customPanel1.Controls.Add(this.busquedaCliente1);
            this.customPanel1.Controls.Add(this.Label8);
            this.customPanel1.Controls.Add(this.Label9);
            this.customPanel1.Controls.Add(this.cmbFormapago);
            this.customPanel1.Controls.Add(this.cmbTipoDocumento);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.Location = new System.Drawing.Point(45, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(776, 358);
            this.customPanel1.TabIndex = 81;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.busquedaProducto);
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
            this.customPanel2.Location = new System.Drawing.Point(45, 383);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(778, 223);
            this.customPanel2.TabIndex = 82;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.txtDescuento);
            this.customPanel3.Controls.Add(this.lblsubtotal);
            this.customPanel3.Controls.Add(this.Label11);
            this.customPanel3.Controls.Add(this.txttotalpagar);
            this.customPanel3.Controls.Add(this.txtCambio);
            this.customPanel3.Controls.Add(this.txtsubtotal);
            this.customPanel3.Controls.Add(this.Label10);
            this.customPanel3.Controls.Add(this.Label2);
            this.customPanel3.Controls.Add(this.txtRecibido);
            this.customPanel3.Controls.Add(this.txtiva);
            this.customPanel3.Controls.Add(this.cbodescuento);
            this.customPanel3.Controls.Add(this.Label5);
            this.customPanel3.Controls.Add(this.Label7);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel3.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel3.Location = new System.Drawing.Point(476, 853);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(350, 317);
            this.customPanel3.TabIndex = 83;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.TextBox1);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 90F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel4.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel4.Location = new System.Drawing.Point(25, 854);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(424, 316);
            this.customPanel4.TabIndex = 84;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 1050);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtexistencia;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtvalorunit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cmbFormapago;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblfecha;
        internal System.Windows.Forms.DateTimePicker dtpfecha;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtCambio;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtRecibido;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.ComboBox cbodescuento;
        internal System.Windows.Forms.Label lblsubtotal;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtsubtotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtiva;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txttotalpagar;
        internal System.Windows.Forms.ComboBox cmbTipoDocumento;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAñadir;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.TextBox txtDescuento;
        private BusquedaCliente busquedaCliente1;
        private BusquedaCliente BusquedaEmpleado;
        private BusquedaCliente busquedaProducto;
        private Detalles Detalles;
        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
        private CustomPanel customPanel3;
        private CustomPanel customPanel4;
    }
}