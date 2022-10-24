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
    public partial class FrmClienteCantidad : Form
    {
        public FrmClienteCantidad()
        {
            InitializeComponent();
        }

        public int cantidad { get; set; }
        
        private void FrmClienteCantidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.clientesCantCompras' Puede moverla o quitarla según sea necesario.
            cantidad = -1;
            this.clientesCantComprasTableAdapter.Fill(this.dtsReportesxsd.clientesCantCompras,cantidad);

            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.cantidad = Convert.ToInt32(TxtCantidad.Text);
            this.clientesCantComprasTableAdapter.Fill(this.dtsReportesxsd.clientesCantCompras, cantidad);

            this.reportViewer1.RefreshReport();
        }
    }
}
