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
    public partial class frmListadoStock : Form
    {
        public frmListadoStock()
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
            InsumosNegocio ventas = new InsumosNegocio();
            try
            {
                dgvListadoVentas.DataSource = ventas.listaS();
                dgvListadoVentas.AutoResizeColumns();
                dgvListadoVentas.Columns[0].HeaderText = "ID Insumo";
                dgvListadoVentas.Columns[1].HeaderText = "Descripcion";
                dgvListadoVentas.Columns[2].HeaderText = "Cantidad actual";




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmListadoStock_Load(object sender, EventArgs e)
        {
            cargar();

        }
    }
}
