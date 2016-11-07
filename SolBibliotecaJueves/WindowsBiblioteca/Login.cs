using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class Login : Form
    {
        Logica.Usuario objLogicaUsuario = new Logica.Usuario();
        Entidades.Usuario objEntidadUsuario = new Entidades.Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objEntidadUsuario.IdUsuario = txtUsuario.Text;
            objEntidadUsuario.Contraseña = txtContraseña.Text;
            if (objLogicaUsuario.Validar(objEntidadUsuario))
            {
                MessageBox.Show("Acceso concedido");
                MenuPrincipal objMenuPrincipal = new MenuPrincipal();
                objMenuPrincipal.Show();
            }
            else MessageBox.Show("Acceso Denegado");
        }
    }
}
