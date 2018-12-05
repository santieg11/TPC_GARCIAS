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
    public partial class frmIngresoVenta : Form
    {
        private CLIENTES cliente = new CLIENTES();
        private PRODUCTOS prod = new PRODUCTOS();
        private IList<CLIENTES> listaC = new List<CLIENTES>();
        private IList<PRODUCTOS> listaP = new List<PRODUCTOS>();

        public frmIngresoVenta()
        {
            InitializeComponent();
            ProductosNegocio produ = new ProductosNegocio();
            ClientesNegocio clie = new ClientesNegocio();

            listaP = produ.listar();
            listaC = clie.listar();
            
            foreach (CLIENTES cliente in listaC)
            {
                cmbClientes.Items.Add(cliente.strNombre);
            }

            foreach (PRODUCTOS prod in listaP)
            {
                cmbProducto.Items.Add(prod.strDescripcion);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaEntrega.Value < DateTime.Today) //verifico que no se ingresen fechas en el pasado
            {
                MessageBox.Show("No se puede seleccionar fechas anteriores al dia de la fecha");
                dtpFechaEntrega.Value = DateTime.Today;
            }
        }

        private void frmIngresoVenta_Load(object sender, EventArgs e)
        {


        }
    }
}
