namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmProdUnion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.produstosnovendidosYVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produstos_no_vendidos_Y_VendidosTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.Produstos_no_vendidos_Y_VendidosTableAdapter();
            this.Produstos_no_vendidos_Y_VendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produstosnovendidosYVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produstos_no_vendidos_Y_VendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se mostraran primero aquellos que nunca se vendieron y luego aquellos \r\nque se ve" +
    "ndieron mas de la cantidad de veces especificada\r\n";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Produstos_no_vendidos_Y_VendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptProdUnion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 333);
            this.reportViewer1.TabIndex = 1;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produstosnovendidosYVendidosBindingSource
            // 
            this.produstosnovendidosYVendidosBindingSource.DataMember = "Produstos_no_vendidos_Y_Vendidos";
            this.produstosnovendidosYVendidosBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // produstos_no_vendidos_Y_VendidosTableAdapter
            // 
            this.produstos_no_vendidos_Y_VendidosTableAdapter.ClearBeforeFill = true;
            // 
            // Produstos_no_vendidos_Y_VendidosBindingSource
            // 
            this.Produstos_no_vendidos_Y_VendidosBindingSource.DataMember = "Produstos_no_vendidos_Y_Vendidos";
            this.Produstos_no_vendidos_Y_VendidosBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de veces";
            // 
            // NumCantidad
            // 
            this.NumCantidad.Location = new System.Drawing.Point(157, 77);
            this.NumCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(120, 22);
            this.NumCantidad.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(317, 70);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 32);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmProdUnion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProdUnion";
            this.Text = "FrmProdUnion";
            this.Load += new System.EventHandler(this.FrmProdUnion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produstosnovendidosYVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Produstos_no_vendidos_Y_VendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Produstos_no_vendidos_Y_VendidosBindingSource;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private System.Windows.Forms.BindingSource produstosnovendidosYVendidosBindingSource;
        private Datos.DtsReportesxsdTableAdapters.Produstos_no_vendidos_Y_VendidosTableAdapter produstos_no_vendidos_Y_VendidosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Button BtnBuscar;
    }
}