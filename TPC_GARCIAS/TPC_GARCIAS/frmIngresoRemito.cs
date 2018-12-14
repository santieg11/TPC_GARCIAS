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
    public partial class frmIngresoRemito : Form
    {
        private IList<PROVEEDORES> listaP = new List<PROVEEDORES>();
        private IList<INSUMOS> listaI = new List<INSUMOS>();
        private IList<DetalleCompras> listaR = new List<DetalleCompras>();


        public frmIngresoRemito()
        {
            InitializeComponent();
            ProveedoresNegocio prov = new ProveedoresNegocio();
            InsumosNegocio insu = new InsumosNegocio();

            listaP = prov.listar();
            listaI = insu.listar();
            listaR.Clear();

            foreach (PROVEEDORES prove in listaP)
            {
                cmbProv.Items.Add(prove.strNombre);
            }

            foreach (INSUMOS insum in listaI)
            {
                cmbInsumo.Items.Add(insum.strDescripcion);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarProd();

        }

        private void reload()
        {
            dgvDetalleIng.DataSource = null;
            dgvDetalleIng.DataSource = listaI;
            try
            {
                dgvDetalleIng.AutoResizeColumns();

                dgvDetalleIng.Columns[0].HeaderText = "Cod Prod";
                dgvDetalleIng.Columns[1].HeaderText = "Cantidad";
                dgvDetalleIng.Columns[2].HeaderText = "Valor Total";
                dgvDetalleIng.Columns[3].HeaderText = "Producto";
                dgvDetalleIng.Columns[4].HeaderText = "Valor Unitario";
                dgvDetalleIng.Columns[5].Visible = false;
                dgvDetalleIng.Columns[6].Visible = false;
                dgvDetalleIng.Columns[7].Visible = false;
                dgvDetalleIng.Columns[8].Visible = false;
                dgvDetalleIng.Columns[9].Visible = false;
                dgvDetalleIng.Columns[10].Visible = false;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarProd()
        {
            DetalleCompras agregar = new DetalleCompras();

            agregar.strDesc = cmbInsumo.SelectedItem.ToString();
            agregar.intCantidad = Convert.ToInt32(txbCantidad.Text);

            if (listaR.Count == 0)
            {
                foreach (INSUMOS insu in listaI)
                {
                    if (agregar.strDesc == insu.strDescripcion)
                    {
                        agregar.intIdInsumo = insu.intCodInsumo;
                        agregar.decValor = insu.decValor * agregar.intCantidad;
                    }
                }
            }
            else
            {
                foreach (DetalleCompras comp in listaR)
                {
                    if (agregar.strDesc == comp.strDesc)
                    {
                        agregar.intIdInsumo = comp.intIdInsumo;
                        agregar.intCantidad = comp.intCantidad + agregar.intCantidad;
                        agregar.decValor = comp.decValor * agregar.intCantidad;

                        listaR.Remove(comp);
                        break;
                    }
                    else
                    {
                        foreach (INSUMOS insu in listaI)
                        {
                            if (agregar.strDesc == insu.strDescripcion)
                            {
                                agregar.intIdInsumo = insu.intCodInsumo;
                                agregar.decValor = insu.decValor * agregar.intCantidad;
                            }
                        }
                    }
                }
            }
            agregar.strNroRemito = mtbRemito.Text;
            listaR.Add(agregar);


            reloadI();
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DetalleCompras quitar = new DetalleCompras();

            quitar.strDesc = cmbInsumo.SelectedItem.ToString();
            quitar.intCantidad = Convert.ToInt32(txbCantidad.Text);

            foreach (DetalleCompras det in listaR)
            {
                if (det.strDesc == quitar.strDesc)
                {
                    if ((det.intCantidad - quitar.intCantidad) < 0)
                    {
                        MessageBox.Show("No se puede quitar mas de lo ya ingresado");
                    }
                    else
                    {
                        det.intCantidad -= quitar.intCantidad;
                        det.decValor = det.decValor * det.intCantidad;
                    }
                    if (det.intCantidad == 0)
                    {
                        listaR.Remove(det);
                        break;
                    }
                }
            }

            reloadI();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbProv.Text = null;
            cmbInsumo.Text = null;
            listaR.Clear();
            txbCantidad.Text = null;
            mtbRemito.Text = null;
            reloadI();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComprasNegocio conexionC = new ComprasNegocio();
            COMPRAS comp = new COMPRAS();

            foreach (PROVEEDORES prov in listaP)
            {
                if (prov.strNombre == cmbProv.Text)
                {
                    comp.intIDProv = prov.intIDProv;
                }
            }

            foreach (DetalleCompras det in listaR)
            {
                comp.decValorCompra += det.decValor;
            }
            comp.strNroRemito = mtbRemito.Text;

            try
            {
                conexionC.cargarCompra(comp);
                conexionC.cargarRemito(listaR);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            MessageBox.Show("Compra generada correctamente");


        }

        private void reloadI()
        {
            dgvDetalleIng.DataSource = null;
            dgvDetalleIng.DataSource = listaR;
            try
            {
                dgvDetalleIng.AutoResizeColumns();

                dgvDetalleIng.Columns[0].HeaderText = "Cod Insumo";
                dgvDetalleIng.Columns[1].HeaderText = "Descripcion";
                dgvDetalleIng.Columns[2].HeaderText = "Cantidad";
                dgvDetalleIng.Columns[3].HeaderText = "Valor";
                dgvDetalleIng.Columns[4].Visible = false;
                dgvDetalleIng.Columns[5].Visible = false;
                dgvDetalleIng.Columns[6].Visible = false;
                dgvDetalleIng.Columns[7].Visible = false;
                dgvDetalleIng.Columns[8].Visible = false;
                dgvDetalleIng.Columns[9].Visible = false;

                dgvDetalleIng.Columns["decValor"].DisplayIndex = 3;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

