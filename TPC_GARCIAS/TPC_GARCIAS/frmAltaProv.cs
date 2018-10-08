using System;
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
    }
}
