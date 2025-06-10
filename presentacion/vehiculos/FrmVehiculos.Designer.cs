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
            this.btnVehiculosT = new System.Windows.Forms.Button();
            this.dgvVehiculosT = new System.Windows.Forms.DataGridView();
            this.tbxVehiculosT = new System.Windows.Forms.TextBox();
            this.lblVehiculosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiculosSubtituloF
            // 
            this.lblVehiculosSubtituloF.AutoSize = true;
            this.lblVehiculosSubtituloF.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubtituloF.Location = new System.Drawing.Point(417, 69);
            this.lblVehiculosSubtituloF.Name = "lblVehiculosSubtituloF";
            this.lblVehiculosSubtituloF.Size = new System.Drawing.Size(106, 24);
            this.lblVehiculosSubtituloF.TabIndex = 29;
            this.lblVehiculosSubtituloF.Text = "Furgones";
            // 
            // lblVehiculosSubTituloT
            // 
            this.lblVehiculosSubTituloT.AutoSize = true;
            this.lblVehiculosSubTituloT.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSubTituloT.Location = new System.Drawing.Point(15, 69);
            this.lblVehiculosSubTituloT.Name = "lblVehiculosSubTituloT";
            this.lblVehiculosSubTituloT.Size = new System.Drawing.Size(118, 24);
            this.lblVehiculosSubTituloT.TabIndex = 28;
            this.lblVehiculosSubTituloT.Text = "Tractores";
            // 
            // btnVehiculosF
            // 
            this.btnVehiculosF.Location = new System.Drawing.Point(719, 94);
            this.btnVehiculosF.Name = "btnVehiculosF";
            this.btnVehiculosF.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosF.TabIndex = 27;
            this.btnVehiculosF.Text = "Nuevo";
            this.btnVehiculosF.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculosF
            // 
            this.dgvVehiculosF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosF.Location = new System.Drawing.Point(421, 121);
            this.dgvVehiculosF.MultiSelect = false;
            this.dgvVehiculosF.Name = "dgvVehiculosF";
            this.dgvVehiculosF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosF.Size = new System.Drawing.Size(359, 558);
            this.dgvVehiculosF.TabIndex = 26;
            // 
            // tbxVehiculosF
            // 
            this.tbxVehiculosF.Location = new System.Drawing.Point(421, 96);
            this.tbxVehiculosF.Name = "tbxVehiculosF";
            this.tbxVehiculosF.Size = new System.Drawing.Size(292, 20);
            this.tbxVehiculosF.TabIndex = 25;
            this.tbxVehiculosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehiculosF_KeyPress);
            // 
            // btnVehiculosT
            // 
            this.btnVehiculosT.Location = new System.Drawing.Point(312, 94);
            this.btnVehiculosT.Name = "btnVehiculosT";
            this.btnVehiculosT.Size = new System.Drawing.Size(61, 23);
            this.btnVehiculosT.TabIndex = 22;
            this.btnVehiculosT.Text = "Nuevo";
            this.btnVehiculosT.UseVisualStyleBackColor = true;
            this.btnVehiculosT.Click += new System.EventHandler(this.btnVehiculosT_Click);
            // 
            // dgvVehiculosT
            // 
            this.dgvVehiculosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculosT.Location = new System.Drawing.Point(14, 121);
            this.dgvVehiculosT.MultiSelect = false;
            this.dgvVehiculosT.Name = "dgvVehiculosT";
            this.dgvVehiculosT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosT.Size = new System.Drawing.Size(359, 558);
            this.dgvVehiculosT.TabIndex = 21;
            this.dgvVehiculosT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculosT_CellDoubleClick);
            // 
            // tbxVehiculosT
            // 
            this.tbxVehiculosT.Location = new System.Drawing.Point(14, 96);
            this.tbxVehiculosT.Name = "tbxVehiculosT";
            this.tbxVehiculosT.Size = new System.Drawing.Size(292, 20);
            this.tbxVehiculosT.TabIndex = 20;
            this.tbxVehiculosT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehiculosT_KeyPress);
            // 
            // lblVehiculosTitulo
            // 
            this.lblVehiculosTitulo.AutoSize = true;
            this.lblVehiculosTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblVehiculosTitulo.Name = "lblVehiculosTitulo";
            this.lblVehiculosTitulo.Size = new System.Drawing.Size(493, 41);
            this.lblVehiculosTitulo.TabIndex = 30;
            this.lblVehiculosTitulo.Text = "VEHICULOS LARGA DISTANCIA";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 691);
            this.Controls.Add(this.lblVehiculosTitulo);
            this.Controls.Add(this.lblVehiculosSubtituloF);
            this.Controls.Add(this.lblVehiculosSubTituloT);
            this.Controls.Add(this.btnVehiculosF);
            this.Controls.Add(this.dgvVehiculosF);
            this.Controls.Add(this.tbxVehiculosF);
            this.Controls.Add(this.btnVehiculosT);
            this.Controls.Add(this.dgvVehiculosT);
            this.Controls.Add(this.tbxVehiculosT);
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
        private System.Windows.Forms.Button btnVehiculosT;
        private System.Windows.Forms.DataGridView dgvVehiculosT;
        private System.Windows.Forms.TextBox tbxVehiculosT;
        private System.Windows.Forms.Label lblVehiculosTitulo;
    }
}