namespace presentacion.reparaciones
{
    partial class FrmReparaciones
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
            this.btnReparacionesNuevo = new System.Windows.Forms.Button();
            this.dgvReparaciones = new System.Windows.Forms.DataGridView();
            this.tbxReparacionesFiltro = new System.Windows.Forms.TextBox();
            this.lblReparacionesFiltro = new System.Windows.Forms.Label();
            this.lblReparacionesSubtitulo2 = new System.Windows.Forms.Label();
            this.dgvReparacionesFinalizadas = new System.Windows.Forms.DataGridView();
            this.tbxReparacionesFinalizadasFiltro = new System.Windows.Forms.TextBox();
            this.lblReparacionesFinalizadasFiltro = new System.Windows.Forms.Label();
            this.lblReparacionesSubtitulo3 = new System.Windows.Forms.Label();
            this.lblReparacionesSubtitulo = new System.Windows.Forms.Label();
            this.lblReparacionesTituloa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacionesFinalizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReparacionesNuevo
            // 
            this.btnReparacionesNuevo.Location = new System.Drawing.Point(508, 93);
            this.btnReparacionesNuevo.Name = "btnReparacionesNuevo";
            this.btnReparacionesNuevo.Size = new System.Drawing.Size(63, 23);
            this.btnReparacionesNuevo.TabIndex = 22;
            this.btnReparacionesNuevo.Text = "Nuevo";
            this.btnReparacionesNuevo.UseVisualStyleBackColor = true;
            this.btnReparacionesNuevo.Click += new System.EventHandler(this.btnReparacionesNuevo_Click);
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReparaciones.Location = new System.Drawing.Point(14, 121);
            this.dgvReparaciones.MultiSelect = false;
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(684, 186);
            this.dgvReparaciones.TabIndex = 21;
            this.dgvReparaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparaciones_CellDoubleClick);
            // 
            // tbxReparacionesFiltro
            // 
            this.tbxReparacionesFiltro.Location = new System.Drawing.Point(210, 95);
            this.tbxReparacionesFiltro.Name = "tbxReparacionesFiltro";
            this.tbxReparacionesFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxReparacionesFiltro.TabIndex = 20;
            this.tbxReparacionesFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxReparacionesFiltro_KeyPress);
            // 
            // lblReparacionesFiltro
            // 
            this.lblReparacionesFiltro.AutoSize = true;
            this.lblReparacionesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesFiltro.Location = new System.Drawing.Point(170, 99);
            this.lblReparacionesFiltro.Name = "lblReparacionesFiltro";
            this.lblReparacionesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblReparacionesFiltro.TabIndex = 19;
            this.lblReparacionesFiltro.Text = "Filtro";
            // 
            // lblReparacionesSubtitulo2
            // 
            this.lblReparacionesSubtitulo2.AutoSize = true;
            this.lblReparacionesSubtitulo2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesSubtitulo2.Location = new System.Drawing.Point(17, 91);
            this.lblReparacionesSubtitulo2.Name = "lblReparacionesSubtitulo2";
            this.lblReparacionesSubtitulo2.Size = new System.Drawing.Size(142, 28);
            this.lblReparacionesSubtitulo2.TabIndex = 18;
            this.lblReparacionesSubtitulo2.Text = "PENDIENTES";
            // 
            // dgvReparacionesFinalizadas
            // 
            this.dgvReparacionesFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparacionesFinalizadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReparacionesFinalizadas.Location = new System.Drawing.Point(14, 363);
            this.dgvReparacionesFinalizadas.MultiSelect = false;
            this.dgvReparacionesFinalizadas.Name = "dgvReparacionesFinalizadas";
            this.dgvReparacionesFinalizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparacionesFinalizadas.Size = new System.Drawing.Size(684, 186);
            this.dgvReparacionesFinalizadas.TabIndex = 25;
            this.dgvReparacionesFinalizadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparacionesFinalizadas_CellDoubleClick);
            // 
            // tbxReparacionesFinalizadasFiltro
            // 
            this.tbxReparacionesFinalizadasFiltro.Location = new System.Drawing.Point(224, 337);
            this.tbxReparacionesFinalizadasFiltro.Name = "tbxReparacionesFinalizadasFiltro";
            this.tbxReparacionesFinalizadasFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxReparacionesFinalizadasFiltro.TabIndex = 24;
            this.tbxReparacionesFinalizadasFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxReparacionesFinalizadasFiltro_KeyPress);
            // 
            // lblReparacionesFinalizadasFiltro
            // 
            this.lblReparacionesFinalizadasFiltro.AutoSize = true;
            this.lblReparacionesFinalizadasFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesFinalizadasFiltro.Location = new System.Drawing.Point(184, 341);
            this.lblReparacionesFinalizadasFiltro.Name = "lblReparacionesFinalizadasFiltro";
            this.lblReparacionesFinalizadasFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblReparacionesFinalizadasFiltro.TabIndex = 23;
            this.lblReparacionesFinalizadasFiltro.Text = "Filtro";
            // 
            // lblReparacionesSubtitulo3
            // 
            this.lblReparacionesSubtitulo3.AutoSize = true;
            this.lblReparacionesSubtitulo3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesSubtitulo3.Location = new System.Drawing.Point(17, 332);
            this.lblReparacionesSubtitulo3.Name = "lblReparacionesSubtitulo3";
            this.lblReparacionesSubtitulo3.Size = new System.Drawing.Size(155, 28);
            this.lblReparacionesSubtitulo3.TabIndex = 27;
            this.lblReparacionesSubtitulo3.Text = "FINALIZADAS";
            // 
            // lblReparacionesSubtitulo
            // 
            this.lblReparacionesSubtitulo.AutoSize = true;
            this.lblReparacionesSubtitulo.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesSubtitulo.Location = new System.Drawing.Point(16, 46);
            this.lblReparacionesSubtitulo.Name = "lblReparacionesSubtitulo";
            this.lblReparacionesSubtitulo.Size = new System.Drawing.Size(360, 19);
            this.lblReparacionesSubtitulo.TabIndex = 29;
            this.lblReparacionesSubtitulo.Text = "Arreglos, cambios y trabajos realizados";
            // 
            // lblReparacionesTituloa
            // 
            this.lblReparacionesTituloa.AutoSize = true;
            this.lblReparacionesTituloa.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesTituloa.Location = new System.Drawing.Point(12, 9);
            this.lblReparacionesTituloa.Name = "lblReparacionesTituloa";
            this.lblReparacionesTituloa.Size = new System.Drawing.Size(360, 41);
            this.lblReparacionesTituloa.TabIndex = 28;
            this.lblReparacionesTituloa.Text = "REGISTRO DE TALLER";
            // 
            // FrmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.lblReparacionesSubtitulo);
            this.Controls.Add(this.lblReparacionesTituloa);
            this.Controls.Add(this.lblReparacionesSubtitulo3);
            this.Controls.Add(this.dgvReparacionesFinalizadas);
            this.Controls.Add(this.tbxReparacionesFinalizadasFiltro);
            this.Controls.Add(this.lblReparacionesFinalizadasFiltro);
            this.Controls.Add(this.btnReparacionesNuevo);
            this.Controls.Add(this.dgvReparaciones);
            this.Controls.Add(this.tbxReparacionesFiltro);
            this.Controls.Add(this.lblReparacionesFiltro);
            this.Controls.Add(this.lblReparacionesSubtitulo2);
            this.Name = "FrmReparaciones";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.FrmReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacionesFinalizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReparacionesNuevo;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.TextBox tbxReparacionesFiltro;
        private System.Windows.Forms.Label lblReparacionesFiltro;
        private System.Windows.Forms.Label lblReparacionesSubtitulo2;
        private System.Windows.Forms.DataGridView dgvReparacionesFinalizadas;
        private System.Windows.Forms.TextBox tbxReparacionesFinalizadasFiltro;
        private System.Windows.Forms.Label lblReparacionesFinalizadasFiltro;
        private System.Windows.Forms.Label lblReparacionesSubtitulo3;
        private System.Windows.Forms.Label lblReparacionesSubtitulo;
        private System.Windows.Forms.Label lblReparacionesTituloa;
    }
}