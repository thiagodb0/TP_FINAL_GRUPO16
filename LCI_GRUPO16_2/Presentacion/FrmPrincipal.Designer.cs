namespace LCI_GRUPO16_2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientePorCantidadDeVecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeraYUltimaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalFacturadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuncaSeVendieronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuncaSeVendieronYMasDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosCarosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientePorCantidadDeVecesToolStripMenuItem,
            this.promedioPorNombreToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // clientePorCantidadDeVecesToolStripMenuItem
            // 
            this.clientePorCantidadDeVecesToolStripMenuItem.Name = "clientePorCantidadDeVecesToolStripMenuItem";
            this.clientePorCantidadDeVecesToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.clientePorCantidadDeVecesToolStripMenuItem.Text = "Cantidad de compras";
            this.clientePorCantidadDeVecesToolStripMenuItem.Click += new System.EventHandler(this.clientePorCantidadDeVecesToolStripMenuItem_Click);
            // 
            // promedioPorNombreToolStripMenuItem
            // 
            this.promedioPorNombreToolStripMenuItem.Name = "promedioPorNombreToolStripMenuItem";
            this.promedioPorNombreToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.promedioPorNombreToolStripMenuItem.Text = "Promedio por nombre";
            this.promedioPorNombreToolStripMenuItem.Click += new System.EventHandler(this.promedioPorNombreToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeraYUltimaVentaToolStripMenuItem,
            this.totalFacturadoToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // primeraYUltimaVentaToolStripMenuItem
            // 
            this.primeraYUltimaVentaToolStripMenuItem.Name = "primeraYUltimaVentaToolStripMenuItem";
            this.primeraYUltimaVentaToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.primeraYUltimaVentaToolStripMenuItem.Text = "Primera y ultima venta";
            this.primeraYUltimaVentaToolStripMenuItem.Click += new System.EventHandler(this.primeraYUltimaVentaToolStripMenuItem_Click);
            // 
            // totalFacturadoToolStripMenuItem
            // 
            this.totalFacturadoToolStripMenuItem.Name = "totalFacturadoToolStripMenuItem";
            this.totalFacturadoToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.totalFacturadoToolStripMenuItem.Text = "Total facturado";
            this.totalFacturadoToolStripMenuItem.Click += new System.EventHandler(this.totalFacturadoToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automovilesToolStripMenuItem,
            this.repuestosToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // automovilesToolStripMenuItem
            // 
            this.automovilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuncaSeVendieronToolStripMenuItem});
            this.automovilesToolStripMenuItem.Name = "automovilesToolStripMenuItem";
            this.automovilesToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.automovilesToolStripMenuItem.Text = "Automoviles";
            // 
            // nuncaSeVendieronToolStripMenuItem
            // 
            this.nuncaSeVendieronToolStripMenuItem.Name = "nuncaSeVendieronToolStripMenuItem";
            this.nuncaSeVendieronToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.nuncaSeVendieronToolStripMenuItem.Text = "Nunca se vendieron";
            this.nuncaSeVendieronToolStripMenuItem.Click += new System.EventHandler(this.nuncaSeVendieronToolStripMenuItem_Click);
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuncaSeVendieronYMasDeToolStripMenuItem,
            this.productosCarosToolStripMenuItem});
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.todosToolStripMenuItem.Text = "Todos";
            // 
            // nuncaSeVendieronYMasDeToolStripMenuItem
            // 
            this.nuncaSeVendieronYMasDeToolStripMenuItem.Name = "nuncaSeVendieronYMasDeToolStripMenuItem";
            this.nuncaSeVendieronYMasDeToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.nuncaSeVendieronYMasDeToolStripMenuItem.Text = "Nunca se vendieron y mas de";
            this.nuncaSeVendieronYMasDeToolStripMenuItem.Click += new System.EventHandler(this.nuncaSeVendieronYMasDeToolStripMenuItem_Click);
            // 
            // productosCarosToolStripMenuItem
            // 
            this.productosCarosToolStripMenuItem.Name = "productosCarosToolStripMenuItem";
            this.productosCarosToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.productosCarosToolStripMenuItem.Text = "Productos Caros";
            this.productosCarosToolStripMenuItem.Click += new System.EventHandler(this.productosCarosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porMesToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // porMesToolStripMenuItem
            // 
            this.porMesToolStripMenuItem.Name = "porMesToolStripMenuItem";
            this.porMesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.porMesToolStripMenuItem.Text = "Por mes ";
            this.porMesToolStripMenuItem.Click += new System.EventHandler(this.porMesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LCI_GRUPO16_2.Properties.Resources.C;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientePorCantidadDeVecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeraYUltimaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalFacturadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automovilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuncaSeVendieronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuncaSeVendieronYMasDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosCarosToolStripMenuItem;
    }
}

