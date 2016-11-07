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
    public partial class frmLibros : Form
    {
        Logica.Genero objLogicaGenero = new Logica.Genero();
        Logica.Editorial objLogicaEditorial = new Logica.Editorial();
        Logica.Autor objLogicaAutor = new Logica.Autor();
        Entidades.Libro objEntidadLibro = new Entidades.Libro();
        Logica.Libro objLogicaLibro = new Logica.Libro();

        // crear DataTable
        DataTable dtAutorLibro = new DataTable("dtAutorLibro");

        // creo un objeto de DataView para filtrar en memoria
        DataView dvLibros = new DataView();

        public frmLibros()
        {
            InitializeComponent();
            DataColumn isbn = dtAutorLibro.Columns.Add("ISBN", typeof(string));
            DataColumn idAutor = dtAutorLibro.Columns.Add("IdAutor", typeof(int));
         
        }

        void CargarGeneros()
        {
            cboGeneros.DataSource = objLogicaGenero.TraerTodos();
            cboGeneros.ValueMember = "ID"; // valor a guardar
            cboGeneros.DisplayMember = "Descripcion"; // valor a mostrar

        }
        void CargarEditoriales()
        {
            cboEditoriales.DataSource = objLogicaEditorial.TraerTodos();
            cboEditoriales.ValueMember = "ID"; // valor a guardar
            cboEditoriales.DisplayMember = "Descripcion"; // valor a mostrar
        }

        void CargarAutores()
        {
            dgvAutores.AutoGenerateColumns = false;
            dgvAutores.DataSource = objLogicaAutor.TraerTodos();
            dgvAutores.Columns[0].Width = 100;
            dgvAutores.Columns[1].Width = 300;
            dgvAutores.Columns[2].Width = 100;
        }
        private void frmLibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLibros.vista_libros' table. You can move, or remove it, as needed.
            this.vista_librosTableAdapter.Fill(this.dsLibros.vista_libros);
            CargarGeneros();
            CargarEditoriales();
            CargarAutores();
            this.reportViewer1.RefreshReport();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // cargo propiedades en entidad libro
            try
            {
                objEntidadLibro.ISBN = txtISBN.Text;
                objEntidadLibro.Titulo = txtTitulo.Text;
                objEntidadLibro.Edicion = Convert.ToInt32(txtEdicion.Text);

                Entidades.Genero objGenero = new Entidades.Genero();
                objGenero.ID = Convert.ToInt32(cboGeneros.SelectedValue);
                objEntidadLibro.Genero = objGenero;

                Entidades.Editorial objEditorial = new Entidades.Editorial();
                objEditorial.ID = Convert.ToInt32(cboEditoriales.SelectedValue);
                objEntidadLibro.Editorial = objEditorial;

                // autores
                // recorro el datagridview
                // me fijo si esta seleccionado el autor
                // y agrego al datatable
                foreach (DataGridViewRow item in dgvAutores.Rows)
                {
                    if (Convert.ToBoolean(item.Cells["Agregar"].Value))
                    {
                        // agrego autor e isbn al datatable
                        DataRow filaAutorLibro = dtAutorLibro.NewRow();
                        filaAutorLibro[0] = txtISBN.Text;
                        filaAutorLibro[1] = Convert.ToInt32(item.Cells["Codigo"].Value);
                        dtAutorLibro.Rows.Add(filaAutorLibro);
                    }

                }



                objLogicaLibro.Agregar(objEntidadLibro, dtAutorLibro);
                MessageBox.Show("LIBRO AGREGADO EXITOSAMENTE!");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tcLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcLibros.SelectedTab == tcLibros.TabPages[3])
            {
                // cargo el datagrid
                dvLibros = objLogicaLibro.TraerTodos().DefaultView;
                dgvLibros.DataSource = dvLibros;
                dgvLibros.Columns[0].Width = 60; //autor
                dgvLibros.Columns[1].Width = 60; //isbn
                dgvLibros.Columns[2].Width = 260; //nombre
                dgvLibros.Columns[3].Width = 50; //edicion
                dgvLibros.Columns[4].Width = 100; //genero
                dgvLibros.Columns[5].Width = 200; //editorial
                dgvLibros.Columns["Autores"].DisplayIndex = 0;
                txtfiltro.Focus();
                cboFiltro.Text = "Nombre";

            }

            if(tcLibros.SelectedTab == tcLibros.TabPages[1])
            {
                cboLibro.DataSource = objLogicaLibro.TraerParaModificar();
                cboLibro.DisplayMember = "Libro";
                cboLibro.ValueMember = "ISBN";
                this.cboLibro.SelectedIndexChanged += new System.EventHandler(this.cboLibro_SelectedIndexChanged);
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            dvLibros.RowFilter = cboFiltro.SelectedItem + " like'%" + txtfiltro.Text + "%'";
            dgvLibros.DataSource = dvLibros;
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // el usuario hizo click en una celda de alguna fila
            // debemos preguntar si es la columna 0
            if (e.ColumnIndex == 0)
            {
                // recupero el ISBN del libro
                string strISBN = dgvLibros.CurrentRow.Cells[1].Value.ToString();
                List<Entidades.Autor> ListaAutores = objLogicaLibro.TraerAutoresPorISBN(strISBN);

                StringBuilder autores = new StringBuilder();

                foreach (var autor in ListaAutores)
                {
                    autores.Append(autor.Apellido + ", " + autor.Nombre + "\n");

                }
                MessageBox.Show(autores.ToString(), "Lista de Autores");

            }
        }

        private void cboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strISBN = cboLibro.SelectedValue.ToString();
            objEntidadLibro = objLogicaLibro.TraerUno(strISBN);
            txtISBNModi.Text = objEntidadLibro.ISBN;
            txtTituloModi.Text = objEntidadLibro.Titulo;
            txtEdicionModi.Text = objEntidadLibro.Edicion.ToString();
            cboGeneroModi.Text = objEntidadLibro.Genero.Descripcion;
            cboEditorialModi.Text = objEntidadLibro.Editorial.Descripcion;
        }
    }
}
