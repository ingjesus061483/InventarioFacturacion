
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Empleado = new BusquedaCliente();
            this.Proveedorbuscar = new BusquedaCliente();
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Producto = new BusquedaCliente();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtvalorunit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.Detalles = new Detalles();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Empleado);
            this.GroupBox1.Controls.Add(this.Proveedorbuscar);
            this.GroupBox1.Controls.Add(this.txtCodigo);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.dtpFechaEntrega);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.cmbTipoDocumento);
            this.GroupBox1.Controls.Add(this.lblfecha);
            this.GroupBox1.Controls.Add(this.dtpfecha);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(23, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(794, 358);
            this.GroupBox1.TabIndex = 82;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Encabezado de compra";
            // 
            // Empleado
            // 
            this.Empleado.Cliente = null;
            this.Empleado.clienteHelp = null;
            this.Empleado.Empleado = null;
            this.Empleado.empleadoHelp = null;
            this.Empleado.Location = new System.Drawing.Point(37, 128);
            this.Empleado.Name = "Empleado";
            this.Empleado.Producto = null;
            this.Empleado.productoHelp = null;
            this.Empleado.Proveedor = null;
            this.Empleado.proveedorHelp = null;
            this.Empleado.Size = new System.Drawing.Size(743, 58);
            this.Empleado.TabIndex = 87;
            this.Empleado.TextoBoton = null;
            // 
            // Proveedorbuscar
            // 
            this.Proveedorbuscar.Cliente = null;
            this.Proveedorbuscar.clienteHelp = null;
            this.Proveedorbuscar.Empleado = null;
            this.Proveedorbuscar.empleadoHelp = null;
            this.Proveedorbuscar.Location = new System.Drawing.Point(37, 71);
            this.Proveedorbuscar.Name = "Proveedorbuscar";
            this.Proveedorbuscar.Producto = null;
            this.Proveedorbuscar.productoHelp = null;
            this.Proveedorbuscar.Proveedor = null;
            this.Proveedorbuscar.proveedorHelp = null;
            this.Proveedorbuscar.Size = new System.Drawing.Size(743, 61);
            this.Proveedorbuscar.TabIndex = 86;
            this.Proveedorbuscar.TextoBoton = null;
            this.Proveedorbuscar.Load += new System.EventHandler(this.Proveedor_Load);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(214, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(566, 30);
            this.txtCodigo.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 85;
            this.label10.Text = "Codigo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 247);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 24);
            this.Label1.TabIndex = 65;
            this.Label1.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Location = new System.Drawing.Point(214, 241);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(563, 30);
            this.dtpFechaEntrega.TabIndex = 64;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(-4, 296);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(193, 24);
            this.Label9.TabIndex = 63;
            this.Label9.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(214, 291);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(563, 31);
            this.cmbTipoDocumento.TabIndex = 62;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(124, 197);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(67, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(217, 191);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(561, 30);
            this.dtpfecha.TabIndex = 58;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(23, 893);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(392, 228);
            this.TextBox4.TabIndex = 97;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(764, 1129);
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
            this.btninsertar.Location = new System.Drawing.Point(699, 1129);
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
            this.lblsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(47, 34);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(89, 24);
            this.lblsubtotal.TabIndex = 95;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(153, 31);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(168, 30);
            this.txtsubtotal.TabIndex = 88;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(39, 85);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(97, 24);
            this.Label5.TabIndex = 87;
            this.Label5.Text = "Impuesto";
            // 
            // txtiva
            // 
            this.txtiva.BackColor = System.Drawing.SystemColors.Control;
            this.txtiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiva.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(153, 79);
            this.txtiva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(168, 30);
            this.txtiva.TabIndex = 89;
            this.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(19, 131);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 24);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "Total pagar";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.SystemColors.Control;
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(153, 128);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(168, 30);
            this.txttotalpagar.TabIndex = 90;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Producto);
            this.GroupBox2.Controls.Add(this.txtexistencia);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtcantidad);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtvalorunit);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(18, 389);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(803, 178);
            this.GroupBox2.TabIndex = 98;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalle de compra";
            // 
            // Producto
            // 
            this.Producto.Cliente = null;
            this.Producto.clienteHelp = null;
            this.Producto.Empleado = null;
            this.Producto.empleadoHelp = null;
            this.Producto.Location = new System.Drawing.Point(16, 19);
            this.Producto.Name = "Producto";
            this.Producto.Producto = null;
            this.Producto.productoHelp = null;
            this.Producto.Proveedor = null;
            this.Producto.proveedorHelp = null;
            this.Producto.Size = new System.Drawing.Size(767, 55);
            this.Producto.TabIndex = 88;
            this.Producto.TextoBoton = null;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(157, 82);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.ReadOnly = true;
            this.txtexistencia.Size = new System.Drawing.Size(72, 30);
            this.txtexistencia.TabIndex = 67;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(31, 85);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 24);
            this.Label6.TabIndex = 68;
            this.Label6.Text = "Existencias";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(157, 131);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(624, 30);
            this.txtcantidad.TabIndex = 60;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(42, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 24);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Cantidad";
            // 
            // txtvalorunit
            // 
            this.txtvalorunit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunit.Location = new System.Drawing.Point(386, 83);
            this.txtvalorunit.Name = "txtvalorunit";
            this.txtvalorunit.ReadOnly = true;
            this.txtvalorunit.Size = new System.Drawing.Size(394, 30);
            this.txtvalorunit.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(242, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 24);
            this.Label3.TabIndex = 65;
            this.Label3.Text = "Valor Unitario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsubtotal);
            this.groupBox3.Controls.Add(this.txttotalpagar);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.txtiva);
            this.groupBox3.Controls.Add(this.Label5);
            this.groupBox3.Controls.Add(this.txtsubtotal);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(482, 893);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 185);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.BackgroundImage")));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(758, 581);
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
            this.btnAñadir.Location = new System.Drawing.Point(690, 581);
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
            this.Detalles.facturaHelp = null;
            this.Detalles.Location = new System.Drawing.Point(23, 655);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(801, 216);
            this.Detalles.TabIndex = 102;
            this.Detalles.Load += new System.EventHandler(this.Detalles_Load);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(910, 912);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
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
        internal System.Windows.Forms.GroupBox GroupBox2;
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
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnAñadir;
        private Detalles Detalles;
    }
}