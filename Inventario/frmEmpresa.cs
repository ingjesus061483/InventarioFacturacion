﻿using Helper;
using Helper.DTO;
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
    public partial class frmEmpresa : Form
    {
        string ruta = "";
        int id;
        EmpresaDTO empresa;
        TipoRegimenHelp _tipoRegimenHelp;
        EmpresaHelp _empresaHelp;
        public frmEmpresa(TipoRegimenHelp tipoRegimenHelp ,EmpresaHelp empresaHelp )
        {
            _tipoRegimenHelp = tipoRegimenHelp;
            _empresaHelp = empresaHelp;
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Utilities .Cmb(cmbTipoRegimen,_tipoRegimenHelp.Queryable.ToList ());
            Nuevo();
        }
        void Nuevo()
        {
            id = 0;
            empresa = null;
            txtNit.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbTipoRegimen.SelectedIndex =-1;
            txtDireccion.Text = string .Empty ;
            txtCamaraComercio.Text = string .Empty ;
            txtEmail.Text = string.Empty;
            txtSlogan.Text = string .Empty ;            
            txtContacto.Text = string .Empty ;
            txtTelefono.Text = string .Empty;
            ruta = "";
            PictureBox1.Image = null;
            txtNit.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            frmBusqueda frmBusqueda = new frmBusqueda(_empresaHelp );
            frmBusqueda.ShowDialog();
            id = frmBusqueda.Id;
            empresa = _empresaHelp.Queryable .Where (x=>x.Id== id).FirstOrDefault();
            if (empresa == null)
            {
                Nuevo();
                return;
            }
            txtNombre.Text = empresa.Nombre;
            cmbTipoRegimen.SelectedValue = empresa.TipoRegimenId;
            txtDireccion.Text = empresa.Direccion;
            txtCamaraComercio.Text = empresa.CamaraComercio;
            txtEmail.Text = empresa.Email;
            txtSlogan.Text = empresa.Slogan;
            txtNit.Text = empresa.Nit;
            txtContacto.Text = empresa.Contacto;
            txtTelefono.Text = empresa.Telefono;
            ruta = empresa.Logo ;
            if (!string.IsNullOrEmpty(ruta))
            {
                PictureBox1.Load(ruta);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ruta = Utilities.CargarImagen(PictureBox1);
        }
     
        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (empresa == null)
            {               
                empresa = new EmpresaDTO
                {
                    Nombre =txtNombre .Text ,
                    TipoRegimenId = cmbTipoRegimen.SelectedValue!=null?
                                    int.Parse ( cmbTipoRegimen.SelectedValue.ToString ( )):
                                    -1,
                    Direccion= txtDireccion.Text ,
                    CamaraComercio= txtCamaraComercio.Text ,
                    Email= txtEmail.Text,
                    Slogan= txtSlogan.Text ,
                    Nit= txtNit.Text ,
                    Contacto= txtContacto.Text ,
                    Telefono= txtTelefono.Text ,
                    Logo= ruta 
                };
                _empresaHelp.Guardar(empresa);  
                Nuevo();             
            }
            else
            {
                empresa.Nombre = txtNombre.Text;
                empresa.TipoRegimenId = int.Parse(cmbTipoRegimen.SelectedValue.ToString());
                empresa.Direccion = txtDireccion.Text;
                empresa.CamaraComercio = txtCamaraComercio.Text;
                empresa.Email = txtEmail.Text;
                empresa.Slogan = txtSlogan.Text;
                empresa.Contacto = txtContacto.Text;
                empresa.Telefono = txtTelefono.Text;
                empresa.Logo = ruta;
                _empresaHelp.Actualizar(empresa.Id, empresa);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
