using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            catch (Exception ex)
            {
                MessageBox.Show("Email ingresado incorrecto");
            }
        }

        
    }
}
