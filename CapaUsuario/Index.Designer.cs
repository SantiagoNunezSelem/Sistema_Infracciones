using MaterialSkin.Controls;

namespace Sistema_Infracciones
{
    partial class Index
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
            this.infraccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoInfraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTipoInfraccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTipoInfraccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTipoInfraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTipoInfracciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infraccionesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infraccionesToolStripMenuItem
            // 
            this.infraccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTipoInfraccionToolStripMenuItem,
            this.verTipoInfraccionesToolStripMenuItem,
            this.borrarTipoInfraccionesToolStripMenuItem,
            this.nuevoTipoInfraccionToolStripMenuItem,
            this.borrarTipoInfracciónToolStripMenuItem});
            this.infraccionesToolStripMenuItem.Name = "infraccionesToolStripMenuItem";
            this.infraccionesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.infraccionesToolStripMenuItem.Text = "Infracciones";
            // 
            // agregarTipoInfraccionToolStripMenuItem
            // 
            this.agregarTipoInfraccionToolStripMenuItem.Name = "agregarTipoInfraccionToolStripMenuItem";
            this.agregarTipoInfraccionToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.agregarTipoInfraccionToolStripMenuItem.Text = "Agregar Infracción de Vehiculo";
            this.agregarTipoInfraccionToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoInfraccionToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVehiculoToolStripMenuItem,
            this.verVehiculoToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // verTipoInfraccionesToolStripMenuItem
            // 
            this.verTipoInfraccionesToolStripMenuItem.Name = "verTipoInfraccionesToolStripMenuItem";
            this.verTipoInfraccionesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.verTipoInfraccionesToolStripMenuItem.Text = "Editar Infracción de Vehiculo";
            // 
            // borrarTipoInfraccionesToolStripMenuItem
            // 
            this.borrarTipoInfraccionesToolStripMenuItem.Name = "borrarTipoInfraccionesToolStripMenuItem";
            this.borrarTipoInfraccionesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.borrarTipoInfraccionesToolStripMenuItem.Text = "Borrar Infracción de Vehiculo";
            // 
            // registrarVehiculoToolStripMenuItem
            // 
            this.registrarVehiculoToolStripMenuItem.Name = "registrarVehiculoToolStripMenuItem";
            this.registrarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarVehiculoToolStripMenuItem.Text = "Registrar Vehiculo";
            // 
            // verVehiculoToolStripMenuItem
            // 
            this.verVehiculoToolStripMenuItem.Name = "verVehiculoToolStripMenuItem";
            this.verVehiculoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verVehiculoToolStripMenuItem.Text = "Informacion Vehiculo";
            // 
            // informacionPagosToolStripMenuItem
            // 
            this.informacionPagosToolStripMenuItem.Name = "informacionPagosToolStripMenuItem";
            this.informacionPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionPagosToolStripMenuItem.Text = "Informacion Pagos";
            // 
            // nuevoTipoInfraccionToolStripMenuItem
            // 
            this.nuevoTipoInfraccionToolStripMenuItem.Name = "nuevoTipoInfraccionToolStripMenuItem";
            this.nuevoTipoInfraccionToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.nuevoTipoInfraccionToolStripMenuItem.Text = "Agregar Nuevo Tipo de Infracción";
            // 
            // borrarTipoInfracciónToolStripMenuItem
            // 
            this.borrarTipoInfracciónToolStripMenuItem.Name = "borrarTipoInfracciónToolStripMenuItem";
            this.borrarTipoInfracciónToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.borrarTipoInfracciónToolStripMenuItem.Text = "Borrar Tipo Infracción";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 623);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Sistema Infracciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infraccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoInfraccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTipoInfraccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTipoInfraccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTipoInfraccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTipoInfracciónToolStripMenuItem;
    }
}

