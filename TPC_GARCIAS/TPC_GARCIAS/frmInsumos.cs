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
    public partial class frmInsumos : Form
    {
        public frmInsumos()
        {
            InitializeComponent();
            txbDescripcion.MaxLength = 50;
            btnMod.Hide();
            mtbIDInsumo.ReadOnly = true;
        }

        public frmInsumos(INSUMOS id, char tipo)
        {
            InitializeComponent();
            txbDescripcion.MaxLength = 50;
            btnAceptar.Hide();
            btnCancelar.Hide();

            try
            {
                InsumosNegocio conectar = new InsumosNegocio();
                INSUMOS datos = new INSUMOS();
                datos = conectar.consultar(id.intCodInsumo);

                mtbIDInsumo.Text = id.intCodInsumo.ToString();
                txbDescripcion.Text = datos.strDescripcion;

                if (tipo == 'v')
                {
                    txbDescripcion.ReadOnly = true;

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
            InsumosNegocio conectar = new InsumosNegocio();
            INSUMOS datos = new INSUMOS();

            try
            {
                datos.strDescripcion = txbDescripcion.Text;
                conectar.alta(datos);

                MessageBox.Show("Insumo creado exitosamente");
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

            InsumosNegocio conectar = new InsumosNegocio();
            INSUMOS datos = new INSUMOS();

            datos.intCodInsumo = Convert.ToInt32(mtbIDInsumo.Text);
            datos.strDescripcion= txbDescripcion.Text;
            datos.datUltMod = DateTime.Now;


            conectar.modificar(datos);
            MessageBox.Show("Insumo modificado");
        }
    }
}
