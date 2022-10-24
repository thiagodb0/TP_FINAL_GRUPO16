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
    public partial class FrmFactVendedor : Form
    {
        public FrmFactVendedor()
        {
            InitializeComponent();
        }

        
        private void FrmFactVendedor_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.FacturadoXVendedor' Puede moverla o quitarla según sea necesario.
            this.facturadoXVendedorTableAdapter.Fill(this.dtsReportesxsd.FacturadoXVendedor);

            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
