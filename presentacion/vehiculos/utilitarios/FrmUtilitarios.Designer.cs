namespace presentacion.utilitarios
{
    partial class FrmUtilitarios
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
            this.btnUtilitariosNuevo = new System.Windows.Forms.Button();
            this.dgvUtilitarios = new System.Windows.Forms.DataGridView();
            this.tbxUtilitariosFiltro = new System.Windows.Forms.TextBox();
            this.lblUtilitariosFiltro = new System.Windows.Forms.Label();
            this.lblUtilitariosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilitarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUtilitariosNuevo
            // 
            this.btnUtilitariosNuevo.Location = new System.Drawing.Point(528, 69);
            this.btnUtilitariosNuevo.Name = "btnUtilitariosNuevo";
            this.btnUtilitariosNuevo.Size = new System.Drawing.Size(105, 23);
            this.btnUtilitariosNuevo.TabIndex = 19;
            this.btnUtilitariosNuevo.Text = "Agregar Vehiculo";
            this.btnUtilitariosNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvUtilitarios
            // 
            this.dgvUtilitarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilitarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUtilitarios.Location = new System.Drawing.Point(13, 98);
            this.dgvUtilitarios.MultiSelect = false;
            this.dgvUtilitarios.Name = "dgvUtilitarios";
            this.dgvUtilitarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilitarios.Size = new System.Drawing.Size(620, 298);
            this.dgvUtilitarios.TabIndex = 18;
            // 
            // tbxUtilitariosFiltro
            // 
            this.tbxUtilitariosFiltro.Location = new System.Drawing.Point(51, 72);
            this.tbxUtilitariosFiltro.Name = "tbxUtilitariosFiltro";
            this.tbxUtilitariosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxUtilitariosFiltro.TabIndex = 17;
            // 
            // lblUtilitariosFiltro
            // 
            this.lblUtilitariosFiltro.AutoSize = true;
            this.lblUtilitariosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilitariosFiltro.Location = new System.Drawing.Point(11, 76);
            this.lblUtilitariosFiltro.Name = "lblUtilitariosFiltro";
            this.lblUtilitariosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblUtilitariosFiltro.TabIndex = 16;
            this.lblUtilitariosFiltro.Text = "Filtro";
            // 
            // lblUtilitariosTitulo
            // 
            this.lblUtilitariosTitulo.AutoSize = true;
            this.lblUtilitariosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilitariosTitulo.Location = new System.Drawing.Point(147, 15);
            this.lblUtilitariosTitulo.Name = "lblUtilitariosTitulo";
            this.lblUtilitariosTitulo.Size = new System.Drawing.Size(351, 34);
            this.lblUtilitariosTitulo.TabIndex = 15;
            this.lblUtilitariosTitulo.Text = "VEHICULOS UTILITARIOS";
            // 
            // FrmUtilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnUtilitariosNuevo);
            this.Controls.Add(this.dgvUtilitarios);
            this.Controls.Add(this.tbxUtilitariosFiltro);
            this.Controls.Add(this.lblUtilitariosFiltro);
            this.Controls.Add(this.lblUtilitariosTitulo);
            this.Name = "FrmUtilitarios";
            this.Text = "FrmUtilitarios";
            this.Load += new System.EventHandler(this.FrmUtilitarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilitarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUtilitariosNuevo;
        private System.Windows.Forms.DataGridView dgvUtilitarios;
        private System.Windows.Forms.TextBox tbxUtilitariosFiltro;
        private System.Windows.Forms.Label lblUtilitariosFiltro;
        private System.Windows.Forms.Label lblUtilitariosTitulo;
    }
}