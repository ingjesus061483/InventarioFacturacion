using Helper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmRecibir : Form
    {
        int formapago;

       public  OrdenCompra Compra { get; set; }
        FormaPagoHelp _formaPagoHelp;
        CompraHelp _compraHelp;
        public frmRecibir(CompraHelp compraHelp,FormaPagoHelp formaPagoHelp  )
        {
            _formaPagoHelp = formaPagoHelp;
            _compraHelp = compraHelp;
            InitializeComponent();
        }

        private void cmbFormapago_SelectedValueChanged(object sender, EventArgs e)
        {
          
                int.TryParse(cmbFormapago.SelectedValue != null ? cmbFormapago.SelectedValue.ToString() : "", out formapago);
                switch (formapago)
                {
                    case 1:
                        {
                            Compra.EstadoId = 1;
                            break;
                        }
                    case 2:
                        {
                            Compra.EstadoId = 2;
                            break;
                        }
                }
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formapago ==0)
            {
                    MessageBox.Show("El campo forma pago no puede ser vacio ", "",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }
            _compraHelp.RecibirMercancia(txtCodigo.Text, dtpfechaEntrega.Value, txtObservaciones.Text,formapago , Compra.EstadoId);
            this.Close();
        }

        private void frmRecibir_Load(object sender, EventArgs e)
        {
            _formaPagoHelp.Cmb(cmbFormapago);
            txtCodigo.Text = Compra.Codigo;
            dtpfechaEntrega.Value = Compra.FechaEntrega;
            decimal totalpagar = Compra.TotalPagar;
            txttotalpagar.Text = totalpagar.ToString();
        }
    }
}
