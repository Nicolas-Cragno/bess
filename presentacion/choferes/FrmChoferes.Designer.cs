namespace presentacion.choferes
{
    partial class FrmChoferes
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
            this.btnInactivos = new System.Windows.Forms.Button();
            this.btnChoferesNuevo = new System.Windows.Forms.Button();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.tbxChoferesFiltro = new System.Windows.Forms.TextBox();
            this.lblChoferesFiltro = new System.Windows.Forms.Label();
            this.lblChoferesTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInactivos
            // 
            this.btnInactivos.Location = new System.Drawing.Point(443, 72);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(92, 23);
            this.btnInactivos.TabIndex = 14;
            this.btnInactivos.Text = "Ver inactivos";
            this.btnInactivos.UseVisualStyleBackColor = true;
            // 
            // btnChoferesNuevo
            // 
            this.btnChoferesNuevo.Location = new System.Drawing.Point(541, 72);
            this.btnChoferesNuevo.Name = "btnChoferesNuevo";
            this.btnChoferesNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnChoferesNuevo.TabIndex = 12;
            this.btnChoferesNuevo.Text = "Agregar Chofer";
            this.btnChoferesNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChoferes.Location = new System.Drawing.Point(13, 101);
            this.dgvChoferes.MultiSelect = false;
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferes.Size = new System.Drawing.Size(620, 298);
            this.dgvChoferes.TabIndex = 11;
            // 
            // tbxChoferesFiltro
            // 
            this.tbxChoferesFiltro.Location = new System.Drawing.Point(51, 75);
            this.tbxChoferesFiltro.Name = "tbxChoferesFiltro";
            this.tbxChoferesFiltro.Size = new System.Drawing.Size(292, 20);
            this.tbxChoferesFiltro.TabIndex = 10;
            // 
            // lblChoferesFiltro
            // 
            this.lblChoferesFiltro.AutoSize = true;
            this.lblChoferesFiltro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesFiltro.Location = new System.Drawing.Point(11, 79);
            this.lblChoferesFiltro.Name = "lblChoferesFiltro";
            this.lblChoferesFiltro.Size = new System.Drawing.Size(34, 12);
            this.lblChoferesFiltro.TabIndex = 9;
            this.lblChoferesFiltro.Text = "Filtro";
            // 
            // lblChoferesTitulo
            // 
            this.lblChoferesTitulo.AutoSize = true;
            this.lblChoferesTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesTitulo.Location = new System.Drawing.Point(188, 18);
            this.lblChoferesTitulo.Name = "lblChoferesTitulo";
            this.lblChoferesTitulo.Size = new System.Drawing.Size(271, 34);
            this.lblChoferesTitulo.TabIndex = 8;
            this.lblChoferesTitulo.Text = "CHOFERES ACTIVOS";
            // 
            // FrmChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnInactivos);
            this.Controls.Add(this.btnChoferesNuevo);
            this.Controls.Add(this.dgvChoferes);
            this.Controls.Add(this.tbxChoferesFiltro);
            this.Controls.Add(this.lblChoferesFiltro);
            this.Controls.Add(this.lblChoferesTitulo);
            this.Name = "FrmChoferes";
            this.Text = "FrmChoferes";
            this.Load += new System.EventHandler(this.FrmChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInactivos;
        private System.Windows.Forms.Button btnChoferesNuevo;
        private System.Windows.Forms.DataGridView dgvChoferes;
        private System.Windows.Forms.TextBox tbxChoferesFiltro;
        private System.Windows.Forms.Label lblChoferesFiltro;
        private System.Windows.Forms.Label lblChoferesTitulo;
    }
}