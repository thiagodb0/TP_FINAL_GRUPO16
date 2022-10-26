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
    public partial class FrmProdCaros : Form
    {
        public FrmProdCaros()
        {
            InitializeComponent();
        }

        private void FrmProdCaros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.ProductosSuperiorPromedio' Puede moverla o quitarla según sea necesario.
            this.productosSuperiorPromedioTableAdapter.Fill(this.dtsReportesxsd.ProductosSuperiorPromedio);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
