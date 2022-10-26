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
    public partial class FrmFactxMes : Form
    {
        public FrmFactxMes()
        {
            InitializeComponent();
        }

        public int anio1 { get; set; }
        public int anio2 { get; set; }
        private void FrmFactxMes_Load(object sender, EventArgs e)
        {
            anio1 = 2000;
            anio2 = 2030;
            // TODO: esta línea de código carga datos en la tabla 'dtsReportesxsd.PromedioMes' Puede moverla o quitarla según sea necesario.
            this.promedioMesTableAdapter.Fill(this.dtsReportesxsd.PromedioMes,anio1,anio2);

            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            anio1 = Convert.ToInt32(TxtAnio1.Text);
            anio2 = Convert.ToInt32(TxtAnio2.Text);
            this.promedioMesTableAdapter.Fill(this.dtsReportesxsd.PromedioMes, anio1, anio2);

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
