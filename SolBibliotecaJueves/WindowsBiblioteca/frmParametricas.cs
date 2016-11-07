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
    public partial class frmParametricas : Form
    {
        public frmParametricas()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtDescripcion.ReadOnly = false;
            txtDescripcion.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtDescripcion.ReadOnly = false;
            txtDescripcion.Text = "";
            txtDescripcion.Focus();
        }

        private void dgDatos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtDescripcion.Text = row.Cells[1].Value.ToString();

                }
            }

        }

        
    }
}
