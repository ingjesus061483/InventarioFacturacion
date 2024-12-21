
namespace Inventario
{
    partial class frmVistaPrevia
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
            this.DgVer = new System.Windows.Forms.DataGridView();
            this.customPanel1 = new Inventario.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgVer)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgVer
            // 
            this.DgVer.AllowUserToAddRows = false;
            this.DgVer.AllowUserToDeleteRows = false;
            this.DgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgVer.Location = new System.Drawing.Point(0, 0);
            this.DgVer.Name = "DgVer";
            this.DgVer.ReadOnly = true;
            this.DgVer.RowHeadersVisible = false;
            this.DgVer.RowHeadersWidth = 62;
            this.DgVer.RowTemplate.Height = 28;
            this.DgVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgVer.Size = new System.Drawing.Size(776, 426);
            this.DgVer.TabIndex = 0;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.DgVer);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.Location = new System.Drawing.Point(12, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(776, 426);
            this.customPanel1.TabIndex = 1;
            // 
            // frmVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customPanel1);
            this.Name = "frmVistaPrevia";
            this.Text = "frmVistaPrevia";
            this.Load += new System.EventHandler(this.frmVistaPrevia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVer)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgVer;
        private CustomPanel customPanel1;
    }
}