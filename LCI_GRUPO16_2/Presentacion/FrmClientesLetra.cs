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
    public partial class FrmClientesLetra : Form
    {
        public FrmClientesLetra()
        {
            InitializeComponent();
        }

        public string nombre { get; set; }
        private void FrmClientesLetra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.ClientesPromedio' Puede moverla o quitarla según sea necesario.
            nombre = String.Empty;
            this.clientesPromedioTableAdapter.Fill(this.dtsReportesxsd.ClientesPromedio,nombre);

            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            nombre = TxtCliente.Text;

            this.clientesPromedioTableAdapter.Fill(this.dtsReportesxsd.ClientesPromedio,nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
