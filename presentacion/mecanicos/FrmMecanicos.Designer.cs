namespace presentacion.mecanicos
{
    partial class FrmMecanicos
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
            this.btnMecanicosInactivos = new System.Windows.Forms.Button();
            this.btnMecanicosNuevo = new System.Windows.Forms.Button();
            this.dgvMecanicos = new System.Windows.Forms.DataGridView();
            this.tbxMecanicosFiltro = new System.Windows.Forms.TextBox();
            this.lblMecanicosFiltro = new System.Windows.Forms.Label();
            this.lblMecanicosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMecanicosInactivos
            // 
            this.btnMecanicosInactivos.Location = new System.Drawing.Point(424, 69);
            this.btnMecanicosInactivos.Name = "btnMecanicosInactivos";
            this.btnMecanicosInactivos.Size = new System.Drawing.Size(92, 23);
            this.btnMecanicosInactivos.TabIndex = 20;
            this.btnMecanicosInactivos.Text = "Ver inactivos";
            this.btnMecanicosInactivos.UseVisualStyleBackColor = true;
            // 
            // btnMecanicosNuevo
            // 
            this.btnMecanicosNuevo.Location = new System.Drawing.Point(522, 69);
            this.btnMecanicosNuevo.Name = "btnMecanicosNuevo";
            this.btnMecanicosNuevo.Size = new System.Drawing.Size(111, 23);
            this.btnMecanicosNuevo.TabIndex = 19;
            this.btnMecanicosNuevo.Text = "Agregar Mecanico";
            this.btnMecanicosNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvMecanicos
            // 
            this.dgvMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMecanicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMecanicos.Location = new System.Drawing.Point(13, 98);
            this.dgvMecanicos.MultiSelect = false;
            this.dgvMecanicos.Name = "dgvMecanicos";
            this.dgvMecanicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMecanicos.Size = new System.Drawing.Size(620, 298);
            this.dgvMecanicos.TabIndex = 18;
            // 
            // tbxMecanicosFiltro
            // 
            this.tbxMecanicosFiltro.Location = new System.Drawing.Point(51, 72);
            this.tbxMecanicosFiltro.Name = "tbxMecanicosFiltro";
            this.tbxMecanicosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxMecanicosFiltro.TabIndex = 17;
            // 
            // lblMecanicosFiltro
            // 
            this.lblMecanicosFiltro.AutoSize = true;
            this.lblMecanicosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMecanicosFiltro.Location = new System.Drawing.Point(11, 76);
            this.lblMecanicosFiltro.Name = "lblMecanicosFiltro";
            this.lblMecanicosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblMecanicosFiltro.TabIndex = 16;
            this.lblMecanicosFiltro.Text = "Filtro";
            // 
            // lblMecanicosTitulo
            // 
            this.lblMecanicosTitulo.AutoSize = true;
            this.lblMecanicosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMecanicosTitulo.Location = new System.Drawing.Point(243, 15);
            this.lblMecanicosTitulo.Name = "lblMecanicosTitulo";
            this.lblMecanicosTitulo.Size = new System.Drawing.Size(159, 34);
            this.lblMecanicosTitulo.TabIndex = 15;
            this.lblMecanicosTitulo.Text = "MECANICOS";
            // 
            // FrmMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnMecanicosInactivos);
            this.Controls.Add(this.btnMecanicosNuevo);
            this.Controls.Add(this.dgvMecanicos);
            this.Controls.Add(this.tbxMecanicosFiltro);
            this.Controls.Add(this.lblMecanicosFiltro);
            this.Controls.Add(this.lblMecanicosTitulo);
            this.Name = "FrmMecanicos";
            this.Text = "FrmMecanicos";
            this.Load += new System.EventHandler(this.FrmMecanicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMecanicosInactivos;
        private System.Windows.Forms.Button btnMecanicosNuevo;
        private System.Windows.Forms.DataGridView dgvMecanicos;
        private System.Windows.Forms.TextBox tbxMecanicosFiltro;
        private System.Windows.Forms.Label lblMecanicosFiltro;
        private System.Windows.Forms.Label lblMecanicosTitulo;
    }
}