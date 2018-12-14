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
                dgvListadoCompras.Columns[0].HeaderText = "Id Compra";
                dgvListadoCompras.Columns[1].HeaderText = "Id Prov";
                dgvListadoCompras.Columns[2].Visible = false;
                dgvListadoCompras.Columns[3].HeaderText = "Fecha Compra";
                dgvListadoCompras.Columns[4].HeaderText = "Valor";
                dgvListadoCompras.Columns[5].HeaderText = "Nro Remito";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
