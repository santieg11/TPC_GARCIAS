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
                dgvListadoCompras.DataSource = prov.listar();
                dgvListadoCompras.Columns[0].HeaderText = "ID Prov";
                dgvListadoCompras.Columns[1].HeaderText = "Nombre";
                dgvListadoCompras.Columns[2].HeaderText = "CUIT";
                dgvListadoCompras.Columns[3].HeaderText = "ID Contacto";
                dgvListadoCompras.Columns[4].HeaderText = "Fecha Alta";
                dgvListadoCompras.Columns[5].HeaderText = "Fecha Baja";
                dgvListadoCompras.Columns[6].HeaderText = "Ult Modificacion";
                dgvListadoCompras.Columns[7].HeaderText = "Status";
                
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
                //Cuando termino de dar un alta, sigue acá el código...
                //llamo al metodo cargar para re cargar...
                //cargar();
                //otra cosa que pueden hacer es...
                //Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
