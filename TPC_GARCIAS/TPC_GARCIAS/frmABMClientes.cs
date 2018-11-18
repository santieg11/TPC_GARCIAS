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
    public partial class frmABMClientes : Form
    {
        public frmABMClientes()
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
            ClientesNegocio client = new ClientesNegocio();
            try
            {
                dgvProveedores.DataSource = client.listar();
                dgvProveedores.Columns[0].HeaderText = "ID Cliente";
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
                frmAltaClientes alta = new frmAltaClientes();
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
            try
            {
                CLIENTES id;
                id = (CLIENTES)dgvProveedores.CurrentRow.DataBoundItem;

                frmAltaClientes ver = new frmAltaClientes(id,'v');
                ver.ShowDialog();

                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            CLIENTES id;
            id = (CLIENTES)dgvProveedores.CurrentRow.DataBoundItem;

            ClientesNegocio prov = new ClientesNegocio();
            prov.eliminarLogico(id.intIDCliente);

            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CLIENTES id;
                id = (CLIENTES)dgvProveedores.CurrentRow.DataBoundItem;

                frmAltaClientes mod = new frmAltaClientes(id,'m');
                mod.ShowDialog();
                
                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            CLIENTES id;
            id = (CLIENTES)dgvProveedores.CurrentRow.DataBoundItem;

            ClientesNegocio client = new ClientesNegocio();
            client.habilitarlogico(id.intIDCliente);

            cargar();
        }
    }
}
