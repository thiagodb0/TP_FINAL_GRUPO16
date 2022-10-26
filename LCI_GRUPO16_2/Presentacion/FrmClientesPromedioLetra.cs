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
    public partial class FrmClientesPromedioLetra : Form
    {
        public FrmClientesPromedioLetra()
        {
            InitializeComponent();
        }

        public string nombre { get; set; }
        private void FrmClientesPromedioLetra_Load(object sender, EventArgs e)
        {
            nombre = string.Empty;
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.ClientesPromedio' Puede moverla o quitarla según sea necesario.
            this.clientesPromedioTableAdapter.Fill(this.dtsReportesxsd.ClientesPromedio,nombre);

            this.reportViewer1.RefreshReport();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = TxtNombre.Text;
            this.clientesPromedioTableAdapter.Fill(this.dtsReportesxsd.ClientesPromedio, nombre);

            this.reportViewer1.RefreshReport();

        }
    }
}
