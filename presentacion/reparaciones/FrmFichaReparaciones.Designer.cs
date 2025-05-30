namespace presentacion.reparaciones
{
    partial class FrmFichaReparaciones
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
            this.cbxFichaReparacionesTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblFichaReparacionesTipoTrabajo = new System.Windows.Forms.Label();
            this.cbxFichaReparacionesInt = new System.Windows.Forms.ComboBox();
            this.lblFichaReparacionesInterno = new System.Windows.Forms.Label();
            this.btnFichaReparacionesCerrar = new System.Windows.Forms.Button();
            this.btnFichaReparacionesOK = new System.Windows.Forms.Button();
            this.cbxFichaReparacionesChofer = new System.Windows.Forms.ComboBox();
            this.cbxFichaReparacionesTipo = new System.Windows.Forms.ComboBox();
            this.lblFichaReparacionesChofer = new System.Windows.Forms.Label();
            this.tbxFichaReparacionesDetalle = new System.Windows.Forms.TextBox();
            this.lblFichaReparacionesDetalle = new System.Windows.Forms.Label();
            this.lblFichaReparacionesTipo = new System.Windows.Forms.Label();
            this.lblFichaReparacionTitulo = new System.Windows.Forms.Label();
            this.cbxFichaReparacionesMecanico = new System.Windows.Forms.ComboBox();
            this.lblFichaReparacionesMecanico = new System.Windows.Forms.Label();
            this.dtpFichaReparacionesFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFichaReparacionesInicio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFichaReparacionesFinHs = new System.Windows.Forms.Label();
            this.lblFichaReparacionesInicioHs = new System.Windows.Forms.Label();
            this.cbxFichaReparacionesHoraFin = new System.Windows.Forms.ComboBox();
            this.dtpFichaReparacionesFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFichaReparacionesFin = new System.Windows.Forms.Label();
            this.cbxFichaReparacionesHoraInicio = new System.Windows.Forms.ComboBox();
            this.btnFichaReparacionesAgregar = new System.Windows.Forms.Button();
            this.cbxFichaReparacionesFiltroArticulos = new System.Windows.Forms.TextBox();
            this.lblFichaReparacionesFiltroArticulos = new System.Windows.Forms.Label();
            this.dgvFichaReparacionesRepuestos = new System.Windows.Forms.DataGridView();
            this.lblFichaReparacionesTituloArticulos = new System.Windows.Forms.Label();
            this.dgvFichaReparacionesArticulos = new System.Windows.Forms.DataGridView();
            this.lblFichaReparacionesTituloRepuestos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaReparacionesRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaReparacionesArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFichaReparacionesTipoTrabajo
            // 
            this.cbxFichaReparacionesTipoTrabajo.FormattingEnabled = true;
            this.cbxFichaReparacionesTipoTrabajo.Location = new System.Drawing.Point(185, 63);
            this.cbxFichaReparacionesTipoTrabajo.Name = "cbxFichaReparacionesTipoTrabajo";
            this.cbxFichaReparacionesTipoTrabajo.Size = new System.Drawing.Size(116, 21);
            this.cbxFichaReparacionesTipoTrabajo.TabIndex = 190;
            // 
            // lblFichaReparacionesTipoTrabajo
            // 
            this.lblFichaReparacionesTipoTrabajo.AutoSize = true;
            this.lblFichaReparacionesTipoTrabajo.Location = new System.Drawing.Point(187, 47);
            this.lblFichaReparacionesTipoTrabajo.Name = "lblFichaReparacionesTipoTrabajo";
            this.lblFichaReparacionesTipoTrabajo.Size = new System.Drawing.Size(84, 13);
            this.lblFichaReparacionesTipoTrabajo.TabIndex = 189;
            this.lblFichaReparacionesTipoTrabajo.Text = "trabajo a realizar";
            // 
            // cbxFichaReparacionesInt
            // 
            this.cbxFichaReparacionesInt.FormattingEnabled = true;
            this.cbxFichaReparacionesInt.Location = new System.Drawing.Point(123, 63);
            this.cbxFichaReparacionesInt.Name = "cbxFichaReparacionesInt";
            this.cbxFichaReparacionesInt.Size = new System.Drawing.Size(56, 21);
            this.cbxFichaReparacionesInt.TabIndex = 181;
            // 
            // lblFichaReparacionesInterno
            // 
            this.lblFichaReparacionesInterno.AutoSize = true;
            this.lblFichaReparacionesInterno.Location = new System.Drawing.Point(125, 46);
            this.lblFichaReparacionesInterno.Name = "lblFichaReparacionesInterno";
            this.lblFichaReparacionesInterno.Size = new System.Drawing.Size(39, 13);
            this.lblFichaReparacionesInterno.TabIndex = 180;
            this.lblFichaReparacionesInterno.Text = "interno";
            // 
            // btnFichaReparacionesCerrar
            // 
            this.btnFichaReparacionesCerrar.Location = new System.Drawing.Point(798, 376);
            this.btnFichaReparacionesCerrar.Name = "btnFichaReparacionesCerrar";
            this.btnFichaReparacionesCerrar.Size = new System.Drawing.Size(74, 23);
            this.btnFichaReparacionesCerrar.TabIndex = 179;
            this.btnFichaReparacionesCerrar.Text = "Cerrar";
            this.btnFichaReparacionesCerrar.UseVisualStyleBackColor = true;
            this.btnFichaReparacionesCerrar.Click += new System.EventHandler(this.btnFichaReparacionesCerrar_Click);
            // 
            // btnFichaReparacionesOK
            // 
            this.btnFichaReparacionesOK.Location = new System.Drawing.Point(18, 376);
            this.btnFichaReparacionesOK.Name = "btnFichaReparacionesOK";
            this.btnFichaReparacionesOK.Size = new System.Drawing.Size(74, 23);
            this.btnFichaReparacionesOK.TabIndex = 178;
            this.btnFichaReparacionesOK.Text = "Guardar";
            this.btnFichaReparacionesOK.UseVisualStyleBackColor = true;
            this.btnFichaReparacionesOK.Click += new System.EventHandler(this.btnFichaReparacionesOK_Click);
            // 
            // cbxFichaReparacionesChofer
            // 
            this.cbxFichaReparacionesChofer.FormattingEnabled = true;
            this.cbxFichaReparacionesChofer.Location = new System.Drawing.Point(22, 105);
            this.cbxFichaReparacionesChofer.Name = "cbxFichaReparacionesChofer";
            this.cbxFichaReparacionesChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxFichaReparacionesChofer.TabIndex = 177;
            // 
            // cbxFichaReparacionesTipo
            // 
            this.cbxFichaReparacionesTipo.FormattingEnabled = true;
            this.cbxFichaReparacionesTipo.Location = new System.Drawing.Point(21, 63);
            this.cbxFichaReparacionesTipo.Name = "cbxFichaReparacionesTipo";
            this.cbxFichaReparacionesTipo.Size = new System.Drawing.Size(96, 21);
            this.cbxFichaReparacionesTipo.TabIndex = 176;
            this.cbxFichaReparacionesTipo.SelectedIndexChanged += new System.EventHandler(this.cbxFichaReparacionesTipo_SelectedIndexChanged);
            // 
            // lblFichaReparacionesChofer
            // 
            this.lblFichaReparacionesChofer.AutoSize = true;
            this.lblFichaReparacionesChofer.Location = new System.Drawing.Point(24, 89);
            this.lblFichaReparacionesChofer.Name = "lblFichaReparacionesChofer";
            this.lblFichaReparacionesChofer.Size = new System.Drawing.Size(83, 13);
            this.lblFichaReparacionesChofer.TabIndex = 175;
            this.lblFichaReparacionesChofer.Text = "chofer asociado";
            // 
            // tbxFichaReparacionesDetalle
            // 
            this.tbxFichaReparacionesDetalle.Location = new System.Drawing.Point(18, 298);
            this.tbxFichaReparacionesDetalle.Multiline = true;
            this.tbxFichaReparacionesDetalle.Name = "tbxFichaReparacionesDetalle";
            this.tbxFichaReparacionesDetalle.Size = new System.Drawing.Size(280, 74);
            this.tbxFichaReparacionesDetalle.TabIndex = 174;
            // 
            // lblFichaReparacionesDetalle
            // 
            this.lblFichaReparacionesDetalle.AutoSize = true;
            this.lblFichaReparacionesDetalle.Location = new System.Drawing.Point(23, 282);
            this.lblFichaReparacionesDetalle.Name = "lblFichaReparacionesDetalle";
            this.lblFichaReparacionesDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblFichaReparacionesDetalle.TabIndex = 173;
            this.lblFichaReparacionesDetalle.Text = "Detalle";
            // 
            // lblFichaReparacionesTipo
            // 
            this.lblFichaReparacionesTipo.AutoSize = true;
            this.lblFichaReparacionesTipo.Location = new System.Drawing.Point(23, 47);
            this.lblFichaReparacionesTipo.Name = "lblFichaReparacionesTipo";
            this.lblFichaReparacionesTipo.Size = new System.Drawing.Size(24, 13);
            this.lblFichaReparacionesTipo.TabIndex = 172;
            this.lblFichaReparacionesTipo.Text = "tipo";
            // 
            // lblFichaReparacionTitulo
            // 
            this.lblFichaReparacionTitulo.AutoSize = true;
            this.lblFichaReparacionTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaReparacionTitulo.Location = new System.Drawing.Point(90, 11);
            this.lblFichaReparacionTitulo.Name = "lblFichaReparacionTitulo";
            this.lblFichaReparacionTitulo.Size = new System.Drawing.Size(142, 28);
            this.lblFichaReparacionTitulo.TabIndex = 171;
            this.lblFichaReparacionTitulo.Text = "Reparacion";
            // 
            // cbxFichaReparacionesMecanico
            // 
            this.cbxFichaReparacionesMecanico.FormattingEnabled = true;
            this.cbxFichaReparacionesMecanico.Location = new System.Drawing.Point(22, 145);
            this.cbxFichaReparacionesMecanico.Name = "cbxFichaReparacionesMecanico";
            this.cbxFichaReparacionesMecanico.Size = new System.Drawing.Size(280, 21);
            this.cbxFichaReparacionesMecanico.TabIndex = 192;
            // 
            // lblFichaReparacionesMecanico
            // 
            this.lblFichaReparacionesMecanico.AutoSize = true;
            this.lblFichaReparacionesMecanico.Location = new System.Drawing.Point(24, 129);
            this.lblFichaReparacionesMecanico.Name = "lblFichaReparacionesMecanico";
            this.lblFichaReparacionesMecanico.Size = new System.Drawing.Size(53, 13);
            this.lblFichaReparacionesMecanico.TabIndex = 191;
            this.lblFichaReparacionesMecanico.Text = "mecanico";
            // 
            // dtpFichaReparacionesFechaInicio
            // 
            this.dtpFichaReparacionesFechaInicio.Location = new System.Drawing.Point(63, 26);
            this.dtpFichaReparacionesFechaInicio.Name = "dtpFichaReparacionesFechaInicio";
            this.dtpFichaReparacionesFechaInicio.Size = new System.Drawing.Size(81, 20);
            this.dtpFichaReparacionesFechaInicio.TabIndex = 193;
            this.dtpFichaReparacionesFechaInicio.ValueChanged += new System.EventHandler(this.dtpFichaReparacionesFecha_ValueChanged);
            // 
            // lblFichaReparacionesInicio
            // 
            this.lblFichaReparacionesInicio.AutoSize = true;
            this.lblFichaReparacionesInicio.Location = new System.Drawing.Point(26, 29);
            this.lblFichaReparacionesInicio.Name = "lblFichaReparacionesInicio";
            this.lblFichaReparacionesInicio.Size = new System.Drawing.Size(31, 13);
            this.lblFichaReparacionesInicio.TabIndex = 194;
            this.lblFichaReparacionesInicio.Text = "inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFichaReparacionesFinHs);
            this.groupBox1.Controls.Add(this.lblFichaReparacionesInicioHs);
            this.groupBox1.Controls.Add(this.cbxFichaReparacionesHoraFin);
            this.groupBox1.Controls.Add(this.dtpFichaReparacionesFechaFin);
            this.groupBox1.Controls.Add(this.lblFichaReparacionesFin);
            this.groupBox1.Controls.Add(this.cbxFichaReparacionesHoraInicio);
            this.groupBox1.Controls.Add(this.dtpFichaReparacionesFechaInicio);
            this.groupBox1.Controls.Add(this.lblFichaReparacionesInicio);
            this.groupBox1.Location = new System.Drawing.Point(20, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 107);
            this.groupBox1.TabIndex = 198;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tiempo de trabajo";
            // 
            // lblFichaReparacionesFinHs
            // 
            this.lblFichaReparacionesFinHs.AutoSize = true;
            this.lblFichaReparacionesFinHs.Location = new System.Drawing.Point(152, 63);
            this.lblFichaReparacionesFinHs.Name = "lblFichaReparacionesFinHs";
            this.lblFichaReparacionesFinHs.Size = new System.Drawing.Size(28, 13);
            this.lblFichaReparacionesFinHs.TabIndex = 203;
            this.lblFichaReparacionesFinHs.Text = "hora";
            // 
            // lblFichaReparacionesInicioHs
            // 
            this.lblFichaReparacionesInicioHs.AutoSize = true;
            this.lblFichaReparacionesInicioHs.Location = new System.Drawing.Point(152, 29);
            this.lblFichaReparacionesInicioHs.Name = "lblFichaReparacionesInicioHs";
            this.lblFichaReparacionesInicioHs.Size = new System.Drawing.Size(28, 13);
            this.lblFichaReparacionesInicioHs.TabIndex = 202;
            this.lblFichaReparacionesInicioHs.Text = "hora";
            // 
            // cbxFichaReparacionesHoraFin
            // 
            this.cbxFichaReparacionesHoraFin.FormattingEnabled = true;
            this.cbxFichaReparacionesHoraFin.Location = new System.Drawing.Point(185, 60);
            this.cbxFichaReparacionesHoraFin.Name = "cbxFichaReparacionesHoraFin";
            this.cbxFichaReparacionesHoraFin.Size = new System.Drawing.Size(72, 21);
            this.cbxFichaReparacionesHoraFin.TabIndex = 201;
            // 
            // dtpFichaReparacionesFechaFin
            // 
            this.dtpFichaReparacionesFechaFin.Location = new System.Drawing.Point(63, 60);
            this.dtpFichaReparacionesFechaFin.Name = "dtpFichaReparacionesFechaFin";
            this.dtpFichaReparacionesFechaFin.Size = new System.Drawing.Size(81, 20);
            this.dtpFichaReparacionesFechaFin.TabIndex = 200;
            // 
            // lblFichaReparacionesFin
            // 
            this.lblFichaReparacionesFin.AutoSize = true;
            this.lblFichaReparacionesFin.Location = new System.Drawing.Point(39, 60);
            this.lblFichaReparacionesFin.Name = "lblFichaReparacionesFin";
            this.lblFichaReparacionesFin.Size = new System.Drawing.Size(18, 13);
            this.lblFichaReparacionesFin.TabIndex = 199;
            this.lblFichaReparacionesFin.Text = "fin";
            // 
            // cbxFichaReparacionesHoraInicio
            // 
            this.cbxFichaReparacionesHoraInicio.FormattingEnabled = true;
            this.cbxFichaReparacionesHoraInicio.Location = new System.Drawing.Point(185, 26);
            this.cbxFichaReparacionesHoraInicio.Name = "cbxFichaReparacionesHoraInicio";
            this.cbxFichaReparacionesHoraInicio.Size = new System.Drawing.Size(72, 21);
            this.cbxFichaReparacionesHoraInicio.TabIndex = 199;
            // 
            // btnFichaReparacionesAgregar
            // 
            this.btnFichaReparacionesAgregar.Location = new System.Drawing.Point(816, 60);
            this.btnFichaReparacionesAgregar.Name = "btnFichaReparacionesAgregar";
            this.btnFichaReparacionesAgregar.Size = new System.Drawing.Size(56, 23);
            this.btnFichaReparacionesAgregar.TabIndex = 203;
            this.btnFichaReparacionesAgregar.Text = "Nuevo";
            this.btnFichaReparacionesAgregar.UseVisualStyleBackColor = true;
            // 
            // cbxFichaReparacionesFiltroArticulos
            // 
            this.cbxFichaReparacionesFiltroArticulos.Location = new System.Drawing.Point(384, 63);
            this.cbxFichaReparacionesFiltroArticulos.Name = "cbxFichaReparacionesFiltroArticulos";
            this.cbxFichaReparacionesFiltroArticulos.Size = new System.Drawing.Size(397, 20);
            this.cbxFichaReparacionesFiltroArticulos.TabIndex = 202;
            // 
            // lblFichaReparacionesFiltroArticulos
            // 
            this.lblFichaReparacionesFiltroArticulos.AutoSize = true;
            this.lblFichaReparacionesFiltroArticulos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaReparacionesFiltroArticulos.Location = new System.Drawing.Point(344, 67);
            this.lblFichaReparacionesFiltroArticulos.Name = "lblFichaReparacionesFiltroArticulos";
            this.lblFichaReparacionesFiltroArticulos.Size = new System.Drawing.Size(34, 12);
            this.lblFichaReparacionesFiltroArticulos.TabIndex = 201;
            this.lblFichaReparacionesFiltroArticulos.Text = "Filtro";
            // 
            // dgvFichaReparacionesRepuestos
            // 
            this.dgvFichaReparacionesRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaReparacionesRepuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaReparacionesRepuestos.Location = new System.Drawing.Point(343, 248);
            this.dgvFichaReparacionesRepuestos.MultiSelect = false;
            this.dgvFichaReparacionesRepuestos.Name = "dgvFichaReparacionesRepuestos";
            this.dgvFichaReparacionesRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaReparacionesRepuestos.Size = new System.Drawing.Size(529, 124);
            this.dgvFichaReparacionesRepuestos.TabIndex = 200;
            this.dgvFichaReparacionesRepuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaReparacionesRepuestos_CellClick);
            // 
            // lblFichaReparacionesTituloArticulos
            // 
            this.lblFichaReparacionesTituloArticulos.AutoSize = true;
            this.lblFichaReparacionesTituloArticulos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaReparacionesTituloArticulos.Location = new System.Drawing.Point(342, 29);
            this.lblFichaReparacionesTituloArticulos.Name = "lblFichaReparacionesTituloArticulos";
            this.lblFichaReparacionesTituloArticulos.Size = new System.Drawing.Size(226, 24);
            this.lblFichaReparacionesTituloArticulos.TabIndex = 199;
            this.lblFichaReparacionesTituloArticulos.Text = "Lista de repuestos";
            // 
            // dgvFichaReparacionesArticulos
            // 
            this.dgvFichaReparacionesArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaReparacionesArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaReparacionesArticulos.Location = new System.Drawing.Point(343, 90);
            this.dgvFichaReparacionesArticulos.MultiSelect = false;
            this.dgvFichaReparacionesArticulos.Name = "dgvFichaReparacionesArticulos";
            this.dgvFichaReparacionesArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaReparacionesArticulos.Size = new System.Drawing.Size(529, 124);
            this.dgvFichaReparacionesArticulos.TabIndex = 204;
            this.dgvFichaReparacionesArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaReparacionesArticulos_CellClick);
            // 
            // lblFichaReparacionesTituloRepuestos
            // 
            this.lblFichaReparacionesTituloRepuestos.AutoSize = true;
            this.lblFichaReparacionesTituloRepuestos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaReparacionesTituloRepuestos.Location = new System.Drawing.Point(342, 221);
            this.lblFichaReparacionesTituloRepuestos.Name = "lblFichaReparacionesTituloRepuestos";
            this.lblFichaReparacionesTituloRepuestos.Size = new System.Drawing.Size(250, 24);
            this.lblFichaReparacionesTituloRepuestos.TabIndex = 205;
            this.lblFichaReparacionesTituloRepuestos.Text = "Repuestos necesarios";
            // 
            // FrmFichaReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.lblFichaReparacionesTituloRepuestos);
            this.Controls.Add(this.dgvFichaReparacionesArticulos);
            this.Controls.Add(this.btnFichaReparacionesAgregar);
            this.Controls.Add(this.cbxFichaReparacionesFiltroArticulos);
            this.Controls.Add(this.lblFichaReparacionesFiltroArticulos);
            this.Controls.Add(this.dgvFichaReparacionesRepuestos);
            this.Controls.Add(this.lblFichaReparacionesTituloArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxFichaReparacionesMecanico);
            this.Controls.Add(this.lblFichaReparacionesMecanico);
            this.Controls.Add(this.cbxFichaReparacionesTipoTrabajo);
            this.Controls.Add(this.lblFichaReparacionesTipoTrabajo);
            this.Controls.Add(this.cbxFichaReparacionesInt);
            this.Controls.Add(this.lblFichaReparacionesInterno);
            this.Controls.Add(this.btnFichaReparacionesCerrar);
            this.Controls.Add(this.btnFichaReparacionesOK);
            this.Controls.Add(this.cbxFichaReparacionesChofer);
            this.Controls.Add(this.cbxFichaReparacionesTipo);
            this.Controls.Add(this.lblFichaReparacionesChofer);
            this.Controls.Add(this.tbxFichaReparacionesDetalle);
            this.Controls.Add(this.lblFichaReparacionesDetalle);
            this.Controls.Add(this.lblFichaReparacionesTipo);
            this.Controls.Add(this.lblFichaReparacionTitulo);
            this.Name = "FrmFichaReparaciones";
            this.Load += new System.EventHandler(this.FrmFichaReparaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaReparacionesRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaReparacionesArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFichaReparacionesTipoTrabajo;
        private System.Windows.Forms.Label lblFichaReparacionesTipoTrabajo;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesInt;
        private System.Windows.Forms.Label lblFichaReparacionesInterno;
        private System.Windows.Forms.Button btnFichaReparacionesCerrar;
        private System.Windows.Forms.Button btnFichaReparacionesOK;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesChofer;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesTipo;
        private System.Windows.Forms.Label lblFichaReparacionesChofer;
        private System.Windows.Forms.TextBox tbxFichaReparacionesDetalle;
        private System.Windows.Forms.Label lblFichaReparacionesDetalle;
        private System.Windows.Forms.Label lblFichaReparacionesTipo;
        private System.Windows.Forms.Label lblFichaReparacionTitulo;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesMecanico;
        private System.Windows.Forms.Label lblFichaReparacionesMecanico;
        private System.Windows.Forms.DateTimePicker dtpFichaReparacionesFechaInicio;
        private System.Windows.Forms.Label lblFichaReparacionesInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFichaReparacionesFin;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesHoraInicio;
        private System.Windows.Forms.Button btnFichaReparacionesAgregar;
        private System.Windows.Forms.TextBox cbxFichaReparacionesFiltroArticulos;
        private System.Windows.Forms.Label lblFichaReparacionesFiltroArticulos;
        private System.Windows.Forms.DataGridView dgvFichaReparacionesRepuestos;
        private System.Windows.Forms.Label lblFichaReparacionesTituloArticulos;
        private System.Windows.Forms.DataGridView dgvFichaReparacionesArticulos;
        private System.Windows.Forms.Label lblFichaReparacionesTituloRepuestos;
        private System.Windows.Forms.ComboBox cbxFichaReparacionesHoraFin;
        private System.Windows.Forms.DateTimePicker dtpFichaReparacionesFechaFin;
        private System.Windows.Forms.Label lblFichaReparacionesFinHs;
        private System.Windows.Forms.Label lblFichaReparacionesInicioHs;
    }
}