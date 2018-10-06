using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_GARCIAS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema se cerrara");
            this.Close();
        }

        private void btnListadoCompras_Click(object sender, EventArgs e)
        {
            frmListadoCompras ventana = new frmListadoCompras();
            ventana.Show();
            this.Close();

        }
    }
}
