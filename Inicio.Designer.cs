namespace SiManEm
{
    partial class Inicio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label etiquetaLogo;
        private System.Windows.Forms.Label etiquetaNombreApp;
        private System.Windows.Forms.Button botonTabInicio;
        private System.Windows.Forms.Button botonTabEmpleados;
        private System.Windows.Forms.Button botonTabDepartamentos;
        private System.Windows.Forms.Button botonTabCargos;
        private System.Windows.Forms.Button botonTabVacaciones;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TabControl tabControlContenido;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.TabPage tabCargos;
        private System.Windows.Forms.TabPage tabVacaciones;
        private System.Windows.Forms.Label etiquetaTituloInicio;
        private System.Windows.Forms.Label etiquetaTituloEmpleados;
        private System.Windows.Forms.Label etiquetaTituloDepartamentos;
        private System.Windows.Forms.Label etiquetaTituloCargos;
        private System.Windows.Forms.Label etiquetaTituloVacaciones;
        private System.Windows.Forms.Panel panelBarraVentana;
        private System.Windows.Forms.Button botonMinimizar;
        private System.Windows.Forms.Button botonCerrar;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.botonTabVacaciones = new System.Windows.Forms.Button();
            this.botonTabCargos = new System.Windows.Forms.Button();
            this.botonTabDepartamentos = new System.Windows.Forms.Button();
            this.botonTabEmpleados = new System.Windows.Forms.Button();
            this.botonTabInicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.etiquetaNombreApp = new System.Windows.Forms.Label();
            this.etiquetaLogo = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tabControlContenido = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.etiquetaTituloInicio = new System.Windows.Forms.Label();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.etiquetaTituloEmpleados = new System.Windows.Forms.Label();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.etiquetaTituloDepartamentos = new System.Windows.Forms.Label();
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.etiquetaTituloCargos = new System.Windows.Forms.Label();
            this.tabVacaciones = new System.Windows.Forms.TabPage();
            this.etiquetaTituloVacaciones = new System.Windows.Forms.Label();
            this.panelBarraVentana = new System.Windows.Forms.Panel();
            this.botonMinimizar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tabControlContenido.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            this.tabDepartamentos.SuspendLayout();
            this.tabCargos.SuspendLayout();
            this.tabVacaciones.SuspendLayout();
            this.panelBarraVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.botonTabVacaciones);
            this.panelMenu.Controls.Add(this.botonTabCargos);
            this.panelMenu.Controls.Add(this.botonTabDepartamentos);
            this.panelMenu.Controls.Add(this.botonTabEmpleados);
            this.panelMenu.Controls.Add(this.botonTabInicio);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 540);
            this.panelMenu.TabIndex = 0;
            // 
            // botonTabVacaciones
            // 
            this.botonTabVacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabVacaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabVacaciones.FlatAppearance.BorderSize = 0;
            this.botonTabVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabVacaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabVacaciones.ForeColor = System.Drawing.Color.White;
            this.botonTabVacaciones.Location = new System.Drawing.Point(0, 320);
            this.botonTabVacaciones.Name = "botonTabVacaciones";
            this.botonTabVacaciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabVacaciones.Size = new System.Drawing.Size(220, 55);
            this.botonTabVacaciones.TabIndex = 5;
            this.botonTabVacaciones.Text = "Vacaciones";
            this.botonTabVacaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabVacaciones.UseVisualStyleBackColor = true;
            this.botonTabVacaciones.Click += new System.EventHandler(this.botonTabVacaciones_Click);
            // 
            // botonTabCargos
            // 
            this.botonTabCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabCargos.FlatAppearance.BorderSize = 0;
            this.botonTabCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabCargos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabCargos.ForeColor = System.Drawing.Color.White;
            this.botonTabCargos.Location = new System.Drawing.Point(0, 265);
            this.botonTabCargos.Name = "botonTabCargos";
            this.botonTabCargos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabCargos.Size = new System.Drawing.Size(220, 55);
            this.botonTabCargos.TabIndex = 4;
            this.botonTabCargos.Text = "Cargos";
            this.botonTabCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabCargos.UseVisualStyleBackColor = true;
            this.botonTabCargos.Click += new System.EventHandler(this.botonTabCargos_Click);
            // 
            // botonTabDepartamentos
            // 
            this.botonTabDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabDepartamentos.FlatAppearance.BorderSize = 0;
            this.botonTabDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabDepartamentos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabDepartamentos.ForeColor = System.Drawing.Color.White;
            this.botonTabDepartamentos.Location = new System.Drawing.Point(0, 210);
            this.botonTabDepartamentos.Name = "botonTabDepartamentos";
            this.botonTabDepartamentos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabDepartamentos.Size = new System.Drawing.Size(220, 55);
            this.botonTabDepartamentos.TabIndex = 3;
            this.botonTabDepartamentos.Text = "Departamentos";
            this.botonTabDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabDepartamentos.UseVisualStyleBackColor = true;
            this.botonTabDepartamentos.Click += new System.EventHandler(this.botonTabDepartamentos_Click);
            // 
            // botonTabEmpleados
            // 
            this.botonTabEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabEmpleados.FlatAppearance.BorderSize = 0;
            this.botonTabEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabEmpleados.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabEmpleados.ForeColor = System.Drawing.Color.White;
            this.botonTabEmpleados.Location = new System.Drawing.Point(0, 155);
            this.botonTabEmpleados.Name = "botonTabEmpleados";
            this.botonTabEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabEmpleados.Size = new System.Drawing.Size(220, 55);
            this.botonTabEmpleados.TabIndex = 2;
            this.botonTabEmpleados.Text = "Empleados";
            this.botonTabEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabEmpleados.UseVisualStyleBackColor = true;
            this.botonTabEmpleados.Click += new System.EventHandler(this.botonTabEmpleados_Click);
            // 
            // botonTabInicio
            // 
            this.botonTabInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabInicio.FlatAppearance.BorderSize = 0;
            this.botonTabInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabInicio.ForeColor = System.Drawing.Color.White;
            this.botonTabInicio.Location = new System.Drawing.Point(0, 100);
            this.botonTabInicio.Name = "botonTabInicio";
            this.botonTabInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabInicio.Size = new System.Drawing.Size(220, 55);
            this.botonTabInicio.TabIndex = 1;
            this.botonTabInicio.Text = "Inicio";
            this.botonTabInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabInicio.UseVisualStyleBackColor = true;
            this.botonTabInicio.Click += new System.EventHandler(this.botonTabInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.etiquetaNombreApp);
            this.panelLogo.Controls.Add(this.etiquetaLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // etiquetaNombreApp
            // 
            this.etiquetaNombreApp.AutoSize = true;
            this.etiquetaNombreApp.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.etiquetaNombreApp.ForeColor = System.Drawing.Color.White;
            this.etiquetaNombreApp.Location = new System.Drawing.Point(72, 34);
            this.etiquetaNombreApp.Name = "etiquetaNombreApp";
            this.etiquetaNombreApp.Size = new System.Drawing.Size(103, 30);
            this.etiquetaNombreApp.TabIndex = 1;
            this.etiquetaNombreApp.Text = "SiManEm";
            // 
            // etiquetaLogo
            // 
            this.etiquetaLogo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.etiquetaLogo.ForeColor = System.Drawing.Color.White;
            this.etiquetaLogo.Location = new System.Drawing.Point(11, 20);
            this.etiquetaLogo.Name = "etiquetaLogo";
            this.etiquetaLogo.Size = new System.Drawing.Size(60, 60);
            this.etiquetaLogo.TabIndex = 0;
            this.etiquetaLogo.Text = "S";
            this.etiquetaLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.tabControlContenido);
            this.panelPrincipal.Controls.Add(this.panelBarraVentana);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(220, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(18);
            this.panelPrincipal.Size = new System.Drawing.Size(760, 540);
            this.panelPrincipal.TabIndex = 1;
            // 
            // tabControlContenido
            // 
            this.tabControlContenido.Controls.Add(this.tabInicio);
            this.tabControlContenido.Controls.Add(this.tabEmpleados);
            this.tabControlContenido.Controls.Add(this.tabDepartamentos);
            this.tabControlContenido.Controls.Add(this.tabCargos);
            this.tabControlContenido.Controls.Add(this.tabVacaciones);
            this.tabControlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContenido.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlContenido.Location = new System.Drawing.Point(18, 62);
            this.tabControlContenido.Multiline = true;
            this.tabControlContenido.Name = "tabControlContenido";
            this.tabControlContenido.SelectedIndex = 0;
            this.tabControlContenido.Size = new System.Drawing.Size(724, 460);
            this.tabControlContenido.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.White;
            this.tabInicio.Controls.Add(this.etiquetaTituloInicio);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(716, 434);
            this.tabInicio.TabIndex = 0;
            // 
            // etiquetaTituloInicio
            // 
            this.etiquetaTituloInicio.AutoSize = true;
            this.etiquetaTituloInicio.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloInicio.Location = new System.Drawing.Point(24, 24);
            this.etiquetaTituloInicio.Name = "etiquetaTituloInicio";
            this.etiquetaTituloInicio.Size = new System.Drawing.Size(174, 45);
            this.etiquetaTituloInicio.TabIndex = 0;
            this.etiquetaTituloInicio.Text = "Dashboard";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.BackColor = System.Drawing.Color.White;
            this.tabEmpleados.Controls.Add(this.etiquetaTituloEmpleados);
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(716, 434);
            this.tabEmpleados.TabIndex = 1;
            // 
            // etiquetaTituloEmpleados
            // 
            this.etiquetaTituloEmpleados.AutoSize = true;
            this.etiquetaTituloEmpleados.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloEmpleados.Location = new System.Drawing.Point(24, 24);
            this.etiquetaTituloEmpleados.Name = "etiquetaTituloEmpleados";
            this.etiquetaTituloEmpleados.Size = new System.Drawing.Size(176, 45);
            this.etiquetaTituloEmpleados.TabIndex = 0;
            this.etiquetaTituloEmpleados.Text = "Empleados";
            // 
            // tabDepartamentos
            // 
            this.tabDepartamentos.BackColor = System.Drawing.Color.White;
            this.tabDepartamentos.Controls.Add(this.etiquetaTituloDepartamentos);
            this.tabDepartamentos.Location = new System.Drawing.Point(4, 22);
            this.tabDepartamentos.Name = "tabDepartamentos";
            this.tabDepartamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartamentos.Size = new System.Drawing.Size(716, 434);
            this.tabDepartamentos.TabIndex = 2;
            // 
            // etiquetaTituloDepartamentos
            // 
            this.etiquetaTituloDepartamentos.AutoSize = true;
            this.etiquetaTituloDepartamentos.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloDepartamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloDepartamentos.Location = new System.Drawing.Point(24, 24);
            this.etiquetaTituloDepartamentos.Name = "etiquetaTituloDepartamentos";
            this.etiquetaTituloDepartamentos.Size = new System.Drawing.Size(239, 45);
            this.etiquetaTituloDepartamentos.TabIndex = 0;
            this.etiquetaTituloDepartamentos.Text = "Departamentos";
            // 
            // tabCargos
            // 
            this.tabCargos.BackColor = System.Drawing.Color.White;
            this.tabCargos.Controls.Add(this.etiquetaTituloCargos);
            this.tabCargos.Location = new System.Drawing.Point(4, 22);
            this.tabCargos.Name = "tabCargos";
            this.tabCargos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargos.Size = new System.Drawing.Size(716, 434);
            this.tabCargos.TabIndex = 3;
            // 
            // etiquetaTituloCargos
            // 
            this.etiquetaTituloCargos.AutoSize = true;
            this.etiquetaTituloCargos.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloCargos.Location = new System.Drawing.Point(24, 24);
            this.etiquetaTituloCargos.Name = "etiquetaTituloCargos";
            this.etiquetaTituloCargos.Size = new System.Drawing.Size(119, 45);
            this.etiquetaTituloCargos.TabIndex = 0;
            this.etiquetaTituloCargos.Text = "Cargos";
            // 
            // tabVacaciones
            // 
            this.tabVacaciones.BackColor = System.Drawing.Color.White;
            this.tabVacaciones.Controls.Add(this.etiquetaTituloVacaciones);
            this.tabVacaciones.Location = new System.Drawing.Point(4, 5);
            this.tabVacaciones.Name = "tabVacaciones";
            this.tabVacaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacaciones.Size = new System.Drawing.Size(716, 451);
            this.tabVacaciones.TabIndex = 4;
            // 
            // etiquetaTituloVacaciones
            // 
            this.etiquetaTituloVacaciones.AutoSize = true;
            this.etiquetaTituloVacaciones.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloVacaciones.Location = new System.Drawing.Point(24, 24);
            this.etiquetaTituloVacaciones.Name = "etiquetaTituloVacaciones";
            this.etiquetaTituloVacaciones.Size = new System.Drawing.Size(176, 45);
            this.etiquetaTituloVacaciones.TabIndex = 0;
            this.etiquetaTituloVacaciones.Text = "Vacaciones";
            // 
            // panelBarraVentana
            // 
            this.panelBarraVentana.Controls.Add(this.botonMinimizar);
            this.panelBarraVentana.Controls.Add(this.botonCerrar);
            this.panelBarraVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraVentana.Location = new System.Drawing.Point(18, 18);
            this.panelBarraVentana.Name = "panelBarraVentana";
            this.panelBarraVentana.Size = new System.Drawing.Size(724, 44);
            this.panelBarraVentana.TabIndex = 1;
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.FlatAppearance.BorderSize = 0;
            this.botonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMinimizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.botonMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonMinimizar.Location = new System.Drawing.Point(640, 6);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(34, 32);
            this.botonMinimizar.TabIndex = 0;
            this.botonMinimizar.Text = "-";
            this.botonMinimizar.UseVisualStyleBackColor = true;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.botonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonCerrar.Location = new System.Drawing.Point(680, 6);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(34, 32);
            this.botonCerrar.TabIndex = 1;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 540);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiManEm - Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.tabControlContenido.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            this.tabEmpleados.ResumeLayout(false);
            this.tabEmpleados.PerformLayout();
            this.tabDepartamentos.ResumeLayout(false);
            this.tabDepartamentos.PerformLayout();
            this.tabCargos.ResumeLayout(false);
            this.tabCargos.PerformLayout();
            this.tabVacaciones.ResumeLayout(false);
            this.tabVacaciones.PerformLayout();
            this.panelBarraVentana.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }
}
