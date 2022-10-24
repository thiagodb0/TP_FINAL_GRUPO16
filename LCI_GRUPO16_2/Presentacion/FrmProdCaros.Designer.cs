namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmProdCaros
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
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.productosSuperiorPromedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosSuperiorPromedioTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.ProductosSuperiorPromedioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSuperiorPromedioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.productosSuperiorPromedioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptProdPromedio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosSuperiorPromedioBindingSource
            // 
            this.productosSuperiorPromedioBindingSource.DataMember = "ProductosSuperiorPromedio";
            this.productosSuperiorPromedioBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // productosSuperiorPromedioTableAdapter
            // 
            this.productosSuperiorPromedioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProdCaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmProdCaros";
            this.Text = "FrmProdCaros";
            this.Load += new System.EventHandler(this.FrmProdCaros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSuperiorPromedioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private System.Windows.Forms.BindingSource productosSuperiorPromedioBindingSource;
        private Datos.DtsReportesxsdTableAdapters.ProductosSuperiorPromedioTableAdapter productosSuperiorPromedioTableAdapter;
    }
}