﻿using Helper;
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
    public partial class frmMotivo : Form
    {
        MotivoHelp _motivoHelp;
        int id;
        Motivo motivo;
        public frmMotivo(MotivoHelp motivoHelp )
        {
            _motivoHelp = motivoHelp;
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda frmBusqueda = new frmBusqueda(_motivoHelp);
            frmBusqueda.ShowDialog();
            id = frmBusqueda.Id;
            motivo = _motivoHelp.BuscarMotivos(frmBusqueda.Id);
            if( motivo==null)
            {
                Nuevo();
                return;                
            }
            txtCodigo.Text = motivo.Codigo;
            txtNombre.Text = motivo.Concepto;
            txtDescripcion.Text  = motivo.Descripcion;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void Nuevo()
        {
            id = 0;
            txtCodigo.Text = string.Empty;
            txtNombre.Text =string .Empty ;
            txtDescripcion.Text = string.Empty;
            txtCodigo.Focus();
            motivo = null;
        }
        private void frmMotivo_Load(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            if(id==0)
            {
                motivo = new Motivo
                {
                    Codigo = txtCodigo.Text,
                    Concepto = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };
                _motivoHelp .Guardar (motivo );
                Nuevo();
            }
            else
            {                   
                motivo.Concepto = txtNombre.Text;
                motivo.Descripcion = txtDescripcion.Text;
                _motivoHelp.Actualizar(id, motivo);
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
