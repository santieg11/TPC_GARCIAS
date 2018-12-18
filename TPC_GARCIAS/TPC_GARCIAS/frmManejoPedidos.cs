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

        private void cargar()
        {
            PedidosNegocio ped = new PedidosNegocio();
            try
            {
                dgvPedidos.DataSource = ped.listar();

                dgvPedidos.Columns["intIDVenta"].DisplayIndex = 1;
                dgvPedidos.Columns["datFechaVta"].DisplayIndex = 2;
                
                dgvPedidos.Columns[0].HeaderText = "ID Pedido";
                dgvPedidos.Columns[1].HeaderText = "Entrega Acordada";
                dgvPedidos.Columns[2].HeaderText = "Entrega Real";
                dgvPedidos.Columns[3].HeaderText = "Status";
                dgvPedidos.Columns[4].HeaderText = "ID Venta";
                dgvPedidos.Columns[5].HeaderText = "Fecha Pedido";
                dgvPedidos.Columns[6].Visible = false;
                dgvPedidos.Columns[7].Visible = false;

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
