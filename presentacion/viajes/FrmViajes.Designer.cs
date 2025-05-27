namespace presentacion.viajes
{
    partial class FrmViajes
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
            this.btnViajesNuevo = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.tbxViajesFiltro = new System.Windows.Forms.TextBox();
            this.lblViajesFiltro = new System.Windows.Forms.Label();
            this.lblViajesTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViajesNuevo
            // 
            this.btnViajesNuevo.Location = new System.Drawing.Point(540, 70);
            this.btnViajesNuevo.Name = "btnViajesNuevo";
            this.btnViajesNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnViajesNuevo.TabIndex = 22;
            this.btnViajesNuevo.Text = "Agregar Evento";
            this.btnViajesNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViajes.Location = new System.Drawing.Point(12, 98);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajes.Size = new System.Drawing.Size(620, 298);
            this.dgvViajes.TabIndex = 21;
            // 
            // tbxViajesFiltro
            // 
            this.tbxViajesFiltro.Location = new System.Drawing.Point(54, 73);
            this.tbxViajesFiltro.Name = "tbxViajesFiltro";
            this.tbxViajesFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxViajesFiltro.TabIndex = 20;
            // 
            // lblViajesFiltro
            // 
            this.lblViajesFiltro.AutoSize = true;
            this.lblViajesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajesFiltro.Location = new System.Drawing.Point(14, 77);
            this.lblViajesFiltro.Name = "lblViajesFiltro";
            this.lblViajesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblViajesFiltro.TabIndex = 19;
            this.lblViajesFiltro.Text = "Filtro";
            // 
            // lblViajesTitulo
            // 
            this.lblViajesTitulo.AutoSize = true;
            this.lblViajesTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajesTitulo.Location = new System.Drawing.Point(259, 15);
            this.lblViajesTitulo.Name = "lblViajesTitulo";
            this.lblViajesTitulo.Size = new System.Drawing.Size(111, 34);
            this.lblViajesTitulo.TabIndex = 18;
            this.lblViajesTitulo.Text = "VIAJES";
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnViajesNuevo);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.tbxViajesFiltro);
            this.Controls.Add(this.lblViajesFiltro);
            this.Controls.Add(this.lblViajesTitulo);
            this.Name = "FrmViajes";
            this.Text = "FrmViajes";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViajesNuevo;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.TextBox tbxViajesFiltro;
        private System.Windows.Forms.Label lblViajesFiltro;
        private System.Windows.Forms.Label lblViajesTitulo;
    }
}