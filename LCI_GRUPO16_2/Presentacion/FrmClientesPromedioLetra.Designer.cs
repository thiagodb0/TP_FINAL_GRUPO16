namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmClientesPromedioLetra
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
            this.clientesPromedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.clientesPromedioTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.ClientesPromedioTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesPromedioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesPromedioBindingSource
            // 
            this.clientesPromedioBindingSource.DataMember = "ClientesPromedio";
            this.clientesPromedioBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientesPromedioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptClientesLetraProm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese las primeras letras del cliente que desea buscar";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(16, 48);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // clientesPromedioTableAdapter
            // 
            this.clientesPromedioTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCI_GRUPO16_2.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(472, -166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmClientesPromedioLetra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(876, 570);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmClientesPromedioLetra";
            this.Text = "FrmClientesPromedioLetra";
            this.Load += new System.EventHandler(this.FrmClientesPromedioLetra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesPromedioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.BindingSource clientesPromedioBindingSource;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private Datos.DtsReportesxsdTableAdapters.ClientesPromedioTableAdapter clientesPromedioTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}