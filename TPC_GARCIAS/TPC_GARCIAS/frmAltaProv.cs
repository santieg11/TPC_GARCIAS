﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;
using NEGOCIO;

namespace TPC_GARCIAS
{
    public partial class frmAltaProv : Form
    {
        public frmAltaProv()
        {
            InitializeComponent();
            txbNomProv.MaxLength = 50;
            mtbCUIT.MaxLength = 13;
            txbNomContacto.MaxLength = 80;
            txbEmail.MaxLength = 50;
            txbDireccion.MaxLength = 50;
            btnMod.Hide();
            txbIDProv.ReadOnly = true;
            txbIDContacto.ReadOnly = true;
        }

        public frmAltaProv(PROVEEDORES id, char tipo)
        {
            InitializeComponent();
            txbNomProv.MaxLength = 50;
            mtbCUIT.MaxLength = 13;
            txbNomContacto.MaxLength = 80;
            txbEmail.MaxLength = 50;
            txbDireccion.MaxLength = 50;
            txbIDProv.ReadOnly = true;
            txbIDContacto.ReadOnly = true;
            btnAceptar.Hide();
            btnCancelar.Hide();
            

            try
            {
                ProveedoresNegocio conectarP = new ProveedoresNegocio();
                PROVEEDORES datosP = new PROVEEDORES();
                datosP = conectarP.ConsultarProv(id.intIDProv);

                ContactosNegocio conectarC = new ContactosNegocio();
                DatosContacto datosC = new DatosContacto();
                datosC = conectarC.consultar(id.intIdContacto);

                txbIDProv.Text = id.intIDProv.ToString();
                txbNomProv.Text = datosP.strNombre;
                mtbCUIT.Text = datosP.strCuit;
                txbIDContacto.Text = id.intIdContacto.ToString();

                txbNomContacto.Text = datosC.strNombre;
                mtbTelefono.Text = datosC.intTelefono.ToString();
                txbEmail.Text = datosC.strEmail;
                txbDireccion.Text = datosC.strDireccion;

                if (tipo == 'v')
                {                  
                    txbNomProv.ReadOnly = true;
                    mtbCUIT.ReadOnly = true;
                    txbNomContacto.ReadOnly = true;
                    mtbTelefono.ReadOnly = true;
                    txbEmail.ReadOnly = true;
                    txbDireccion.ReadOnly = true;

                    btnMod.Hide();
                }
                else if (tipo == 'm')
                {
                    btnMod.Show();
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txbEmail_Validated(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(txbEmail.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Email ingresado incorrecto");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio conectarP = new ProveedoresNegocio();
            PROVEEDORES datosP = new PROVEEDORES();

            ContactosNegocio conectarC = new ContactosNegocio();
            DatosContacto datosC = new DatosContacto();

            try
            {
                datosC.strNombre = txbNomContacto.Text;
                datosC.strEmail = txbEmail.Text;
                datosC.intTelefono = (int)Convert.ToInt64(mtbTelefono.Text);
                datosC.strDireccion = txbDireccion.Text;

                conectarC.alta(datosC);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            try
            {
                datosP.strNombre = txbNomProv.Text;
                datosP.strCuit = mtbCUIT.Text;
                datosP.intIdContacto = conectarC.consultarID();

                conectarP.alta(datosP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                MessageBox.Show("Proveedor creado exitosamente");

            }




        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnMod_Click(object sender, EventArgs e)
        {
            
            ProveedoresNegocio conectarP = new ProveedoresNegocio();
            PROVEEDORES datosP = new PROVEEDORES();
            ContactosNegocio conectarC = new ContactosNegocio();
            DatosContacto datosC = new DatosContacto();

            datosP.intIDProv = Convert.ToInt32(txbIDProv.Text);
            datosP.strNombre = txbNomProv.Text;
            datosP.strCuit = mtbCUIT.Text;
            datosP.datUltMod = DateTime.Now;

            datosC.intIDContacto = Convert.ToInt32(txbIDContacto.Text);
            datosC.strNombre = txbNomContacto.Text;
            datosC.intTelefono = Convert.ToInt32(mtbTelefono.Text);
            datosC.strEmail = txbEmail.Text;
            datosC.strDireccion = txbDireccion.Text;

            conectarP.modificar(datosP);
            conectarC.modificar(datosC);
            MessageBox.Show("Proveedor modificado");
        }
    }
}
