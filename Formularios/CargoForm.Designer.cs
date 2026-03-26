namespace SiManEm.Formularios
{
    partial class CargoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label etiquetaDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button botonBuscarDepartamento;
        private System.Windows.Forms.Label etiquetaDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
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
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etiquetaDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.botonBuscarDepartamento = new System.Windows.Forms.Button();
            this.etiquetaDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(20, 23);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(44, 13);
            this.etiquetaNombre.TabIndex = 0;
            this.etiquetaNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // etiquetaDepartamento
            // 
            this.etiquetaDepartamento.AutoSize = true;
            this.etiquetaDepartamento.Location = new System.Drawing.Point(20, 68);
            this.etiquetaDepartamento.Name = "etiquetaDepartamento";
            this.etiquetaDepartamento.Size = new System.Drawing.Size(74, 13);
            this.etiquetaDepartamento.TabIndex = 2;
            this.etiquetaDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(150, 65);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(180, 20);
            this.txtDepartamento.TabIndex = 3;
            // 
            // botonBuscarDepartamento
            // 
            this.botonBuscarDepartamento.Location = new System.Drawing.Point(338, 63);
            this.botonBuscarDepartamento.Name = "botonBuscarDepartamento";
            this.botonBuscarDepartamento.Size = new System.Drawing.Size(92, 28);
            this.botonBuscarDepartamento.TabIndex = 4;
            this.botonBuscarDepartamento.Text = "Buscar...";
            this.botonBuscarDepartamento.UseVisualStyleBackColor = true;
            this.botonBuscarDepartamento.Click += new System.EventHandler(this.botonBuscarDepartamento_Click);
            // 
            // etiquetaDescripcion
            // 
            this.etiquetaDescripcion.AutoSize = true;
            this.etiquetaDescripcion.Location = new System.Drawing.Point(20, 113);
            this.etiquetaDescripcion.Name = "etiquetaDescripcion";
            this.etiquetaDescripcion.Size = new System.Drawing.Size(63, 13);
            this.etiquetaDescripcion.TabIndex = 5;
            this.etiquetaDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(150, 110);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(260, 165);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(80, 28);
            this.botonAceptar.TabIndex = 7;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(350, 165);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 28);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // CargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 220);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.etiquetaDescripcion);
            this.Controls.Add(this.botonBuscarDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.etiquetaDepartamento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiquetaNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
