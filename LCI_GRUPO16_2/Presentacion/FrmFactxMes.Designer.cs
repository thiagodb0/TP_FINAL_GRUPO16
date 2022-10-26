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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese entre los dos años que desea buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(207, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "y";
            // 
            // TxtAnio1
            // 
            this.TxtAnio1.Location = new System.Drawing.Point(83, 44);
            this.TxtAnio1.Name = "TxtAnio1";
            this.TxtAnio1.Size = new System.Drawing.Size(100, 22);
            this.TxtAnio1.TabIndex = 3;
            // 
            // TxtAnio2
            // 
            this.TxtAnio2.Location = new System.Drawing.Point(248, 47);
            this.TxtAnio2.Name = "TxtAnio2";
            this.TxtAnio2.Size = new System.Drawing.Size(100, 22);
            this.TxtAnio2.TabIndex = 4;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.promedioMesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptPromedioMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(817, 335);
            this.reportViewer1.TabIndex = 5;
            // 
            // promedioMesTableAdapter
            // 
            this.promedioMesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(400, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(159, 42);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
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
            this.pictureBox1.Location = new System.Drawing.Point(565, -147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFactxMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.TxtAnio2);
            this.Controls.Add(this.TxtAnio1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmFactxMes";
            this.Text = "FrmFactxMes";
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