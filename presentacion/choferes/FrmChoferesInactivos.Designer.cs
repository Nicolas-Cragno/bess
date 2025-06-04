namespace presentacion.choferes
{
    partial class FrmChoferesInactivos
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
            this.btnChoferesInactivosClose = new System.Windows.Forms.Button();
            this.dgvChoferesInactivos = new System.Windows.Forms.DataGridView();
            this.tbxChoferesInactivosFiltro = new System.Windows.Forms.TextBox();
            this.lblChoferesInactivosFiltro = new System.Windows.Forms.Label();
            this.lblChoferesInactivosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoferesInactivosClose
            // 
            this.btnChoferesInactivosClose.Location = new System.Drawing.Point(449, 344);
            this.btnChoferesInactivosClose.Name = "btnChoferesInactivosClose";
            this.btnChoferesInactivosClose.Size = new System.Drawing.Size(51, 23);
            this.btnChoferesInactivosClose.TabIndex = 12;
            this.btnChoferesInactivosClose.Text = "Cerrar";
            this.btnChoferesInactivosClose.UseVisualStyleBackColor = true;
            this.btnChoferesInactivosClose.Click += new System.EventHandler(this.btnChoferesInactivosClose_Click);
            // 
            // dgvChoferesInactivos
            // 
            this.dgvChoferesInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferesInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChoferesInactivos.Location = new System.Drawing.Point(13, 93);
            this.dgvChoferesInactivos.MultiSelect = false;
            this.dgvChoferesInactivos.Name = "dgvChoferesInactivos";
            this.dgvChoferesInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferesInactivos.Size = new System.Drawing.Size(487, 245);
            this.dgvChoferesInactivos.TabIndex = 11;
            // 
            // tbxChoferesInactivosFiltro
            // 
            this.tbxChoferesInactivosFiltro.Location = new System.Drawing.Point(13, 67);
            this.tbxChoferesInactivosFiltro.Name = "tbxChoferesInactivosFiltro";
            this.tbxChoferesInactivosFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxChoferesInactivosFiltro.TabIndex = 10;
            // 
            // lblChoferesInactivosFiltro
            // 
            this.lblChoferesInactivosFiltro.AutoSize = true;
            this.lblChoferesInactivosFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesInactivosFiltro.Location = new System.Drawing.Point(11, 52);
            this.lblChoferesInactivosFiltro.Name = "lblChoferesInactivosFiltro";
            this.lblChoferesInactivosFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblChoferesInactivosFiltro.TabIndex = 9;
            this.lblChoferesInactivosFiltro.Text = "Filtro";
            // 
            // lblChoferesInactivosTitulo
            // 
            this.lblChoferesInactivosTitulo.AutoSize = true;
            this.lblChoferesInactivosTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesInactivosTitulo.Location = new System.Drawing.Point(105, 7);
            this.lblChoferesInactivosTitulo.Name = "lblChoferesInactivosTitulo";
            this.lblChoferesInactivosTitulo.Size = new System.Drawing.Size(303, 34);
            this.lblChoferesInactivosTitulo.TabIndex = 8;
            this.lblChoferesInactivosTitulo.Text = "CHOFERES INACTIVOS";
            // 
            // FrmChoferesInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 375);
            this.Controls.Add(this.btnChoferesInactivosClose);
            this.Controls.Add(this.dgvChoferesInactivos);
            this.Controls.Add(this.tbxChoferesInactivosFiltro);
            this.Controls.Add(this.lblChoferesInactivosFiltro);
            this.Controls.Add(this.lblChoferesInactivosTitulo);
            this.Name = "FrmChoferesInactivos";
            this.Text = "FrmChoferesInactivos";
            this.Load += new System.EventHandler(this.FrmChoferesInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoferesInactivosClose;
        private System.Windows.Forms.DataGridView dgvChoferesInactivos;
        private System.Windows.Forms.TextBox tbxChoferesInactivosFiltro;
        private System.Windows.Forms.Label lblChoferesInactivosFiltro;
        private System.Windows.Forms.Label lblChoferesInactivosTitulo;
    }
}