
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.busquedaProducto = new BusquedaCliente();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtvalorunit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BusquedaEmpleado = new BusquedaCliente();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.busquedaCliente1 = new BusquedaCliente();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.Detalles = new Detalles();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.busquedaProducto);
            this.GroupBox2.Controls.Add(this.txtexistencia);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtcantidad);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtvalorunit);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(23, 383);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(803, 199);
            this.GroupBox2.TabIndex = 64;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalle de factura";
            // 
            // busquedaProducto
            // 
            this.busquedaProducto.Cliente = null;
            this.busquedaProducto.clienteHelp = null;
            this.busquedaProducto.Empleado = null;
            this.busquedaProducto.empleadoHelp = null;
            this.busquedaProducto.Location = new System.Drawing.Point(-10, 25);
            this.busquedaProducto.Name = "busquedaProducto";
            this.busquedaProducto.Producto = null;
            this.busquedaProducto.productoHelp = null;
            this.busquedaProducto.Proveedor = null;
            this.busquedaProducto.proveedorHelp = null;
            this.busquedaProducto.Size = new System.Drawing.Size(788, 63);
            this.busquedaProducto.TabIndex = 81;
            this.busquedaProducto.TextoBoton = null;
            this.busquedaProducto.Load += new System.EventHandler(this.busquedaProducto_Load);
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(157, 96);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.ReadOnly = true;
            this.txtexistencia.Size = new System.Drawing.Size(72, 30);
            this.txtexistencia.TabIndex = 67;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(31, 99);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 24);
            this.Label6.TabIndex = 68;
            this.Label6.Text = "Existencias";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(157, 141);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(624, 30);
            this.txtcantidad.TabIndex = 60;
            this.txtcantidad.Text = "1";
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(51, 144);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 24);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Cantidad";
            // 
            // txtvalorunit
            // 
            this.txtvalorunit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunit.Location = new System.Drawing.Point(419, 96);
            this.txtvalorunit.Name = "txtvalorunit";
            this.txtvalorunit.ReadOnly = true;
            this.txtvalorunit.Size = new System.Drawing.Size(362, 30);
            this.txtvalorunit.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(274, 99);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 24);
            this.Label3.TabIndex = 65;
            this.Label3.Text = "Valor Unitario";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BusquedaEmpleado);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtCodigo);
            this.GroupBox1.Controls.Add(this.busquedaCliente1);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.cmbTipoDocumento);
            this.GroupBox1.Controls.Add(this.cmbFormapago);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.lblfecha);
            this.GroupBox1.Controls.Add(this.dtpfecha);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(23, 49);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(803, 318);
            this.GroupBox1.TabIndex = 63;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Encabezado de factura";
            // 
            // BusquedaEmpleado
            // 
            this.BusquedaEmpleado.Cliente = null;
            this.BusquedaEmpleado.clienteHelp = null;
            this.BusquedaEmpleado.Empleado = null;
            this.BusquedaEmpleado.empleadoHelp = null;
            this.BusquedaEmpleado.Location = new System.Drawing.Point(43, 109);
            this.BusquedaEmpleado.Name = "BusquedaEmpleado";
            this.BusquedaEmpleado.Producto = null;
            this.BusquedaEmpleado.productoHelp = null;
            this.BusquedaEmpleado.Proveedor = null;
            this.BusquedaEmpleado.proveedorHelp = null;
            this.BusquedaEmpleado.Size = new System.Drawing.Size(734, 48);
            this.BusquedaEmpleado.TabIndex = 80;
            this.BusquedaEmpleado.TextoBoton = null;
            this.BusquedaEmpleado.Load += new System.EventHandler(this.BusquedaEmpleado_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(221, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(557, 30);
            this.txtCodigo.TabIndex = 78;
            // 
            // busquedaCliente1
            // 
            this.busquedaCliente1.Cliente = null;
            this.busquedaCliente1.clienteHelp = null;
            this.busquedaCliente1.Empleado = null;
            this.busquedaCliente1.empleadoHelp = null;
            this.busquedaCliente1.Location = new System.Drawing.Point(45, 62);
            this.busquedaCliente1.Name = "busquedaCliente1";
            this.busquedaCliente1.Producto = null;
            this.busquedaCliente1.productoHelp = null;
            this.busquedaCliente1.Proveedor = null;
            this.busquedaCliente1.proveedorHelp = null;
            this.busquedaCliente1.Size = new System.Drawing.Size(732, 51);
            this.busquedaCliente1.TabIndex = 80;
            this.busquedaCliente1.TextoBoton = null;
            this.busquedaCliente1.Load += new System.EventHandler(this.busquedaCliente1_Load);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(-2, 259);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(193, 24);
            this.Label9.TabIndex = 63;
            this.Label9.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(217, 256);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(563, 27);
            this.cmbTipoDocumento.TabIndex = 62;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // cmbFormapago
            // 
            this.cmbFormapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormapago.FormattingEnabled = true;
            this.cmbFormapago.Location = new System.Drawing.Point(217, 210);
            this.cmbFormapago.Name = "cmbFormapago";
            this.cmbFormapago.Size = new System.Drawing.Size(563, 27);
            this.cmbFormapago.TabIndex = 60;
            this.cmbFormapago.SelectedValueChanged += new System.EventHandler(this.cmbFormapago_SelectedValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(39, 214);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(152, 24);
            this.Label8.TabIndex = 61;
            this.Label8.Text = "Forma de pago";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(127, 169);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(67, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(217, 166);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(563, 30);
            this.dtpfecha.TabIndex = 58;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(98, 266);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(81, 24);
            this.Label11.TabIndex = 82;
            this.Label11.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(188, 263);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(160, 30);
            this.txtCambio.TabIndex = 83;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(87, 220);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 24);
            this.Label10.TabIndex = 80;
            this.Label10.Text = "Recibido";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.Location = new System.Drawing.Point(189, 217);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(160, 30);
            this.txtRecibido.TabIndex = 81;
            this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(23, 837);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(430, 253);
            this.TextBox1.TabIndex = 79;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(760, 1162);
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
            this.btninsertar.Location = new System.Drawing.Point(695, 1162);
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
            this.cbodescuento.Location = new System.Drawing.Point(189, 126);
            this.cbodescuento.Name = "cbodescuento";
            this.cbodescuento.Size = new System.Drawing.Size(72, 31);
            this.cbodescuento.TabIndex = 78;
            this.cbodescuento.SelectedIndexChanged += new System.EventHandler(this.cbodescuento_SelectedIndexChanged);
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(90, 37);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(89, 24);
            this.lblsubtotal.TabIndex = 77;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(69, 130);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(111, 24);
            this.Label7.TabIndex = 75;
            this.Label7.Text = "Descuento";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(189, 33);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(160, 30);
            this.txtsubtotal.TabIndex = 69;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(69, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(108, 24);
            this.Label5.TabIndex = 70;
            this.Label5.Text = "Impuestos";
            // 
            // txtiva
            // 
            this.txtiva.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(189, 82);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(160, 30);
            this.txtiva.TabIndex = 71;
            this.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(45, 175);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 24);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "Total a pagar";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(189, 171);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(160, 30);
            this.txttotalpagar.TabIndex = 72;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.Label11);
            this.groupBox3.Controls.Add(this.txtCambio);
            this.groupBox3.Controls.Add(this.Label10);
            this.groupBox3.Controls.Add(this.txtRecibido);
            this.groupBox3.Controls.Add(this.cbodescuento);
            this.groupBox3.Controls.Add(this.Label7);
            this.groupBox3.Controls.Add(this.Label5);
            this.groupBox3.Controls.Add(this.txtiva);
            this.groupBox3.Controls.Add(this.lblsubtotal);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.txtsubtotal);
            this.groupBox3.Controls.Add(this.txttotalpagar);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 833);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 314);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(267, 126);
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
            this.btnAñadir.Location = new System.Drawing.Point(698, 594);
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
            this.btnQuitar.Location = new System.Drawing.Point(766, 594);
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
            this.Detalles.facturaHelp = null;
            this.Detalles.Location = new System.Drawing.Point(25, 659);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(801, 168);
            this.Detalles.TabIndex = 80;
            this.Detalles.Load += new System.EventHandler(this.detalles1_Load);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 912);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtexistencia;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtvalorunit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
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
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnAñadir;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.TextBox txtDescuento;
        private BusquedaCliente busquedaCliente1;
        private BusquedaCliente BusquedaEmpleado;
        private BusquedaCliente busquedaProducto;
        private Detalles Detalles;
    }
}