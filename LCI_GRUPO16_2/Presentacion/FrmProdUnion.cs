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
    public partial class FrmProdUnion : Form
    {
        public FrmProdUnion()
        {
            InitializeComponent();
        }

        public int cant { get; set; }
        private void FrmProdUnion_Load(object sender, EventArgs e)
        {
            cant = 0;
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.Produstos_no_vendidos_Y_Vendidos' Puede moverla o quitarla según sea necesario.
            this.produstos_no_vendidos_Y_VendidosTableAdapter.Fill(this.dtsReportesxsd.Produstos_no_vendidos_Y_Vendidos,cant);

            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            cant = Convert.ToInt32(NumCantidad.Value);

            this.produstos_no_vendidos_Y_VendidosTableAdapter.Fill(this.dtsReportesxsd.Produstos_no_vendidos_Y_Vendidos, cant);

            this.reportViewer1.RefreshReport();
        }
    }
}
