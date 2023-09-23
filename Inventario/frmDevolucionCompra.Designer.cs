
namespace Inventario
{
    partial class frmDevolucionCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.busquedaMotivo = new Inventario.BusquedaCliente();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCompraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNOmbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedaMotivo
            // 
            this.busquedaMotivo.Cliente = null;
            this.busquedaMotivo.clienteHelp = null;
            this.busquedaMotivo.Empleado = null;
            this.busquedaMotivo.empleadoHelp = null;
            this.busquedaMotivo.Location = new System.Drawing.Point(31, 59);
            this.busquedaMotivo.Motivo = null;
            this.busquedaMotivo.MotivoHelp = null;
            this.busquedaMotivo.Name = "busquedaMotivo";
            this.busquedaMotivo.Producto = null;
            this.busquedaMotivo.productoHelp = null;
            this.busquedaMotivo.Proveedor = null;
            this.busquedaMotivo.proveedorHelp = null;
            this.busquedaMotivo.Size = new System.Drawing.Size(734, 55);
            this.busquedaMotivo.TabIndex = 99;
            this.busquedaMotivo.TextoBoton = null;
            this.busquedaMotivo.Load += new System.EventHandler(this.busquedaMotivo_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 104;
            this.label2.Text = "Codigo compra";
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(787, 298);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 103;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.Location = new System.Drawing.Point(722, 298);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(60, 60);
            this.btninsertar.TabIndex = 102;
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.OrdenCompraId,
            this.OrdenCompra,
            this.ProductoId,
            this.Cantidad,
            this.ProductoNOmbre,
            this.Column3,
            this.Column7});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgDetalle.Location = new System.Drawing.Point(17, 134);
            this.dgDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersVisible = false;
            this.dgDetalle.RowHeadersWidth = 62;
            this.dgDetalle.Size = new System.Drawing.Size(830, 154);
            this.dgDetalle.TabIndex = 101;
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.Location = new System.Drawing.Point(191, 17);
            this.txtCodigoFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.ReadOnly = true;
            this.txtCodigoFactura.Size = new System.Drawing.Size(553, 30);
            this.txtCodigoFactura.TabIndex = 100;
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
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "producto";
            this.producto.MinimumWidth = 8;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Visible = false;
            this.producto.Width = 150;
            // 
            // OrdenCompraId
            // 
            this.OrdenCompraId.DataPropertyName = "OrdenCompraId";
            this.OrdenCompraId.HeaderText = "OrdenCompraId";
            this.OrdenCompraId.MinimumWidth = 8;
            this.OrdenCompraId.Name = "OrdenCompraId";
            this.OrdenCompraId.ReadOnly = true;
            this.OrdenCompraId.Visible = false;
            this.OrdenCompraId.Width = 150;
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.DataPropertyName = "OrdenCompra";
            this.OrdenCompra.HeaderText = "OrdenCompra";
            this.OrdenCompra.MinimumWidth = 8;
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.ReadOnly = true;
            this.OrdenCompra.Visible = false;
            this.OrdenCompra.Width = 150;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // ProductoNOmbre
            // 
            this.ProductoNOmbre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductoNOmbre.DataPropertyName = "NombreProducto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductoNOmbre.DefaultCellStyle = dataGridViewCellStyle8;
            this.ProductoNOmbre.HeaderText = "Detalle";
            this.ProductoNOmbre.MinimumWidth = 8;
            this.ProductoNOmbre.Name = "ProductoNOmbre";
            this.ProductoNOmbre.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
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
            // frmDevolucionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 369);
            this.Controls.Add(this.busquedaMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.txtCodigoFactura);
            this.Name = "frmDevolucionCompra";
            this.Text = "frmDevolucionCompra";
            this.Load += new System.EventHandler(this.frmDevolucionCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusquedaCliente busquedaMotivo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.DataGridView dgDetalle;
        internal System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNOmbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}