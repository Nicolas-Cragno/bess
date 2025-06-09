namespace presentacion.personas
{
    partial class FrmFichaPersona
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
            this.btnFichaPersonaCerrar = new System.Windows.Forms.Button();
            this.btnFichaPersonaEventos = new System.Windows.Forms.Button();
            this.tbxFichaPersonaFiltroEventos = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaFiltroEventos = new System.Windows.Forms.Label();
            this.dgvFichaPersonaEventos = new System.Windows.Forms.DataGridView();
            this.btnFichaPersonaEditar = new System.Windows.Forms.Button();
            this.tbxFichaPersonaDetalle = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaDetalle = new System.Windows.Forms.Label();
            this.tbxFichaPersonaData4 = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaData4 = new System.Windows.Forms.Label();
            this.tbxFichaPersonaData3 = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaData3 = new System.Windows.Forms.Label();
            this.tbxFichaPersonaData2 = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaData2 = new System.Windows.Forms.Label();
            this.tbxFichaPersonaData1 = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaData1 = new System.Windows.Forms.Label();
            this.lblFichaPersonaPuesto = new System.Windows.Forms.Label();
            this.lblFichaPersonaEmpresa = new System.Windows.Forms.Label();
            this.tbxFichaPersonaDNI = new System.Windows.Forms.TextBox();
            this.lblFichaPersonaDNI = new System.Windows.Forms.Label();
            this.lblFichaPersonaTitulo = new System.Windows.Forms.Label();
            this.cbxFichaPersonaEmpresa = new System.Windows.Forms.ComboBox();
            this.cbxFichaPersonaPuesto = new System.Windows.Forms.ComboBox();
            this.btnFichaPersonaAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaPersonaEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFichaPersonaCerrar
            // 
            this.btnFichaPersonaCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFichaPersonaCerrar.Location = new System.Drawing.Point(704, 363);
            this.btnFichaPersonaCerrar.Name = "btnFichaPersonaCerrar";
            this.btnFichaPersonaCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaPersonaCerrar.TabIndex = 73;
            this.btnFichaPersonaCerrar.Text = "Cerrar";
            this.btnFichaPersonaCerrar.UseVisualStyleBackColor = true;
            this.btnFichaPersonaCerrar.Click += new System.EventHandler(this.btnFichaPersonaCerrar_Click);
            // 
            // btnFichaPersonaEventos
            // 
            this.btnFichaPersonaEventos.Location = new System.Drawing.Point(687, 57);
            this.btnFichaPersonaEventos.Name = "btnFichaPersonaEventos";
            this.btnFichaPersonaEventos.Size = new System.Drawing.Size(92, 23);
            this.btnFichaPersonaEventos.TabIndex = 72;
            this.btnFichaPersonaEventos.Text = "Agregar Evento";
            this.btnFichaPersonaEventos.UseVisualStyleBackColor = true;
            // 
            // tbxFichaPersonaFiltroEventos
            // 
            this.tbxFichaPersonaFiltroEventos.Location = new System.Drawing.Point(442, 59);
            this.tbxFichaPersonaFiltroEventos.Name = "tbxFichaPersonaFiltroEventos";
            this.tbxFichaPersonaFiltroEventos.Size = new System.Drawing.Size(217, 20);
            this.tbxFichaPersonaFiltroEventos.TabIndex = 71;
            this.tbxFichaPersonaFiltroEventos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFichaPersonaFiltroEventos_KeyPress);
            // 
            // lblFichaPersonaFiltroEventos
            // 
            this.lblFichaPersonaFiltroEventos.AutoSize = true;
            this.lblFichaPersonaFiltroEventos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaPersonaFiltroEventos.Location = new System.Drawing.Point(402, 63);
            this.lblFichaPersonaFiltroEventos.Name = "lblFichaPersonaFiltroEventos";
            this.lblFichaPersonaFiltroEventos.Size = new System.Drawing.Size(34, 12);
            this.lblFichaPersonaFiltroEventos.TabIndex = 70;
            this.lblFichaPersonaFiltroEventos.Text = "Filtro";
            // 
            // dgvFichaPersonaEventos
            // 
            this.dgvFichaPersonaEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichaPersonaEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFichaPersonaEventos.Location = new System.Drawing.Point(398, 86);
            this.dgvFichaPersonaEventos.MultiSelect = false;
            this.dgvFichaPersonaEventos.Name = "dgvFichaPersonaEventos";
            this.dgvFichaPersonaEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichaPersonaEventos.Size = new System.Drawing.Size(381, 271);
            this.dgvFichaPersonaEventos.TabIndex = 69;
            this.dgvFichaPersonaEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichaPersonaEventos_CellDoubleClick);
            // 
            // btnFichaPersonaEditar
            // 
            this.btnFichaPersonaEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFichaPersonaEditar.Location = new System.Drawing.Point(9, 363);
            this.btnFichaPersonaEditar.Name = "btnFichaPersonaEditar";
            this.btnFichaPersonaEditar.Size = new System.Drawing.Size(75, 23);
            this.btnFichaPersonaEditar.TabIndex = 67;
            this.btnFichaPersonaEditar.Text = "Editar Datos";
            this.btnFichaPersonaEditar.UseVisualStyleBackColor = true;
            this.btnFichaPersonaEditar.Click += new System.EventHandler(this.btnFichaPersonaEditar_Click);
            // 
            // tbxFichaPersonaDetalle
            // 
            this.tbxFichaPersonaDetalle.Location = new System.Drawing.Point(9, 248);
            this.tbxFichaPersonaDetalle.Multiline = true;
            this.tbxFichaPersonaDetalle.Name = "tbxFichaPersonaDetalle";
            this.tbxFichaPersonaDetalle.ReadOnly = true;
            this.tbxFichaPersonaDetalle.Size = new System.Drawing.Size(324, 109);
            this.tbxFichaPersonaDetalle.TabIndex = 66;
            // 
            // lblFichaPersonaDetalle
            // 
            this.lblFichaPersonaDetalle.AutoSize = true;
            this.lblFichaPersonaDetalle.Location = new System.Drawing.Point(15, 232);
            this.lblFichaPersonaDetalle.Name = "lblFichaPersonaDetalle";
            this.lblFichaPersonaDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblFichaPersonaDetalle.TabIndex = 65;
            this.lblFichaPersonaDetalle.Text = "Detalle";
            // 
            // tbxFichaPersonaData4
            // 
            this.tbxFichaPersonaData4.Location = new System.Drawing.Point(233, 176);
            this.tbxFichaPersonaData4.Name = "tbxFichaPersonaData4";
            this.tbxFichaPersonaData4.ReadOnly = true;
            this.tbxFichaPersonaData4.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaPersonaData4.TabIndex = 64;
            // 
            // lblFichaPersonaData4
            // 
            this.lblFichaPersonaData4.AutoSize = true;
            this.lblFichaPersonaData4.Location = new System.Drawing.Point(239, 160);
            this.lblFichaPersonaData4.Name = "lblFichaPersonaData4";
            this.lblFichaPersonaData4.Size = new System.Drawing.Size(34, 13);
            this.lblFichaPersonaData4.TabIndex = 63;
            this.lblFichaPersonaData4.Text = "dato4";
            // 
            // tbxFichaPersonaData3
            // 
            this.tbxFichaPersonaData3.Location = new System.Drawing.Point(117, 176);
            this.tbxFichaPersonaData3.Name = "tbxFichaPersonaData3";
            this.tbxFichaPersonaData3.ReadOnly = true;
            this.tbxFichaPersonaData3.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaPersonaData3.TabIndex = 62;
            // 
            // lblFichaPersonaData3
            // 
            this.lblFichaPersonaData3.AutoSize = true;
            this.lblFichaPersonaData3.Location = new System.Drawing.Point(123, 160);
            this.lblFichaPersonaData3.Name = "lblFichaPersonaData3";
            this.lblFichaPersonaData3.Size = new System.Drawing.Size(34, 13);
            this.lblFichaPersonaData3.TabIndex = 61;
            this.lblFichaPersonaData3.Text = "dato3";
            // 
            // tbxFichaPersonaData2
            // 
            this.tbxFichaPersonaData2.Location = new System.Drawing.Point(9, 176);
            this.tbxFichaPersonaData2.Name = "tbxFichaPersonaData2";
            this.tbxFichaPersonaData2.ReadOnly = true;
            this.tbxFichaPersonaData2.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaPersonaData2.TabIndex = 60;
            // 
            // lblFichaPersonaData2
            // 
            this.lblFichaPersonaData2.AutoSize = true;
            this.lblFichaPersonaData2.Location = new System.Drawing.Point(15, 160);
            this.lblFichaPersonaData2.Name = "lblFichaPersonaData2";
            this.lblFichaPersonaData2.Size = new System.Drawing.Size(34, 13);
            this.lblFichaPersonaData2.TabIndex = 59;
            this.lblFichaPersonaData2.Text = "dato2";
            // 
            // tbxFichaPersonaData1
            // 
            this.tbxFichaPersonaData1.Location = new System.Drawing.Point(233, 126);
            this.tbxFichaPersonaData1.Name = "tbxFichaPersonaData1";
            this.tbxFichaPersonaData1.ReadOnly = true;
            this.tbxFichaPersonaData1.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaPersonaData1.TabIndex = 58;
            // 
            // lblFichaPersonaData1
            // 
            this.lblFichaPersonaData1.AutoSize = true;
            this.lblFichaPersonaData1.Location = new System.Drawing.Point(239, 110);
            this.lblFichaPersonaData1.Name = "lblFichaPersonaData1";
            this.lblFichaPersonaData1.Size = new System.Drawing.Size(34, 13);
            this.lblFichaPersonaData1.TabIndex = 57;
            this.lblFichaPersonaData1.Text = "dato1";
            // 
            // lblFichaPersonaPuesto
            // 
            this.lblFichaPersonaPuesto.AutoSize = true;
            this.lblFichaPersonaPuesto.Location = new System.Drawing.Point(15, 110);
            this.lblFichaPersonaPuesto.Name = "lblFichaPersonaPuesto";
            this.lblFichaPersonaPuesto.Size = new System.Drawing.Size(88, 13);
            this.lblFichaPersonaPuesto.TabIndex = 55;
            this.lblFichaPersonaPuesto.Text = "tipo de empleado";
            // 
            // lblFichaPersonaEmpresa
            // 
            this.lblFichaPersonaEmpresa.AutoSize = true;
            this.lblFichaPersonaEmpresa.Location = new System.Drawing.Point(123, 59);
            this.lblFichaPersonaEmpresa.Name = "lblFichaPersonaEmpresa";
            this.lblFichaPersonaEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblFichaPersonaEmpresa.TabIndex = 53;
            this.lblFichaPersonaEmpresa.Text = "empresa";
            // 
            // tbxFichaPersonaDNI
            // 
            this.tbxFichaPersonaDNI.Location = new System.Drawing.Point(9, 75);
            this.tbxFichaPersonaDNI.Name = "tbxFichaPersonaDNI";
            this.tbxFichaPersonaDNI.ReadOnly = true;
            this.tbxFichaPersonaDNI.Size = new System.Drawing.Size(100, 20);
            this.tbxFichaPersonaDNI.TabIndex = 52;
            // 
            // lblFichaPersonaDNI
            // 
            this.lblFichaPersonaDNI.AutoSize = true;
            this.lblFichaPersonaDNI.Location = new System.Drawing.Point(15, 59);
            this.lblFichaPersonaDNI.Name = "lblFichaPersonaDNI";
            this.lblFichaPersonaDNI.Size = new System.Drawing.Size(21, 13);
            this.lblFichaPersonaDNI.TabIndex = 51;
            this.lblFichaPersonaDNI.Text = "dni";
            // 
            // lblFichaPersonaTitulo
            // 
            this.lblFichaPersonaTitulo.AutoSize = true;
            this.lblFichaPersonaTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaPersonaTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblFichaPersonaTitulo.Name = "lblFichaPersonaTitulo";
            this.lblFichaPersonaTitulo.Size = new System.Drawing.Size(431, 34);
            this.lblFichaPersonaTitulo.TabIndex = 50;
            this.lblFichaPersonaTitulo.Text = "Apellido, nombres empleado";
            // 
            // cbxFichaPersonaEmpresa
            // 
            this.cbxFichaPersonaEmpresa.FormattingEnabled = true;
            this.cbxFichaPersonaEmpresa.Location = new System.Drawing.Point(117, 75);
            this.cbxFichaPersonaEmpresa.Name = "cbxFichaPersonaEmpresa";
            this.cbxFichaPersonaEmpresa.Size = new System.Drawing.Size(216, 21);
            this.cbxFichaPersonaEmpresa.TabIndex = 74;
            // 
            // cbxFichaPersonaPuesto
            // 
            this.cbxFichaPersonaPuesto.FormattingEnabled = true;
            this.cbxFichaPersonaPuesto.Location = new System.Drawing.Point(9, 126);
            this.cbxFichaPersonaPuesto.Name = "cbxFichaPersonaPuesto";
            this.cbxFichaPersonaPuesto.Size = new System.Drawing.Size(208, 21);
            this.cbxFichaPersonaPuesto.TabIndex = 75;
            // 
            // btnFichaPersonaAlta
            // 
            this.btnFichaPersonaAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFichaPersonaAlta.Location = new System.Drawing.Point(258, 363);
            this.btnFichaPersonaAlta.Name = "btnFichaPersonaAlta";
            this.btnFichaPersonaAlta.Size = new System.Drawing.Size(75, 23);
            this.btnFichaPersonaAlta.TabIndex = 76;
            this.btnFichaPersonaAlta.Text = "Dar de alta";
            this.btnFichaPersonaAlta.UseVisualStyleBackColor = true;
            this.btnFichaPersonaAlta.Click += new System.EventHandler(this.btnFichaPersonaAlta_Click);
            // 
            // FrmFichaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 397);
            this.Controls.Add(this.btnFichaPersonaAlta);
            this.Controls.Add(this.cbxFichaPersonaPuesto);
            this.Controls.Add(this.cbxFichaPersonaEmpresa);
            this.Controls.Add(this.btnFichaPersonaCerrar);
            this.Controls.Add(this.btnFichaPersonaEventos);
            this.Controls.Add(this.tbxFichaPersonaFiltroEventos);
            this.Controls.Add(this.lblFichaPersonaFiltroEventos);
            this.Controls.Add(this.dgvFichaPersonaEventos);
            this.Controls.Add(this.btnFichaPersonaEditar);
            this.Controls.Add(this.tbxFichaPersonaDetalle);
            this.Controls.Add(this.lblFichaPersonaDetalle);
            this.Controls.Add(this.tbxFichaPersonaData4);
            this.Controls.Add(this.lblFichaPersonaData4);
            this.Controls.Add(this.tbxFichaPersonaData3);
            this.Controls.Add(this.lblFichaPersonaData3);
            this.Controls.Add(this.tbxFichaPersonaData2);
            this.Controls.Add(this.lblFichaPersonaData2);
            this.Controls.Add(this.tbxFichaPersonaData1);
            this.Controls.Add(this.lblFichaPersonaData1);
            this.Controls.Add(this.lblFichaPersonaPuesto);
            this.Controls.Add(this.lblFichaPersonaEmpresa);
            this.Controls.Add(this.tbxFichaPersonaDNI);
            this.Controls.Add(this.lblFichaPersonaDNI);
            this.Controls.Add(this.lblFichaPersonaTitulo);
            this.Name = "FrmFichaPersona";
            this.Load += new System.EventHandler(this.FrmFichaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichaPersonaEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFichaPersonaCerrar;
        private System.Windows.Forms.Button btnFichaPersonaEventos;
        private System.Windows.Forms.TextBox tbxFichaPersonaFiltroEventos;
        private System.Windows.Forms.Label lblFichaPersonaFiltroEventos;
        private System.Windows.Forms.DataGridView dgvFichaPersonaEventos;
        private System.Windows.Forms.Button btnFichaPersonaEditar;
        private System.Windows.Forms.TextBox tbxFichaPersonaDetalle;
        private System.Windows.Forms.Label lblFichaPersonaDetalle;
        private System.Windows.Forms.TextBox tbxFichaPersonaData4;
        private System.Windows.Forms.Label lblFichaPersonaData4;
        private System.Windows.Forms.TextBox tbxFichaPersonaData3;
        private System.Windows.Forms.Label lblFichaPersonaData3;
        private System.Windows.Forms.TextBox tbxFichaPersonaData2;
        private System.Windows.Forms.Label lblFichaPersonaData2;
        private System.Windows.Forms.TextBox tbxFichaPersonaData1;
        private System.Windows.Forms.Label lblFichaPersonaData1;
        private System.Windows.Forms.Label lblFichaPersonaPuesto;
        private System.Windows.Forms.Label lblFichaPersonaEmpresa;
        private System.Windows.Forms.TextBox tbxFichaPersonaDNI;
        private System.Windows.Forms.Label lblFichaPersonaDNI;
        private System.Windows.Forms.Label lblFichaPersonaTitulo;
        private System.Windows.Forms.ComboBox cbxFichaPersonaEmpresa;
        private System.Windows.Forms.ComboBox cbxFichaPersonaPuesto;
        private System.Windows.Forms.Button btnFichaPersonaAlta;
    }
}