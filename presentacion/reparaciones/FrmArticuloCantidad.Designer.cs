namespace presentacion.reparaciones
{
    partial class FrmArticuloCantidad
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
            this.lblArticuloCantidadNombre = new System.Windows.Forms.Label();
            this.lblArticuloCantidadCodigo = new System.Windows.Forms.Label();
            this.lblArticuloCantidadMarca = new System.Windows.Forms.Label();
            this.tbxArticuloCantidad = new System.Windows.Forms.TextBox();
            this.lblArticuloCantidadCantidad = new System.Windows.Forms.Label();
            this.lblArticuloCantidadStock = new System.Windows.Forms.Label();
            this.lblArticuloCantidadDisponible = new System.Windows.Forms.Label();
            this.btnFichaReparacionesOK = new System.Windows.Forms.Button();
            this.lblArticuloCantidadUnidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArticuloCantidadNombre
            // 
            this.lblArticuloCantidadNombre.AutoSize = true;
            this.lblArticuloCantidadNombre.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloCantidadNombre.Location = new System.Drawing.Point(12, 9);
            this.lblArticuloCantidadNombre.Name = "lblArticuloCantidadNombre";
            this.lblArticuloCantidadNombre.Size = new System.Drawing.Size(246, 28);
            this.lblArticuloCantidadNombre.TabIndex = 172;
            this.lblArticuloCantidadNombre.Text = "Nombre de articulo";
            // 
            // lblArticuloCantidadCodigo
            // 
            this.lblArticuloCantidadCodigo.AutoSize = true;
            this.lblArticuloCantidadCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloCantidadCodigo.Location = new System.Drawing.Point(13, 56);
            this.lblArticuloCantidadCodigo.Name = "lblArticuloCantidadCodigo";
            this.lblArticuloCantidadCodigo.Size = new System.Drawing.Size(144, 19);
            this.lblArticuloCantidadCodigo.TabIndex = 173;
            this.lblArticuloCantidadCodigo.Text = "Codigo Provedor";
            // 
            // lblArticuloCantidadMarca
            // 
            this.lblArticuloCantidadMarca.AutoSize = true;
            this.lblArticuloCantidadMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloCantidadMarca.Location = new System.Drawing.Point(13, 37);
            this.lblArticuloCantidadMarca.Name = "lblArticuloCantidadMarca";
            this.lblArticuloCantidadMarca.Size = new System.Drawing.Size(54, 19);
            this.lblArticuloCantidadMarca.TabIndex = 175;
            this.lblArticuloCantidadMarca.Text = "Marca";
            // 
            // tbxArticuloCantidad
            // 
            this.tbxArticuloCantidad.Location = new System.Drawing.Point(81, 95);
            this.tbxArticuloCantidad.Name = "tbxArticuloCantidad";
            this.tbxArticuloCantidad.Size = new System.Drawing.Size(76, 20);
            this.tbxArticuloCantidad.TabIndex = 176;
            this.tbxArticuloCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxArticuloCantidad_KeyPress);
            // 
            // lblArticuloCantidadCantidad
            // 
            this.lblArticuloCantidadCantidad.AutoSize = true;
            this.lblArticuloCantidadCantidad.Location = new System.Drawing.Point(27, 98);
            this.lblArticuloCantidadCantidad.Name = "lblArticuloCantidadCantidad";
            this.lblArticuloCantidadCantidad.Size = new System.Drawing.Size(48, 13);
            this.lblArticuloCantidadCantidad.TabIndex = 177;
            this.lblArticuloCantidadCantidad.Text = "cantidad";
            // 
            // lblArticuloCantidadStock
            // 
            this.lblArticuloCantidadStock.AutoSize = true;
            this.lblArticuloCantidadStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloCantidadStock.Location = new System.Drawing.Point(81, 120);
            this.lblArticuloCantidadStock.Name = "lblArticuloCantidadStock";
            this.lblArticuloCantidadStock.Size = new System.Drawing.Size(54, 19);
            this.lblArticuloCantidadStock.TabIndex = 178;
            this.lblArticuloCantidadStock.Text = "Stock";
            // 
            // lblArticuloCantidadDisponible
            // 
            this.lblArticuloCantidadDisponible.AutoSize = true;
            this.lblArticuloCantidadDisponible.Location = new System.Drawing.Point(21, 124);
            this.lblArticuloCantidadDisponible.Name = "lblArticuloCantidadDisponible";
            this.lblArticuloCantidadDisponible.Size = new System.Drawing.Size(54, 13);
            this.lblArticuloCantidadDisponible.TabIndex = 179;
            this.lblArticuloCantidadDisponible.Text = "disponible";
            // 
            // btnFichaReparacionesOK
            // 
            this.btnFichaReparacionesOK.Location = new System.Drawing.Point(237, 152);
            this.btnFichaReparacionesOK.Name = "btnFichaReparacionesOK";
            this.btnFichaReparacionesOK.Size = new System.Drawing.Size(74, 23);
            this.btnFichaReparacionesOK.TabIndex = 180;
            this.btnFichaReparacionesOK.Text = "Aceptar";
            this.btnFichaReparacionesOK.UseVisualStyleBackColor = true;
            this.btnFichaReparacionesOK.Click += new System.EventHandler(this.btnFichaReparacionesOK_Click);
            // 
            // lblArticuloCantidadUnidad
            // 
            this.lblArticuloCantidadUnidad.AutoSize = true;
            this.lblArticuloCantidadUnidad.Location = new System.Drawing.Point(163, 98);
            this.lblArticuloCantidadUnidad.Name = "lblArticuloCantidadUnidad";
            this.lblArticuloCantidadUnidad.Size = new System.Drawing.Size(39, 13);
            this.lblArticuloCantidadUnidad.TabIndex = 181;
            this.lblArticuloCantidadUnidad.Text = "unidad";
            // 
            // FrmArticuloCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 187);
            this.Controls.Add(this.lblArticuloCantidadUnidad);
            this.Controls.Add(this.btnFichaReparacionesOK);
            this.Controls.Add(this.lblArticuloCantidadDisponible);
            this.Controls.Add(this.lblArticuloCantidadStock);
            this.Controls.Add(this.lblArticuloCantidadCantidad);
            this.Controls.Add(this.tbxArticuloCantidad);
            this.Controls.Add(this.lblArticuloCantidadMarca);
            this.Controls.Add(this.lblArticuloCantidadCodigo);
            this.Controls.Add(this.lblArticuloCantidadNombre);
            this.Name = "FrmArticuloCantidad";
            this.Text = "FrmArticuloCantidad";
            this.Load += new System.EventHandler(this.FrmArticuloCantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticuloCantidadNombre;
        private System.Windows.Forms.Label lblArticuloCantidadCodigo;
        private System.Windows.Forms.Label lblArticuloCantidadMarca;
        private System.Windows.Forms.TextBox tbxArticuloCantidad;
        private System.Windows.Forms.Label lblArticuloCantidadCantidad;
        private System.Windows.Forms.Label lblArticuloCantidadStock;
        private System.Windows.Forms.Label lblArticuloCantidadDisponible;
        private System.Windows.Forms.Button btnFichaReparacionesOK;
        private System.Windows.Forms.Label lblArticuloCantidadUnidad;
    }
}