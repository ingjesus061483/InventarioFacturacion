
namespace Inventario
{
    partial class frmEnvioEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioEmail));
            this.Button5 = new System.Windows.Forms.Button();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.Location = new System.Drawing.Point(507, 667);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(60, 60);
            this.Button5.TabIndex = 12;
            this.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(135, 68);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPara.Size = new System.Drawing.Size(565, 59);
            this.txtPara.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(573, 667);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(60, 60);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnTo
            // 
            this.btnTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo.Location = new System.Drawing.Point(21, 80);
            this.btnTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(112, 38);
            this.btnTo.TabIndex = 14;
            this.btnTo.Text = "Para";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(52, 148);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 24);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(136, 144);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(562, 30);
            this.txtAsunto.TabIndex = 8;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdjuntar.BackgroundImage")));
            this.btnAdjuntar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.Location = new System.Drawing.Point(640, 667);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(60, 60);
            this.btnAdjuntar.TabIndex = 10;
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(22, 276);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(678, 381);
            this.txtMensaje.TabIndex = 9;
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(22, 207);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatos.Size = new System.Drawing.Size(676, 59);
            this.txtDatos.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "De";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(136, 19);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(562, 30);
            this.txtFrom.TabIndex = 16;
            // 
            // frmEnvioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.txtMensaje);
            this.Name = "frmEnvioEmail";
            this.Text = "frmEnvioEmail";
            this.Load += new System.EventHandler(this.frmEnvioEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.TextBox txtPara;
        internal System.Windows.Forms.Button btnEnviar;
        internal System.Windows.Forms.Button btnTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAsunto;
        internal System.Windows.Forms.Button btnAdjuntar;
        internal System.Windows.Forms.TextBox txtMensaje;
        internal System.Windows.Forms.TextBox txtDatos;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtFrom;
    }
}