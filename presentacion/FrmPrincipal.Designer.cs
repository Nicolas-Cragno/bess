namespace presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChoferes = new System.Windows.Forms.ToolStripMenuItem();
            this.mecanicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOtros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTallerCamiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReparacionesCamiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRepuestosCamiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTallerCamionesFurgones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReparacionesFurgones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRepuestosFurgones = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AllowMerge = false;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMovimientos,
            this.tsmEventos,
            this.tsmTaller,
            this.tsmViajes,
            this.tsmRecursos});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPrincipal.ShowItemToolTips = true;
            this.menuPrincipal.Size = new System.Drawing.Size(160, 450);
            this.menuPrincipal.TabIndex = 8;
            this.menuPrincipal.Text = "Menu";
            // 
            // tsmMovimientos
            // 
            this.tsmMovimientos.Name = "tsmMovimientos";
            this.tsmMovimientos.Size = new System.Drawing.Size(154, 28);
            this.tsmMovimientos.Text = "Movimientos";
            this.tsmMovimientos.Click += new System.EventHandler(this.tsmMovimientos_Click);
            // 
            // tsmEventos
            // 
            this.tsmEventos.Name = "tsmEventos";
            this.tsmEventos.Size = new System.Drawing.Size(106, 28);
            this.tsmEventos.Text = "Eventos";
            this.tsmEventos.Click += new System.EventHandler(this.tsmEventos_Click);
            // 
            // tsmTaller
            // 
            this.tsmTaller.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTallerCamiones,
            this.tsmTallerCamionesFurgones});
            this.tsmTaller.Name = "tsmTaller";
            this.tsmTaller.Size = new System.Drawing.Size(94, 28);
            this.tsmTaller.Text = "Taller";
            // 
            // tsmViajes
            // 
            this.tsmViajes.Name = "tsmViajes";
            this.tsmViajes.Size = new System.Drawing.Size(94, 28);
            this.tsmViajes.Text = "Viajes";
            this.tsmViajes.Click += new System.EventHandler(this.tsmViajes_Click);
            // 
            // tsmRecursos
            // 
            this.tsmRecursos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChoferes,
            this.mecanicosToolStripMenuItem,
            this.tsmVehiculos,
            this.tsmOtros,
            this.tsmEmpresas,
            this.tsmClientes});
            this.tsmRecursos.Name = "tsmRecursos";
            this.tsmRecursos.Size = new System.Drawing.Size(118, 28);
            this.tsmRecursos.Text = "Recursos";
            // 
            // tsmChoferes
            // 
            this.tsmChoferes.Name = "tsmChoferes";
            this.tsmChoferes.Size = new System.Drawing.Size(260, 28);
            this.tsmChoferes.Text = "Choferes";
            this.tsmChoferes.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // mecanicosToolStripMenuItem
            // 
            this.mecanicosToolStripMenuItem.Name = "mecanicosToolStripMenuItem";
            this.mecanicosToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.mecanicosToolStripMenuItem.Text = "Mecanicos";
            this.mecanicosToolStripMenuItem.Click += new System.EventHandler(this.mecanicosToolStripMenuItem_Click);
            // 
            // tsmVehiculos
            // 
            this.tsmVehiculos.Name = "tsmVehiculos";
            this.tsmVehiculos.Size = new System.Drawing.Size(260, 28);
            this.tsmVehiculos.Text = "Vehiculos";
            this.tsmVehiculos.Click += new System.EventHandler(this.tsmVehiculos_Click);
            // 
            // tsmOtros
            // 
            this.tsmOtros.Name = "tsmOtros";
            this.tsmOtros.Size = new System.Drawing.Size(260, 28);
            this.tsmOtros.Text = "Otros vehiculos";
            this.tsmOtros.Click += new System.EventHandler(this.otrosVehiculosToolStripMenuItem_Click);
            // 
            // tsmEmpresas
            // 
            this.tsmEmpresas.Name = "tsmEmpresas";
            this.tsmEmpresas.Size = new System.Drawing.Size(260, 28);
            this.tsmEmpresas.Text = "Empresas";
            this.tsmEmpresas.Click += new System.EventHandler(this.tsmEmpresas_Click);
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(260, 28);
            this.tsmClientes.Text = "Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // tsmTallerCamiones
            // 
            this.tsmTallerCamiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReparacionesCamiones,
            this.tsmRepuestosCamiones});
            this.tsmTallerCamiones.Name = "tsmTallerCamiones";
            this.tsmTallerCamiones.Size = new System.Drawing.Size(180, 28);
            this.tsmTallerCamiones.Text = "Camiones";
            // 
            // tsmReparacionesCamiones
            // 
            this.tsmReparacionesCamiones.Name = "tsmReparacionesCamiones";
            this.tsmReparacionesCamiones.Size = new System.Drawing.Size(224, 28);
            this.tsmReparacionesCamiones.Text = "Reparaciones";
            this.tsmReparacionesCamiones.Click += new System.EventHandler(this.tsmReparacionesCamiones_Click);
            // 
            // tsmRepuestosCamiones
            // 
            this.tsmRepuestosCamiones.Name = "tsmRepuestosCamiones";
            this.tsmRepuestosCamiones.Size = new System.Drawing.Size(224, 28);
            this.tsmRepuestosCamiones.Text = "Repuestos";
            this.tsmRepuestosCamiones.Click += new System.EventHandler(this.tsmRepuestosCamiones_Click);
            // 
            // tsmTallerCamionesFurgones
            // 
            this.tsmTallerCamionesFurgones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReparacionesFurgones,
            this.tsmRepuestosFurgones});
            this.tsmTallerCamionesFurgones.Name = "tsmTallerCamionesFurgones";
            this.tsmTallerCamionesFurgones.Size = new System.Drawing.Size(180, 28);
            this.tsmTallerCamionesFurgones.Text = "Furgones";
            // 
            // tsmReparacionesFurgones
            // 
            this.tsmReparacionesFurgones.Name = "tsmReparacionesFurgones";
            this.tsmReparacionesFurgones.Size = new System.Drawing.Size(224, 28);
            this.tsmReparacionesFurgones.Text = "Reparaciones";
            this.tsmReparacionesFurgones.Click += new System.EventHandler(this.tsmReparacionesFurgones_Click);
            // 
            // tsmRepuestosFurgones
            // 
            this.tsmRepuestosFurgones.Name = "tsmRepuestosFurgones";
            this.tsmRepuestosFurgones.Size = new System.Drawing.Size(224, 28);
            this.tsmRepuestosFurgones.Text = "Repuestos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmMovimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmEventos;
        private System.Windows.Forms.ToolStripMenuItem tsmViajes;
        private System.Windows.Forms.ToolStripMenuItem tsmRecursos;
        private System.Windows.Forms.ToolStripMenuItem tsmChoferes;
        private System.Windows.Forms.ToolStripMenuItem tsmVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmOtros;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpresas;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmTaller;
        private System.Windows.Forms.ToolStripMenuItem mecanicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTallerCamiones;
        private System.Windows.Forms.ToolStripMenuItem tsmReparacionesCamiones;
        private System.Windows.Forms.ToolStripMenuItem tsmRepuestosCamiones;
        private System.Windows.Forms.ToolStripMenuItem tsmTallerCamionesFurgones;
        private System.Windows.Forms.ToolStripMenuItem tsmReparacionesFurgones;
        private System.Windows.Forms.ToolStripMenuItem tsmRepuestosFurgones;
    }
}