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
            this.lblVehiculosSubtituloF = new System.Windows.Forms.Label();
            this.lblVehiculosSubTituloT = new System.Windows.Forms.Label();
            this.btnVehiculosF = new System.Windows.Forms.Button();
            this.dgvVehiculosF = new System.Windows.Forms.DataGridView();
            this.tbxVehiculosF = new System.Windows.Forms.TextBox();
            this.lblVehiculosFiltroF = new System.Windows.Forms.Label();
            this.btnVehiculosT = new System.Windows.Forms.Button();
            this.dgvVehiculosT = new System.Windows.Forms.DataGridView();
            this.tbxVehiculosT = new System.Windows.Forms.TextBox();
            this.lblVehiculosFiltroT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiculosSubtituloF
            // 
            this.lblVehiculosSubtituloF.AutoSize = true;
            this.lblVehiculosSubtituloF.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubtituloF.Location = new System.Drawing.Point(412, 15);
            this.lblVehiculosSubtituloF.Name = "lblVehiculosSubtituloF";
            this.lblVehiculosSubtituloF.Size = new System.Drawing.Size(116, 28);
            this.lblVehiculosSubtituloF.TabIndex = 29;
            this.lblVehiculosSubtituloF.Text = "Furgones";
            // 
            // lblVehiculosSubTituloT
            // 
            this.lblVehiculosSubTituloT.AutoSize = true;
            this.lblVehiculosSubTituloT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubTituloT.Location = new System.Drawing.Point(95, 15);
            this.lblVehiculosSubTituloT.Name = "lblVehiculosSubTituloT";
            this.lblVehiculosSubTituloT.Size = new System.Drawing.Size(129, 28);
            this.lblVehiculosSubTituloT.TabIndex = 28;
            this.lblVehiculosSubTituloT.Text = "Tractores";
            // 
            // btnVehiculosF
            // 
            this.btnVehiculosF.Location = new System.Drawing.Point(538, 60);
            this.btnVehiculosF.Name = "btnVehiculosF";
            this.btnVehiculosF.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosF.TabIndex = 27;
            this.btnVehiculosF.Text = "Agregar";
            this.btnVehiculosF.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculosF
            // 
            this.dgvVehiculosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosF.Location = new System.Drawing.Point(327, 88);
            this.dgvVehiculosF.MultiSelect = false;
            this.dgvVehiculosF.Name = "dgvVehiculosF";
            this.dgvVehiculosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosF.Size = new System.Drawing.Size(272, 311);
            this.dgvVehiculosF.TabIndex = 26;
            // 
            // tbxVehiculosF
            // 
            this.tbxVehiculosF.Location = new System.Drawing.Point(327, 62);
            this.tbxVehiculosF.Name = "tbxVehiculosF";
            this.tbxVehiculosF.Size = new System.Drawing.Size(205, 20);
            this.tbxVehiculosF.TabIndex = 25;
            // 
            // lblVehiculosFiltroF
            // 
            this.lblVehiculosFiltroF.AutoSize = true;
            this.lblVehiculosFiltroF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosFiltroF.Location = new System.Drawing.Point(334, 47);
            this.lblVehiculosFiltroF.Name = "lblVehiculosFiltroF";
            this.lblVehiculosFiltroF.Size = new System.Drawing.Size(34, 12);
            this.lblVehiculosFiltroF.TabIndex = 24;
            this.lblVehiculosFiltroF.Text = "Filtro";
            // 
            // btnVehiculosT
            // 
            this.btnVehiculosT.Location = new System.Drawing.Point(235, 61);
            this.btnVehiculosT.Name = "btnVehiculosT";
            this.btnVehiculosT.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosT.TabIndex = 22;
            this.btnVehiculosT.Text = "Agregar";
            this.btnVehiculosT.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculosT
            // 
            this.dgvVehiculosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosT.Location = new System.Drawing.Point(24, 88);
            this.dgvVehiculosT.MultiSelect = false;
            this.dgvVehiculosT.Name = "dgvVehiculosT";
            this.dgvVehiculosT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosT.Size = new System.Drawing.Size(272, 311);
            this.dgvVehiculosT.TabIndex = 21;
            // 
            // tbxVehiculosT
            // 
            this.tbxVehiculosT.Location = new System.Drawing.Point(24, 62);
            this.tbxVehiculosT.Name = "tbxVehiculosT";
            this.tbxVehiculosT.Size = new System.Drawing.Size(205, 20);
            this.tbxVehiculosT.TabIndex = 20;
            // 
            // lblVehiculosFiltroT
            // 
            this.lblVehiculosFiltroT.AutoSize = true;
            this.lblVehiculosFiltroT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosFiltroT.Location = new System.Drawing.Point(24, 47);
            this.lblVehiculosFiltroT.Name = "lblVehiculosFiltroT";
            this.lblVehiculosFiltroT.Size = new System.Drawing.Size(34, 12);
            this.lblVehiculosFiltroT.TabIndex = 19;
            this.lblVehiculosFiltroT.Text = "Filtro";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.lblVehiculosSubtituloF);
            this.Controls.Add(this.lblVehiculosSubTituloT);
            this.Controls.Add(this.btnVehiculosF);
            this.Controls.Add(this.dgvVehiculosF);
            this.Controls.Add(this.tbxVehiculosF);
            this.Controls.Add(this.lblVehiculosFiltroF);
            this.Controls.Add(this.btnVehiculosT);
            this.Controls.Add(this.dgvVehiculosT);
            this.Controls.Add(this.tbxVehiculosT);
            this.Controls.Add(this.lblVehiculosFiltroT);
            this.Name = "FrmVehiculos";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculosSubtituloF;
        private System.Windows.Forms.Label lblVehiculosSubTituloT;
        private System.Windows.Forms.Button btnVehiculosF;
        private System.Windows.Forms.DataGridView dgvVehiculosF;
        private System.Windows.Forms.TextBox tbxVehiculosF;
        private System.Windows.Forms.Label lblVehiculosFiltroF;
        private System.Windows.Forms.Button btnVehiculosT;
        private System.Windows.Forms.DataGridView dgvVehiculosT;
        private System.Windows.Forms.TextBox tbxVehiculosT;
        private System.Windows.Forms.Label lblVehiculosFiltroT;
    }
}