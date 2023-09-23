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
    public partial class frmEmail : Form
    {
        EmailHelp _emailHelp;
       public Usuario Usuario { get; set; }
        public frmEmail(EmailHelp emailHelp  )
        {
            _emailHelp = emailHelp;
            InitializeComponent();
        }

        private void frmEmail_Load(object sender, EventArgs e)
        { 
            txtEmail.Text  = Usuario.Email;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(!_emailHelp.EmailBienEscrito(txtEmail.Text ))
            {
                return;
            }
           if(string .IsNullOrEmpty(txtPassword.Text))
            {
                return;

            }
            _emailHelp.Remitente = txtEmail.Text;
            _emailHelp.Pwd = txtPassword.Text ;
            this.Close();
        }
    }
}
