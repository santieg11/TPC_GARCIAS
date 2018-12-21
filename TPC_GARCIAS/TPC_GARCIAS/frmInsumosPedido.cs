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
    public partial class frmInsumosPedido : Form
    {
    
        private IList<INSUMOS> listaI = new List<INSUMOS>();
        private IList<InsumosPedidos> listaR = new List<InsumosPedidos>();
        private IList<InsumosPedidos> listaIN = new List<InsumosPedidos>();
        InsumosPedidos insuPed = new InsumosPedidos();
        InsumosNegocio insu = new InsumosNegocio();
        PedidoVta pedvta = new PedidoVta();

        public frmInsumosPedido(PedidoVta ped)
        {
            InitializeComponent();

            pedvta = ped;

            listaI = insu.listar();

            foreach (INSUMOS insum in listaI)
            {
                cmbInsumo.Items.Add(insum.strDescripcion);
            }

            consultarInsumos();
        }


        private void consultarInsumos()
        {
            
            listaIN = insu.listarIP(pedvta.intNroPedido);
            InsumosPedidos insumo;

            foreach (INSUMOS insum in listaI)
            {
                foreach (InsumosPedidos insuP in listaIN)
                {


                    if (insuP.intCodI == insum.intCodInsumo)
                    {
                        insumo = new InsumosPedidos();
                        insumo.strDesc = insum.strDescripcion;
                        insumo.intCodI = insuP.intCodI;
                        insumo.intCodP = insuP.intCodP;
                        insumo.intCant = insuP.intCant;
                        listaR.Add(insumo);
                    }
                }
            }

            reload();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPedidos ventana = new frmPedidos(pedvta);
            ventana.Show();
            this.Close();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargarProd();
            reload();

        }

        private void reload()
        {
            dgvDetalleIng.DataSource = null;
            dgvDetalleIng.DataSource = listaR;
        }

        private void cargarProd()
        {
            InsumosPedidos agregar = new InsumosPedidos();

            agregar.intCodP = insuPed.intCodP;
            agregar.strDesc = cmbInsumo.SelectedItem.ToString();
            agregar.intCant = Convert.ToInt32(txbCantidad.Text);

            


            if (listaR.Count == 0)
            {
                foreach (INSUMOS insum in listaI)
                {
                    if (insum.strDescripcion == agregar.strDesc)
                    {
                        agregar.intCodI = insum.intCodInsumo;
                    }
                }
            }
            else
            {
                foreach (InsumosPedidos isup in listaR)
                {
                    if (isup.strDesc == agregar.strDesc)
                    {
                        agregar.intCodP = isup.intCodP;
                        agregar.intCodI = isup.intCodI;
                        agregar.intCant += isup.intCant;

                        listaR.Remove(isup);
                        break;
                    }

                    else
                    {
                        foreach (INSUMOS insum in listaI)
                        {
                            if (insum.strDescripcion == agregar.strDesc)
                            {
                                agregar.intCodI = insum.intCodInsumo;
                                agregar.intCodP = isup.intCodP;
                            }
                        }
                    }
                }
            }
            
            listaR.Add(agregar);
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            InsumosPedidos quitar = new InsumosPedidos();

            quitar.intCodP = insuPed.intCodP;
            quitar.strDesc = cmbInsumo.SelectedItem.ToString();
            quitar.intCant = Convert.ToInt32(txbCantidad.Text);

            foreach (InsumosPedidos insu in listaR)
            {
                int cant = Convert.ToInt32(txbCantidad.Text);
                if (insu.strDesc == quitar.strDesc)
                {
                    if ((insu.intCant - cant) < 0)
                    {
                        MessageBox.Show("No se puede quitar mas de lo ya ingresado");
                    }
                    else
                    {
                        insu.intCant -= quitar.intCant;
                    }
                    if (insu.intCant == 0)
                    {
                        listaR.Remove(insu);
                        break;
                    }

                }
            }
            reload();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listaR.Clear();
            reload();
            txbCantidad.Text = null;
            cmbInsumo.Text = null;
            consultarInsumos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsumosNegocio conexion = new InsumosNegocio();

            conexion.altaIPed(listaR);
            MessageBox.Show("Se grabaron los cambios");
            
        }

    }
}

