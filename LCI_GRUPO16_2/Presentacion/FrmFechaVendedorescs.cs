using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCI_GRUPO16_2.Presentacion
{
    public partial class FrmFechaVendedorescs : Form
    {
        public FrmFechaVendedorescs()
        {
            InitializeComponent();
        }
        public int Cod { get; set; }

        private void FrmFechaVendedorescs_Load(object sender, EventArgs e)
        {
            Cod = 1;
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.FechaVendedores' Puede moverla o quitarla según sea necesario.
            this.fechaVendedoresTableAdapter.Fill(this.dtsReportesxsd.FechaVendedores,Cod);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cod =  Convert.ToInt32( txtCodigo.Text);
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.FechaVendedores' Puede moverla o quitarla según sea necesario.
            this.fechaVendedoresTableAdapter.Fill(this.dtsReportesxsd.FechaVendedores, Cod);

            this.reportViewer1.RefreshReport();
        }
    }
}
