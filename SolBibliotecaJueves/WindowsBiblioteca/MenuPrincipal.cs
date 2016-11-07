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
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el mdi , cierra la aplicacion
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmAltaAutor objForm = new frmAltaAutor();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmVistaAutores objForm = new frmVistaAutores();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmModificaAutor objForm = new frmModificaAutor();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmBorrarAutor objForm = new frmBorrarAutor();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmListadoAutores objForm = new frmListadoAutores();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmGenero objForm = new frmGenero();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void actualizacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmEditorial objForm = new frmEditorial();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void actualizacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmLibros objForm = new frmLibros();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar
            frmListadoGeneros objForm = new frmListadoGeneros();
            // 2. Establecer que ese form sea hijo del
            // menu principal ( mdi)
            objForm.MdiParent = this;
            // 3. Que muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;
            // 4. msotrar el form
            objForm.Show();
        }
    }
}
