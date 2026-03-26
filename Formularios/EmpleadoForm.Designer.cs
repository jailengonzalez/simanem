namespace SiManEm.Formularios
{
    partial class EmpleadoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label etiquetaDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button botonBuscarDepartamento;
        private System.Windows.Forms.Label etiquetaCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button botonBuscarCargo;
        private System.Windows.Forms.Label etiquetaFechaInicio;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label etiquetaSalario;
        private System.Windows.Forms.TextBox txtSalario;
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
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etiquetaDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.botonBuscarDepartamento = new System.Windows.Forms.Button();
            this.etiquetaCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.botonBuscarCargo = new System.Windows.Forms.Button();
            this.etiquetaFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.etiquetaSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            // etiquetaCargo
            // 
            this.etiquetaCargo.AutoSize = true;
            this.etiquetaCargo.Location = new System.Drawing.Point(20, 113);
            this.etiquetaCargo.Name = "etiquetaCargo";
            this.etiquetaCargo.Size = new System.Drawing.Size(35, 13);
            this.etiquetaCargo.TabIndex = 5;
            this.etiquetaCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(150, 110);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(180, 20);
            this.txtCargo.TabIndex = 6;
            // 
            // botonBuscarCargo
            // 
            this.botonBuscarCargo.Location = new System.Drawing.Point(338, 108);
            this.botonBuscarCargo.Name = "botonBuscarCargo";
            this.botonBuscarCargo.Size = new System.Drawing.Size(92, 28);
            this.botonBuscarCargo.TabIndex = 7;
            this.botonBuscarCargo.Text = "Buscar...";
            this.botonBuscarCargo.UseVisualStyleBackColor = true;
            this.botonBuscarCargo.Click += new System.EventHandler(this.botonBuscarCargo_Click);
            // 
            // etiquetaFechaInicio
            // 
            this.etiquetaFechaInicio.AutoSize = true;
            this.etiquetaFechaInicio.Location = new System.Drawing.Point(20, 158);
            this.etiquetaFechaInicio.Name = "etiquetaFechaInicio";
            this.etiquetaFechaInicio.Size = new System.Drawing.Size(59, 13);
            this.etiquetaFechaInicio.TabIndex = 8;
            this.etiquetaFechaInicio.Text = "FechaInicio";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(150, 155);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(280, 20);
            this.txtFechaInicio.TabIndex = 9;
            // 
            // etiquetaSalario
            // 
            this.etiquetaSalario.AutoSize = true;
            this.etiquetaSalario.Location = new System.Drawing.Point(20, 203);
            this.etiquetaSalario.Name = "etiquetaSalario";
            this.etiquetaSalario.Size = new System.Drawing.Size(39, 13);
            this.etiquetaSalario.TabIndex = 10;
            this.etiquetaSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(150, 200);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(280, 20);
            this.txtSalario.TabIndex = 11;
            this.txtSalario.Leave += new System.EventHandler(this.txtSalario_Leave);
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Location = new System.Drawing.Point(20, 248);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(40, 13);
            this.etiquetaEstado.TabIndex = 12;
            this.etiquetaEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(150, 245);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(280, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(260, 295);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(80, 28);
            this.botonAceptar.TabIndex = 14;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(350, 295);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 28);
            this.botonCancelar.TabIndex = 15;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // EmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 360);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.etiquetaEstado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.etiquetaSalario);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.etiquetaFechaInicio);
            this.Controls.Add(this.botonBuscarCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.etiquetaCargo);
            this.Controls.Add(this.botonBuscarDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.etiquetaDepartamento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiquetaNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpleadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
