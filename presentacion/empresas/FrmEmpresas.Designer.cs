namespace presentacion.empresas
{
    partial class FrmEmpresas
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
            this.btnEmpresasNuevo = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.tbxEmpresasFiltro = new System.Windows.Forms.TextBox();
            this.lblEmpresasFiltro = new System.Windows.Forms.Label();
            this.lblEmpresasTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpresasNuevo
            // 
            this.btnEmpresasNuevo.Location = new System.Drawing.Point(532, 69);
            this.btnEmpresasNuevo.Name = "btnEmpresasNuevo";
            this.btnEmpresasNuevo.Size = new System.Drawing.Size(101, 23);
            this.btnEmpresasNuevo.TabIndex = 19;
            this.btnEmpresasNuevo.Text = "Agregar Empresa";
            this.btnEmpresasNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpresas.Location = new System.Drawing.Point(13, 98);
            this.dgvEmpresas.MultiSelect = false;
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.Size = new System.Drawing.Size(620, 298);
            this.dgvEmpresas.TabIndex = 18;
            // 
            // tbxEmpresasFiltro
            // 
            this.tbxEmpresasFiltro.Location = new System.Drawing.Point(51, 72);
            this.tbxEmpresasFiltro.Name = "tbxEmpresasFiltro";
            this.tbxEmpresasFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxEmpresasFiltro.TabIndex = 17;
            // 
            // lblEmpresasFiltro
            // 
            this.lblEmpresasFiltro.AutoSize = true;
            this.lblEmpresasFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresasFiltro.Location = new System.Drawing.Point(11, 76);
            this.lblEmpresasFiltro.Name = "lblEmpresasFiltro";
            this.lblEmpresasFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblEmpresasFiltro.TabIndex = 16;
            this.lblEmpresasFiltro.Text = "Filtro";
            // 
            // lblEmpresasTitulo
            // 
            this.lblEmpresasTitulo.AutoSize = true;
            this.lblEmpresasTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresasTitulo.Location = new System.Drawing.Point(187, 15);
            this.lblEmpresasTitulo.Name = "lblEmpresasTitulo";
            this.lblEmpresasTitulo.Size = new System.Drawing.Size(271, 34);
            this.lblEmpresasTitulo.TabIndex = 15;
            this.lblEmpresasTitulo.Text = "EMPRESAS PROPIAS";
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnEmpresasNuevo);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.tbxEmpresasFiltro);
            this.Controls.Add(this.lblEmpresasFiltro);
            this.Controls.Add(this.lblEmpresasTitulo);
            this.Name = "FrmEmpresas";
            this.Text = "FrmEmpresas";
            this.Load += new System.EventHandler(this.FrmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresasNuevo;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TextBox tbxEmpresasFiltro;
        private System.Windows.Forms.Label lblEmpresasFiltro;
        private System.Windows.Forms.Label lblEmpresasTitulo;
    }
}