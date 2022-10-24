using LCI_GRUPO16_2.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCI_GRUPO16_2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            
        }

        private void clientePorCantidadDeVecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteCantidad frm = new FrmClienteCantidad();
            frm.ShowDialog();
        }

        private void promedioPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesLetra frm = new FrmClientesLetra();
            frm.ShowDialog();
        }

        private void nuncaSeVendieronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutosNoVend frm = new FrmAutosNoVend();
            frm.ShowDialog();
        }

        private void nuncaSeVendieronYMasDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdUnion frm = new FrmProdUnion();
            frm.ShowDialog();
        }

        private void productosCarosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdCaros frm = new FrmProdCaros();
            frm.ShowDialog();
        }

        private void primeraYUltimaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFechaVendedorescs frm = new FrmFechaVendedorescs();
            frm.ShowDialog();
        }

        private void totalFacturadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactVendedor frm = new FrmFactVendedor();
            frm.ShowDialog();
        }

        private void porMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactxMes frm = new FrmFactxMes();
            frm.ShowDialog();
        }
    }
}
