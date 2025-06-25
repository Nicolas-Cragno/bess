namespace presentacion.articulos
{
    partial class FrmRepuestos
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
            this.btnRepuestosNuevo = new System.Windows.Forms.Button();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.tbxRepuestosFiltro = new System.Windows.Forms.TextBox();
            this.lblRepuestosFiltro = new System.Windows.Forms.Label();
            this.lblRepuestosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepuestosNuevo
            // 
            this.btnRepuestosNuevo.Location = new System.Drawing.Point(312, 94);
            this.btnRepuestosNuevo.Name = "btnRepuestosNuevo";
            this.btnRepuestosNuevo.Size = new System.Drawing.Size(63, 23);
            this.btnRepuestosNuevo.TabIndex = 19;
            this.btnRepuestosNuevo.Text = "Nuevo";
            this.btnRepuestosNuevo.UseVisualStyleBackColor = true;
            this.btnRepuestosNuevo.Click += new System.EventHandler(this.btnRepuestosNuevo_Click);
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRepuestos.Location = new System.Drawing.Point(14, 121);
            this.dgvRepuestos.MultiSelect = false;
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepuestos.Size = new System.Drawing.Size(684, 557);
            this.dgvRepuestos.TabIndex = 18;
            this.dgvRepuestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepuestos_CellDoubleClick);
            // 
            // tbxRepuestosFiltro
            // 
            this.tbxRepuestosFiltro.Location = new System.Drawing.Point(14, 96);
            this.tbxRepuestosFiltro.Name = "tbxRepuestosFiltro";
            this.tbxRepuestosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxRepuestosFiltro.TabIndex = 17;
            this.tbxRepuestosFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRepuestosFiltro_KeyPress);
            // 
            // lblRepuestosFiltro
            // 
            this.lblRepuestosFiltro.AutoSize = true;
            this.lblRepuestosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuestosFiltro.Location = new System.Drawing.Point(17, 81);
            this.lblRepuestosFiltro.Name = "lblRepuestosFiltro";
            this.lblRepuestosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblRepuestosFiltro.TabIndex = 16;
            this.lblRepuestosFiltro.Text = "Filtro";
            // 
            // lblRepuestosTitulo
            // 
            this.lblRepuestosTitulo.AutoSize = true;
            this.lblRepuestosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuestosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblRepuestosTitulo.Name = "lblRepuestosTitulo";
            this.lblRepuestosTitulo.Size = new System.Drawing.Size(271, 34);
            this.lblRepuestosTitulo.TabIndex = 15;
            this.lblRepuestosTitulo.Text = "INVENTARIO STOCK";
            // 
            // FrmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.btnRepuestosNuevo);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.tbxRepuestosFiltro);
            this.Controls.Add(this.lblRepuestosFiltro);
            this.Controls.Add(this.lblRepuestosTitulo);
            this.Name = "FrmRepuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.FrmRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepuestosNuevo;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.TextBox tbxRepuestosFiltro;
        private System.Windows.Forms.Label lblRepuestosFiltro;
        private System.Windows.Forms.Label lblRepuestosTitulo;
    }
}