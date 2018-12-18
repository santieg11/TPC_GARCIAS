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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema se cerrara");
            this.Close();
        }

        private void btnABMProveedores_Click(object sender, EventArgs e)
        {
            frmABMProv ventana = new frmABMProv();
            ventana.Show();
            this.Close();
        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            frmABMClientes ventana = new frmABMClientes();
            ventana.Show();
            this.Close();
        }

        private void btnABMInsumos_Click(object sender, EventArgs e)
        {
            frmABMInsumos ventana = new frmABMInsumos();
            ventana.Show();
            this.Close();
        }

        private void btnABMProductos_Click(object sender, EventArgs e)
        {
            frmABMProductos ventana = new frmABMProductos();
            ventana.Show();
            this.Close();
        }

        private void btnIngresoRemito_Click(object sender, EventArgs e)
        {
            frmIngresoRemito ventana = new frmIngresoRemito();
            ventana.Show();
            this.Close();
        }

        private void btnIngresoVenta_Click(object sender, EventArgs e)
        {
            frmIngresoVenta ventana = new frmIngresoVenta();
            ventana.Show();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmManejoPedidos ventana = new frmManejoPedidos();
            ventana.Show();
            this.Close();
        }

        private void btnListadoCompras_Click(object sender, EventArgs e)
        {
            frmListadoCompras ventana = new frmListadoCompras();
            ventana.Show();
            this.Close();

        }

        private void btnListadoVentas_Click(object sender, EventArgs e)
        {
            frmListadoVentas ventana = new frmListadoVentas();
            ventana.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmListadoStock ventana = new frmListadoStock();
            ventana.Show();
            this.Close();
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnABMPerfiles_Click(object sender, EventArgs e)
        {

        }
    }
}
