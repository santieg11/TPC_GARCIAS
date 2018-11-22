﻿using System;
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
    public partial class frmABMProductos : Form
    {
        public frmABMProductos()
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
            ProductosNegocio prod = new ProductosNegocio();
            try
            {
                dgvProductos.DataSource = prod.listar();
                dgvProductos.Columns[0].HeaderText = "ID Producto";
                dgvProductos.Columns[1].HeaderText = "Descripcion";
                dgvProductos.Columns[2].HeaderText = "% Ganancia";
                dgvProductos.Columns[3].HeaderText = "Valor";
                dgvProductos.Columns[4].HeaderText = "Valor Ult. Venta";
                dgvProductos.Columns[5].HeaderText = "Fecha Ult. Venta";
                dgvProductos.Columns[6].HeaderText = "Fecha Alta";
                dgvProductos.Columns[7].HeaderText = "Fecha Baja";
                dgvProductos.Columns[8].HeaderText = "Ult Modificacion";
                dgvProductos.Columns[9].HeaderText = "Status";

                dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProductos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                frmProductos alta = new frmProductos();
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
            PRODUCTOS id;
            id = (PRODUCTOS)dgvProductos.CurrentRow.DataBoundItem;

            ProductosNegocio prov = new ProductosNegocio();
            prov.eliminarLogico(id.intCodProd);

            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTOS id;
                id = (PRODUCTOS)dgvProductos.CurrentRow.DataBoundItem;

                frmProductos mod = new frmProductos(id,'m');
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
            PRODUCTOS id;
            id = (PRODUCTOS)dgvProductos.CurrentRow.DataBoundItem;

            ProductosNegocio prov = new ProductosNegocio();
            prov.habilitarlogico(id.intCodProd);

            cargar();
        }


    }
}
