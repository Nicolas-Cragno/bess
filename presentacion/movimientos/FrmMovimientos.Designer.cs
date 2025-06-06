namespace presentacion.movimientos
{
    partial class FrmMovimientos
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
            this.btnMovimientosNuevo = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.tbxMovimientosFiltro = new System.Windows.Forms.TextBox();
            this.lblMovimientosFiltro = new System.Windows.Forms.Label();
            this.lblMovimientosTitulo = new System.Windows.Forms.Label();
            this.lblMovimientosSubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovimientosNuevo
            // 
            this.btnMovimientosNuevo.Location = new System.Drawing.Point(355, 93);
            this.btnMovimientosNuevo.Name = "btnMovimientosNuevo";
            this.btnMovimientosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnMovimientosNuevo.TabIndex = 23;
            this.btnMovimientosNuevo.Text = "Agregar Nuevo";
            this.btnMovimientosNuevo.UseVisualStyleBackColor = true;
            this.btnMovimientosNuevo.Click += new System.EventHandler(this.btnMovimientosNuevo_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovimientos.Location = new System.Drawing.Point(14, 121);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(684, 557);
            this.dgvMovimientos.TabIndex = 22;
            this.dgvMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellContentClick);
            this.dgvMovimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellDoubleClick);
            // 
            // tbxMovimientosFiltro
            // 
            this.tbxMovimientosFiltro.Location = new System.Drawing.Point(57, 95);
            this.tbxMovimientosFiltro.Name = "tbxMovimientosFiltro";
            this.tbxMovimientosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxMovimientosFiltro.TabIndex = 21;
            this.tbxMovimientosFiltro.TextChanged += new System.EventHandler(this.tbxMovimientosFiltro_TextChanged);
            this.tbxMovimientosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMovimientosFiltro_KeyPress);
            // 
            // lblMovimientosFiltro
            // 
            this.lblMovimientosFiltro.AutoSize = true;
            this.lblMovimientosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosFiltro.Location = new System.Drawing.Point(17, 99);
            this.lblMovimientosFiltro.Name = "lblMovimientosFiltro";
            this.lblMovimientosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblMovimientosFiltro.TabIndex = 20;
            this.lblMovimientosFiltro.Text = "Filtro";
            this.lblMovimientosFiltro.Click += new System.EventHandler(this.lblMovimientosFiltro_Click);
            // 
            // lblMovimientosTitulo
            // 
            this.lblMovimientosTitulo.AutoSize = true;
            this.lblMovimientosTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblMovimientosTitulo.Name = "lblMovimientosTitulo";
            this.lblMovimientosTitulo.Size = new System.Drawing.Size(455, 41);
            this.lblMovimientosTitulo.TabIndex = 19;
            this.lblMovimientosTitulo.Text = "REGISTRO DE MOVIMIENTOS";
            this.lblMovimientosTitulo.Click += new System.EventHandler(this.lblMovimientosTitulo_Click);
            // 
            // lblMovimientosSubtitulo
            // 
            this.lblMovimientosSubtitulo.AutoSize = true;
            this.lblMovimientosSubtitulo.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosSubtitulo.Location = new System.Drawing.Point(16, 46);
            this.lblMovimientosSubtitulo.Name = "lblMovimientosSubtitulo";
            this.lblMovimientosSubtitulo.Size = new System.Drawing.Size(369, 19);
            this.lblMovimientosSubtitulo.TabIndex = 24;
            this.lblMovimientosSubtitulo.Text = "Entradas, salidas y movimientos internos";
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.lblMovimientosSubtitulo);
            this.Controls.Add(this.btnMovimientosNuevo);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.tbxMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosFiltro);
            this.Controls.Add(this.lblMovimientosTitulo);
            this.Name = "FrmMovimientos";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.FrmMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMovimientosNuevo;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.TextBox tbxMovimientosFiltro;
        private System.Windows.Forms.Label lblMovimientosFiltro;
        private System.Windows.Forms.Label lblMovimientosTitulo;
        private System.Windows.Forms.Label lblMovimientosSubtitulo;
    }
}