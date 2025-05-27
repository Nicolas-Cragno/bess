namespace presentacion.empresas
{
    partial class FrmClientes
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
            this.btnClientesNuevo = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbxClientesFiltro = new System.Windows.Forms.TextBox();
            this.lblClientesFiltro = new System.Windows.Forms.Label();
            this.lblClientesTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientesNuevo
            // 
            this.btnClientesNuevo.Location = new System.Drawing.Point(532, 69);
            this.btnClientesNuevo.Name = "btnClientesNuevo";
            this.btnClientesNuevo.Size = new System.Drawing.Size(101, 23);
            this.btnClientesNuevo.TabIndex = 24;
            this.btnClientesNuevo.Text = "Agregar Empresa";
            this.btnClientesNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(13, 98);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(620, 298);
            this.dgvClientes.TabIndex = 23;
            // 
            // tbxClientesFiltro
            // 
            this.tbxClientesFiltro.Location = new System.Drawing.Point(51, 72);
            this.tbxClientesFiltro.Name = "tbxClientesFiltro";
            this.tbxClientesFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxClientesFiltro.TabIndex = 22;
            // 
            // lblClientesFiltro
            // 
            this.lblClientesFiltro.AutoSize = true;
            this.lblClientesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesFiltro.Location = new System.Drawing.Point(11, 76);
            this.lblClientesFiltro.Name = "lblClientesFiltro";
            this.lblClientesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblClientesFiltro.TabIndex = 21;
            this.lblClientesFiltro.Text = "Filtro";
            // 
            // lblClientesTitulo
            // 
            this.lblClientesTitulo.AutoSize = true;
            this.lblClientesTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesTitulo.Location = new System.Drawing.Point(251, 15);
            this.lblClientesTitulo.Name = "lblClientesTitulo";
            this.lblClientesTitulo.Size = new System.Drawing.Size(143, 34);
            this.lblClientesTitulo.TabIndex = 20;
            this.lblClientesTitulo.Text = "CLIENTES";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnClientesNuevo);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.tbxClientesFiltro);
            this.Controls.Add(this.lblClientesFiltro);
            this.Controls.Add(this.lblClientesTitulo);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientesNuevo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbxClientesFiltro;
        private System.Windows.Forms.Label lblClientesFiltro;
        private System.Windows.Forms.Label lblClientesTitulo;
    }
}