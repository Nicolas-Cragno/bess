namespace presentacion.eventos
{
    partial class FrmEvento
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
            this.btnEventosNuevo = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.tbxEventosFiltro = new System.Windows.Forms.TextBox();
            this.lblEventosFiltro = new System.Windows.Forms.Label();
            this.lblEventosTitulo = new System.Windows.Forms.Label();
            this.lblMovimientosSubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventosNuevo
            // 
            this.btnEventosNuevo.Location = new System.Drawing.Point(355, 93);
            this.btnEventosNuevo.Name = "btnEventosNuevo";
            this.btnEventosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnEventosNuevo.TabIndex = 17;
            this.btnEventosNuevo.Text = "Agregar Evento";
            this.btnEventosNuevo.UseVisualStyleBackColor = true;
            this.btnEventosNuevo.Click += new System.EventHandler(this.btnEventosNuevo_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEventos.Location = new System.Drawing.Point(14, 121);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(684, 557);
            this.dgvEventos.TabIndex = 16;
            this.dgvEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellDoubleClick);
            // 
            // tbxEventosFiltro
            // 
            this.tbxEventosFiltro.Location = new System.Drawing.Point(57, 95);
            this.tbxEventosFiltro.Name = "tbxEventosFiltro";
            this.tbxEventosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxEventosFiltro.TabIndex = 15;
            this.tbxEventosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEventosFiltro_KeyPress);
            // 
            // lblEventosFiltro
            // 
            this.lblEventosFiltro.AutoSize = true;
            this.lblEventosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosFiltro.Location = new System.Drawing.Point(17, 99);
            this.lblEventosFiltro.Name = "lblEventosFiltro";
            this.lblEventosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblEventosFiltro.TabIndex = 14;
            this.lblEventosFiltro.Text = "Filtro";
            // 
            // lblEventosTitulo
            // 
            this.lblEventosTitulo.AutoSize = true;
            this.lblEventosTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblEventosTitulo.Name = "lblEventosTitulo";
            this.lblEventosTitulo.Size = new System.Drawing.Size(379, 41);
            this.lblEventosTitulo.TabIndex = 13;
            this.lblEventosTitulo.Text = "REGISTRO DE EVENTOS";
            // 
            // lblMovimientosSubtitulo
            // 
            this.lblMovimientosSubtitulo.AutoSize = true;
            this.lblMovimientosSubtitulo.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosSubtitulo.Location = new System.Drawing.Point(15, 50);
            this.lblMovimientosSubtitulo.Name = "lblMovimientosSubtitulo";
            this.lblMovimientosSubtitulo.Size = new System.Drawing.Size(432, 19);
            this.lblMovimientosSubtitulo.TabIndex = 25;
            this.lblMovimientosSubtitulo.Text = "Sucesos relacionados con vehiculos y/o personal";
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.lblMovimientosSubtitulo);
            this.Controls.Add(this.btnEventosNuevo);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.tbxEventosFiltro);
            this.Controls.Add(this.lblEventosFiltro);
            this.Controls.Add(this.lblEventosTitulo);
            this.Name = "FrmEvento";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FrmEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventosNuevo;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox tbxEventosFiltro;
        private System.Windows.Forms.Label lblEventosFiltro;
        private System.Windows.Forms.Label lblEventosTitulo;
        private System.Windows.Forms.Label lblMovimientosSubtitulo;
    }
}