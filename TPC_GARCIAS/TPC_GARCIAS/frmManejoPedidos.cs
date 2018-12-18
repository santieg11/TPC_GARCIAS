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
    public partial class frmManejoPedidos : Form
    {
        public frmManejoPedidos()
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
            PedidosNegocio ped = new PedidosNegocio();
            try
            {
                dgvPedidos.DataSource = ped.listar();
                dgvPedidos.Columns[0].HeaderText = "ID Venta";
                dgvPedidos.Columns[1].HeaderText = "Fecha Pedido";
                dgvPedidos.Columns[2].HeaderText = "Entrega Acordada";
                dgvPedidos.Columns[3].HeaderText = "Entrega Real";
                dgvPedidos.Columns[4].HeaderText = "Status";

                dgvPedidos.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmManejoPedidos_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
