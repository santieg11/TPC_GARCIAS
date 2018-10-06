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
    public partial class frmListadoCompras : Form
    {
        public frmListadoCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }

        private void frmListadoCompras_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ComprasNegocio comp = new ComprasNegocio();
            try
            {
                dgvListadoCompras.DataSource = comp.listar();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
