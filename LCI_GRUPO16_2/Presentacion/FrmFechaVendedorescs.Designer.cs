namespace LCI_GRUPO16_2.Presentacion
{
    partial class FrmFechaVendedorescs
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
            this.fechaVendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReportesxsd = new LCI_GRUPO16_2.Datos.DtsReportesxsd();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fechaVendedoresTableAdapter = new LCI_GRUPO16_2.Datos.DtsReportesxsdTableAdapters.FechaVendedoresTableAdapter();
            this.fechaVendedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVendedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaVendedoresBindingSource
            // 
            this.fechaVendedoresBindingSource.DataMember = "FechaVendedores";
            this.fechaVendedoresBindingSource.DataSource = this.dtsReportesxsd;
            // 
            // dtsReportesxsd
            // 
            this.dtsReportesxsd.DataSetName = "DtsReportesxsd";
            this.dtsReportesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "indique el legajo del vendedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(177, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fechaVendedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LCI_GRUPO16_2.Reportes.RptFechaVendedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(817, 341);
            this.reportViewer1.TabIndex = 3;
            // 
            // fechaVendedoresTableAdapter
            // 
            this.fechaVendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // fechaVendedoresBindingSource1
            // 
            this.fechaVendedoresBindingSource1.DataMember = "FechaVendedores";
            this.fechaVendedoresBindingSource1.DataSource = this.dtsReportesxsd;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCI_GRUPO16_2.Properties.Resources.Logo_Corporativo_Estudio_Elegante_Profesional_Blanco_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(581, -140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFechaVendedorescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmFechaVendedorescs";
            this.Text = "Primera y ultima venta";
            this.Load += new System.EventHandler(this.FrmFechaVendedorescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fechaVendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVendedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fechaVendedoresBindingSource;
        private Datos.DtsReportesxsd dtsReportesxsd;
        private Datos.DtsReportesxsdTableAdapters.FechaVendedoresTableAdapter fechaVendedoresTableAdapter;
        private System.Windows.Forms.BindingSource fechaVendedoresBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}