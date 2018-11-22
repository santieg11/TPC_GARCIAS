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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            txbDescripcion.MaxLength = 50;
            btnMod.Hide();
            mtbIDProd.ReadOnly = true;
        }

        public frmProductos(PRODUCTOS id, char tipo)
        {
            InitializeComponent();
            txbDescripcion.MaxLength = 50;
            btnAceptar.Hide();
            btnCancelar.Hide();
            mtbIDProd.ReadOnly = true;

            try
            {
                ProductosNegocio conectar = new ProductosNegocio();
                PRODUCTOS datos = new PRODUCTOS();
                datos = conectar.consultar(id.intCodProd);

                mtbIDProd.Text = id.intCodProd.ToString();
                txbDescripcion.Text = datos.strDescripcion;
                txbValor.Text = datos.decValor.ToString();
                mtbGanancia.Text = datos.intGanancia.ToString();

                if (tipo == 'v')
                {
                    txbDescripcion.ReadOnly = true;
                    mtbGanancia.ReadOnly = true;

                    btnMod.Hide();
                }
                else if (tipo == 'm')
                {
                    btnMod.Show();
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductosNegocio conectar = new ProductosNegocio();
            PRODUCTOS datos = new PRODUCTOS();

            try
            {
                datos.strDescripcion = txbDescripcion.Text;
                conectar.alta(datos);

                MessageBox.Show("Producto creado exitosamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnMod_Click(object sender, EventArgs e)
        {

            ProductosNegocio conectar = new ProductosNegocio();
            PRODUCTOS datos = new PRODUCTOS();

            datos.intCodProd = Convert.ToInt32(mtbIDProd.Text);
            datos.strDescripcion= txbDescripcion.Text;
            datos.datUltMod = DateTime.Now;
            datos.decValor = Convert.ToInt32(txbValor.Text);

            conectar.modificar(datos);
            MessageBox.Show("Producto modificado");
        }
    }
}
