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
    public partial class frmPedidos : Form
    {
        private IList<string> listaS = new List<string>();
        int idvta;
        int idstatus;
        PedidoVta ped = new PedidoVta();

        public frmPedidos()
        {
            InitializeComponent();
        }

        public frmPedidos(PedidoVta id)
        {
            InitializeComponent();
            ped = id;

            txbPedido.Text = id.intNroPedido.ToString();
            txbVenta.Text = id.intIDVenta.ToString();
            dtpPedido.Value = id.datFechaVta;
            dtpEAcord.Value = id.datEntregaAcordada;

            idvta = id.intNroPedido;
            idstatus = id.intStatusPedido;

            txbPedido.ReadOnly = true;
            txbVenta.ReadOnly = true;
            dtpPedido.Enabled = false;
            dtpEAcord.Enabled = false;
            lblEReal.Visible = false;
            dtpEReal.Visible = false;

            listaS.Add("No empezado"); //status 1
            listaS.Add("En produccion"); //status 2
            listaS.Add("Terminado"); //status 3
            listaS.Add("Entregado"); //status 4

            foreach (string var in listaS)
            {
                cmbStatus.Items.Add(var);
            }

            string stat = listaS[id.intStatusPedido - 1].ToString();
            cmbStatus.Text = stat;
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmManejoPedidos ventana = new frmManejoPedidos();
            ventana.Show();
            this.Close();

        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmInsumosPedido ventana = new frmInsumosPedido(ped);
            ventana.Show();
            this.Close();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            if (idstatus == 4)
            {
                lblEReal.Visible = true;
                dtpEReal.Visible = true;
            }
        }
    }
}
