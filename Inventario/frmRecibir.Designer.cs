
namespace Inventario
{
    partial class frmRecibir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibir));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpfechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.cmbFormapago = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(221, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(566, 30);
            this.txtCodigo.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 91;
            this.label10.Text = "Codigo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(23, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 24);
            this.Label1.TabIndex = 89;
            this.Label1.Text = "Fecha de entrega";
            // 
            // dtpfechaEntrega
            // 
            this.dtpfechaEntrega.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaEntrega.Location = new System.Drawing.Point(221, 88);
            this.dtpfechaEntrega.Name = "dtpfechaEntrega";
            this.dtpfechaEntrega.Size = new System.Drawing.Size(563, 30);
            this.dtpfechaEntrega.TabIndex = 88;
            // 
            // cmbFormapago
            // 
            this.cmbFormapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormapago.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormapago.FormattingEnabled = true;
            this.cmbFormapago.Location = new System.Drawing.Point(221, 137);
            this.cmbFormapago.Name = "cmbFormapago";
            this.cmbFormapago.Size = new System.Drawing.Size(563, 31);
            this.cmbFormapago.TabIndex = 86;
            this.cmbFormapago.SelectedValueChanged += new System.EventHandler(this.cmbFormapago_SelectedValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(44, 143);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(152, 24);
            this.Label8.TabIndex = 87;
            this.Label8.Text = "Forma de pago";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(727, 343);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 60);
            this.btnLogin.TabIndex = 92;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(221, 190);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(566, 70);
            this.txtObservaciones.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 94;
            this.label2.Text = "Observaciones";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.SystemColors.Control;
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(221, 283);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(563, 30);
            this.txttotalpagar.TabIndex = 96;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 95;
            this.label3.Text = "Total pagar";
            // 
            // frmRecibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 420);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dtpfechaEntrega);
            this.Controls.Add(this.cmbFormapago);
            this.Controls.Add(this.Label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRecibir";
            this.Text = "frmRecibir";
            this.Load += new System.EventHandler(this.frmRecibir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpfechaEntrega;
        internal System.Windows.Forms.ComboBox cmbFormapago;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox txtObservaciones;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txttotalpagar;
        internal System.Windows.Forms.Label label3;
    }
}