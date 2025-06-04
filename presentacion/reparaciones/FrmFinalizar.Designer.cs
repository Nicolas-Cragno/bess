namespace presentacion.reparaciones
{
    partial class FrmFinalizar
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
            this.lblFinalizarTxt1 = new System.Windows.Forms.Label();
            this.lblFinalizarTxt3 = new System.Windows.Forms.Label();
            this.btnFinalizarOK = new System.Windows.Forms.Button();
            this.lblFinalizarTxt2 = new System.Windows.Forms.Label();
            this.btnFinalizarCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFinalizarTxt1
            // 
            this.lblFinalizarTxt1.AutoSize = true;
            this.lblFinalizarTxt1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarTxt1.Location = new System.Drawing.Point(18, 9);
            this.lblFinalizarTxt1.Name = "lblFinalizarTxt1";
            this.lblFinalizarTxt1.Size = new System.Drawing.Size(234, 19);
            this.lblFinalizarTxt1.TabIndex = 174;
            this.lblFinalizarTxt1.Text = "Está a punto de finalizar";
            // 
            // lblFinalizarTxt3
            // 
            this.lblFinalizarTxt3.AutoSize = true;
            this.lblFinalizarTxt3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarTxt3.Location = new System.Drawing.Point(18, 75);
            this.lblFinalizarTxt3.Name = "lblFinalizarTxt3";
            this.lblFinalizarTxt3.Size = new System.Drawing.Size(144, 19);
            this.lblFinalizarTxt3.TabIndex = 176;
            this.lblFinalizarTxt3.Text = "¿ Está seguro ?";
            // 
            // btnFinalizarOK
            // 
            this.btnFinalizarOK.Location = new System.Drawing.Point(22, 120);
            this.btnFinalizarOK.Name = "btnFinalizarOK";
            this.btnFinalizarOK.Size = new System.Drawing.Size(74, 23);
            this.btnFinalizarOK.TabIndex = 230;
            this.btnFinalizarOK.Text = "Finalizar";
            this.btnFinalizarOK.UseVisualStyleBackColor = true;
            this.btnFinalizarOK.Click += new System.EventHandler(this.btnFinalizarOK_Click);
            // 
            // lblFinalizarTxt2
            // 
            this.lblFinalizarTxt2.AutoSize = true;
            this.lblFinalizarTxt2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarTxt2.Location = new System.Drawing.Point(18, 42);
            this.lblFinalizarTxt2.Name = "lblFinalizarTxt2";
            this.lblFinalizarTxt2.Size = new System.Drawing.Size(108, 19);
            this.lblFinalizarTxt2.TabIndex = 175;
            this.lblFinalizarTxt2.Text = "el trabajo.";
            // 
            // btnFinalizarCancelar
            // 
            this.btnFinalizarCancelar.Location = new System.Drawing.Point(185, 120);
            this.btnFinalizarCancelar.Name = "btnFinalizarCancelar";
            this.btnFinalizarCancelar.Size = new System.Drawing.Size(74, 23);
            this.btnFinalizarCancelar.TabIndex = 231;
            this.btnFinalizarCancelar.Text = "Cancelar";
            this.btnFinalizarCancelar.UseVisualStyleBackColor = true;
            this.btnFinalizarCancelar.Click += new System.EventHandler(this.btnFinalizarCancelar_Click);
            // 
            // FrmFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 155);
            this.Controls.Add(this.btnFinalizarCancelar);
            this.Controls.Add(this.btnFinalizarOK);
            this.Controls.Add(this.lblFinalizarTxt3);
            this.Controls.Add(this.lblFinalizarTxt2);
            this.Controls.Add(this.lblFinalizarTxt1);
            this.Name = "FrmFinalizar";
            this.Text = "FrmFinalizar";
            this.Load += new System.EventHandler(this.FrmFinalizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalizarTxt1;
        private System.Windows.Forms.Label lblFinalizarTxt3;
        private System.Windows.Forms.Button btnFinalizarOK;
        private System.Windows.Forms.Label lblFinalizarTxt2;
        private System.Windows.Forms.Button btnFinalizarCancelar;
    }
}