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
    public partial class frmImpuesto : Form
    {
        int id;
        ImpuestoHelp _impuestoHelp;
        Impuesto impuesto;
        public frmImpuesto(ImpuestoHelp impuestoHelp  )
        {
            _impuestoHelp = impuestoHelp;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_impuestoHelp);
            frmBusqueda.ShowDialog();
            id = frmBusqueda.Id;
            impuesto  = _impuestoHelp .BuscarImpuesto (id);
            if (impuesto  == null)
            {
                Nuevo();
                return;
            }
            txtNombre.Text = impuesto .Nombre;
            txtValor.Text = impuesto.Valor.ToString();
            txtDescripcion.Text = impuesto .Descripcion;

        }
        void Nuevo()
        {
            id = 0;
            impuesto = null;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtNombre.Focus();
        }
        private void frmImpuesto_Load(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtValor.Text, out decimal valor);
            if (valor == 0)
            {
                Utilities.GetDialogResult ("Este campo no puede ser vacio", "",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string .IsNullOrEmpty (txtNombre .Text))
            {
                Utilities .GetDialogResult ("Este campo no puede ser vacio", "",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (id == 0)
            {
                impuesto = new Impuesto
                {
                    Nombre = txtNombre.Text,
                    Valor = valor,
                    Descripcion = txtDescripcion.Text
                };
                _impuestoHelp.Guardar(impuesto);
            }
            else
            {
                impuesto.Nombre = txtNombre.Text;
                impuesto.Valor = valor;
                impuesto.Descripcion = txtDescripcion.Text;
                _impuestoHelp.Actualizar(id, impuesto);
            }
            Nuevo();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
