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
            this.btnRepuestosNuevo.Location = new System.Drawing.Point(541, 69);
            this.btnRepuestosNuevo.Name = "btnRepuestosNuevo";
            this.btnRepuestosNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnRepuestosNuevo.TabIndex = 19;
            this.btnRepuestosNuevo.Text = "Agregar Nuevo";
            this.btnRepuestosNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRepuestos.Location = new System.Drawing.Point(13, 98);
            this.dgvRepuestos.MultiSelect = false;
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepuestos.Size = new System.Drawing.Size(620, 298);
            this.dgvRepuestos.TabIndex = 18;
            // 
            // tbxRepuestosFiltro
            // 
            this.tbxRepuestosFiltro.Location = new System.Drawing.Point(51, 72);
            this.tbxRepuestosFiltro.Name = "tbxRepuestosFiltro";
            this.tbxRepuestosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxRepuestosFiltro.TabIndex = 17;
            // 
            // lblRepuestosFiltro
            // 
            this.lblRepuestosFiltro.AutoSize = true;
            this.lblRepuestosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuestosFiltro.Location = new System.Drawing.Point(11, 76);
            this.lblRepuestosFiltro.Name = "lblRepuestosFiltro";
            this.lblRepuestosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblRepuestosFiltro.TabIndex = 16;
            this.lblRepuestosFiltro.Text = "Filtro";
            // 
            // lblRepuestosTitulo
            // 
            this.lblRepuestosTitulo.AutoSize = true;
            this.lblRepuestosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuestosTitulo.Location = new System.Drawing.Point(188, 15);
            this.lblRepuestosTitulo.Name = "lblRepuestosTitulo";
            this.lblRepuestosTitulo.Size = new System.Drawing.Size(271, 34);
            this.lblRepuestosTitulo.TabIndex = 15;
            this.lblRepuestosTitulo.Text = "REPUESTOS TALLER";
            // 
            // FrmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnRepuestosNuevo);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.tbxRepuestosFiltro);
            this.Controls.Add(this.lblRepuestosFiltro);
            this.Controls.Add(this.lblRepuestosTitulo);
            this.Name = "FrmRepuestos";
            this.Text = "FrmRepuestos";
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