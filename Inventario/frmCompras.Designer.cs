
using Helper;

namespace Inventario
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNofactura = new System.Windows.Forms.TextBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.creditos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RecibirMercancia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.devoluvionCompre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnBuscar);
            this.Panel1.Controls.Add(this.btnNuevo);
            this.Panel1.Controls.Add(this.btnexportar);
            this.Panel1.Controls.Add(this.chkPeriodo);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.txtNofactura);
            this.Panel1.Controls.Add(this.dtpFechaFin);
            this.Panel1.Controls.Add(this.dtpFechaInicio);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txtTotalVentas);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1924, 293);
            this.Panel1.TabIndex = 107;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1849, 194);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 113;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(1781, 195);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 112;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportar.BackgroundImage")));
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(1713, 196);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(60, 60);
            this.btnexportar.TabIndex = 110;
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeriodo.Location = new System.Drawing.Point(1245, 50);
            this.chkPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(214, 28);
            this.chkPeriodo.TabIndex = 109;
            this.chkPeriodo.Text = "Establecer periodo";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(1303, 103);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 24);
            this.Label3.TabIndex = 106;
            this.Label3.Text = "Factura No";
            // 
            // txtNofactura
            // 
            this.txtNofactura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNofactura.Location = new System.Drawing.Point(1440, 100);
            this.txtNofactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNofactura.Name = "txtNofactura";
            this.txtNofactura.Size = new System.Drawing.Size(469, 30);
            this.txtNofactura.TabIndex = 108;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(1722, 50);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(187, 30);
            this.dtpFechaFin.TabIndex = 107;
            this.dtpFechaFin.Visible = false;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(1492, 50);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(187, 30);
            this.dtpFechaInicio.TabIndex = 106;
            this.dtpFechaInicio.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1290, 146);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Total Ventas";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(1440, 143);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(469, 30);
            this.txtTotalVentas.TabIndex = 4;
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.AllowUserToDeleteRows = false;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ver,
            this.imprimir,
            this.creditos,
            this.RecibirMercancia,
            this.devoluvionCompre});
            this.dgCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCompras.Location = new System.Drawing.Point(0, 293);
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            this.dgCompras.RowHeadersVisible = false;
            this.dgCompras.RowHeadersWidth = 62;
            this.dgCompras.RowTemplate.Height = 28;
            this.dgCompras.Size = new System.Drawing.Size(1924, 369);
            this.dgCompras.TabIndex = 114;
            this.dgCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ver
            // 
            this.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver.HeaderText = "";
            this.ver.MinimumWidth = 8;
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Text = "Ver";
            this.ver.UseColumnTextForButtonValue = true;
            this.ver.Width = 150;
            // 
            // imprimir
            // 
            this.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimir.HeaderText = "";
            this.imprimir.MinimumWidth = 8;
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Text = "Imprimir";
            this.imprimir.UseColumnTextForButtonValue = true;
            this.imprimir.Width = 150;
            // 
            // creditos
            // 
            this.creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditos.HeaderText = "";
            this.creditos.MinimumWidth = 8;
            this.creditos.Name = "creditos";
            this.creditos.ReadOnly = true;
            this.creditos.Text = "Creditos";
            this.creditos.UseColumnTextForButtonValue = true;
            this.creditos.Width = 150;
            // 
            // RecibirMercancia
            // 
            this.RecibirMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecibirMercancia.HeaderText = "";
            this.RecibirMercancia.MinimumWidth = 8;
            this.RecibirMercancia.Name = "RecibirMercancia";
            this.RecibirMercancia.ReadOnly = true;
            this.RecibirMercancia.Text = "Recibir mercancia";
            this.RecibirMercancia.UseColumnTextForButtonValue = true;
            this.RecibirMercancia.Width = 150;
            // 
            // devoluvionCompre
            // 
            this.devoluvionCompre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devoluvionCompre.HeaderText = "";
            this.devoluvionCompre.MinimumWidth = 8;
            this.devoluvionCompre.Name = "devoluvionCompre";
            this.devoluvionCompre.ReadOnly = true;
            this.devoluvionCompre.Text = "Devoluvion de compra";
            this.devoluvionCompre.UseColumnTextForButtonValue = true;
            this.devoluvionCompre.Width = 150;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 662);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.Panel1);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.CheckBox chkPeriodo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNofactura;
        internal System.Windows.Forms.DateTimePicker dtpFechaFin;
        internal System.Windows.Forms.DateTimePicker dtpFechaInicio;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewButtonColumn imprimir;
        private System.Windows.Forms.DataGridViewButtonColumn creditos;
        private System.Windows.Forms.DataGridViewButtonColumn RecibirMercancia;
        private System.Windows.Forms.DataGridViewButtonColumn devoluvionCompre;

        ProveedorHelp _proveedorHelp;
        EmpleadoHelp _empleadoHelp;
        ProductoHelp _productoHelp;
        CompraHelp _compraHelp;
        UsuarioHelp _usuarioHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;
        FormaPagoHelp _formaPagoHelp;
        TipoDocumentoHelp _tipoDocumentoHelp;
        ImpuestoHelp _impuestoHelp;
        DevolucionCompraHelp _devoluvionCompraHelp;
        MotivoHelp _motivoHelp;
    }
}