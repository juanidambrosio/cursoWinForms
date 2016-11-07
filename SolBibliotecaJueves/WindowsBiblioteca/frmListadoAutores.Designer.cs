namespace WindowsBiblioteca
{
    partial class frmListadoAutores
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
            this.dsAutores = new WindowsBiblioteca.dsAutores();
            this.vista_autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_autoresTableAdapter = new WindowsBiblioteca.dsAutoresTableAdapters.vista_autoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_autoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_autoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsBiblioteca.ReporteAutores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(576, 315);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsAutores
            // 
            this.dsAutores.DataSetName = "dsAutores";
            this.dsAutores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_autoresBindingSource
            // 
            this.vista_autoresBindingSource.DataMember = "vista_autores";
            this.vista_autoresBindingSource.DataSource = this.dsAutores;
            // 
            // vista_autoresTableAdapter
            // 
            this.vista_autoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 326);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoAutores";
            this.Text = "frmListadoAutores";
            this.Load += new System.EventHandler(this.frmListadoAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_autoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vista_autoresBindingSource;
        private dsAutores dsAutores;
        private dsAutoresTableAdapters.vista_autoresTableAdapter vista_autoresTableAdapter;
    }
}