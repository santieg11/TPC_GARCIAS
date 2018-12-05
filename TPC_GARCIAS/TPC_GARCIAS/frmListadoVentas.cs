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
    public partial class frmListadoVentas : Form
    {
        public frmListadoVentas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            VentasNegocio ventas = new VentasNegocio();
            try
            {
                dgvListadoVentas.DataSource = ventas.listar();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
