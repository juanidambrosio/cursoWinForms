namespace WindowsBiblioteca
{
    partial class frmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tcLibros = new System.Windows.Forms.TabControl();
            this.tpNuevo = new System.Windows.Forms.TabPage();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.cboEditoriales = new System.Windows.Forms.ComboBox();
            this.tpModifica = new System.Windows.Forms.TabPage();
            this.tpBorrar = new System.Windows.Forms.TabPage();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.tpListado = new System.Windows.Forms.TabPage();
            this.tpNovedades = new System.Windows.Forms.TabPage();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.Autores = new System.Windows.Forms.DataGridViewLinkColumn();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsLibros = new WindowsBiblioteca.dsLibros();
            this.vista_librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_librosTableAdapter = new WindowsBiblioteca.dsLibrosTableAdapters.vista_librosTableAdapter();
            this.cboLibro = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISBNModi = new System.Windows.Forms.TextBox();
            this.txtTituloModi = new System.Windows.Forms.TextBox();
            this.txtEdicionModi = new System.Windows.Forms.TextBox();
            this.cboGeneroModi = new System.Windows.Forms.ComboBox();
            this.cboEditorialModi = new System.Windows.Forms.ComboBox();
            this.tcLibros.SuspendLayout();
            this.tpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpModifica.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_librosBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLibros
            // 
            this.tcLibros.Controls.Add(this.tpNuevo);
            this.tcLibros.Controls.Add(this.tpModifica);
            this.tcLibros.Controls.Add(this.tpBorrar);
            this.tcLibros.Controls.Add(this.tpConsulta);
            this.tcLibros.Controls.Add(this.tpListado);
            this.tcLibros.Controls.Add(this.tpNovedades);
            this.tcLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLibros.Location = new System.Drawing.Point(4, 12);
            this.tcLibros.Name = "tcLibros";
            this.tcLibros.SelectedIndex = 0;
            this.tcLibros.Size = new System.Drawing.Size(802, 599);
            this.tcLibros.TabIndex = 0;
            this.tcLibros.SelectedIndexChanged += new System.EventHandler(this.tcLibros_SelectedIndexChanged);
            // 
            // tpNuevo
            // 
            this.tpNuevo.Controls.Add(this.dgvAutores);
            this.tpNuevo.Controls.Add(this.btnConfirmar);
            this.tpNuevo.Controls.Add(this.tableLayoutPanel1);
            this.tpNuevo.Location = new System.Drawing.Point(4, 25);
            this.tpNuevo.Name = "tpNuevo";
            this.tpNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevo.Size = new System.Drawing.Size(794, 570);
            this.tpNuevo.TabIndex = 0;
            this.tpNuevo.Text = "NUEVO";
            this.tpNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Autor,
            this.Agregar});
            this.dgvAutores.Location = new System.Drawing.Point(19, 185);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.Size = new System.Drawing.Size(562, 332);
            this.dgvAutores.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(606, 427);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 69);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.01779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.70819F));
            this.tableLayoutPanel1.Controls.Add(this.lblISBN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtISBN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEdicion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboGeneros, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboEditoriales, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(138, 7);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(45, 16);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TITULO :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "EDICION :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "GENERO :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "EDITORIAL :";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(190, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(238, 22);
            this.txtISBN.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(190, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(238, 22);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(190, 64);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(100, 22);
            this.txtEdicion.TabIndex = 7;
            // 
            // cboGeneros
            // 
            this.cboGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(190, 94);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(238, 24);
            this.cboGeneros.TabIndex = 8;
            // 
            // cboEditoriales
            // 
            this.cboEditoriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditoriales.FormattingEnabled = true;
            this.cboEditoriales.Location = new System.Drawing.Point(190, 124);
            this.cboEditoriales.Name = "cboEditoriales";
            this.cboEditoriales.Size = new System.Drawing.Size(238, 24);
            this.cboEditoriales.TabIndex = 9;
            // 
            // tpModifica
            // 
            this.tpModifica.Controls.Add(this.tableLayoutPanel2);
            this.tpModifica.Controls.Add(this.lblSeleccion);
            this.tpModifica.Controls.Add(this.cboLibro);
            this.tpModifica.Location = new System.Drawing.Point(4, 25);
            this.tpModifica.Name = "tpModifica";
            this.tpModifica.Padding = new System.Windows.Forms.Padding(3);
            this.tpModifica.Size = new System.Drawing.Size(794, 570);
            this.tpModifica.TabIndex = 1;
            this.tpModifica.Text = "MODIFICACION";
            this.tpModifica.UseVisualStyleBackColor = true;
            // 
            // tpBorrar
            // 
            this.tpBorrar.Location = new System.Drawing.Point(4, 25);
            this.tpBorrar.Name = "tpBorrar";
            this.tpBorrar.Size = new System.Drawing.Size(744, 538);
            this.tpBorrar.TabIndex = 2;
            this.tpBorrar.Text = "BORRAR";
            this.tpBorrar.UseVisualStyleBackColor = true;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.cboFiltro);
            this.tpConsulta.Controls.Add(this.txtfiltro);
            this.tpConsulta.Controls.Add(this.dgvLibros);
            this.tpConsulta.Location = new System.Drawing.Point(4, 25);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Size = new System.Drawing.Size(744, 538);
            this.tpConsulta.TabIndex = 3;
            this.tpConsulta.Text = "CONSULTAR";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(169, 20);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(218, 22);
            this.txtfiltro.TabIndex = 1;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autores});
            this.dgvLibros.Location = new System.Drawing.Point(4, 48);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.Size = new System.Drawing.Size(737, 487);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // tpListado
            // 
            this.tpListado.Controls.Add(this.reportViewer1);
            this.tpListado.Location = new System.Drawing.Point(4, 25);
            this.tpListado.Name = "tpListado";
            this.tpListado.Size = new System.Drawing.Size(794, 570);
            this.tpListado.TabIndex = 4;
            this.tpListado.Text = "LISTAR";
            this.tpListado.UseVisualStyleBackColor = true;
            // 
            // tpNovedades
            // 
            this.tpNovedades.Location = new System.Drawing.Point(4, 25);
            this.tpNovedades.Name = "tpNovedades";
            this.tpNovedades.Size = new System.Drawing.Size(744, 538);
            this.tpNovedades.TabIndex = 5;
            this.tpNovedades.Text = "NOVEDADES";
            this.tpNovedades.UseVisualStyleBackColor = true;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "ISBN",
            "Nombre",
            "Genero",
            "Editorial"});
            this.cboFiltro.Location = new System.Drawing.Point(4, 20);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(159, 24);
            this.cboFiltro.TabIndex = 2;
            // 
            // Autores
            // 
            this.Autores.HeaderText = "Autor";
            this.Autores.Name = "Autores";
            this.Autores.Text = "Autor";
            this.Autores.UseColumnTextForLinkValue = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsLibros";
            reportDataSource1.Value = this.vista_librosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsBiblioteca.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsLibros
            // 
            this.dsLibros.DataSetName = "dsLibros";
            this.dsLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_librosBindingSource
            // 
            this.vista_librosBindingSource.DataMember = "vista_libros";
            this.vista_librosBindingSource.DataSource = this.dsLibros;
            // 
            // vista_librosTableAdapter
            // 
            this.vista_librosTableAdapter.ClearBeforeFill = true;
            // 
            // cboLibro
            // 
            this.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibro.FormattingEnabled = true;
            this.cboLibro.Location = new System.Drawing.Point(178, 32);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(561, 24);
            this.cboLibro.TabIndex = 0;
            
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSeleccion.Location = new System.Drawing.Point(6, 36);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(139, 20);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccionar Libro :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.01779F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.70819F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtISBNModi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTituloModi, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtEdicionModi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboGeneroModi, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboEditorialModi, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(729, 153);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "TITULO :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "EDICION :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "GENERO :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "EDITORIAL :";
            // 
            // txtISBNModi
            // 
            this.txtISBNModi.Location = new System.Drawing.Point(246, 4);
            this.txtISBNModi.Name = "txtISBNModi";
            this.txtISBNModi.Size = new System.Drawing.Size(292, 22);
            this.txtISBNModi.TabIndex = 0;
            // 
            // txtTituloModi
            // 
            this.txtTituloModi.Location = new System.Drawing.Point(246, 34);
            this.txtTituloModi.Name = "txtTituloModi";
            this.txtTituloModi.Size = new System.Drawing.Size(292, 22);
            this.txtTituloModi.TabIndex = 6;
            // 
            // txtEdicionModi
            // 
            this.txtEdicionModi.Location = new System.Drawing.Point(246, 64);
            this.txtEdicionModi.Name = "txtEdicionModi";
            this.txtEdicionModi.Size = new System.Drawing.Size(89, 22);
            this.txtEdicionModi.TabIndex = 7;
            // 
            // cboGeneroModi
            // 
            this.cboGeneroModi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneroModi.FormattingEnabled = true;
            this.cboGeneroModi.Location = new System.Drawing.Point(246, 94);
            this.cboGeneroModi.Name = "cboGeneroModi";
            this.cboGeneroModi.Size = new System.Drawing.Size(292, 24);
            this.cboGeneroModi.TabIndex = 8;
            // 
            // cboEditorialModi
            // 
            this.cboEditorialModi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditorialModi.FormattingEnabled = true;
            this.cboEditorialModi.Location = new System.Drawing.Point(246, 124);
            this.cboEditorialModi.Name = "cboEditorialModi";
            this.cboEditorialModi.Size = new System.Drawing.Size(292, 24);
            this.cboEditorialModi.TabIndex = 9;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 561);
            this.Controls.Add(this.tcLibros);
            this.Name = "frmLibros";
            this.Text = "ACTUALIZACION DE LIBROS";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.tcLibros.ResumeLayout(false);
            this.tpNuevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpModifica.ResumeLayout(false);
            this.tpModifica.PerformLayout();
            this.tpConsulta.ResumeLayout(false);
            this.tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_librosBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLibros;
        private System.Windows.Forms.TabPage tpNuevo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.ComboBox cboEditoriales;
        private System.Windows.Forms.TabPage tpModifica;
        private System.Windows.Forms.TabPage tpBorrar;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.TabPage tpListado;
        private System.Windows.Forms.TabPage tpNovedades;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.DataGridViewLinkColumn Autores;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vista_librosBindingSource;
        private dsLibros dsLibros;
        private dsLibrosTableAdapters.vista_librosTableAdapter vista_librosTableAdapter;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.ComboBox cboLibro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISBNModi;
        private System.Windows.Forms.TextBox txtTituloModi;
        private System.Windows.Forms.TextBox txtEdicionModi;
        private System.Windows.Forms.ComboBox cboGeneroModi;
        private System.Windows.Forms.ComboBox cboEditorialModi;
    }
}