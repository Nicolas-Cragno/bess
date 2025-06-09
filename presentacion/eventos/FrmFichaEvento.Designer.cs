namespace presentacion.eventos
{
    partial class FrmFichaEvento
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
            this.cbxFichaEventoFurgon = new System.Windows.Forms.ComboBox();
            this.lblFichaEventoFurgon = new System.Windows.Forms.Label();
            this.btnFichaEventoCerrar = new System.Windows.Forms.Button();
            this.btnFichaEventoOK = new System.Windows.Forms.Button();
            this.cbxFichaEventoChofer = new System.Windows.Forms.ComboBox();
            this.lblFichaEventoTipo = new System.Windows.Forms.Label();
            this.cbxFichaEventoInterno = new System.Windows.Forms.ComboBox();
            this.lblFichaEventoDNI = new System.Windows.Forms.Label();
            this.tbxFichaEventoDetalle = new System.Windows.Forms.TextBox();
            this.lblFichaEventoDetalle = new System.Windows.Forms.Label();
            this.lblFichaEventoInterno = new System.Windows.Forms.Label();
            this.lblFichaEventoTitulo = new System.Windows.Forms.Label();
            this.cbxFichaEventoTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxFichaEventoFurgon
            // 
            this.cbxFichaEventoFurgon.FormattingEnabled = true;
            this.cbxFichaEventoFurgon.Location = new System.Drawing.Point(90, 94);
            this.cbxFichaEventoFurgon.Name = "cbxFichaEventoFurgon";
            this.cbxFichaEventoFurgon.Size = new System.Drawing.Size(72, 21);
            this.cbxFichaEventoFurgon.TabIndex = 100;
            // 
            // lblFichaEventoFurgon
            // 
            this.lblFichaEventoFurgon.AutoSize = true;
            this.lblFichaEventoFurgon.Location = new System.Drawing.Point(94, 78);
            this.lblFichaEventoFurgon.Name = "lblFichaEventoFurgon";
            this.lblFichaEventoFurgon.Size = new System.Drawing.Size(37, 13);
            this.lblFichaEventoFurgon.TabIndex = 99;
            this.lblFichaEventoFurgon.Text = "furgon";
            // 
            // btnFichaEventoCerrar
            // 
            this.btnFichaEventoCerrar.Location = new System.Drawing.Point(221, 355);
            this.btnFichaEventoCerrar.Name = "btnFichaEventoCerrar";
            this.btnFichaEventoCerrar.Size = new System.Drawing.Size(74, 23);
            this.btnFichaEventoCerrar.TabIndex = 98;
            this.btnFichaEventoCerrar.Text = "Cerrar";
            this.btnFichaEventoCerrar.UseVisualStyleBackColor = true;
            this.btnFichaEventoCerrar.Click += new System.EventHandler(this.btnFichaEventoCerrar_Click);
            // 
            // btnFichaEventoOK
            // 
            this.btnFichaEventoOK.Location = new System.Drawing.Point(13, 355);
            this.btnFichaEventoOK.Name = "btnFichaEventoOK";
            this.btnFichaEventoOK.Size = new System.Drawing.Size(74, 23);
            this.btnFichaEventoOK.TabIndex = 97;
            this.btnFichaEventoOK.Text = "Agregar";
            this.btnFichaEventoOK.UseVisualStyleBackColor = true;
            this.btnFichaEventoOK.Click += new System.EventHandler(this.btnFichaEventoOK_Click);
            // 
            // cbxFichaEventoChofer
            // 
            this.cbxFichaEventoChofer.FormattingEnabled = true;
            this.cbxFichaEventoChofer.Location = new System.Drawing.Point(12, 54);
            this.cbxFichaEventoChofer.Name = "cbxFichaEventoChofer";
            this.cbxFichaEventoChofer.Size = new System.Drawing.Size(280, 21);
            this.cbxFichaEventoChofer.TabIndex = 96;
            // 
            // lblFichaEventoTipo
            // 
            this.lblFichaEventoTipo.AutoSize = true;
            this.lblFichaEventoTipo.Location = new System.Drawing.Point(171, 78);
            this.lblFichaEventoTipo.Name = "lblFichaEventoTipo";
            this.lblFichaEventoTipo.Size = new System.Drawing.Size(24, 13);
            this.lblFichaEventoTipo.TabIndex = 94;
            this.lblFichaEventoTipo.Text = "tipo";
            // 
            // cbxFichaEventoInterno
            // 
            this.cbxFichaEventoInterno.FormattingEnabled = true;
            this.cbxFichaEventoInterno.Location = new System.Drawing.Point(12, 94);
            this.cbxFichaEventoInterno.Name = "cbxFichaEventoInterno";
            this.cbxFichaEventoInterno.Size = new System.Drawing.Size(72, 21);
            this.cbxFichaEventoInterno.TabIndex = 93;
            // 
            // lblFichaEventoDNI
            // 
            this.lblFichaEventoDNI.AutoSize = true;
            this.lblFichaEventoDNI.Location = new System.Drawing.Point(12, 38);
            this.lblFichaEventoDNI.Name = "lblFichaEventoDNI";
            this.lblFichaEventoDNI.Size = new System.Drawing.Size(45, 13);
            this.lblFichaEventoDNI.TabIndex = 92;
            this.lblFichaEventoDNI.Text = "persona";
            // 
            // tbxFichaEventoDetalle
            // 
            this.tbxFichaEventoDetalle.Location = new System.Drawing.Point(12, 143);
            this.tbxFichaEventoDetalle.Multiline = true;
            this.tbxFichaEventoDetalle.Name = "tbxFichaEventoDetalle";
            this.tbxFichaEventoDetalle.Size = new System.Drawing.Size(280, 206);
            this.tbxFichaEventoDetalle.TabIndex = 91;
            // 
            // lblFichaEventoDetalle
            // 
            this.lblFichaEventoDetalle.AutoSize = true;
            this.lblFichaEventoDetalle.Location = new System.Drawing.Point(12, 127);
            this.lblFichaEventoDetalle.Name = "lblFichaEventoDetalle";
            this.lblFichaEventoDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblFichaEventoDetalle.TabIndex = 90;
            this.lblFichaEventoDetalle.Text = "Detalle";
            // 
            // lblFichaEventoInterno
            // 
            this.lblFichaEventoInterno.AutoSize = true;
            this.lblFichaEventoInterno.Location = new System.Drawing.Point(12, 78);
            this.lblFichaEventoInterno.Name = "lblFichaEventoInterno";
            this.lblFichaEventoInterno.Size = new System.Drawing.Size(37, 13);
            this.lblFichaEventoInterno.TabIndex = 89;
            this.lblFichaEventoInterno.Text = "tractor";
            // 
            // lblFichaEventoTitulo
            // 
            this.lblFichaEventoTitulo.AutoSize = true;
            this.lblFichaEventoTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaEventoTitulo.Location = new System.Drawing.Point(99, 8);
            this.lblFichaEventoTitulo.Name = "lblFichaEventoTitulo";
            this.lblFichaEventoTitulo.Size = new System.Drawing.Size(111, 34);
            this.lblFichaEventoTitulo.TabIndex = 88;
            this.lblFichaEventoTitulo.Text = "Evento";
            // 
            // cbxFichaEventoTipo
            // 
            this.cbxFichaEventoTipo.FormattingEnabled = true;
            this.cbxFichaEventoTipo.Location = new System.Drawing.Point(168, 94);
            this.cbxFichaEventoTipo.Name = "cbxFichaEventoTipo";
            this.cbxFichaEventoTipo.Size = new System.Drawing.Size(124, 21);
            this.cbxFichaEventoTipo.TabIndex = 101;
            // 
            // FrmFichaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 390);
            this.Controls.Add(this.cbxFichaEventoTipo);
            this.Controls.Add(this.cbxFichaEventoFurgon);
            this.Controls.Add(this.lblFichaEventoFurgon);
            this.Controls.Add(this.btnFichaEventoCerrar);
            this.Controls.Add(this.btnFichaEventoOK);
            this.Controls.Add(this.cbxFichaEventoChofer);
            this.Controls.Add(this.lblFichaEventoTipo);
            this.Controls.Add(this.cbxFichaEventoInterno);
            this.Controls.Add(this.lblFichaEventoDNI);
            this.Controls.Add(this.tbxFichaEventoDetalle);
            this.Controls.Add(this.lblFichaEventoDetalle);
            this.Controls.Add(this.lblFichaEventoInterno);
            this.Controls.Add(this.lblFichaEventoTitulo);
            this.Name = "FrmFichaEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmFichaEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFichaEventoFurgon;
        private System.Windows.Forms.Label lblFichaEventoFurgon;
        private System.Windows.Forms.Button btnFichaEventoCerrar;
        private System.Windows.Forms.Button btnFichaEventoOK;
        private System.Windows.Forms.ComboBox cbxFichaEventoChofer;
        private System.Windows.Forms.Label lblFichaEventoTipo;
        private System.Windows.Forms.ComboBox cbxFichaEventoInterno;
        private System.Windows.Forms.Label lblFichaEventoDNI;
        private System.Windows.Forms.TextBox tbxFichaEventoDetalle;
        private System.Windows.Forms.Label lblFichaEventoDetalle;
        private System.Windows.Forms.Label lblFichaEventoInterno;
        private System.Windows.Forms.Label lblFichaEventoTitulo;
        private System.Windows.Forms.ComboBox cbxFichaEventoTipo;
    }
}