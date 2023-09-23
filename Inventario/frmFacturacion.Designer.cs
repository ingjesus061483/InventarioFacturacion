
using Helper;

namespace Inventario
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtNofactura = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.btnexportar = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnTotatizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cuestas1 = new Inventario.UserControls.Cuestas();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(1412, 178);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(469, 30);
            this.txtTotalVentas.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1262, 181);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Total Ventas";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(1473, 20);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(187, 30);
            this.dtpFechaInicio.TabIndex = 106;
            this.dtpFechaInicio.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(1703, 20);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(187, 30);
            this.dtpFechaFin.TabIndex = 107;
            this.dtpFechaFin.Visible = false;
            // 
            // txtNofactura
            // 
            this.txtNofactura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNofactura.Location = new System.Drawing.Point(1412, 135);
            this.txtNofactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNofactura.Name = "txtNofactura";
            this.txtNofactura.Size = new System.Drawing.Size(469, 30);
            this.txtNofactura.TabIndex = 108;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(1275, 138);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 24);
            this.Label3.TabIndex = 106;
            this.Label3.Text = "Factura No";
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeriodo.Location = new System.Drawing.Point(1226, 20);
            this.chkPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(214, 28);
            this.chkPeriodo.TabIndex = 109;
            this.chkPeriodo.Text = "Establecer periodo";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // btnexportar
            // 
            this.btnexportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportar.BackgroundImage")));
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(1685, 231);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(60, 60);
            this.btnexportar.TabIndex = 110;
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.cmbEstado);
            this.Panel1.Controls.Add(this.btnTotatizar);
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
            this.Panel1.Size = new System.Drawing.Size(1909, 306);
            this.Panel1.TabIndex = 106;
            // 
            // btnTotatizar
            // 
            this.btnTotatizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotatizar.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotatizar.Image = ((System.Drawing.Image)(resources.GetObject("btnTotatizar.Image")));
            this.btnTotatizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotatizar.Location = new System.Drawing.Point(1617, 231);
            this.btnTotatizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotatizar.Name = "btnTotatizar";
            this.btnTotatizar.Size = new System.Drawing.Size(60, 60);
            this.btnTotatizar.TabIndex = 125;
            this.btnTotatizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTotatizar.UseVisualStyleBackColor = true;
            this.btnTotatizar.Click += new System.EventHandler(this.btnTotatizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1821, 229);
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
            this.btnNuevo.Location = new System.Drawing.Point(1753, 230);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 112;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cuestas1
            // 
            this.cuestas1.CompraHelp = null;
            this.cuestas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuestas1.ExistenciaHelp = null;
            this.cuestas1.FacturaHelp = null;
            this.cuestas1.Location = new System.Drawing.Point(0, 306);
            this.cuestas1.Name = "cuestas1";
            this.cuestas1.NameButtons = new string[] {
        "Ver",
        "Imprimir",
        "Creditos",
        "Devolucion de ventas"};
            this.cuestas1.ProductoHelp = null;
            this.cuestas1.Size = new System.Drawing.Size(1909, 298);
            this.cuestas1.TabIndex = 114;
            this.cuestas1.Load += new System.EventHandler(this.cuestas1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1240, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 127;
            this.label2.Text = "Estado factura";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(1412, 88);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(469, 31);
            this.cmbEstado.TabIndex = 126;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            this.cmbEstado.SelectedValueChanged += new System.EventHandler(this.cmbEstado_SelectedValueChanged);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 604);
            this.Controls.Add(this.cuestas1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtTotalVentas;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFechaInicio;
        internal System.Windows.Forms.DateTimePicker dtpFechaFin;
        internal System.Windows.Forms.TextBox txtNofactura;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox chkPeriodo;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnNuevo;
        private UserControls.Cuestas cuestas1;
        internal System.Windows.Forms.Button btnTotatizar;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstado;

        TipoDocumentoHelp _TipoDocumentoHelp;
        FormaPagoHelp _FormaPagoHelp;
        UsuarioHelp _usuarioHelp;
        ClienteHelp _clienteHelp;
        EmpleadoHelp _empleadoHelp;
        ProductoHelp _productoHelp;
        ImpuestoHelp _impuestoHelp;
        FacturaHelp _facturaHelp;
        ImpresoraHelp _impresoraHelp;
        DevolucionVentaHelp _devolucionVentaHelp;
        MotivoHelp _motivoHelp;
        EstadoHelp _estadoHelp;
        TipoIdentificacionHelp _tipoIdentificacionHelp;

    }
}