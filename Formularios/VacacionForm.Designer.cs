namespace SiManEm.Formularios
{
    partial class VacacionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button botonBuscarEmpleado;
        private System.Windows.Forms.Label etiquetaFechaInicio;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label etiquetaFechaFin;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Label etiquetaEstado;
        private System.Windows.Forms.TextBox txtEstado;
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
            this.etiquetaEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.botonBuscarEmpleado = new System.Windows.Forms.Button();
            this.etiquetaFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.etiquetaFechaFin = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaEmpleado
            // 
            this.etiquetaEmpleado.AutoSize = true;
            this.etiquetaEmpleado.Location = new System.Drawing.Point(20, 23);
            this.etiquetaEmpleado.Name = "etiquetaEmpleado";
            this.etiquetaEmpleado.Size = new System.Drawing.Size(51, 13);
            this.etiquetaEmpleado.TabIndex = 0;
            this.etiquetaEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(150, 20);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(180, 20);
            this.txtEmpleado.TabIndex = 1;
            // 
            // botonBuscarEmpleado
            // 
            this.botonBuscarEmpleado.Location = new System.Drawing.Point(338, 18);
            this.botonBuscarEmpleado.Name = "botonBuscarEmpleado";
            this.botonBuscarEmpleado.Size = new System.Drawing.Size(92, 28);
            this.botonBuscarEmpleado.TabIndex = 2;
            this.botonBuscarEmpleado.Text = "Buscar...";
            this.botonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.botonBuscarEmpleado.Click += new System.EventHandler(this.botonBuscarEmpleado_Click);
            // 
            // etiquetaFechaInicio
            // 
            this.etiquetaFechaInicio.AutoSize = true;
            this.etiquetaFechaInicio.Location = new System.Drawing.Point(20, 68);
            this.etiquetaFechaInicio.Name = "etiquetaFechaInicio";
            this.etiquetaFechaInicio.Size = new System.Drawing.Size(59, 13);
            this.etiquetaFechaInicio.TabIndex = 3;
            this.etiquetaFechaInicio.Text = "FechaInicio";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(150, 65);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(280, 20);
            this.txtFechaInicio.TabIndex = 4;
            // 
            // etiquetaFechaFin
            // 
            this.etiquetaFechaFin.AutoSize = true;
            this.etiquetaFechaFin.Location = new System.Drawing.Point(20, 113);
            this.etiquetaFechaFin.Name = "etiquetaFechaFin";
            this.etiquetaFechaFin.Size = new System.Drawing.Size(48, 13);
            this.etiquetaFechaFin.TabIndex = 5;
            this.etiquetaFechaFin.Text = "FechaFin";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(150, 110);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(280, 20);
            this.txtFechaFin.TabIndex = 6;
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Location = new System.Drawing.Point(20, 158);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(40, 13);
            this.etiquetaEstado.TabIndex = 7;
            this.etiquetaEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(150, 155);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(280, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(260, 215);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(80, 28);
            this.botonAceptar.TabIndex = 9;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(350, 215);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 28);
            this.botonCancelar.TabIndex = 10;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // VacacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 280);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.etiquetaEstado);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.etiquetaFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.etiquetaFechaInicio);
            this.Controls.Add(this.botonBuscarEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.etiquetaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VacacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vacacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
