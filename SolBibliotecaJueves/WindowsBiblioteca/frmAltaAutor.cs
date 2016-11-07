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
    public partial class frmAltaAutor : Form
    {
        // creo objeto de Logica autor
        Logica.Autor objLogicaAutor = new Logica.Autor();

        public frmAltaAutor()
        {
            InitializeComponent();
            cboPaises.DataSource = objLogicaAutor.TraerPaises();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtApellido.CausesValidation = false;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // crear objeto de entidades autor
                Entidades.Autor objEntidadAutor = new Entidades.Autor();
                // cargo propiedades
                objEntidadAutor.Apellido = txtApellido.Text;
                objEntidadAutor.Nombre = txtNombre.Text;
                objEntidadAutor.FechaNacimiento = dtpFechaNac.Value;

                // cargar el pais elegido
                Entidades.Paises objPais = new Entidades.Paises();
                Enum.TryParse(cboPaises.SelectedValue.ToString(), out objPais);
                objEntidadAutor.Nacionalidad = objPais;


                // llamo al metodo agregar y le paso de parametro objentidadautor
                objLogicaAutor.Agregar(objEntidadAutor);

                MessageBox.Show("AUTOR AGREGADO!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text=="")
            {
                errorProvider1.SetError(txtApellido, "EL APELLIDO ES OBLIGATORIO!!");
                e.Cancel = true;
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtApellido, ""); // QUITO ALERTA DE VALIDACION
        }
    }
}
