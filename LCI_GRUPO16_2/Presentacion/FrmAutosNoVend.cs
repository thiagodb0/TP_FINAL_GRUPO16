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
    public partial class FrmAutosNoVend : Form
    {
        public FrmAutosNoVend()
        {
            InitializeComponent();
        }

        private void FrmAutosNoVend_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.AutosSinVender' Puede moverla o quitarla según sea necesario.
            this.autosSinVenderTableAdapter.Fill(this.dtsReportesxsd.AutosSinVender);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
