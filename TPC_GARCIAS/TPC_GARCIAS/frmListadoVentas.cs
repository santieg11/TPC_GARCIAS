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
                dgvListadoVentas.AutoResizeColumns();
                dgvListadoVentas.Columns[0].HeaderText = "ID Venta";
                dgvListadoVentas.Columns[1].HeaderText = "Fecha Venta";
                dgvListadoVentas.Columns[2].HeaderText = "ID Cliente";
                dgvListadoVentas.Columns[3].HeaderText = "Nombre";
                dgvListadoVentas.Columns[4].HeaderText = "ID Pedido";
                dgvListadoVentas.Columns[5].HeaderText = "Fecha Entrega";
                dgvListadoVentas.Columns[6].HeaderText = "Valor";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
