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
            this.lblReparacionesTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReparacionesNuevo
            // 
            this.btnReparacionesNuevo.Location = new System.Drawing.Point(540, 70);
            this.btnReparacionesNuevo.Name = "btnReparacionesNuevo";
            this.btnReparacionesNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnReparacionesNuevo.TabIndex = 22;
            this.btnReparacionesNuevo.Text = "Agregar Trabajo";
            this.btnReparacionesNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReparaciones.Location = new System.Drawing.Point(12, 98);
            this.dgvReparaciones.MultiSelect = false;
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(620, 298);
            this.dgvReparaciones.TabIndex = 21;
            // 
            // tbxReparacionesFiltro
            // 
            this.tbxReparacionesFiltro.Location = new System.Drawing.Point(54, 73);
            this.tbxReparacionesFiltro.Name = "tbxReparacionesFiltro";
            this.tbxReparacionesFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxReparacionesFiltro.TabIndex = 20;
            // 
            // lblReparacionesFiltro
            // 
            this.lblReparacionesFiltro.AutoSize = true;
            this.lblReparacionesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesFiltro.Location = new System.Drawing.Point(14, 77);
            this.lblReparacionesFiltro.Name = "lblReparacionesFiltro";
            this.lblReparacionesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblReparacionesFiltro.TabIndex = 19;
            this.lblReparacionesFiltro.Text = "Filtro";
            // 
            // lblReparacionesTitulo
            // 
            this.lblReparacionesTitulo.AutoSize = true;
            this.lblReparacionesTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparacionesTitulo.Location = new System.Drawing.Point(195, 15);
            this.lblReparacionesTitulo.Name = "lblReparacionesTitulo";
            this.lblReparacionesTitulo.Size = new System.Drawing.Size(255, 34);
            this.lblReparacionesTitulo.TabIndex = 18;
            this.lblReparacionesTitulo.Text = "REGISTRO TALLER";
            // 
            // FrmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnReparacionesNuevo);
            this.Controls.Add(this.dgvReparaciones);
            this.Controls.Add(this.tbxReparacionesFiltro);
            this.Controls.Add(this.lblReparacionesFiltro);
            this.Controls.Add(this.lblReparacionesTitulo);
            this.Name = "FrmReparaciones";
            this.Text = "FrmReparaciones";
            this.Load += new System.EventHandler(this.FrmReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReparacionesNuevo;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.TextBox tbxReparacionesFiltro;
        private System.Windows.Forms.Label lblReparacionesFiltro;
        private System.Windows.Forms.Label lblReparacionesTitulo;
    }
}