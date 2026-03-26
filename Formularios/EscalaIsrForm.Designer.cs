namespace SiManEm.Formularios
{
    partial class EscalaIsrForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaLimiteInferior;
        private System.Windows.Forms.TextBox txtLimiteInferior;
        private System.Windows.Forms.Label etiquetaLimiteSuperior;
        private System.Windows.Forms.TextBox txtLimiteSuperior;
        private System.Windows.Forms.Label etiquetaTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label etiquetaCuotaFija;
        private System.Windows.Forms.TextBox txtCuotaFija;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.etiquetaLimiteInferior = new System.Windows.Forms.Label();
            this.txtLimiteInferior = new System.Windows.Forms.TextBox();
            this.etiquetaLimiteSuperior = new System.Windows.Forms.Label();
            this.txtLimiteSuperior = new System.Windows.Forms.TextBox();
            this.etiquetaTasa = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.etiquetaCuotaFija = new System.Windows.Forms.Label();
            this.txtCuotaFija = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaLimiteInferior
            // 
            this.etiquetaLimiteInferior.AutoSize = true;
            this.etiquetaLimiteInferior.Location = new System.Drawing.Point(20, 23);
            this.etiquetaLimiteInferior.Name = "etiquetaLimiteInferior";
            this.etiquetaLimiteInferior.Size = new System.Drawing.Size(98, 13);
            this.etiquetaLimiteInferior.TabIndex = 0;
            this.etiquetaLimiteInferior.Text = "LimiteInferior (RD$)";
            // 
            // txtLimiteInferior
            // 
            this.txtLimiteInferior.Location = new System.Drawing.Point(160, 20);
            this.txtLimiteInferior.Name = "txtLimiteInferior";
            this.txtLimiteInferior.Size = new System.Drawing.Size(220, 20);
            this.txtLimiteInferior.TabIndex = 1;
            this.txtLimiteInferior.Leave += new System.EventHandler(this.txtLimiteInferior_Leave);
            // 
            // etiquetaLimiteSuperior
            // 
            this.etiquetaLimiteSuperior.AutoSize = true;
            this.etiquetaLimiteSuperior.Location = new System.Drawing.Point(20, 63);
            this.etiquetaLimiteSuperior.Name = "etiquetaLimiteSuperior";
            this.etiquetaLimiteSuperior.Size = new System.Drawing.Size(102, 13);
            this.etiquetaLimiteSuperior.TabIndex = 2;
            this.etiquetaLimiteSuperior.Text = "LimiteSuperior (RD$)";
            // 
            // txtLimiteSuperior
            // 
            this.txtLimiteSuperior.Location = new System.Drawing.Point(160, 60);
            this.txtLimiteSuperior.Name = "txtLimiteSuperior";
            this.txtLimiteSuperior.Size = new System.Drawing.Size(220, 20);
            this.txtLimiteSuperior.TabIndex = 3;
            this.txtLimiteSuperior.Leave += new System.EventHandler(this.txtLimiteSuperior_Leave);
            // 
            // etiquetaTasa
            // 
            this.etiquetaTasa.AutoSize = true;
            this.etiquetaTasa.Location = new System.Drawing.Point(20, 103);
            this.etiquetaTasa.Name = "etiquetaTasa";
            this.etiquetaTasa.Size = new System.Drawing.Size(49, 13);
            this.etiquetaTasa.TabIndex = 4;
            this.etiquetaTasa.Text = "Tasa (%)";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(160, 100);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(220, 20);
            this.txtTasa.TabIndex = 5;
            this.txtTasa.Leave += new System.EventHandler(this.txtTasa_Leave);
            // 
            // etiquetaCuotaFija
            // 
            this.etiquetaCuotaFija.AutoSize = true;
            this.etiquetaCuotaFija.Location = new System.Drawing.Point(20, 143);
            this.etiquetaCuotaFija.Name = "etiquetaCuotaFija";
            this.etiquetaCuotaFija.Size = new System.Drawing.Size(80, 13);
            this.etiquetaCuotaFija.TabIndex = 6;
            this.etiquetaCuotaFija.Text = "CuotaFija (RD$)";
            // 
            // txtCuotaFija
            // 
            this.txtCuotaFija.Location = new System.Drawing.Point(160, 140);
            this.txtCuotaFija.Name = "txtCuotaFija";
            this.txtCuotaFija.Size = new System.Drawing.Size(220, 20);
            this.txtCuotaFija.TabIndex = 7;
            this.txtCuotaFija.Leave += new System.EventHandler(this.txtCuotaFija_Leave);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(210, 180);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(80, 28);
            this.botonAceptar.TabIndex = 8;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(300, 180);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 28);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // EscalaIsrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtCuotaFija);
            this.Controls.Add(this.etiquetaCuotaFija);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.etiquetaTasa);
            this.Controls.Add(this.txtLimiteSuperior);
            this.Controls.Add(this.etiquetaLimiteSuperior);
            this.Controls.Add(this.txtLimiteInferior);
            this.Controls.Add(this.etiquetaLimiteInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EscalaIsrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Escala ISR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
