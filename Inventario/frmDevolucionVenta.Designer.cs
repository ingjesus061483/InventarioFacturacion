
namespace Inventario
{
    partial class frmDevolucionVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionVenta));
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaEncabezado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNOmbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busquedaMotivo = new Inventario.BusquedaCliente();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FacturaId,
            this.FacturaEncabezado,
            this.ProductoId,
            this.Cantidad,
            this.ProductoNOmbre,
            this.Column3,
            this.Column7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDetalle.Location = new System.Drawing.Point(26, 131);
            this.dgDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersVisible = false;
            this.dgDetalle.RowHeadersWidth = 62;
            this.dgDetalle.Size = new System.Drawing.Size(830, 154);
            this.dgDetalle.TabIndex = 81;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // FacturaId
            // 
            this.FacturaId.DataPropertyName = "FacturaId";
            this.FacturaId.HeaderText = "FacturaId";
            this.FacturaId.MinimumWidth = 8;
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            this.FacturaId.Visible = false;
            this.FacturaId.Width = 150;
            // 
            // FacturaEncabezado
            // 
            this.FacturaEncabezado.DataPropertyName = "FacturaEncabezado";
            this.FacturaEncabezado.HeaderText = "FacturaEncabezado";
            this.FacturaEncabezado.MinimumWidth = 8;
            this.FacturaEncabezado.Name = "FacturaEncabezado";
            this.FacturaEncabezado.ReadOnly = true;
            this.FacturaEncabezado.Visible = false;
            this.FacturaEncabezado.Width = 150;
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.MinimumWidth = 8;
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Visible = false;
            this.ProductoId.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // ProductoNOmbre
            // 
            this.ProductoNOmbre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductoNOmbre.DataPropertyName = "NombreProducto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductoNOmbre.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductoNOmbre.HeaderText = "Detalle";
            this.ProductoNOmbre.MinimumWidth = 8;
            this.ProductoNOmbre.Name = "ProductoNOmbre";
            this.ProductoNOmbre.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Valor unitario";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Total";
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // busquedaMotivo
            // 
            this.busquedaMotivo.Cliente = null;
            this.busquedaMotivo.clienteHelp = null;
            this.busquedaMotivo.Empleado = null;
            this.busquedaMotivo.empleadoHelp = null;
            this.busquedaMotivo.Location = new System.Drawing.Point(40, 56);
            this.busquedaMotivo.Motivo = null;
            this.busquedaMotivo.MotivoHelp = null;
            this.busquedaMotivo.Name = "busquedaMotivo";
            this.busquedaMotivo.Producto = null;
            this.busquedaMotivo.productoHelp = null;
            this.busquedaMotivo.Proveedor = null;
            this.busquedaMotivo.proveedorHelp = null;
            this.busquedaMotivo.Size = new System.Drawing.Size(734, 55);
            this.busquedaMotivo.TabIndex = 78;
            this.busquedaMotivo.TextoBoton = null;
            this.busquedaMotivo.Load += new System.EventHandler(this.busquedaCliente2_Load);
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.Location = new System.Drawing.Point(200, 14);
            this.txtCodigoFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.ReadOnly = true;
            this.txtCodigoFactura.Size = new System.Drawing.Size(553, 30);
            this.txtCodigoFactura.TabIndex = 79;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(796, 295);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 96;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.Location = new System.Drawing.Point(731, 295);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(60, 60);
            this.btninsertar.TabIndex = 95;
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 98;
            this.label2.Text = "Codigo factura";
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 367);
            this.Controls.Add(this.busquedaMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.txtCodigoFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDevoluciones";
            this.Text = "frmDevoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgDetalle;
        internal System.Windows.Forms.TextBox txtCodigoFactura;
        private BusquedaCliente busquedaMotivo;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaEncabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNOmbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.Label label2;
    }
}