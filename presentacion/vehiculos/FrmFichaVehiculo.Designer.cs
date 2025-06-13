namespace presentacion.vehiculos
{
    partial class FrmFichaVehiculo
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
            this.btnFichaVehiculoAlta = new System.Windows.Forms.Button();
            this.cbxFichaVehiculoEmpresa = new System.Windows.Forms.ComboBox();
            this.btnFichaVehiculoCerrar = new System.Windows.Forms.Button();
            this.btnFichaVehiculoNuevoEvento = new System.Windows.Forms.Button();
            this.tbxFichaVehiculoFiltro = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoFiltro = new System.Windows.Forms.Label();
            this.dgvFichaVehiculoEventos = new System.Windows.Forms.DataGridView();
            this.btnFichaVehiculoOK = new System.Windows.Forms.Button();
            this.tbxFichaVehiculoDetalle = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoDetalle = new System.Windows.Forms.Label();
            this.tbxFichaVehiculoModelo = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoModelo = new System.Windows.Forms.Label();
            this.tbxFichaVehiculoMarca = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoMarca = new System.Windows.Forms.Label();
            this.tbxFichaVehiculoDominio = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoDominio = new System.Windows.Forms.Label();
            this.lblFichaVehiculoEmpresa = new System.Windows.Forms.Label();
            this.lblFichaVehiculoTipo = new System.Windows.Forms.Label();
            this.lblFichaVehiculoTitulo = new System.Windows.Forms.Label();
            this.cbxFichaVehiculoTipo = new System.Windows.Forms.ComboBox();
            this.cbxFichaVehiculoDocumentacion = new System.Windows.Forms.CheckBox();
            this.cbxFichaVehiculoTaller = new System.Windows.Forms.CheckBox();
            this.tbxFichaVehiculoEstado = new System.Windows.Forms.TextBox();
            this.lblFichaVehiculoEstado = new System.Windows.Forms.Label();
            this.gbxFicahVehiculoEstado = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaVehiculoEventos)).BeginInit();
            this.gbxFicahVehiculoEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFichaVehiculoAlta
            // 
            this.btnFichaVehiculoAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFichaVehiculoAlta.Location = new System.Drawing.Point(263, 364);
            this.btnFichaVehiculoAlta.Name = "btnFichaVehiculoAlta";
            this.btnFichaVehiculoAlta.Size = new System.Drawing.Size(75, 23);
            this.btnFichaVehiculoAlta.TabIndex = 100;
            this.btnFichaVehiculoAlta.Text = "Dar de alta";
            this.btnFichaVehiculoAlta.UseVisualStyleBackColor = true;
            this.btnFichaVehiculoAlta.Click += new System.EventHandler(this.btnFichaVehiculoAlta_Click);
            // 
            // cbxFichaVehiculoEmpresa
            // 
            this.cbxFichaVehiculoEmpresa.FormattingEnabled = true;
            this.cbxFichaVehiculoEmpresa.Location = new System.Drawing.Point(122, 76);
            this.cbxFichaVehiculoEmpresa.Name = "cbxFichaVehiculoEmpresa";
            this.cbxFichaVehiculoEmpresa.Size = new System.Drawing.Size(216, 21);
            this.cbxFichaVehiculoEmpresa.TabIndex = 98;
            // 
            // btnFichaVehiculoCerrar
            // 
            this.btnFichaVehiculoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFichaVehiculoCerrar.Location = new System.Drawing.Point(709, 364);
            this.btnFichaVehiculoCerrar.Name = "btnFichaVehiculoCerrar";
            this.btnFichaVehiculoCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaVehiculoCerrar.TabIndex = 97;
            this.btnFichaVehiculoCerrar.Text = "Cerrar";
            this.btnFichaVehiculoCerrar.UseVisualStyleBackColor = true;
            this.btnFichaVehiculoCerrar.Click += new System.EventHandler(this.btnFichaVehiculoCerrar_Click);
            // 
            // btnFichaVehiculoNuevoEvento
            // 
            this.btnFichaVehiculoNuevoEvento.Location = new System.Drawing.Point(692, 58);
            this.btnFichaVehiculoNuevoEvento.Name = "btnFichaVehiculoNuevoEvento";
            this.btnFichaVehiculoNuevoEvento.Size = new System.Drawing.Size(92, 23);
            this.btnFichaVehiculoNuevoEvento.TabIndex = 96;
            this.btnFichaVehiculoNuevoEvento.Text = "Agregar Evento";
            this.btnFichaVehiculoNuevoEvento.UseVisualStyleBackColor = true;
            // 
            // tbxFichaVehiculoFiltro
            // 
            this.tbxFichaVehiculoFiltro.Location = new System.Drawing.Point(447, 60);
            this.tbxFichaVehiculoFiltro.Name = "tbxFichaVehiculoFiltro";
            this.tbxFichaVehiculoFiltro.Size = new System.Drawing.Size(217, 20);
            this.tbxFichaVehiculoFiltro.TabIndex = 95;
            this.tbxFichaVehiculoFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFichaVehiculoFiltro_KeyPress);
            // 
            // lblFichaVehiculoFiltro
            // 
            this.lblFichaVehiculoFiltro.AutoSize = true;
            this.lblFichaVehiculoFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaVehiculoFiltro.Location = new System.Drawing.Point(407, 64);
            this.lblFichaVehiculoFiltro.Name = "lblFichaVehiculoFiltro";
            this.lblFichaVehiculoFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblFichaVehiculoFiltro.TabIndex = 94;
            this.lblFichaVehiculoFiltro.Text = "Filtro";
            // 
            // dgvFichaVehiculoEventos
            // 
            this.dgvFichaVehiculoEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaVehiculoEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaVehiculoEventos.Location = new System.Drawing.Point(403, 87);
            this.dgvFichaVehiculoEventos.MultiSelect = false;
            this.dgvFichaVehiculoEventos.Name = "dgvFichaVehiculoEventos";
            this.dgvFichaVehiculoEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaVehiculoEventos.Size = new System.Drawing.Size(381, 271);
            this.dgvFichaVehiculoEventos.TabIndex = 93;
            this.dgvFichaVehiculoEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaVehiculoEventos_CellDoubleClick);
            this.dgvFichaVehiculoEventos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvFichaVehiculoEventos_KeyPress);
            // 
            // btnFichaVehiculoOK
            // 
            this.btnFichaVehiculoOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFichaVehiculoOK.Location = new System.Drawing.Point(14, 364);
            this.btnFichaVehiculoOK.Name = "btnFichaVehiculoOK";
            this.btnFichaVehiculoOK.Size = new System.Drawing.Size(75, 23);
            this.btnFichaVehiculoOK.TabIndex = 92;
            this.btnFichaVehiculoOK.Text = "Editar Datos";
            this.btnFichaVehiculoOK.UseVisualStyleBackColor = true;
            this.btnFichaVehiculoOK.Click += new System.EventHandler(this.btnFichaVehiculoOK_Click);
            // 
            // tbxFichaVehiculoDetalle
            // 
            this.tbxFichaVehiculoDetalle.Location = new System.Drawing.Point(14, 231);
            this.tbxFichaVehiculoDetalle.Multiline = true;
            this.tbxFichaVehiculoDetalle.Name = "tbxFichaVehiculoDetalle";
            this.tbxFichaVehiculoDetalle.ReadOnly = true;
            this.tbxFichaVehiculoDetalle.Size = new System.Drawing.Size(324, 127);
            this.tbxFichaVehiculoDetalle.TabIndex = 91;
            // 
            // lblFichaVehiculoDetalle
            // 
            this.lblFichaVehiculoDetalle.AutoSize = true;
            this.lblFichaVehiculoDetalle.Location = new System.Drawing.Point(20, 215);
            this.lblFichaVehiculoDetalle.Name = "lblFichaVehiculoDetalle";
            this.lblFichaVehiculoDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblFichaVehiculoDetalle.TabIndex = 90;
            this.lblFichaVehiculoDetalle.Text = "Detalle";
            // 
            // tbxFichaVehiculoModelo
            // 
            this.tbxFichaVehiculoModelo.Location = new System.Drawing.Point(238, 122);
            this.tbxFichaVehiculoModelo.Name = "tbxFichaVehiculoModelo";
            this.tbxFichaVehiculoModelo.ReadOnly = true;
            this.tbxFichaVehiculoModelo.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaVehiculoModelo.TabIndex = 89;
            // 
            // lblFichaVehiculoModelo
            // 
            this.lblFichaVehiculoModelo.AutoSize = true;
            this.lblFichaVehiculoModelo.Location = new System.Drawing.Point(244, 106);
            this.lblFichaVehiculoModelo.Name = "lblFichaVehiculoModelo";
            this.lblFichaVehiculoModelo.Size = new System.Drawing.Size(41, 13);
            this.lblFichaVehiculoModelo.TabIndex = 88;
            this.lblFichaVehiculoModelo.Text = "modelo";
            // 
            // tbxFichaVehiculoMarca
            // 
            this.tbxFichaVehiculoMarca.Location = new System.Drawing.Point(122, 122);
            this.tbxFichaVehiculoMarca.Name = "tbxFichaVehiculoMarca";
            this.tbxFichaVehiculoMarca.ReadOnly = true;
            this.tbxFichaVehiculoMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaVehiculoMarca.TabIndex = 87;
            // 
            // lblFichaVehiculoMarca
            // 
            this.lblFichaVehiculoMarca.AutoSize = true;
            this.lblFichaVehiculoMarca.Location = new System.Drawing.Point(128, 106);
            this.lblFichaVehiculoMarca.Name = "lblFichaVehiculoMarca";
            this.lblFichaVehiculoMarca.Size = new System.Drawing.Size(36, 13);
            this.lblFichaVehiculoMarca.TabIndex = 86;
            this.lblFichaVehiculoMarca.Text = "marca";
            // 
            // tbxFichaVehiculoDominio
            // 
            this.tbxFichaVehiculoDominio.Location = new System.Drawing.Point(14, 122);
            this.tbxFichaVehiculoDominio.Name = "tbxFichaVehiculoDominio";
            this.tbxFichaVehiculoDominio.ReadOnly = true;
            this.tbxFichaVehiculoDominio.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaVehiculoDominio.TabIndex = 85;
            // 
            // lblFichaVehiculoDominio
            // 
            this.lblFichaVehiculoDominio.AutoSize = true;
            this.lblFichaVehiculoDominio.Location = new System.Drawing.Point(20, 106);
            this.lblFichaVehiculoDominio.Name = "lblFichaVehiculoDominio";
            this.lblFichaVehiculoDominio.Size = new System.Drawing.Size(43, 13);
            this.lblFichaVehiculoDominio.TabIndex = 84;
            this.lblFichaVehiculoDominio.Text = "dominio";
            // 
            // lblFichaVehiculoEmpresa
            // 
            this.lblFichaVehiculoEmpresa.AutoSize = true;
            this.lblFichaVehiculoEmpresa.Location = new System.Drawing.Point(128, 60);
            this.lblFichaVehiculoEmpresa.Name = "lblFichaVehiculoEmpresa";
            this.lblFichaVehiculoEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblFichaVehiculoEmpresa.TabIndex = 80;
            this.lblFichaVehiculoEmpresa.Text = "empresa";
            // 
            // lblFichaVehiculoTipo
            // 
            this.lblFichaVehiculoTipo.AutoSize = true;
            this.lblFichaVehiculoTipo.Location = new System.Drawing.Point(20, 60);
            this.lblFichaVehiculoTipo.Name = "lblFichaVehiculoTipo";
            this.lblFichaVehiculoTipo.Size = new System.Drawing.Size(24, 13);
            this.lblFichaVehiculoTipo.TabIndex = 78;
            this.lblFichaVehiculoTipo.Text = "tipo";
            // 
            // lblFichaVehiculoTitulo
            // 
            this.lblFichaVehiculoTitulo.AutoSize = true;
            this.lblFichaVehiculoTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaVehiculoTitulo.Location = new System.Drawing.Point(17, 10);
            this.lblFichaVehiculoTitulo.Name = "lblFichaVehiculoTitulo";
            this.lblFichaVehiculoTitulo.Size = new System.Drawing.Size(335, 34);
            this.lblFichaVehiculoTitulo.TabIndex = 77;
            this.lblFichaVehiculoTitulo.Text = "INT - Dominio (Tipo)";
            // 
            // cbxFichaVehiculoTipo
            // 
            this.cbxFichaVehiculoTipo.FormattingEnabled = true;
            this.cbxFichaVehiculoTipo.Location = new System.Drawing.Point(14, 76);
            this.cbxFichaVehiculoTipo.Name = "cbxFichaVehiculoTipo";
            this.cbxFichaVehiculoTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxFichaVehiculoTipo.TabIndex = 101;
            // 
            // cbxFichaVehiculoDocumentacion
            // 
            this.cbxFichaVehiculoDocumentacion.AutoSize = true;
            this.cbxFichaVehiculoDocumentacion.Location = new System.Drawing.Point(90, 19);
            this.cbxFichaVehiculoDocumentacion.Name = "cbxFichaVehiculoDocumentacion";
            this.cbxFichaVehiculoDocumentacion.Size = new System.Drawing.Size(101, 17);
            this.cbxFichaVehiculoDocumentacion.TabIndex = 168;
            this.cbxFichaVehiculoDocumentacion.Text = "Documentacion";
            this.cbxFichaVehiculoDocumentacion.UseVisualStyleBackColor = true;
            // 
            // cbxFichaVehiculoTaller
            // 
            this.cbxFichaVehiculoTaller.AutoSize = true;
            this.cbxFichaVehiculoTaller.Location = new System.Drawing.Point(23, 19);
            this.cbxFichaVehiculoTaller.Name = "cbxFichaVehiculoTaller";
            this.cbxFichaVehiculoTaller.Size = new System.Drawing.Size(52, 17);
            this.cbxFichaVehiculoTaller.TabIndex = 167;
            this.cbxFichaVehiculoTaller.Text = "Taller";
            this.cbxFichaVehiculoTaller.UseVisualStyleBackColor = true;
            // 
            // tbxFichaVehiculoEstado
            // 
            this.tbxFichaVehiculoEstado.Location = new System.Drawing.Point(238, 168);
            this.tbxFichaVehiculoEstado.Name = "tbxFichaVehiculoEstado";
            this.tbxFichaVehiculoEstado.ReadOnly = true;
            this.tbxFichaVehiculoEstado.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaVehiculoEstado.TabIndex = 170;
            // 
            // lblFichaVehiculoEstado
            // 
            this.lblFichaVehiculoEstado.AutoSize = true;
            this.lblFichaVehiculoEstado.Location = new System.Drawing.Point(244, 152);
            this.lblFichaVehiculoEstado.Name = "lblFichaVehiculoEstado";
            this.lblFichaVehiculoEstado.Size = new System.Drawing.Size(39, 13);
            this.lblFichaVehiculoEstado.TabIndex = 169;
            this.lblFichaVehiculoEstado.Text = "estado";
            // 
            // gbxFicahVehiculoEstado
            // 
            this.gbxFicahVehiculoEstado.Controls.Add(this.cbxFichaVehiculoTaller);
            this.gbxFicahVehiculoEstado.Controls.Add(this.cbxFichaVehiculoDocumentacion);
            this.gbxFicahVehiculoEstado.Location = new System.Drawing.Point(14, 152);
            this.gbxFicahVehiculoEstado.Name = "gbxFicahVehiculoEstado";
            this.gbxFicahVehiculoEstado.Size = new System.Drawing.Size(208, 48);
            this.gbxFicahVehiculoEstado.TabIndex = 171;
            this.gbxFicahVehiculoEstado.TabStop = false;
            this.gbxFicahVehiculoEstado.Text = "Estado físico y administrativo";
            // 
            // FrmFichaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 397);
            this.Controls.Add(this.gbxFicahVehiculoEstado);
            this.Controls.Add(this.tbxFichaVehiculoEstado);
            this.Controls.Add(this.lblFichaVehiculoEstado);
            this.Controls.Add(this.cbxFichaVehiculoTipo);
            this.Controls.Add(this.btnFichaVehiculoAlta);
            this.Controls.Add(this.cbxFichaVehiculoEmpresa);
            this.Controls.Add(this.btnFichaVehiculoCerrar);
            this.Controls.Add(this.btnFichaVehiculoNuevoEvento);
            this.Controls.Add(this.tbxFichaVehiculoFiltro);
            this.Controls.Add(this.lblFichaVehiculoFiltro);
            this.Controls.Add(this.dgvFichaVehiculoEventos);
            this.Controls.Add(this.btnFichaVehiculoOK);
            this.Controls.Add(this.tbxFichaVehiculoDetalle);
            this.Controls.Add(this.lblFichaVehiculoDetalle);
            this.Controls.Add(this.tbxFichaVehiculoModelo);
            this.Controls.Add(this.lblFichaVehiculoModelo);
            this.Controls.Add(this.tbxFichaVehiculoMarca);
            this.Controls.Add(this.lblFichaVehiculoMarca);
            this.Controls.Add(this.tbxFichaVehiculoDominio);
            this.Controls.Add(this.lblFichaVehiculoDominio);
            this.Controls.Add(this.lblFichaVehiculoEmpresa);
            this.Controls.Add(this.lblFichaVehiculoTipo);
            this.Controls.Add(this.lblFichaVehiculoTitulo);
            this.Name = "FrmFichaVehiculo";
            this.Load += new System.EventHandler(this.FrmFichaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaVehiculoEventos)).EndInit();
            this.gbxFicahVehiculoEstado.ResumeLayout(false);
            this.gbxFicahVehiculoEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFichaVehiculoAlta;
        private System.Windows.Forms.ComboBox cbxFichaVehiculoEmpresa;
        private System.Windows.Forms.Button btnFichaVehiculoCerrar;
        private System.Windows.Forms.Button btnFichaVehiculoNuevoEvento;
        private System.Windows.Forms.TextBox tbxFichaVehiculoFiltro;
        private System.Windows.Forms.Label lblFichaVehiculoFiltro;
        private System.Windows.Forms.DataGridView dgvFichaVehiculoEventos;
        private System.Windows.Forms.Button btnFichaVehiculoOK;
        private System.Windows.Forms.TextBox tbxFichaVehiculoDetalle;
        private System.Windows.Forms.Label lblFichaVehiculoDetalle;
        private System.Windows.Forms.TextBox tbxFichaVehiculoModelo;
        private System.Windows.Forms.Label lblFichaVehiculoModelo;
        private System.Windows.Forms.TextBox tbxFichaVehiculoMarca;
        private System.Windows.Forms.Label lblFichaVehiculoMarca;
        private System.Windows.Forms.TextBox tbxFichaVehiculoDominio;
        private System.Windows.Forms.Label lblFichaVehiculoDominio;
        private System.Windows.Forms.Label lblFichaVehiculoEmpresa;
        private System.Windows.Forms.Label lblFichaVehiculoTipo;
        private System.Windows.Forms.Label lblFichaVehiculoTitulo;
        private System.Windows.Forms.ComboBox cbxFichaVehiculoTipo;
        private System.Windows.Forms.CheckBox cbxFichaVehiculoDocumentacion;
        private System.Windows.Forms.CheckBox cbxFichaVehiculoTaller;
        private System.Windows.Forms.TextBox tbxFichaVehiculoEstado;
        private System.Windows.Forms.Label lblFichaVehiculoEstado;
        private System.Windows.Forms.GroupBox gbxFicahVehiculoEstado;
    }
}