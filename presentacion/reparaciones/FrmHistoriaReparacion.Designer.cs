namespace presentacion.reparaciones
{
    partial class FrmHistoriaReparacion
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
            this.lblHistoriaReparacionTituloRepuestos = new System.Windows.Forms.Label();
            this.dgvHistoriaReparacionRepuestos = new System.Windows.Forms.DataGridView();
            this.gpxHistoriaReparacion = new System.Windows.Forms.GroupBox();
            this.lblHistoriaReparacionFinHs = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionInicioHs = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionFin = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionInicio = new System.Windows.Forms.Label();
            this.cbxHistoriaReparacionMecanico = new System.Windows.Forms.ComboBox();
            this.lblHistoriaReparacionMecanico = new System.Windows.Forms.Label();
            this.cbxHistoriaReparacionTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblHistoriaReparacionTipoTrabajo = new System.Windows.Forms.Label();
            this.cbxHistoriaReparacionInt = new System.Windows.Forms.ComboBox();
            this.lblHistoriaReparacionInterno = new System.Windows.Forms.Label();
            this.btnHistoriaReparacionCerrar = new System.Windows.Forms.Button();
            this.btnHistoriaReparacionOK = new System.Windows.Forms.Button();
            this.cbxHistoriaReparacionChofer = new System.Windows.Forms.ComboBox();
            this.cbxHistoriaReparacionTipo = new System.Windows.Forms.ComboBox();
            this.lblHistoriaReparacionChofer = new System.Windows.Forms.Label();
            this.tbxHistoriaReparacionDetalle = new System.Windows.Forms.TextBox();
            this.lblHistoriaReparacionDetalle = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionTipo = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionTitulo = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionInicioFecha = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionFinFecha = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionInicioHora = new System.Windows.Forms.Label();
            this.lblHistoriaReparacionFinHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaReparacionRepuestos)).BeginInit();
            this.gpxHistoriaReparacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHistoriaReparacionTituloRepuestos
            // 
            this.lblHistoriaReparacionTituloRepuestos.AutoSize = true;
            this.lblHistoriaReparacionTituloRepuestos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionTituloRepuestos.Location = new System.Drawing.Point(339, 15);
            this.lblHistoriaReparacionTituloRepuestos.Name = "lblHistoriaReparacionTituloRepuestos";
            this.lblHistoriaReparacionTituloRepuestos.Size = new System.Drawing.Size(250, 24);
            this.lblHistoriaReparacionTituloRepuestos.TabIndex = 228;
            this.lblHistoriaReparacionTituloRepuestos.Text = "Repuestos a utilizar";
            // 
            // dgvHistoriaReparacionRepuestos
            // 
            this.dgvHistoriaReparacionRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaReparacionRepuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHistoriaReparacionRepuestos.Location = new System.Drawing.Point(343, 47);
            this.dgvHistoriaReparacionRepuestos.MultiSelect = false;
            this.dgvHistoriaReparacionRepuestos.Name = "dgvHistoriaReparacionRepuestos";
            this.dgvHistoriaReparacionRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriaReparacionRepuestos.Size = new System.Drawing.Size(283, 325);
            this.dgvHistoriaReparacionRepuestos.TabIndex = 223;
            // 
            // gpxHistoriaReparacion
            // 
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionFinHora);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionInicioHora);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionFinFecha);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionInicioFecha);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionFinHs);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionInicioHs);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionFin);
            this.gpxHistoriaReparacion.Controls.Add(this.lblHistoriaReparacionInicio);
            this.gpxHistoriaReparacion.Location = new System.Drawing.Point(20, 172);
            this.gpxHistoriaReparacion.Name = "gpxHistoriaReparacion";
            this.gpxHistoriaReparacion.Size = new System.Drawing.Size(282, 107);
            this.gpxHistoriaReparacion.TabIndex = 221;
            this.gpxHistoriaReparacion.TabStop = false;
            this.gpxHistoriaReparacion.Text = "tiempo de trabajo";
            // 
            // lblHistoriaReparacionFinHs
            // 
            this.lblHistoriaReparacionFinHs.AutoSize = true;
            this.lblHistoriaReparacionFinHs.Location = new System.Drawing.Point(167, 61);
            this.lblHistoriaReparacionFinHs.Name = "lblHistoriaReparacionFinHs";
            this.lblHistoriaReparacionFinHs.Size = new System.Drawing.Size(28, 13);
            this.lblHistoriaReparacionFinHs.TabIndex = 203;
            this.lblHistoriaReparacionFinHs.Text = "hora";
            // 
            // lblHistoriaReparacionInicioHs
            // 
            this.lblHistoriaReparacionInicioHs.AutoSize = true;
            this.lblHistoriaReparacionInicioHs.Location = new System.Drawing.Point(167, 34);
            this.lblHistoriaReparacionInicioHs.Name = "lblHistoriaReparacionInicioHs";
            this.lblHistoriaReparacionInicioHs.Size = new System.Drawing.Size(28, 13);
            this.lblHistoriaReparacionInicioHs.TabIndex = 202;
            this.lblHistoriaReparacionInicioHs.Text = "hora";
            // 
            // lblHistoriaReparacionFin
            // 
            this.lblHistoriaReparacionFin.AutoSize = true;
            this.lblHistoriaReparacionFin.Location = new System.Drawing.Point(51, 61);
            this.lblHistoriaReparacionFin.Name = "lblHistoriaReparacionFin";
            this.lblHistoriaReparacionFin.Size = new System.Drawing.Size(18, 13);
            this.lblHistoriaReparacionFin.TabIndex = 199;
            this.lblHistoriaReparacionFin.Text = "fin";
            // 
            // lblHistoriaReparacionInicio
            // 
            this.lblHistoriaReparacionInicio.AutoSize = true;
            this.lblHistoriaReparacionInicio.Location = new System.Drawing.Point(38, 34);
            this.lblHistoriaReparacionInicio.Name = "lblHistoriaReparacionInicio";
            this.lblHistoriaReparacionInicio.Size = new System.Drawing.Size(31, 13);
            this.lblHistoriaReparacionInicio.TabIndex = 194;
            this.lblHistoriaReparacionInicio.Text = "inicio";
            // 
            // cbxHistoriaReparacionMecanico
            // 
            this.cbxHistoriaReparacionMecanico.FormattingEnabled = true;
            this.cbxHistoriaReparacionMecanico.Location = new System.Drawing.Point(22, 145);
            this.cbxHistoriaReparacionMecanico.Name = "cbxHistoriaReparacionMecanico";
            this.cbxHistoriaReparacionMecanico.Size = new System.Drawing.Size(280, 21);
            this.cbxHistoriaReparacionMecanico.TabIndex = 220;
            // 
            // lblHistoriaReparacionMecanico
            // 
            this.lblHistoriaReparacionMecanico.AutoSize = true;
            this.lblHistoriaReparacionMecanico.Location = new System.Drawing.Point(24, 129);
            this.lblHistoriaReparacionMecanico.Name = "lblHistoriaReparacionMecanico";
            this.lblHistoriaReparacionMecanico.Size = new System.Drawing.Size(53, 13);
            this.lblHistoriaReparacionMecanico.TabIndex = 219;
            this.lblHistoriaReparacionMecanico.Text = "mecanico";
            // 
            // cbxHistoriaReparacionTipoTrabajo
            // 
            this.cbxHistoriaReparacionTipoTrabajo.FormattingEnabled = true;
            this.cbxHistoriaReparacionTipoTrabajo.Location = new System.Drawing.Point(185, 63);
            this.cbxHistoriaReparacionTipoTrabajo.Name = "cbxHistoriaReparacionTipoTrabajo";
            this.cbxHistoriaReparacionTipoTrabajo.Size = new System.Drawing.Size(116, 21);
            this.cbxHistoriaReparacionTipoTrabajo.TabIndex = 218;
            // 
            // lblHistoriaReparacionTipoTrabajo
            // 
            this.lblHistoriaReparacionTipoTrabajo.AutoSize = true;
            this.lblHistoriaReparacionTipoTrabajo.Location = new System.Drawing.Point(187, 47);
            this.lblHistoriaReparacionTipoTrabajo.Name = "lblHistoriaReparacionTipoTrabajo";
            this.lblHistoriaReparacionTipoTrabajo.Size = new System.Drawing.Size(84, 13);
            this.lblHistoriaReparacionTipoTrabajo.TabIndex = 217;
            this.lblHistoriaReparacionTipoTrabajo.Text = "trabajo a realizar";
            // 
            // cbxHistoriaReparacionInt
            // 
            this.cbxHistoriaReparacionInt.FormattingEnabled = true;
            this.cbxHistoriaReparacionInt.Location = new System.Drawing.Point(123, 63);
            this.cbxHistoriaReparacionInt.Name = "cbxHistoriaReparacionInt";
            this.cbxHistoriaReparacionInt.Size = new System.Drawing.Size(56, 21);
            this.cbxHistoriaReparacionInt.TabIndex = 216;
            // 
            // lblHistoriaReparacionInterno
            // 
            this.lblHistoriaReparacionInterno.AutoSize = true;
            this.lblHistoriaReparacionInterno.Location = new System.Drawing.Point(125, 46);
            this.lblHistoriaReparacionInterno.Name = "lblHistoriaReparacionInterno";
            this.lblHistoriaReparacionInterno.Size = new System.Drawing.Size(39, 13);
            this.lblHistoriaReparacionInterno.TabIndex = 215;
            this.lblHistoriaReparacionInterno.Text = "interno";
            // 
            // btnHistoriaReparacionCerrar
            // 
            this.btnHistoriaReparacionCerrar.Location = new System.Drawing.Point(552, 376);
            this.btnHistoriaReparacionCerrar.Name = "btnHistoriaReparacionCerrar";
            this.btnHistoriaReparacionCerrar.Size = new System.Drawing.Size(74, 23);
            this.btnHistoriaReparacionCerrar.TabIndex = 214;
            this.btnHistoriaReparacionCerrar.Text = "Cerrar";
            this.btnHistoriaReparacionCerrar.UseVisualStyleBackColor = true;
            this.btnHistoriaReparacionCerrar.Click += new System.EventHandler(this.btnHistoriaReparacionCerrar_Click);
            // 
            // btnHistoriaReparacionOK
            // 
            this.btnHistoriaReparacionOK.Location = new System.Drawing.Point(18, 376);
            this.btnHistoriaReparacionOK.Name = "btnHistoriaReparacionOK";
            this.btnHistoriaReparacionOK.Size = new System.Drawing.Size(74, 23);
            this.btnHistoriaReparacionOK.TabIndex = 213;
            this.btnHistoriaReparacionOK.Text = "Guardar";
            this.btnHistoriaReparacionOK.UseVisualStyleBackColor = true;
            // 
            // cbxHistoriaReparacionChofer
            // 
            this.cbxHistoriaReparacionChofer.FormattingEnabled = true;
            this.cbxHistoriaReparacionChofer.Location = new System.Drawing.Point(22, 105);
            this.cbxHistoriaReparacionChofer.Name = "cbxHistoriaReparacionChofer";
            this.cbxHistoriaReparacionChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxHistoriaReparacionChofer.TabIndex = 212;
            // 
            // cbxHistoriaReparacionTipo
            // 
            this.cbxHistoriaReparacionTipo.FormattingEnabled = true;
            this.cbxHistoriaReparacionTipo.Location = new System.Drawing.Point(21, 63);
            this.cbxHistoriaReparacionTipo.Name = "cbxHistoriaReparacionTipo";
            this.cbxHistoriaReparacionTipo.Size = new System.Drawing.Size(96, 21);
            this.cbxHistoriaReparacionTipo.TabIndex = 211;
            // 
            // lblHistoriaReparacionChofer
            // 
            this.lblHistoriaReparacionChofer.AutoSize = true;
            this.lblHistoriaReparacionChofer.Location = new System.Drawing.Point(24, 89);
            this.lblHistoriaReparacionChofer.Name = "lblHistoriaReparacionChofer";
            this.lblHistoriaReparacionChofer.Size = new System.Drawing.Size(83, 13);
            this.lblHistoriaReparacionChofer.TabIndex = 210;
            this.lblHistoriaReparacionChofer.Text = "chofer asociado";
            // 
            // tbxHistoriaReparacionDetalle
            // 
            this.tbxHistoriaReparacionDetalle.Location = new System.Drawing.Point(18, 298);
            this.tbxHistoriaReparacionDetalle.Multiline = true;
            this.tbxHistoriaReparacionDetalle.Name = "tbxHistoriaReparacionDetalle";
            this.tbxHistoriaReparacionDetalle.Size = new System.Drawing.Size(280, 74);
            this.tbxHistoriaReparacionDetalle.TabIndex = 209;
            // 
            // lblHistoriaReparacionDetalle
            // 
            this.lblHistoriaReparacionDetalle.AutoSize = true;
            this.lblHistoriaReparacionDetalle.Location = new System.Drawing.Point(23, 282);
            this.lblHistoriaReparacionDetalle.Name = "lblHistoriaReparacionDetalle";
            this.lblHistoriaReparacionDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblHistoriaReparacionDetalle.TabIndex = 208;
            this.lblHistoriaReparacionDetalle.Text = "Detalle";
            // 
            // lblHistoriaReparacionTipo
            // 
            this.lblHistoriaReparacionTipo.AutoSize = true;
            this.lblHistoriaReparacionTipo.Location = new System.Drawing.Point(23, 47);
            this.lblHistoriaReparacionTipo.Name = "lblHistoriaReparacionTipo";
            this.lblHistoriaReparacionTipo.Size = new System.Drawing.Size(24, 13);
            this.lblHistoriaReparacionTipo.TabIndex = 207;
            this.lblHistoriaReparacionTipo.Text = "tipo";
            // 
            // lblHistoriaReparacionTitulo
            // 
            this.lblHistoriaReparacionTitulo.AutoSize = true;
            this.lblHistoriaReparacionTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionTitulo.Location = new System.Drawing.Point(90, 11);
            this.lblHistoriaReparacionTitulo.Name = "lblHistoriaReparacionTitulo";
            this.lblHistoriaReparacionTitulo.Size = new System.Drawing.Size(142, 28);
            this.lblHistoriaReparacionTitulo.TabIndex = 206;
            this.lblHistoriaReparacionTitulo.Text = "Reparacion";
            // 
            // lblHistoriaReparacionInicioFecha
            // 
            this.lblHistoriaReparacionInicioFecha.AutoSize = true;
            this.lblHistoriaReparacionInicioFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionInicioFecha.Location = new System.Drawing.Point(75, 32);
            this.lblHistoriaReparacionInicioFecha.Name = "lblHistoriaReparacionInicioFecha";
            this.lblHistoriaReparacionInicioFecha.Size = new System.Drawing.Size(79, 15);
            this.lblHistoriaReparacionInicioFecha.TabIndex = 204;
            this.lblHistoriaReparacionInicioFecha.Text = "30/10/1995";
            // 
            // lblHistoriaReparacionFinFecha
            // 
            this.lblHistoriaReparacionFinFecha.AutoSize = true;
            this.lblHistoriaReparacionFinFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionFinFecha.Location = new System.Drawing.Point(75, 59);
            this.lblHistoriaReparacionFinFecha.Name = "lblHistoriaReparacionFinFecha";
            this.lblHistoriaReparacionFinFecha.Size = new System.Drawing.Size(79, 15);
            this.lblHistoriaReparacionFinFecha.TabIndex = 205;
            this.lblHistoriaReparacionFinFecha.Text = "30/10/1995";
            // 
            // lblHistoriaReparacionInicioHora
            // 
            this.lblHistoriaReparacionInicioHora.AutoSize = true;
            this.lblHistoriaReparacionInicioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionInicioHora.Location = new System.Drawing.Point(201, 32);
            this.lblHistoriaReparacionInicioHora.Name = "lblHistoriaReparacionInicioHora";
            this.lblHistoriaReparacionInicioHora.Size = new System.Drawing.Size(43, 15);
            this.lblHistoriaReparacionInicioHora.TabIndex = 206;
            this.lblHistoriaReparacionInicioHora.Text = "00:00";
            // 
            // lblHistoriaReparacionFinHora
            // 
            this.lblHistoriaReparacionFinHora.AutoSize = true;
            this.lblHistoriaReparacionFinHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaReparacionFinHora.Location = new System.Drawing.Point(201, 59);
            this.lblHistoriaReparacionFinHora.Name = "lblHistoriaReparacionFinHora";
            this.lblHistoriaReparacionFinHora.Size = new System.Drawing.Size(43, 15);
            this.lblHistoriaReparacionFinHora.TabIndex = 207;
            this.lblHistoriaReparacionFinHora.Text = "00:00";
            // 
            // FrmHistoriaReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.lblHistoriaReparacionTituloRepuestos);
            this.Controls.Add(this.dgvHistoriaReparacionRepuestos);
            this.Controls.Add(this.gpxHistoriaReparacion);
            this.Controls.Add(this.cbxHistoriaReparacionMecanico);
            this.Controls.Add(this.lblHistoriaReparacionMecanico);
            this.Controls.Add(this.cbxHistoriaReparacionTipoTrabajo);
            this.Controls.Add(this.lblHistoriaReparacionTipoTrabajo);
            this.Controls.Add(this.cbxHistoriaReparacionInt);
            this.Controls.Add(this.lblHistoriaReparacionInterno);
            this.Controls.Add(this.btnHistoriaReparacionCerrar);
            this.Controls.Add(this.btnHistoriaReparacionOK);
            this.Controls.Add(this.cbxHistoriaReparacionChofer);
            this.Controls.Add(this.cbxHistoriaReparacionTipo);
            this.Controls.Add(this.lblHistoriaReparacionChofer);
            this.Controls.Add(this.tbxHistoriaReparacionDetalle);
            this.Controls.Add(this.lblHistoriaReparacionDetalle);
            this.Controls.Add(this.lblHistoriaReparacionTipo);
            this.Controls.Add(this.lblHistoriaReparacionTitulo);
            this.Name = "FrmHistoriaReparacion";
            this.Text = "FrmHistoriaReparacion";
            this.Load += new System.EventHandler(this.FrmHistoriaReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaReparacionRepuestos)).EndInit();
            this.gpxHistoriaReparacion.ResumeLayout(false);
            this.gpxHistoriaReparacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoriaReparacionTituloRepuestos;
        private System.Windows.Forms.DataGridView dgvHistoriaReparacionRepuestos;
        private System.Windows.Forms.GroupBox gpxHistoriaReparacion;
        private System.Windows.Forms.Label lblHistoriaReparacionFinHs;
        private System.Windows.Forms.Label lblHistoriaReparacionInicioHs;
        private System.Windows.Forms.Label lblHistoriaReparacionFin;
        private System.Windows.Forms.Label lblHistoriaReparacionInicio;
        private System.Windows.Forms.ComboBox cbxHistoriaReparacionMecanico;
        private System.Windows.Forms.Label lblHistoriaReparacionMecanico;
        private System.Windows.Forms.ComboBox cbxHistoriaReparacionTipoTrabajo;
        private System.Windows.Forms.Label lblHistoriaReparacionTipoTrabajo;
        private System.Windows.Forms.ComboBox cbxHistoriaReparacionInt;
        private System.Windows.Forms.Label lblHistoriaReparacionInterno;
        private System.Windows.Forms.Button btnHistoriaReparacionCerrar;
        private System.Windows.Forms.Button btnHistoriaReparacionOK;
        private System.Windows.Forms.ComboBox cbxHistoriaReparacionChofer;
        private System.Windows.Forms.ComboBox cbxHistoriaReparacionTipo;
        private System.Windows.Forms.Label lblHistoriaReparacionChofer;
        private System.Windows.Forms.TextBox tbxHistoriaReparacionDetalle;
        private System.Windows.Forms.Label lblHistoriaReparacionDetalle;
        private System.Windows.Forms.Label lblHistoriaReparacionTipo;
        private System.Windows.Forms.Label lblHistoriaReparacionTitulo;
        private System.Windows.Forms.Label lblHistoriaReparacionInicioFecha;
        private System.Windows.Forms.Label lblHistoriaReparacionFinFecha;
        private System.Windows.Forms.Label lblHistoriaReparacionFinHora;
        private System.Windows.Forms.Label lblHistoriaReparacionInicioHora;
    }
}