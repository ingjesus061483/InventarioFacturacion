
namespace Inventario
{
    partial class frmInventarioProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTotatizar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNofactura = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.dgProdctos = new System.Windows.Forms.DataGridView();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidaMedidaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedidaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdctos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTotatizar);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.lbltipo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnexportar);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtNofactura);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.txtTotalVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1822, 264);
            this.panel1.TabIndex = 1;
            // 
            // btnTotatizar
            // 
            this.btnTotatizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotatizar.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotatizar.Image = ((System.Drawing.Image)(resources.GetObject("btnTotatizar.Image")));
            this.btnTotatizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotatizar.Location = new System.Drawing.Point(1535, 180);
            this.btnTotatizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotatizar.Name = "btnTotatizar";
            this.btnTotatizar.Size = new System.Drawing.Size(60, 60);
            this.btnTotatizar.TabIndex = 124;
            this.btnTotatizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTotatizar.UseVisualStyleBackColor = true;
            this.btnTotatizar.Click += new System.EventHandler(this.btnTotatizar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(1330, 39);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(469, 31);
            this.cmbCategoria.TabIndex = 122;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(1206, 42);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(101, 24);
            this.lbltipo.TabIndex = 123;
            this.lbltipo.Text = "Categoria";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1671, 180);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 121;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(1603, 180);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 120;
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
            this.btnexportar.Location = new System.Drawing.Point(1739, 180);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(60, 60);
            this.btnexportar.TabIndex = 118;
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(1193, 84);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(109, 24);
            this.Label3.TabIndex = 116;
            this.Label3.Text = "Codigo No";
            // 
            // txtNofactura
            // 
            this.txtNofactura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNofactura.Location = new System.Drawing.Point(1330, 81);
            this.txtNofactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNofactura.Name = "txtNofactura";
            this.txtNofactura.Size = new System.Drawing.Size(469, 30);
            this.txtNofactura.TabIndex = 117;
            this.txtNofactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNofactura_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1136, 130);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(171, 24);
            this.Label1.TabIndex = 114;
            this.Label1.Text = "Total Existencias";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(1330, 124);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(469, 30);
            this.txtTotalVentas.TabIndex = 115;
            // 
            // dgProdctos
            // 
            this.dgProdctos.AllowUserToAddRows = false;
            this.dgProdctos.AllowUserToDeleteRows = false;
            this.dgProdctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdctos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ver,
            this.Existencia,
            this.editar,
            this.eliminar,
            this.Id,
            this.Codigo,
            this.Nombre,
            this.costo,
            this.Precio,
            this.RutaImagen,
            this.Descripcion,
            this.TotalEntrada,
            this.TotalSalida,
            this.TotalExistencia,
            this.CategoriaId,
            this.UnidaMedidaId,
            this.CategoriaNombre,
            this.UnidadMedidaNombre});
            this.dgProdctos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdctos.Location = new System.Drawing.Point(0, 264);
            this.dgProdctos.Name = "dgProdctos";
            this.dgProdctos.RowHeadersVisible = false;
            this.dgProdctos.RowHeadersWidth = 62;
            this.dgProdctos.RowTemplate.Height = 28;
            this.dgProdctos.Size = new System.Drawing.Size(1822, 382);
            this.dgProdctos.TabIndex = 2;
            this.dgProdctos.DataSourceChanged += new System.EventHandler(this.dgProdctos_DataSourceChanged);
            this.dgProdctos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cuestas1_CellClick);
            // 
            // ver
            // 
            this.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver.HeaderText = "";
            this.ver.MinimumWidth = 8;
            this.ver.Name = "ver";
            this.ver.Text = "Ver";
            this.ver.UseColumnTextForButtonValue = true;
            this.ver.Width = 150;
            // 
            // Existencia
            // 
            this.Existencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Existencia.HeaderText = "";
            this.Existencia.MinimumWidth = 8;
            this.Existencia.Name = "Existencia";
            this.Existencia.Text = "Existencia";
            this.Existencia.UseColumnTextForButtonValue = true;
            this.Existencia.Width = 150;
            // 
            // editar
            // 
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.HeaderText = "";
            this.editar.MinimumWidth = 8;
            this.editar.Name = "editar";
            this.editar.Text = "Editar";
            this.editar.UseColumnTextForButtonValue = true;
            this.editar.Width = 150;
            // 
            // eliminar
            // 
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "";
            this.eliminar.MinimumWidth = 8;
            this.eliminar.Name = "eliminar";
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            this.eliminar.Width = 150;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "Costo";
            this.costo.HeaderText = "Costo";
            this.costo.MinimumWidth = 8;
            this.costo.Name = "costo";
            this.costo.Width = 150;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // RutaImagen
            // 
            this.RutaImagen.DataPropertyName = "RutaImagen";
            this.RutaImagen.HeaderText = "RutaImagen";
            this.RutaImagen.MinimumWidth = 8;
            this.RutaImagen.Name = "RutaImagen";
            this.RutaImagen.Visible = false;
            this.RutaImagen.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = false;
            this.Descripcion.Width = 150;
            // 
            // TotalEntrada
            // 
            this.TotalEntrada.DataPropertyName = "TotalEntrada";
            this.TotalEntrada.HeaderText = "Total entrada";
            this.TotalEntrada.MinimumWidth = 8;
            this.TotalEntrada.Name = "TotalEntrada";
            this.TotalEntrada.Width = 150;
            // 
            // TotalSalida
            // 
            this.TotalSalida.DataPropertyName = "TotalSalida";
            this.TotalSalida.HeaderText = "Total salida";
            this.TotalSalida.MinimumWidth = 8;
            this.TotalSalida.Name = "TotalSalida";
            this.TotalSalida.Width = 150;
            // 
            // TotalExistencia
            // 
            this.TotalExistencia.DataPropertyName = "TotalExistencia";
            dataGridViewCellStyle1.NullValue = "0";
            this.TotalExistencia.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalExistencia.HeaderText = "Total existencia";
            this.TotalExistencia.MinimumWidth = 8;
            this.TotalExistencia.Name = "TotalExistencia";
            this.TotalExistencia.Width = 150;
            // 
            // CategoriaId
            // 
            this.CategoriaId.DataPropertyName = "CategoriaId";
            this.CategoriaId.HeaderText = "CategoriaId";
            this.CategoriaId.MinimumWidth = 8;
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.Visible = false;
            this.CategoriaId.Width = 150;
            // 
            // UnidaMedidaId
            // 
            this.UnidaMedidaId.DataPropertyName = "UnidadMedidaId";
            this.UnidaMedidaId.HeaderText = "UnidadMedidaId";
            this.UnidaMedidaId.MinimumWidth = 8;
            this.UnidaMedidaId.Name = "UnidaMedidaId";
            this.UnidaMedidaId.Visible = false;
            this.UnidaMedidaId.Width = 150;
            // 
            // CategoriaNombre
            // 
            this.CategoriaNombre.DataPropertyName = "Categoria";
            this.CategoriaNombre.HeaderText = "Categoria";
            this.CategoriaNombre.MinimumWidth = 8;
            this.CategoriaNombre.Name = "CategoriaNombre";
            this.CategoriaNombre.Width = 150;
            // 
            // UnidadMedidaNombre
            // 
            this.UnidadMedidaNombre.DataPropertyName = "UnidadMedida";
            this.UnidadMedidaNombre.HeaderText = "Unidad Medida";
            this.UnidadMedidaNombre.MinimumWidth = 8;
            this.UnidadMedidaNombre.Name = "UnidadMedidaNombre";
            this.UnidadMedidaNombre.Width = 150;
            // 
            // frmInventarioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 646);
            this.Controls.Add(this.dgProdctos);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventarioProducto";
            this.Text = "frmInventarioProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventarioProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdctos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNofactura;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotalVentas;
        internal System.Windows.Forms.ComboBox cmbCategoria;
        internal System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.DataGridView dgProdctos;
        internal System.Windows.Forms.Button btnTotatizar;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewButtonColumn Existencia;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidaMedidaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedidaNombre;
    }
}