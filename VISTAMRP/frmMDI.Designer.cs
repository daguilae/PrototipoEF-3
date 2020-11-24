namespace VISTAMRP
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilYAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRecetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.toolsMenu,
            this.reportesToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1315, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(166, 25);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoRecetaToolStripMenuItem,
            this.detalleRecetaToolStripMenuItem});
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recetaToolStripMenuItem.Text = "Receta";
            // 
            // mantenimientoRecetaToolStripMenuItem
            // 
            this.mantenimientoRecetaToolStripMenuItem.Name = "mantenimientoRecetaToolStripMenuItem";
            this.mantenimientoRecetaToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.mantenimientoRecetaToolStripMenuItem.Text = "3306 - Mantenimiento Receta";
            this.mantenimientoRecetaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoRecetaToolStripMenuItem_Click);
            // 
            // detalleRecetaToolStripMenuItem
            // 
            this.detalleRecetaToolStripMenuItem.Name = "detalleRecetaToolStripMenuItem";
            this.detalleRecetaToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.detalleRecetaToolStripMenuItem.Text = "3307 - Detalle Receta";
            this.detalleRecetaToolStripMenuItem.Click += new System.EventHandler(this.detalleRecetaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionDePedidosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // recepcionDePedidosToolStripMenuItem
            // 
            this.recepcionDePedidosToolStripMenuItem.Name = "recepcionDePedidosToolStripMenuItem";
            this.recepcionDePedidosToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.recepcionDePedidosToolStripMenuItem.Text = "3308 - Recepcion De Pedidos";
            this.recepcionDePedidosToolStripMenuItem.Click += new System.EventHandler(this.recepcionDePedidosToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(143, 25);
            this.toolsMenu.Text = "&Herramientas";
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem,
            this.mantenimientoUsuarioToolStripMenuItem,
            this.mantenimientoAplicacionesToolStripMenuItem,
            this.asignacionDePerfilYAplicacionesToolStripMenuItem,
            this.mantenimientoModuloToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.cambioDeContraseñaToolStripMenuItem.Text = "0011-Cambio De Contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "0002-Mantenimiento Usuario";
            this.mantenimientoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // mantenimientoAplicacionesToolStripMenuItem
            // 
            this.mantenimientoAplicacionesToolStripMenuItem.Name = "mantenimientoAplicacionesToolStripMenuItem";
            this.mantenimientoAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.mantenimientoAplicacionesToolStripMenuItem.Text = "0003-Mantenimiento Aplicaciones";
            this.mantenimientoAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.aplicacionesToolStripMenuItem_Click);
            // 
            // asignacionDePerfilYAplicacionesToolStripMenuItem
            // 
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Name = "asignacionDePerfilYAplicacionesToolStripMenuItem";
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Text = "0006-Asignacion de Perfil y Aplicaciones";
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDePerfílYAplicacionesToolStripMenuItem_Click);
            // 
            // mantenimientoModuloToolStripMenuItem
            // 
            this.mantenimientoModuloToolStripMenuItem.Name = "mantenimientoModuloToolStripMenuItem";
            this.mantenimientoModuloToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.mantenimientoModuloToolStripMenuItem.Text = "0008-Mantenimiento Modulo";
            this.mantenimientoModuloToolStripMenuItem.Click += new System.EventHandler(this.móduloToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPerfilToolStripMenuItem,
            this.asignacionDeAplicacionAPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // mantenimientoPerfilToolStripMenuItem
            // 
            this.mantenimientoPerfilToolStripMenuItem.Name = "mantenimientoPerfilToolStripMenuItem";
            this.mantenimientoPerfilToolStripMenuItem.Size = new System.Drawing.Size(436, 26);
            this.mantenimientoPerfilToolStripMenuItem.Text = "0004-Mantenimiento Perfil";
            this.mantenimientoPerfilToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPerfílToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionAPerfilToolStripMenuItem
            // 
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Name = "asignacionDeAplicacionAPerfilToolStripMenuItem";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Size = new System.Drawing.Size(436, 26);
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Text = "0005-Asignacion de Aplicacion a Perfil";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeAplicaciónAPerfílToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoRecetaToolStripMenuItem1,
            this.procesoPedidoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(81, 25);
            this.helpMenu.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(1189, 0);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(124, 31);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(457, 26);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // mantenimientoRecetaToolStripMenuItem1
            // 
            this.mantenimientoRecetaToolStripMenuItem1.Name = "mantenimientoRecetaToolStripMenuItem1";
            this.mantenimientoRecetaToolStripMenuItem1.Size = new System.Drawing.Size(296, 26);
            this.mantenimientoRecetaToolStripMenuItem1.Text = "Mantenimiento  Receta";
            this.mantenimientoRecetaToolStripMenuItem1.Click += new System.EventHandler(this.mantenimientoRecetaToolStripMenuItem1_Click);
            // 
            // procesoPedidoToolStripMenuItem
            // 
            this.procesoPedidoToolStripMenuItem.Name = "procesoPedidoToolStripMenuItem";
            this.procesoPedidoToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.procesoPedidoToolStripMenuItem.Text = "Proceso Recepcion";
            this.procesoPedidoToolStripMenuItem.Click += new System.EventHandler(this.procesoPedidoToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 582);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMDI";
            this.Text = "JULIO MORATAYA 0901-16-24166";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilYAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionAPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRecetaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesoPedidoToolStripMenuItem;
    }
}



