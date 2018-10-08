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
    public partial class frmABMProv : Form
    {
        public frmABMProv()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }

        private void frmABMProv_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ProveedoresNegocio prov = new ProveedoresNegocio();
            try
            {
                dgvProveedores.DataSource = prov.listar();
                dgvProveedores.Columns[0].HeaderText = "ID Prov";
                dgvProveedores.Columns[1].HeaderText = "Nombre";
                dgvProveedores.Columns[2].HeaderText = "CUIT";
                dgvProveedores.Columns[3].HeaderText = "ID Contacto";
                dgvProveedores.Columns[4].HeaderText = "Fecha Alta";
                dgvProveedores.Columns[5].HeaderText = "Fecha Baja";
                dgvProveedores.Columns[6].HeaderText = "Ult Modificacion";
                dgvProveedores.Columns[7].HeaderText = "Status";

                dgvProveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProveedores.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaProv alta = new frmAltaProv();
                alta.ShowDialog();

                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerContacto_Click(object sender, EventArgs e)
        {

            PROVEEDORES id;
            id = (PROVEEDORES)dgvProveedores.CurrentRow.DataBoundItem;

            frmContactos consulta = new frmContactos(id.intIdContacto);

            consulta.ShowDialog();

        }
    }
}
