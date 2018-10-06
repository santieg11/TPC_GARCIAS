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
    public partial class frmListadoCompras : Form
    {
        public frmListadoCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            frmMenu ventana = new frmMenu();
            ventana.Show();
            this.Close();
        }
    }
}
