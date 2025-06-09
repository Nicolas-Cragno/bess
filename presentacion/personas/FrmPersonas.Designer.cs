namespace presentacion.personas
{
    partial class FrmPersonas
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
            this.btnPersonasInactivas = new System.Windows.Forms.Button();
            this.btnPersonasAgregar = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.tbxPersonasFiltro = new System.Windows.Forms.TextBox();
            this.lblPersonasFiltro = new System.Windows.Forms.Label();
            this.lblPersonasTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonasInactivas
            // 
            this.btnPersonasInactivas.Location = new System.Drawing.Point(381, 94);
            this.btnPersonasInactivas.Name = "btnPersonasInactivas";
            this.btnPersonasInactivas.Size = new System.Drawing.Size(63, 23);
            this.btnPersonasInactivas.TabIndex = 20;
            this.btnPersonasInactivas.Text = "Inactivos";
            this.btnPersonasInactivas.UseVisualStyleBackColor = true;
            this.btnPersonasInactivas.Click += new System.EventHandler(this.btnPersonasInactivas_Click);
            // 
            // btnPersonasAgregar
            // 
            this.btnPersonasAgregar.Location = new System.Drawing.Point(312, 94);
            this.btnPersonasAgregar.Name = "btnPersonasAgregar";
            this.btnPersonasAgregar.Size = new System.Drawing.Size(63, 23);
            this.btnPersonasAgregar.TabIndex = 19;
            this.btnPersonasAgregar.Text = "Nuevo";
            this.btnPersonasAgregar.UseVisualStyleBackColor = true;
            this.btnPersonasAgregar.Click += new System.EventHandler(this.btnPersonasAgregar_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonas.Location = new System.Drawing.Point(14, 121);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(684, 557);
            this.dgvPersonas.TabIndex = 18;
            this.dgvPersonas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellDoubleClick);
            // 
            // tbxPersonasFiltro
            // 
            this.tbxPersonasFiltro.Location = new System.Drawing.Point(14, 96);
            this.tbxPersonasFiltro.Name = "tbxPersonasFiltro";
            this.tbxPersonasFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxPersonasFiltro.TabIndex = 17;
            this.tbxPersonasFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPersonasFiltro_KeyPress);
            // 
            // lblPersonasFiltro
            // 
            this.lblPersonasFiltro.AutoSize = true;
            this.lblPersonasFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasFiltro.Location = new System.Drawing.Point(17, 81);
            this.lblPersonasFiltro.Name = "lblPersonasFiltro";
            this.lblPersonasFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblPersonasFiltro.TabIndex = 16;
            this.lblPersonasFiltro.Text = "Filtro";
            // 
            // lblPersonasTitulo
            // 
            this.lblPersonasTitulo.AutoSize = true;
            this.lblPersonasTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblPersonasTitulo.Name = "lblPersonasTitulo";
            this.lblPersonasTitulo.Size = new System.Drawing.Size(341, 41);
            this.lblPersonasTitulo.TabIndex = 25;
            this.lblPersonasTitulo.Text = "NOMBRE DEL PUESTO";
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.lblPersonasTitulo);
            this.Controls.Add(this.btnPersonasInactivas);
            this.Controls.Add(this.btnPersonasAgregar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.tbxPersonasFiltro);
            this.Controls.Add(this.lblPersonasFiltro);
            this.Name = "FrmPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonasInactivas;
        private System.Windows.Forms.Button btnPersonasAgregar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.TextBox tbxPersonasFiltro;
        private System.Windows.Forms.Label lblPersonasFiltro;
        private System.Windows.Forms.Label lblPersonasTitulo;
    }
}