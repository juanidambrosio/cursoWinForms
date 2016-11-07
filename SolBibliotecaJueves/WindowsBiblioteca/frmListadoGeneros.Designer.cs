namespace WindowsBiblioteca
{
    partial class frmListadoGeneros
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
            this.dsGeneros = new WindowsBiblioteca.dsGeneros();
            this.GenerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenerosTableAdapter = new WindowsBiblioteca.dsGenerosTableAdapters.GenerosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GenerosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsBiblioteca.ReporteGeneros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(492, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsGeneros
            // 
            this.dsGeneros.DataSetName = "dsGeneros";
            this.dsGeneros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GenerosBindingSource
            // 
            this.GenerosBindingSource.DataMember = "Generos";
            this.GenerosBindingSource.DataSource = this.dsGeneros;
            // 
            // GenerosTableAdapter
            // 
            this.GenerosTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 273);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoGeneros";
            this.Text = "frmListadoGeneros";
            this.Load += new System.EventHandler(this.frmListadoGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GenerosBindingSource;
        private dsGeneros dsGeneros;
        private dsGenerosTableAdapters.GenerosTableAdapter GenerosTableAdapter;
    }
}