namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmFactxMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactxMes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.promedioMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAnio1 = new System.Windows.Forms.TextBox();
            this.TxtAnio2 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.promedioMesTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.PromedioMesTableAdapter();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.promedioMesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.promedioMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioMesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // promedioMesBindingSource
            // 
            this.promedioMesBindingSource.DataMember = "PromedioMes";
            this.promedioMesBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            // 
            // TxtAnio1
            // 
            resources.ApplyResources(this.TxtAnio1, "TxtAnio1");
            this.TxtAnio1.Name = "TxtAnio1";
            // 
            // TxtAnio2
            // 
            resources.ApplyResources(this.TxtAnio2, "TxtAnio2");
            this.TxtAnio2.Name = "TxtAnio2";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.promedioMesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptPromedioMes.rdlc";
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // promedioMesTableAdapter
            // 
            this.promedioMesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnBuscar
            // 
            resources.ApplyResources(this.BtnBuscar, "BtnBuscar");
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // promedioMesBindingSource1
            // 
            this.promedioMesBindingSource1.DataMember = "PromedioMes";
            this.promedioMesBindingSource1.DataSource = this.dtsReportesxsd;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCI_GRUPO16_2.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmFactxMes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.TxtAnio2);
            this.Controls.Add(this.TxtAnio1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFactxMes";
            this.Load += new System.EventHandler(this.FrmFactxMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promedioMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioMesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAnio1;
        private System.Windows.Forms.TextBox TxtAnio2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource promedioMesBindingSource;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private Datos.DtsReportesxsdTableAdapters.PromedioMesTableAdapter promedioMesTableAdapter;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.BindingSource promedioMesBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}