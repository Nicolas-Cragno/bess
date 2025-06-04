namespace presentacion.personas
{
    partial class FrmPersonasInactivas
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
            this.btnPersonasInactivasClose = new System.Windows.Forms.Button();
            this.dgvPersonasInactivas = new System.Windows.Forms.DataGridView();
            this.tbxPersonasInactivasFiltro = new System.Windows.Forms.TextBox();
            this.lblPersonasInactivasFiltro = new System.Windows.Forms.Label();
            this.lblPersonasInactivasTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasInactivas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonasInactivasClose
            // 
            this.btnPersonasInactivasClose.Location = new System.Drawing.Point(450, 344);
            this.btnPersonasInactivasClose.Name = "btnPersonasInactivasClose";
            this.btnPersonasInactivasClose.Size = new System.Drawing.Size(51, 23);
            this.btnPersonasInactivasClose.TabIndex = 17;
            this.btnPersonasInactivasClose.Text = "Cerrar";
            this.btnPersonasInactivasClose.UseVisualStyleBackColor = true;
            this.btnPersonasInactivasClose.Click += new System.EventHandler(this.btnPersonasInactivasClose_Click);
            // 
            // dgvPersonasInactivas
            // 
            this.dgvPersonasInactivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasInactivas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonasInactivas.Location = new System.Drawing.Point(14, 93);
            this.dgvPersonasInactivas.MultiSelect = false;
            this.dgvPersonasInactivas.Name = "dgvPersonasInactivas";
            this.dgvPersonasInactivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonasInactivas.Size = new System.Drawing.Size(487, 245);
            this.dgvPersonasInactivas.TabIndex = 16;
            // 
            // tbxPersonasInactivasFiltro
            // 
            this.tbxPersonasInactivasFiltro.Location = new System.Drawing.Point(14, 67);
            this.tbxPersonasInactivasFiltro.Name = "tbxPersonasInactivasFiltro";
            this.tbxPersonasInactivasFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxPersonasInactivasFiltro.TabIndex = 15;
            this.tbxPersonasInactivasFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPersonasInactivasFiltro_KeyPress);
            // 
            // lblPersonasInactivasFiltro
            // 
            this.lblPersonasInactivasFiltro.AutoSize = true;
            this.lblPersonasInactivasFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasInactivasFiltro.Location = new System.Drawing.Point(12, 52);
            this.lblPersonasInactivasFiltro.Name = "lblPersonasInactivasFiltro";
            this.lblPersonasInactivasFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblPersonasInactivasFiltro.TabIndex = 14;
            this.lblPersonasInactivasFiltro.Text = "Filtro";
            // 
            // lblPersonasInactivasTitulo
            // 
            this.lblPersonasInactivasTitulo.AutoSize = true;
            this.lblPersonasInactivasTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasInactivasTitulo.Location = new System.Drawing.Point(177, 7);
            this.lblPersonasInactivasTitulo.Name = "lblPersonasInactivasTitulo";
            this.lblPersonasInactivasTitulo.Size = new System.Drawing.Size(159, 34);
            this.lblPersonasInactivasTitulo.TabIndex = 13;
            this.lblPersonasInactivasTitulo.Text = "INACTIVOS";
            // 
            // FrmPersonasInactivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 375);
            this.Controls.Add(this.btnPersonasInactivasClose);
            this.Controls.Add(this.dgvPersonasInactivas);
            this.Controls.Add(this.tbxPersonasInactivasFiltro);
            this.Controls.Add(this.lblPersonasInactivasFiltro);
            this.Controls.Add(this.lblPersonasInactivasTitulo);
            this.Name = "FrmPersonasInactivas";
            this.Text = "FrmPersonasInactivas";
            this.Load += new System.EventHandler(this.FrmPersonasInactivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasInactivas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonasInactivasClose;
        private System.Windows.Forms.DataGridView dgvPersonasInactivas;
        private System.Windows.Forms.TextBox tbxPersonasInactivasFiltro;
        private System.Windows.Forms.Label lblPersonasInactivasFiltro;
        private System.Windows.Forms.Label lblPersonasInactivasTitulo;
    }
}