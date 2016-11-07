using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmEditorial : WindowsBiblioteca.frmParametricas
    {
        Logica.Editorial objLogicaEditorial = new Logica.Editorial();

        public frmEditorial()
        {
            InitializeComponent();
            this.Text = "ACTUALIZACION DE EDITORIALES";
        }
        void TraerTodos()
        {
            dgDatos.DataSource = objLogicaEditorial.TraerTodos();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                objLogicaEditorial.Agregar(txtDescripcion.Text);
                MessageBox.Show("EDITORIAL" + txtDescripcion.Text + " AGREGADA");
            }
            else
            {
                objLogicaEditorial.Modificar(Convert.ToInt32(lblID.Text), txtDescripcion.Text);
                MessageBox.Show("EDITORIAL MODIFICADA");
            }
            txtDescripcion.ReadOnly = true;
            TraerTodos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int intID = Convert.ToInt32(lblID.Text);
            objLogicaEditorial.Borrar(intID);
            MessageBox.Show("EDITORIAL " + txtDescripcion.Text+" BORRADA");
            TraerTodos();
        }
    }
}
