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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventosNuevo
            // 
            this.btnEventosNuevo.Location = new System.Drawing.Point(540, 73);
            this.btnEventosNuevo.Name = "btnEventosNuevo";
            this.btnEventosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnEventosNuevo.TabIndex = 17;
            this.btnEventosNuevo.Text = "Agregar Evento";
            this.btnEventosNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEventos.Location = new System.Drawing.Point(12, 101);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(620, 298);
            this.dgvEventos.TabIndex = 16;
            // 
            // tbxEventosFiltro
            // 
            this.tbxEventosFiltro.Location = new System.Drawing.Point(54, 76);
            this.tbxEventosFiltro.Name = "tbxEventosFiltro";
            this.tbxEventosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxEventosFiltro.TabIndex = 15;
            // 
            // lblEventosFiltro
            // 
            this.lblEventosFiltro.AutoSize = true;
            this.lblEventosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosFiltro.Location = new System.Drawing.Point(14, 80);
            this.lblEventosFiltro.Name = "lblEventosFiltro";
            this.lblEventosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblEventosFiltro.TabIndex = 14;
            this.lblEventosFiltro.Text = "Filtro";
            // 
            // lblEventosTitulo
            // 
            this.lblEventosTitulo.AutoSize = true;
            this.lblEventosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventosTitulo.Location = new System.Drawing.Point(259, 18);
            this.lblEventosTitulo.Name = "lblEventosTitulo";
            this.lblEventosTitulo.Size = new System.Drawing.Size(127, 34);
            this.lblEventosTitulo.TabIndex = 13;
            this.lblEventosTitulo.Text = "EVENTOS";
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnEventosNuevo);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.tbxEventosFiltro);
            this.Controls.Add(this.lblEventosFiltro);
            this.Controls.Add(this.lblEventosTitulo);
            this.Name = "FrmEvento";
            this.Text = "FrmEvento";
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
    }
}