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
    public partial class frmABMInsumos : Form
    {
        public frmABMInsumos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }

        private void frmABMInsumos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            InsumosNegocio insu = new InsumosNegocio();
            try
            {
                dgvInsumos.DataSource = insu.listar();
                
                dgvInsumos.Columns[0].HeaderText = "ID Insumo";
                dgvInsumos.Columns[1].HeaderText = "Descripcion";
                dgvInsumos.Columns[2].HeaderText = "Valor";
                dgvInsumos.Columns[3].HeaderText = "Fecha Ult. Compra";
                dgvInsumos.Columns[4].HeaderText = "Fecha Alta";
                dgvInsumos.Columns[5].HeaderText = "Fecha Baja";
                dgvInsumos.Columns[6].HeaderText = "Ult Modificacion";
                dgvInsumos.Columns[7].HeaderText = "Status";

                dgvInsumos.AutoResizeColumns();
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
                frmInsumos alta = new frmInsumos();
                alta.ShowDialog();

                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            INSUMOS id;
            id = (INSUMOS)dgvInsumos.CurrentRow.DataBoundItem;

            InsumosNegocio prov = new InsumosNegocio();
            prov.eliminarLogico(id.intCodInsumo);

            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                INSUMOS id;
                id = (INSUMOS)dgvInsumos.CurrentRow.DataBoundItem;

                frmInsumos mod = new frmInsumos(id,'m');
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
            INSUMOS id;
            id = (INSUMOS)dgvInsumos.CurrentRow.DataBoundItem;

            InsumosNegocio prov = new InsumosNegocio();
            prov.habilitarlogico(id.intCodInsumo);

            cargar();
        }


    }
}
