namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmFactVendedor
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
            this.facturadoXVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturadoXVendedorTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.FacturadoXVendedorTableAdapter();
            this.facturadoXVendedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.facturadoXVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturadoXVendedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // facturadoXVendedorBindingSource
            // 
            this.facturadoXVendedorBindingSource.DataMember = "FacturadoXVendedor";
            this.facturadoXVendedorBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturadoXVendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptFactXVend.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(862, 648);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // facturadoXVendedorTableAdapter
            // 
            this.facturadoXVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // facturadoXVendedorBindingSource1
            // 
            this.facturadoXVendedorBindingSource1.DataMember = "FacturadoXVendedor";
            this.facturadoXVendedorBindingSource1.DataSource = this.dtsReportesxsd;
            // 
            // FrmFactVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 648);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFactVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactVendedor";
            this.Load += new System.EventHandler(this.FrmFactVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturadoXVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturadoXVendedorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private System.Windows.Forms.BindingSource facturadoXVendedorBindingSource;
        private Datos.DtsReportesxsdTableAdapters.FacturadoXVendedorTableAdapter facturadoXVendedorTableAdapter;
        private System.Windows.Forms.BindingSource facturadoXVendedorBindingSource1;
    }
}