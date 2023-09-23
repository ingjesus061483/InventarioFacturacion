
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
            this.prgboperacion = new System.Windows.Forms.ProgressBar();
            this.btnsalir = new System.Windows.Forms.Button();
            this.taboperacion = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Listexportar = new System.Windows.Forms.ListBox();
            this.CBOTABLA = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.btnimportar = new System.Windows.Forms.Button();
            this.btnabrir = new System.Windows.Forms.Button();
            this.dvver = new System.Windows.Forms.DataGridView();
            this.taboperacion.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvver)).BeginInit();
            this.SuspendLayout();
            // 
            // prgboperacion
            // 
            this.prgboperacion.Location = new System.Drawing.Point(13, 530);
            this.prgboperacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prgboperacion.Name = "prgboperacion";
            this.prgboperacion.Size = new System.Drawing.Size(748, 32);
            this.prgboperacion.TabIndex = 23;
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
            this.TabPage1.Controls.Add(this.button1);
            this.TabPage1.Controls.Add(this.textBox1);
            this.TabPage1.Controls.Add(this.Listexportar);
            this.TabPage1.Controls.Add(this.CBOTABLA);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(682, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(772, 54);
            this.textBox1.TabIndex = 9;
            // 
            // Listexportar
            // 
            this.Listexportar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listexportar.FormattingEnabled = true;
            this.Listexportar.ItemHeight = 23;
            this.Listexportar.Location = new System.Drawing.Point(36, 202);
            this.Listexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Listexportar.Name = "Listexportar";
            this.Listexportar.Size = new System.Drawing.Size(773, 188);
            this.Listexportar.TabIndex = 6;
            // 
            // CBOTABLA
            // 
            this.CBOTABLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOTABLA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOTABLA.FormattingEnabled = true;
            this.CBOTABLA.Location = new System.Drawing.Point(37, 164);
            this.CBOTABLA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBOTABLA.Name = "CBOTABLA";
            this.CBOTABLA.Size = new System.Drawing.Size(772, 31);
            this.CBOTABLA.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 129);
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
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.btnimportar);
            this.TabPage2.Controls.Add(this.btnabrir);
            this.TabPage2.Controls.Add(this.dvver);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage2.Size = new System.Drawing.Size(832, 491);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Importar";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // btnimportar
            // 
            this.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.Image = ((System.Drawing.Image)(resources.GetObject("btnimportar.Image")));
            this.btnimportar.Location = new System.Drawing.Point(764, 420);
            this.btnimportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(60, 60);
            this.btnimportar.TabIndex = 21;
            this.btnimportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimportar.UseVisualStyleBackColor = true;
            // 
            // btnabrir
            // 
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.Image = ((System.Drawing.Image)(resources.GetObject("btnabrir.Image")));
            this.btnabrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnabrir.Location = new System.Drawing.Point(696, 420);
            this.btnabrir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(60, 60);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnabrir.UseVisualStyleBackColor = true;
            // 
            // dvver
            // 
            this.dvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvver.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvver.Location = new System.Drawing.Point(4, 5);
            this.dvver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvver.Name = "dvver";
            this.dvver.RowHeadersWidth = 62;
            this.dvver.Size = new System.Drawing.Size(824, 406);
            this.dvver.TabIndex = 0;
            // 
            // frmImpExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 598);
            this.Controls.Add(this.prgboperacion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.taboperacion);
            this.Name = "frmImpExp";
            this.Text = "frmImpExp";
            this.taboperacion.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ProgressBar prgboperacion;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.TabControl taboperacion;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button btnimportar;
        internal System.Windows.Forms.Button btnabrir;
        internal System.Windows.Forms.DataGridView dvver;
        internal System.Windows.Forms.ListBox Listexportar;
        internal System.Windows.Forms.ComboBox CBOTABLA;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}