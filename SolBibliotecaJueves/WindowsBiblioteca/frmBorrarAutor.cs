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
    public partial class frmBorrarAutor : Form
    {
        Logica.Autor objLogicaAutor = new Logica.Autor();

        public frmBorrarAutor()
        {
            InitializeComponent();
            tlpModificar.Visible = false;
            TraerAutores();
           
        }
        void TraerAutores()
        {

            cboAutores.DataSource = objLogicaAutor.TraerTodos();
            cboAutores.DisplayMember = "Autor"; // campo/alias mostrar
            cboAutores.ValueMember = "Codigo"; // campo/alias del valor a guardad
            this.cboAutores.SelectedIndexChanged += new System.EventHandler(this.cboAutores_SelectedIndexChanged);


        }
        void TraerAutor(int id)
        {
            Entidades.Autor objEntidadAutor = objLogicaAutor.TraerUno(id);
            tlpModificar.Visible = true;
            txtApellido.Text = objEntidadAutor.Apellido;
            txtNombre.Text = objEntidadAutor.Nombre;
            dtpFechaNac.Value = objEntidadAutor.FechaNacimiento;

            // nacionalidad
            cboPaises.Text = objEntidadAutor.Nacionalidad.ToString();

        }
        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se ejecuta cuando el usuario cambia de autor
            int intID = Convert.ToInt32(cboAutores.SelectedValue);
            TraerAutor(intID);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // LLAMAR A METODO BORRAR
            int intID = Convert.ToInt32(cboAutores.SelectedValue);
            objLogicaAutor.Borrar(intID);
            MessageBox.Show("autor borrado!!!!");
        }
    }
}
