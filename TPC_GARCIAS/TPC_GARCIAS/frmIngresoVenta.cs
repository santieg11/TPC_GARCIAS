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
        private IList<INGRESOS> listaI = new List<INGRESOS>();


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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarProd();

        }

        private void reload()
        {
            dgvDetalleVta.DataSource = null;
            dgvDetalleVta.DataSource = listaI;
            try
            {
                dgvDetalleVta.AutoResizeColumns();

                dgvDetalleVta.Columns[0].HeaderText = "Cod Prod";
                dgvDetalleVta.Columns[1].HeaderText = "Cantidad";
                dgvDetalleVta.Columns[2].HeaderText = "Valor Total";
                dgvDetalleVta.Columns[3].HeaderText = "Producto";
                dgvDetalleVta.Columns[4].Visible = false;
                dgvDetalleVta.Columns[5].HeaderText = "Valor Unitario";
                dgvDetalleVta.Columns[6].Visible = false;
                dgvDetalleVta.Columns[7].Visible = false;
                dgvDetalleVta.Columns[8].Visible = false;
                dgvDetalleVta.Columns[9].Visible = false;
                dgvDetalleVta.Columns[10].Visible = false;
                dgvDetalleVta.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarProd()
        {
            INGRESOS agregar = new INGRESOS();
            INGRESOS quitar = new INGRESOS();

            agregar.strDescripcion = cmbProducto.SelectedItem.ToString();
            agregar.intcantidad = Convert.ToInt32(txbCantidad.Text);
                        
            if (listaI.Count == 0)
            {
                foreach (PRODUCTOS prod in listaP)
                {
                    if (agregar.strDescripcion == prod.strDescripcion)
                    {
                        agregar.intcod = prod.intCodProd;
                        agregar.decValorIng = prod.decValor * agregar.intcantidad;
                        agregar.decValor = prod.decValor;
                    }
                }
                listaI.Add(agregar);
            }
            else
            {
                foreach(INGRESOS ing in listaI)
                {
                    if(agregar.strDescripcion == ing.strDescripcion)
                    {
                        agregar.intcod = ing.intcod;
                        agregar.intcantidad = ing.intcantidad + agregar.intcantidad;
                        agregar.decValorIng = ing.decValor * agregar.intcantidad;
                        agregar.decValor = ing.decValor;

                        listaI.Remove(ing);
                        break;
                    }
                    else
                    {
                        foreach (PRODUCTOS prod in listaP)
                        {
                            if (agregar.strDescripcion == prod.strDescripcion)
                            {
                                agregar.intcod = prod.intCodProd;
                                agregar.decValorIng = prod.decValor * agregar.intcantidad;
                                agregar.decValor = prod.decValor;
                            }
                        }
                    }
                }
                listaI.Add(agregar);
            }

            reload();

        }
    
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            INGRESOS quitar = new INGRESOS();

            quitar.strDescripcion = cmbProducto.SelectedItem.ToString();
            quitar.intcantidad = Convert.ToInt32(txbCantidad.Text);

            foreach (INGRESOS ped in listaI)
            {
                if (ped.strDescripcion == quitar.strDescripcion)
                {
                    if ((ped.intcantidad - quitar.intcantidad)<0)
                    {
                        MessageBox.Show("No se puede quitar mas de lo ya pedido");
                    }
                    else
                    {
                        ped.intcantidad = ped.intcantidad - quitar.intcantidad;
                        ped.decValorIng = ped.decValor * ped.intcantidad;
                    }
                    if (ped.intcantidad == 0)
                    {
                        listaI.Remove(ped);
                        break;
                    }
                }
            }

            reload();

        }
    }
}
