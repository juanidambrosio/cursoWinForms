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
    public partial class frmModificarAutor : Form
    {
        Logica.Autor objLogicaAutor = new Logica.Autor();


        public frmModificarAutor()
        {
            InitializeComponent();
            tlpModificar.Visible = false;
            TraerAutores();
            TraerPaises();
        }

        public void TraerAutores ()
        {
            this.cboAutores.DataSource = objLogicaAutor.TraerTodos();
            cboAutores.DisplayMember = "Autor"; //Campo o alias a mostrar
            cboAutores.ValueMember = "Codigo"; //Campo o alias del valor a guardar
            this.cboAutores.SelectedIndexChanged += new System.EventHandler(this.cboAutores_SelectedIndexChanged);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CausesValidation = false;
            this.Close();
        }

        private void CERRARFORMULARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cboAutores.SelectedValue);
            TraerAutor(codigo);
        }

        void TraerAutor(int codigo)
        {
            Entidades.Autor objEntidadAutor = objLogicaAutor.TraerUno(codigo);
            tlpModificar.Visible = true;
            txtApellido.Text = objEntidadAutor.Apellido;
            txtNombre.Text = objEntidadAutor.Nombre;
            dtpFechaNac.Value = objEntidadAutor.FechaNacimiento;
            cboPaises.Text = objEntidadAutor.Nacionalidad.ToString();
        }

        void TraerPaises()
        {
            cboPaises.DataSource = objLogicaAutor.TraerPaises();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Entidades.Autor objEntidadAutor = new Entidades.Autor();
            objEntidadAutor.Codigo = Convert.ToInt32(cboAutores.SelectedValue);
            objEntidadAutor.Apellido = txtApellido.Text;
            objEntidadAutor.Nombre = txtNombre.Text;
            objEntidadAutor.FechaNacimiento = dtpFechaNac.Value;

            Entidades.Paises objPais = new Entidades.Paises();
            Enum.TryParse(cboPaises.SelectedValue.ToString(), out objPais);
            objEntidadAutor.Nacionalidad = objPais;

            // llamo al metodo modificar
            try
            {
                objLogicaAutor.Modificar(objEntidadAutor);
                MessageBox.Show("DATOS DEL AUTOR MODIFICADOS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
