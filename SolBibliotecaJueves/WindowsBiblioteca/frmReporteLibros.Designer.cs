namespace WindowsBiblioteca
{
    partial class frmReporteLibros
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsLibros = new WindowsBiblioteca.dsLibros();
            this.vista_librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_librosTableAdapter = new WindowsBiblioteca.dsLibrosTableAdapters.vista_librosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_librosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsBiblioteca.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(651, 331);
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
            // frmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteLibros";
            this.Text = "frmReporteLibros";
            this.Load += new System.EventHandler(this.frmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_librosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vista_librosBindingSource;
        private dsLibros dsLibros;
        private dsLibrosTableAdapters.vista_librosTableAdapter vista_librosTableAdapter;
    }
}