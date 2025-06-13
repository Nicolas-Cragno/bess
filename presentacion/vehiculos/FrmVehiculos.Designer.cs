namespace presentacion.vehiculos
{
    partial class FrmVehiculos
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
            this.btnVehiculosNuevo = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.tbxVehiculos = new System.Windows.Forms.TextBox();
            this.lblVehiculosTitulo = new System.Windows.Forms.Label();
            this.lblVehiculosFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVehiculosNuevo
            // 
            this.btnVehiculosNuevo.Location = new System.Drawing.Point(312, 94);
            this.btnVehiculosNuevo.Name = "btnVehiculosNuevo";
            this.btnVehiculosNuevo.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosNuevo.TabIndex = 22;
            this.btnVehiculosNuevo.Text = "Nuevo";
            this.btnVehiculosNuevo.UseVisualStyleBackColor = true;
            this.btnVehiculosNuevo.Click += new System.EventHandler(this.btnVehiculosT_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculos.Location = new System.Drawing.Point(14, 121);
            this.dgvVehiculos.MultiSelect = false;
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(684, 557);
            this.dgvVehiculos.TabIndex = 21;
            this.dgvVehiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosT_CellDoubleClick);
            // 
            // tbxVehiculos
            // 
            this.tbxVehiculos.Location = new System.Drawing.Point(14, 96);
            this.tbxVehiculos.Name = "tbxVehiculos";
            this.tbxVehiculos.Size = new System.Drawing.Size(292, 20);
            this.tbxVehiculos.TabIndex = 20;
            this.tbxVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehiculosT_KeyPress);
            // 
            // lblVehiculosTitulo
            // 
            this.lblVehiculosTitulo.AutoSize = true;
            this.lblVehiculosTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblVehiculosTitulo.Name = "lblVehiculosTitulo";
            this.lblVehiculosTitulo.Size = new System.Drawing.Size(322, 41);
            this.lblVehiculosTitulo.TabIndex = 30;
            this.lblVehiculosTitulo.Text = "TIPO DE VEHICULO";
            // 
            // lblVehiculosFiltro
            // 
            this.lblVehiculosFiltro.AutoSize = true;
            this.lblVehiculosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosFiltro.Location = new System.Drawing.Point(17, 81);
            this.lblVehiculosFiltro.Name = "lblVehiculosFiltro";
            this.lblVehiculosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblVehiculosFiltro.TabIndex = 31;
            this.lblVehiculosFiltro.Text = "Filtro";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 691);
            this.Controls.Add(this.lblVehiculosFiltro);
            this.Controls.Add(this.lblVehiculosTitulo);
            this.Controls.Add(this.btnVehiculosNuevo);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.tbxVehiculos);
            this.Name = "FrmVehiculos";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVehiculosNuevo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.TextBox tbxVehiculos;
        private System.Windows.Forms.Label lblVehiculosTitulo;
        private System.Windows.Forms.Label lblVehiculosFiltro;
    }
}