
namespace Inventario
{
    partial class frmDetalleExistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleExistencia));
            this.txtToalSalida = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTotalEntrada = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTotalExistencia = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexportar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblarticulo = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Entradas = new UserControls.Cuestas();
            this.Salidas = new UserControls.Cuestas();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToalSalida
            // 
            this.txtToalSalida.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToalSalida.Location = new System.Drawing.Point(1440, 66);
            this.txtToalSalida.Name = "txtToalSalida";
            this.txtToalSalida.Size = new System.Drawing.Size(131, 30);
            this.txtToalSalida.TabIndex = 73;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(1312, 70);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 24);
            this.Label6.TabIndex = 72;
            this.Label6.Text = "Total salida";
            // 
            // txtTotalEntrada
            // 
            this.txtTotalEntrada.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEntrada.Location = new System.Drawing.Point(1440, 19);
            this.txtTotalEntrada.Name = "txtTotalEntrada";
            this.txtTotalEntrada.Size = new System.Drawing.Size(131, 30);
            this.txtTotalEntrada.TabIndex = 71;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(1296, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(135, 24);
            this.Label5.TabIndex = 70;
            this.Label5.Text = "Total entrada";
            // 
            // txtTotalExistencia
            // 
            this.txtTotalExistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExistencia.Location = new System.Drawing.Point(1440, 114);
            this.txtTotalExistencia.Name = "txtTotalExistencia";
            this.txtTotalExistencia.Size = new System.Drawing.Size(131, 30);
            this.txtTotalExistencia.TabIndex = 69;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(1373, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 24);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 226);
            this.panel1.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Salidas);
            this.panel2.Controls.Add(this.Entradas);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1589, 338);
            this.panel2.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnexportar);
            this.panel3.Controls.Add(this.btnsalir);
            this.panel3.Controls.Add(this.txtTotalEntrada);
            this.panel3.Controls.Add(this.txtTotalExistencia);
            this.panel3.Controls.Add(this.Label6);
            this.panel3.Controls.Add(this.txtToalSalida);
            this.panel3.Controls.Add(this.Label5);
            this.panel3.Controls.Add(this.Label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1589, 239);
            this.panel3.TabIndex = 76;
            // 
            // btnexportar
            // 
            this.btnexportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexportar.BackgroundImage")));
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(1440, 158);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(60, 60);
            this.btnexportar.TabIndex = 108;
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(1508, 158);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(60, 60);
            this.btnsalir.TabIndex = 107;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(19, 18);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(101, 24);
            this.lbltipo.TabIndex = 74;
            this.lbltipo.Text = "Categoria";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(624, 72);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 24);
            this.Label2.TabIndex = 76;
            this.Label2.Text = "Costo";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(613, 18);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(77, 24);
            this.lblcodigo.TabIndex = 72;
            this.lblcodigo.Text = "Código";
            // 
            // lblarticulo
            // 
            this.lblarticulo.AutoSize = true;
            this.lblarticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblarticulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarticulo.Location = new System.Drawing.Point(31, 75);
            this.lblarticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarticulo.Name = "lblarticulo";
            this.lblarticulo.Size = new System.Drawing.Size(84, 24);
            this.lblarticulo.TabIndex = 73;
            this.lblarticulo.Text = "Nombre";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(579, 127);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(179, 24);
            this.Label3.TabIndex = 77;
            this.Label3.Text = "Unidad de medida";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.BackColor = System.Drawing.Color.Transparent;
            this.lblcolor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.Location = new System.Drawing.Point(45, 127);
            this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(70, 24);
            this.lblcolor.TabIndex = 75;
            this.lblcolor.Text = "Precio";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(148, 124);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(400, 30);
            this.txtExistencia.TabIndex = 82;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(148, 15);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(399, 30);
            this.txtCodigo.TabIndex = 78;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(710, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(399, 30);
            this.txtNombre.TabIndex = 79;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(148, 69);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(399, 30);
            this.txtCosto.TabIndex = 80;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(710, 69);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(399, 30);
            this.txtPrecio.TabIndex = 81;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(790, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 30);
            this.textBox1.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbltipo);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.lblcolor);
            this.panel4.Controls.Add(this.txtExistencia);
            this.panel4.Controls.Add(this.Label3);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Controls.Add(this.lblarticulo);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.lblcodigo);
            this.panel4.Controls.Add(this.txtCosto);
            this.panel4.Controls.Add(this.Label2);
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1127, 226);
            this.panel4.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(1127, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 226);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // Entradas
            // 
            this.Entradas.Dock = System.Windows.Forms.DockStyle.Left;
            this.Entradas.FacturaHelp = null;
            this.Entradas.Location = new System.Drawing.Point(0, 47);
            this.Entradas.Name = "Entradas";
            this.Entradas.NameButtons = null;
            this.Entradas.ProductoHelp = null;
            this.Entradas.Size = new System.Drawing.Size(789, 291);
            this.Entradas.TabIndex = 0;
            this.Entradas.Load += new System.EventHandler(this.Entradas_Load);
            // 
            // Salidas
            // 
            this.Salidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Salidas.FacturaHelp = null;
            this.Salidas.Location = new System.Drawing.Point(789, 47);
            this.Salidas.Name = "Salidas";
            this.Salidas.NameButtons = null;
            this.Salidas.ProductoHelp = null;
            this.Salidas.Size = new System.Drawing.Size(800, 291);
            this.Salidas.TabIndex = 1;
            this.Salidas.Load += new System.EventHandler(this.Salidas_Load);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1589, 47);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entradas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(811, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Salidas";
            // 
            // frmDetalleExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 803);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDetalleExistencia";
            this.Text = "frmDetalleExistencia";
            this.Load += new System.EventHandler(this.frmDetalleExistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtToalSalida;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtTotalEntrada;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtTotalExistencia;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnexportar;
        internal System.Windows.Forms.Button btnsalir;
        internal System.Windows.Forms.Label lbltipo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblcodigo;
        internal System.Windows.Forms.Label lblarticulo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblcolor;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox txtExistencia;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtCosto;
        internal System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private UserControls.Cuestas Salidas;
        private UserControls.Cuestas Entradas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}