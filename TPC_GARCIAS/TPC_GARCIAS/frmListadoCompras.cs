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
            IList<COMPRAS> compra = new List<COMPRAS>();
            try
            {
                compra = comp.listar();
                dgvListadoCompras.DataSource = compra;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ComprasNegocio comp = new ComprasNegocio();
            List<COMPRAS> listaC = new List<COMPRAS>();
            listaC = (List<COMPRAS>)comp.listar();

            if (txbBuscar.Text == "")
            {

                dgvListadoCompras.DataSource = listaC;
            }
            else
            {
                List<COMPRAS> lista;
                lista = listaC.FindAll(compra => compra.strNroRemito.Contains(txbBuscar.Text));
                dgvListadoCompras.DataSource = lista;
            }
        }
    }
}
