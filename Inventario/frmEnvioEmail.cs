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
    public partial class frmEnvioEmail : Form
    {
        EmailHelp _emailHelp;
        public Usuario Usuario  { get; set; }
        List<string> fileNames;
        public frmEnvioEmail(EmailHelp emailHelp)
        {
            _emailHelp = emailHelp;
            
            InitializeComponent();
        }
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            fileNames = _emailHelp.Adjuntar();
            txtDatos.Clear();
            foreach (string f in fileNames)
            {
                txtDatos.Text = txtDatos.Text + f + "; ";
            }

        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            frmBusqueda frmbusqueda = new frmBusqueda(_emailHelp.Table);
            frmbusqueda.ShowDialog();
            DataGridViewRow row = frmbusqueda.Row;
            if(row==null)
            {
                return;
            }
            txtPara.Text = txtPara.Text + row.Cells["email"].Value.ToString() + ";";
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAsunto.Text))
                {
                    MessageBox.Show("Se debe colocar un asunto", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Array arr = txtPara.Text.Substring(0, txtPara.Text.Length - 1).Split(';');
                _emailHelp.SendMail(arr, txtAsunto.Text, txtMensaje.Text, fileNames);
                MessageBox.Show("Email enviado a "+txtPara .Text , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Nuevo();
            }
        }
        void Nuevo()
        {
            txtPara.Clear();
            txtAsunto.Clear();
            txtMensaje.Clear();
            fileNames = null;
        }

        private void frmEnvioEmail_Load(object sender, EventArgs e)
        {
            txtFrom.Text = _emailHelp.Remitente;
           
       
        
        }
    }
}
