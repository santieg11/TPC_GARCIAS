using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;



namespace TPC_GARCIAS
{
    public partial class frmMenu : MaterialForm
    {
        public frmMenu()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema se cerrara");
            this.Close();
        }

        private void btnListadoInsumos_Click(object sender, EventArgs e)
        {
            frmReporteInsumos repInsumos = new frmReporteInsumos();
            repInsumos.Show();
            this.Close();

        }
    }
}
