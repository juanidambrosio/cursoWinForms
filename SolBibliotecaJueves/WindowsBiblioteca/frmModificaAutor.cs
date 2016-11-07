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
    public partial class frmModificaAutor : Form
    {
        Logica.Autor objLogicaAutor = new Logica.Autor();
        public frmModificaAutor()
        {
            InitializeComponent();
            tlpModificar.Visible = false;
            TraerAutores();
            TraerPaises();
        }

        void TraerPaises()
        {
            cboPaises.DataSource = objLogicaAutor.TraerPaises();

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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se ejecuta cuando el usuario cambia de autor
            int intID = Convert.ToInt32(cboAutores.SelectedValue);
            TraerAutor(intID);
        
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            // creo un objeto de entidades autor
            Entidades.Autor objEntidadAutor = new Entidades.Autor();

            // cargo datos modificados x el usuario
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
                MessageBox.Show("DATOS DEL AUTOR MODIFICADOS OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
