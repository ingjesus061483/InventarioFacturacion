
namespace Inventario
{
    partial class frmImpExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpExp));
            this.btnsalir = new System.Windows.Forms.Button();
            this.taboperacion = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.ListExportar = new System.Windows.Forms.ListBox();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dvver = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTablaImp = new System.Windows.Forms.ComboBox();
            this.btnimportar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnabrir = new System.Windows.Forms.Button();
            this.taboperacion.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvver)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(772, 530);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // taboperacion
            // 
            this.taboperacion.Controls.Add(this.TabPage1);
            this.taboperacion.Controls.Add(this.TabPage2);
            this.taboperacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.taboperacion.Location = new System.Drawing.Point(0, 0);
            this.taboperacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taboperacion.Name = "taboperacion";
            this.taboperacion.SelectedIndex = 0;
            this.taboperacion.Size = new System.Drawing.Size(840, 524);
            this.taboperacion.TabIndex = 21;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label2);
            this.TabPage1.Controls.Add(this.btnPreview);
            this.TabPage1.Controls.Add(this.txtQuery);
            this.TabPage1.Controls.Add(this.ListExportar);
            this.TabPage1.Controls.Add(this.cmbTabla);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.btnexportar);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage1.Size = new System.Drawing.Size(832, 491);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Exportar ";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Consulta";
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.Location = new System.Drawing.Point(749, 112);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(60, 60);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(37, 50);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.Size = new System.Drawing.Size(772, 54);
            this.txtQuery.TabIndex = 9;
            // 
            // ListExportar
            // 
            this.ListExportar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListExportar.FormattingEnabled = true;
            this.ListExportar.ItemHeight = 23;
            this.ListExportar.Location = new System.Drawing.Point(36, 261);
            this.ListExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListExportar.Name = "ListExportar";
            this.ListExportar.Size = new System.Drawing.Size(773, 142);
            this.ListExportar.TabIndex = 6;
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(37, 214);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(772, 31);
            this.cmbTabla.TabIndex = 7;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 179);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(163, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Tablas a exportar";
            // 
            // btnexportar
            // 
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.Location = new System.Drawing.Point(749, 413);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(60, 60);
            this.btnexportar.TabIndex = 1;
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.dvver);
            this.TabPage2.Controls.Add(this.panel1);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Size = new System.Drawing.Size(832, 491);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Importar";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // dvver
            // 
            this.dvver.AllowUserToAddRows = false;
            this.dvver.AllowUserToDeleteRows = false;
            this.dvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvver.Location = new System.Drawing.Point(4, 94);
            this.dvver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvver.Name = "dvver";
            this.dvver.ReadOnly = true;
            this.dvver.RowHeadersVisible = false;
            this.dvver.RowHeadersWidth = 62;
            this.dvver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvver.Size = new System.Drawing.Size(824, 392);
            this.dvver.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTablaImp);
            this.panel1.Controls.Add(this.btnimportar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnabrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 89);
            this.panel1.TabIndex = 22;
            // 
            // cmbTablaImp
            // 
            this.cmbTablaImp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablaImp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTablaImp.FormattingEnabled = true;
            this.cmbTablaImp.Location = new System.Drawing.Point(103, 42);
            this.cmbTablaImp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTablaImp.Name = "cmbTablaImp";
            this.cmbTablaImp.Size = new System.Drawing.Size(612, 31);
            this.cmbTablaImp.TabIndex = 9;
            this.cmbTablaImp.SelectedIndexChanged += new System.EventHandler(this.cmbTablaImp_SelectedIndexChanged);
            // 
            // btnimportar
            // 
            this.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.Image = ((System.Drawing.Image)(resources.GetObject("btnimportar.Image")));
            this.btnimportar.Location = new System.Drawing.Point(746, 12);
            this.btnimportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(60, 60);
            this.btnimportar.TabIndex = 21;
            this.btnimportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Click += new System.EventHandler(this.btnimportar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tablas a exportar";
            // 
            // btnabrir
            // 
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.Image = ((System.Drawing.Image)(resources.GetObject("btnabrir.Image")));
            this.btnabrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnabrir.Location = new System.Drawing.Point(15, 14);
            this.btnabrir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(60, 60);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // frmImpExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 598);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.taboperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmImpExp";
            this.Text = "frmImpExp";
            this.Load += new System.EventHandler(this.frmImpExp_Load);
            this.taboperacion.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvver)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.TabControl taboperacion;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button btnimportar;
        internal System.Windows.Forms.Button btnabrir;
        internal System.Windows.Forms.DataGridView dvver;
        internal System.Windows.Forms.ListBox ListExportar;
        internal System.Windows.Forms.ComboBox cmbTabla;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ComboBox cmbTablaImp;
        internal System.Windows.Forms.Label label3;
    }
}