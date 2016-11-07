using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmGenero : WindowsBiblioteca.frmParametricas
    {
        Logica.Genero objLogicaGenero = new Logica.Genero();
        public frmGenero()
        {
            InitializeComponent();
            this.Text = "ACTUALIZACION DE GENEROS";
        }
        void TraerTodos()
        {
            dgDatos.DataSource = objLogicaGenero.TraerTodos();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lblID.Text=="")
            {
                objLogicaGenero.Agregar(txtDescripcion.Text);
                MessageBox.Show("GENERO AGREGADO");
            }
            else
            {
                objLogicaGenero.Modificar(Convert.ToInt32(lblID.Text), txtDescripcion.Text);
                MessageBox.Show("GENERO MODIFICADO");
            }
            txtDescripcion.ReadOnly = true;
            TraerTodos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int intID = Convert.ToInt32(lblID.Text);
            objLogicaGenero.Borrar(intID);
            MessageBox.Show("GENERO BORRADO");
            TraerTodos();
        }
    }
}
