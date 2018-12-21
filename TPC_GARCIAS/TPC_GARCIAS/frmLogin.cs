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
    public partial class frmLogin : Form
    {
        private Usuario usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            try
            {
                if (txbUser.Text == "")
                {
                    MessageBox.Show("Ingresar Usuario");
                }
                if (txbPw.Text == "")
                {
                    MessageBox.Show("Ingrese Contraseña");
                }
                else
                {
                    usuario = new Usuario();
                    usuario.strNombreUsuario = txbUser.Text.Trim();
                    usuario.strClave = txbPw.Text.Trim();
                    if (usuarioNegocio.validarUsuario(usuario))
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
