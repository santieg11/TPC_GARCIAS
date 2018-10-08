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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();

        }

        public frmContactos(int id)
        {
            InitializeComponent();

            btnAceptar.Hide();
            ContactosNegocio conectar = new ContactosNegocio();
            DatosContacto datos = new DatosContacto();
            datos = conectar.consultar(id);

            txbIDCont.Text = id.ToString();
            txbNomContacto.Text = datos.strNombre;
            mtbTelefono.Text = datos.intTelefono.ToString();
            txbEmail.Text = datos.strEmail;
            txbDireccion.Text = datos.strDireccion;

            txbIDCont.ReadOnly = true;
            txbNomContacto.ReadOnly = true;
            mtbTelefono.ReadOnly = true;
            txbEmail.ReadOnly = true;
            txbDireccion.ReadOnly = true;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txbNomContacto.ReadOnly = false;
            mtbTelefono.ReadOnly = false;
            txbEmail.ReadOnly = false;
            txbDireccion.ReadOnly = false;
            btnAceptar.Show();
        }
    }
}
