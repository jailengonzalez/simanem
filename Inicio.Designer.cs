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
        private System.Windows.Forms.Button botonTabUsuarios;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TabControl tabControlContenido;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.TabPage tabCargos;
        private System.Windows.Forms.TabPage tabVacaciones;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label etiquetaTituloInicio;
        private System.Windows.Forms.Label etiquetaTituloEmpleados;
        private System.Windows.Forms.Label etiquetaTituloDepartamentos;
        private System.Windows.Forms.Label etiquetaTituloCargos;
        private System.Windows.Forms.Label etiquetaTituloVacaciones;
        private System.Windows.Forms.Panel panelCrudEmpleados;
        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Button botonNuevoEmpleado;
        private System.Windows.Forms.Button botonEditarEmpleado;
        private System.Windows.Forms.Button botonEliminarEmpleado;
        private System.Windows.Forms.Button botonRefrescarEmpleado;
        private System.Windows.Forms.Panel panelCrudDepartamentos;
        private System.Windows.Forms.DataGridView gridDepartamentos;
        private System.Windows.Forms.Button botonNuevoDepartamento;
        private System.Windows.Forms.Button botonEditarDepartamento;
        private System.Windows.Forms.Button botonEliminarDepartamento;
        private System.Windows.Forms.Button botonRefrescarDepartamento;
        private System.Windows.Forms.Panel panelCrudCargos;
        private System.Windows.Forms.DataGridView gridCargos;
        private System.Windows.Forms.Button botonNuevoCargo;
        private System.Windows.Forms.Button botonEditarCargo;
        private System.Windows.Forms.Button botonEliminarCargo;
        private System.Windows.Forms.Button botonRefrescarCargo;
        private System.Windows.Forms.Panel panelCrudVacaciones;
        private System.Windows.Forms.DataGridView gridVacaciones;
        private System.Windows.Forms.Button botonNuevaVacacion;
        private System.Windows.Forms.Button botonEditarVacacion;
        private System.Windows.Forms.Button botonEliminarVacacion;
        private System.Windows.Forms.Button botonRefrescarVacacion;
        private System.Windows.Forms.Panel panelBarraVentana;
        private System.Windows.Forms.Button botonMinimizar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonConfigNomina;
        private System.Windows.Forms.Label etiquetaDashboardTotalEmpleados;
        private System.Windows.Forms.Label etiquetaDashboardTotalEmpleadosValor;
        private System.Windows.Forms.Label etiquetaDashboardAfp;
        private System.Windows.Forms.Label etiquetaDashboardAfpValor;
        private System.Windows.Forms.Label etiquetaDashboardArs;
        private System.Windows.Forms.Label etiquetaDashboardArsValor;
        private System.Windows.Forms.Label etiquetaDashboardIsr;
        private System.Windows.Forms.Label etiquetaDashboardIsrValor;
        private System.Windows.Forms.Label etiquetaDashboardDepartamento;
        private System.Windows.Forms.ComboBox comboDashboardDepartamento;
        private System.Windows.Forms.Label etiquetaDashboardDepartamentoValor;
        private System.Windows.Forms.Button botonDashboardRefrescar;
        private System.Windows.Forms.DataGridView gridDashboardDepartamentos;
        private System.Windows.Forms.Button botonExportarDashboard;
        private System.Windows.Forms.Button botonExportarEmpleados;
        private System.Windows.Forms.Button botonExportarDepartamentos;
        private System.Windows.Forms.Button botonExportarCargos;
        private System.Windows.Forms.Button botonExportarVacaciones;
        private System.Windows.Forms.Panel panelCrudUsuarios;
        private System.Windows.Forms.Button botonExportarUsuarios;
        private System.Windows.Forms.Button botonRefrescarUsuario;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.Button botonEditarUsuario;
        private System.Windows.Forms.Button botonNuevoUsuario;
        private System.Windows.Forms.DataGridView gridUsuarios;

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
            this.botonTabUsuarios = new System.Windows.Forms.Button();
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
            this.botonExportarDashboard = new System.Windows.Forms.Button();
            this.gridDashboardDepartamentos = new System.Windows.Forms.DataGridView();
            this.botonDashboardRefrescar = new System.Windows.Forms.Button();
            this.etiquetaDashboardDepartamentoValor = new System.Windows.Forms.Label();
            this.comboDashboardDepartamento = new System.Windows.Forms.ComboBox();
            this.etiquetaDashboardDepartamento = new System.Windows.Forms.Label();
            this.etiquetaDashboardIsrValor = new System.Windows.Forms.Label();
            this.etiquetaDashboardIsr = new System.Windows.Forms.Label();
            this.etiquetaDashboardArsValor = new System.Windows.Forms.Label();
            this.etiquetaDashboardArs = new System.Windows.Forms.Label();
            this.etiquetaDashboardAfpValor = new System.Windows.Forms.Label();
            this.etiquetaDashboardAfp = new System.Windows.Forms.Label();
            this.etiquetaDashboardTotalEmpleadosValor = new System.Windows.Forms.Label();
            this.etiquetaDashboardTotalEmpleados = new System.Windows.Forms.Label();
            this.botonConfigNomina = new System.Windows.Forms.Button();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.panelCrudEmpleados = new System.Windows.Forms.Panel();
            this.botonExportarEmpleados = new System.Windows.Forms.Button();
            this.botonRefrescarEmpleado = new System.Windows.Forms.Button();
            this.botonEliminarEmpleado = new System.Windows.Forms.Button();
            this.botonEditarEmpleado = new System.Windows.Forms.Button();
            this.botonNuevoEmpleado = new System.Windows.Forms.Button();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.gridDepartamentos = new System.Windows.Forms.DataGridView();
            this.panelCrudDepartamentos = new System.Windows.Forms.Panel();
            this.botonExportarDepartamentos = new System.Windows.Forms.Button();
            this.botonRefrescarDepartamento = new System.Windows.Forms.Button();
            this.botonEliminarDepartamento = new System.Windows.Forms.Button();
            this.botonEditarDepartamento = new System.Windows.Forms.Button();
            this.botonNuevoDepartamento = new System.Windows.Forms.Button();
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.gridCargos = new System.Windows.Forms.DataGridView();
            this.panelCrudCargos = new System.Windows.Forms.Panel();
            this.botonExportarCargos = new System.Windows.Forms.Button();
            this.botonRefrescarCargo = new System.Windows.Forms.Button();
            this.botonEliminarCargo = new System.Windows.Forms.Button();
            this.botonEditarCargo = new System.Windows.Forms.Button();
            this.botonNuevoCargo = new System.Windows.Forms.Button();
            this.tabVacaciones = new System.Windows.Forms.TabPage();
            this.gridVacaciones = new System.Windows.Forms.DataGridView();
            this.panelCrudVacaciones = new System.Windows.Forms.Panel();
            this.botonExportarVacaciones = new System.Windows.Forms.Button();
            this.botonRefrescarVacacion = new System.Windows.Forms.Button();
            this.botonEliminarVacacion = new System.Windows.Forms.Button();
            this.botonEditarVacacion = new System.Windows.Forms.Button();
            this.botonNuevaVacacion = new System.Windows.Forms.Button();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.panelCrudUsuarios = new System.Windows.Forms.Panel();
            this.botonExportarUsuarios = new System.Windows.Forms.Button();
            this.botonRefrescarUsuario = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.botonEditarUsuario = new System.Windows.Forms.Button();
            this.botonNuevoUsuario = new System.Windows.Forms.Button();
            this.panelBarraVentana = new System.Windows.Forms.Panel();
            this.etiquetaTituloInicio = new System.Windows.Forms.Label();
            this.botonMinimizar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.etiquetaTituloEmpleados = new System.Windows.Forms.Label();
            this.etiquetaTituloDepartamentos = new System.Windows.Forms.Label();
            this.etiquetaTituloCargos = new System.Windows.Forms.Label();
            this.etiquetaTituloVacaciones = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.tabControlContenido.SuspendLayout();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardDepartamentos)).BeginInit();
            this.tabEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.panelCrudEmpleados.SuspendLayout();
            this.tabDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamentos)).BeginInit();
            this.panelCrudDepartamentos.SuspendLayout();
            this.tabCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).BeginInit();
            this.panelCrudCargos.SuspendLayout();
            this.tabVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVacaciones)).BeginInit();
            this.panelCrudVacaciones.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.panelCrudUsuarios.SuspendLayout();
            this.panelBarraVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.botonTabUsuarios);
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
            // botonTabUsuarios
            // 
            this.botonTabUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonTabUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonTabUsuarios.FlatAppearance.BorderSize = 0;
            this.botonTabUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonTabUsuarios.ForeColor = System.Drawing.Color.White;
            this.botonTabUsuarios.Location = new System.Drawing.Point(0, 375);
            this.botonTabUsuarios.Name = "botonTabUsuarios";
            this.botonTabUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.botonTabUsuarios.Size = new System.Drawing.Size(220, 55);
            this.botonTabUsuarios.TabIndex = 6;
            this.botonTabUsuarios.Text = "Usuarios";
            this.botonTabUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonTabUsuarios.UseVisualStyleBackColor = true;
            this.botonTabUsuarios.Click += new System.EventHandler(this.botonTabUsuarios_Click);
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
            this.tabControlContenido.Controls.Add(this.tabUsuarios);
            this.tabControlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContenido.Location = new System.Drawing.Point(18, 62);
            this.tabControlContenido.Name = "tabControlContenido";
            this.tabControlContenido.SelectedIndex = 0;
            this.tabControlContenido.Size = new System.Drawing.Size(724, 460);
            this.tabControlContenido.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.White;
            this.tabInicio.Controls.Add(this.botonExportarDashboard);
            this.tabInicio.Controls.Add(this.gridDashboardDepartamentos);
            this.tabInicio.Controls.Add(this.botonDashboardRefrescar);
            this.tabInicio.Controls.Add(this.etiquetaDashboardDepartamentoValor);
            this.tabInicio.Controls.Add(this.comboDashboardDepartamento);
            this.tabInicio.Controls.Add(this.etiquetaDashboardDepartamento);
            this.tabInicio.Controls.Add(this.etiquetaDashboardIsrValor);
            this.tabInicio.Controls.Add(this.etiquetaDashboardIsr);
            this.tabInicio.Controls.Add(this.etiquetaDashboardArsValor);
            this.tabInicio.Controls.Add(this.etiquetaDashboardArs);
            this.tabInicio.Controls.Add(this.etiquetaDashboardAfpValor);
            this.tabInicio.Controls.Add(this.etiquetaDashboardAfp);
            this.tabInicio.Controls.Add(this.etiquetaDashboardTotalEmpleadosValor);
            this.tabInicio.Controls.Add(this.etiquetaDashboardTotalEmpleados);
            this.tabInicio.Controls.Add(this.botonConfigNomina);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(716, 434);
            this.tabInicio.TabIndex = 0;
            // 
            // botonExportarDashboard
            // 
            this.botonExportarDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarDashboard.ForeColor = System.Drawing.Color.White;
            this.botonExportarDashboard.Location = new System.Drawing.Point(576, 127);
            this.botonExportarDashboard.Name = "botonExportarDashboard";
            this.botonExportarDashboard.Size = new System.Drawing.Size(120, 30);
            this.botonExportarDashboard.TabIndex = 14;
            this.botonExportarDashboard.Text = "Exportar PDF";
            this.botonExportarDashboard.UseVisualStyleBackColor = false;
            this.botonExportarDashboard.Click += new System.EventHandler(this.botonExportarDashboard_Click);
            // 
            // gridDashboardDepartamentos
            // 
            this.gridDashboardDepartamentos.AllowUserToAddRows = false;
            this.gridDashboardDepartamentos.AllowUserToDeleteRows = false;
            this.gridDashboardDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDashboardDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDashboardDepartamentos.Location = new System.Drawing.Point(25, 167);
            this.gridDashboardDepartamentos.Name = "gridDashboardDepartamentos";
            this.gridDashboardDepartamentos.ReadOnly = true;
            this.gridDashboardDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDashboardDepartamentos.Size = new System.Drawing.Size(1178, 578);
            this.gridDashboardDepartamentos.TabIndex = 13;
            // 
            // botonDashboardRefrescar
            // 
            this.botonDashboardRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonDashboardRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonDashboardRefrescar.ForeColor = System.Drawing.Color.White;
            this.botonDashboardRefrescar.Location = new System.Drawing.Point(470, 128);
            this.botonDashboardRefrescar.Name = "botonDashboardRefrescar";
            this.botonDashboardRefrescar.Size = new System.Drawing.Size(100, 30);
            this.botonDashboardRefrescar.TabIndex = 12;
            this.botonDashboardRefrescar.Text = "Refrescar";
            this.botonDashboardRefrescar.UseVisualStyleBackColor = false;
            this.botonDashboardRefrescar.Click += new System.EventHandler(this.botonDashboardRefrescar_Click);
            // 
            // etiquetaDashboardDepartamentoValor
            // 
            this.etiquetaDashboardDepartamentoValor.AutoSize = true;
            this.etiquetaDashboardDepartamentoValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.etiquetaDashboardDepartamentoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardDepartamentoValor.Location = new System.Drawing.Point(359, 127);
            this.etiquetaDashboardDepartamentoValor.Name = "etiquetaDashboardDepartamentoValor";
            this.etiquetaDashboardDepartamentoValor.Size = new System.Drawing.Size(18, 20);
            this.etiquetaDashboardDepartamentoValor.TabIndex = 11;
            this.etiquetaDashboardDepartamentoValor.Text = "0";
            // 
            // comboDashboardDepartamento
            // 
            this.comboDashboardDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDashboardDepartamento.FormattingEnabled = true;
            this.comboDashboardDepartamento.Location = new System.Drawing.Point(157, 123);
            this.comboDashboardDepartamento.Name = "comboDashboardDepartamento";
            this.comboDashboardDepartamento.Size = new System.Drawing.Size(193, 21);
            this.comboDashboardDepartamento.TabIndex = 10;
            this.comboDashboardDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboDashboardDepartamento_SelectedIndexChanged);
            // 
            // etiquetaDashboardDepartamento
            // 
            this.etiquetaDashboardDepartamento.AutoSize = true;
            this.etiquetaDashboardDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.etiquetaDashboardDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardDepartamento.Location = new System.Drawing.Point(25, 128);
            this.etiquetaDashboardDepartamento.Name = "etiquetaDashboardDepartamento";
            this.etiquetaDashboardDepartamento.Size = new System.Drawing.Size(119, 15);
            this.etiquetaDashboardDepartamento.TabIndex = 9;
            this.etiquetaDashboardDepartamento.Text = "Empleados en Depto:";
            // 
            // etiquetaDashboardIsrValor
            // 
            this.etiquetaDashboardIsrValor.AutoSize = true;
            this.etiquetaDashboardIsrValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.etiquetaDashboardIsrValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardIsrValor.Location = new System.Drawing.Point(546, 87);
            this.etiquetaDashboardIsrValor.Name = "etiquetaDashboardIsrValor";
            this.etiquetaDashboardIsrValor.Size = new System.Drawing.Size(36, 19);
            this.etiquetaDashboardIsrValor.TabIndex = 8;
            this.etiquetaDashboardIsrValor.Text = "RD$";
            // 
            // etiquetaDashboardIsr
            // 
            this.etiquetaDashboardIsr.AutoSize = true;
            this.etiquetaDashboardIsr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.etiquetaDashboardIsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardIsr.Location = new System.Drawing.Point(410, 90);
            this.etiquetaDashboardIsr.Name = "etiquetaDashboardIsr";
            this.etiquetaDashboardIsr.Size = new System.Drawing.Size(133, 15);
            this.etiquetaDashboardIsr.TabIndex = 7;
            this.etiquetaDashboardIsr.Text = "Descuento ISR mensual:";
            // 
            // etiquetaDashboardArsValor
            // 
            this.etiquetaDashboardArsValor.AutoSize = true;
            this.etiquetaDashboardArsValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.etiquetaDashboardArsValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardArsValor.Location = new System.Drawing.Point(546, 51);
            this.etiquetaDashboardArsValor.Name = "etiquetaDashboardArsValor";
            this.etiquetaDashboardArsValor.Size = new System.Drawing.Size(36, 19);
            this.etiquetaDashboardArsValor.TabIndex = 6;
            this.etiquetaDashboardArsValor.Text = "RD$";
            // 
            // etiquetaDashboardArs
            // 
            this.etiquetaDashboardArs.AutoSize = true;
            this.etiquetaDashboardArs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.etiquetaDashboardArs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardArs.Location = new System.Drawing.Point(410, 54);
            this.etiquetaDashboardArs.Name = "etiquetaDashboardArs";
            this.etiquetaDashboardArs.Size = new System.Drawing.Size(138, 15);
            this.etiquetaDashboardArs.TabIndex = 5;
            this.etiquetaDashboardArs.Text = "Descuento ARS mensual:";
            // 
            // etiquetaDashboardAfpValor
            // 
            this.etiquetaDashboardAfpValor.AutoSize = true;
            this.etiquetaDashboardAfpValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.etiquetaDashboardAfpValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardAfpValor.Location = new System.Drawing.Point(546, 15);
            this.etiquetaDashboardAfpValor.Name = "etiquetaDashboardAfpValor";
            this.etiquetaDashboardAfpValor.Size = new System.Drawing.Size(36, 19);
            this.etiquetaDashboardAfpValor.TabIndex = 4;
            this.etiquetaDashboardAfpValor.Text = "RD$";
            // 
            // etiquetaDashboardAfp
            // 
            this.etiquetaDashboardAfp.AutoSize = true;
            this.etiquetaDashboardAfp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.etiquetaDashboardAfp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardAfp.Location = new System.Drawing.Point(410, 18);
            this.etiquetaDashboardAfp.Name = "etiquetaDashboardAfp";
            this.etiquetaDashboardAfp.Size = new System.Drawing.Size(138, 15);
            this.etiquetaDashboardAfp.TabIndex = 3;
            this.etiquetaDashboardAfp.Text = "Descuento AFP mensual:";
            // 
            // etiquetaDashboardTotalEmpleadosValor
            // 
            this.etiquetaDashboardTotalEmpleadosValor.AutoSize = true;
            this.etiquetaDashboardTotalEmpleadosValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.etiquetaDashboardTotalEmpleadosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardTotalEmpleadosValor.Location = new System.Drawing.Point(243, 77);
            this.etiquetaDashboardTotalEmpleadosValor.Name = "etiquetaDashboardTotalEmpleadosValor";
            this.etiquetaDashboardTotalEmpleadosValor.Size = new System.Drawing.Size(28, 32);
            this.etiquetaDashboardTotalEmpleadosValor.TabIndex = 2;
            this.etiquetaDashboardTotalEmpleadosValor.Text = "0";
            // 
            // etiquetaDashboardTotalEmpleados
            // 
            this.etiquetaDashboardTotalEmpleados.AutoSize = true;
            this.etiquetaDashboardTotalEmpleados.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.etiquetaDashboardTotalEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaDashboardTotalEmpleados.Location = new System.Drawing.Point(25, 86);
            this.etiquetaDashboardTotalEmpleados.Name = "etiquetaDashboardTotalEmpleados";
            this.etiquetaDashboardTotalEmpleados.Size = new System.Drawing.Size(206, 20);
            this.etiquetaDashboardTotalEmpleados.TabIndex = 1;
            this.etiquetaDashboardTotalEmpleados.Text = "Cantidad total de empleados:";
            // 
            // botonConfigNomina
            // 
            this.botonConfigNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonConfigNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConfigNomina.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.botonConfigNomina.ForeColor = System.Drawing.Color.White;
            this.botonConfigNomina.Location = new System.Drawing.Point(22, 21);
            this.botonConfigNomina.Name = "botonConfigNomina";
            this.botonConfigNomina.Size = new System.Drawing.Size(332, 36);
            this.botonConfigNomina.TabIndex = 0;
            this.botonConfigNomina.Text = "Configurar AFP / ARS / ISR";
            this.botonConfigNomina.UseVisualStyleBackColor = false;
            this.botonConfigNomina.Click += new System.EventHandler(this.botonConfigNomina_Click);
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.BackColor = System.Drawing.Color.White;
            this.tabEmpleados.Controls.Add(this.gridEmpleados);
            this.tabEmpleados.Controls.Add(this.panelCrudEmpleados);
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(716, 434);
            this.tabEmpleados.TabIndex = 1;
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.AllowUserToAddRows = false;
            this.gridEmpleados.AllowUserToDeleteRows = false;
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmpleados.Location = new System.Drawing.Point(3, 51);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.ReadOnly = true;
            this.gridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpleados.Size = new System.Drawing.Size(710, 380);
            this.gridEmpleados.TabIndex = 2;
            // 
            // panelCrudEmpleados
            // 
            this.panelCrudEmpleados.Controls.Add(this.botonExportarEmpleados);
            this.panelCrudEmpleados.Controls.Add(this.botonRefrescarEmpleado);
            this.panelCrudEmpleados.Controls.Add(this.botonEliminarEmpleado);
            this.panelCrudEmpleados.Controls.Add(this.botonEditarEmpleado);
            this.panelCrudEmpleados.Controls.Add(this.botonNuevoEmpleado);
            this.panelCrudEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudEmpleados.Location = new System.Drawing.Point(3, 3);
            this.panelCrudEmpleados.Name = "panelCrudEmpleados";
            this.panelCrudEmpleados.Size = new System.Drawing.Size(710, 48);
            this.panelCrudEmpleados.TabIndex = 1;
            // 
            // botonExportarEmpleados
            // 
            this.botonExportarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarEmpleados.ForeColor = System.Drawing.Color.White;
            this.botonExportarEmpleados.Location = new System.Drawing.Point(379, 10);
            this.botonExportarEmpleados.Name = "botonExportarEmpleados";
            this.botonExportarEmpleados.Size = new System.Drawing.Size(120, 28);
            this.botonExportarEmpleados.TabIndex = 4;
            this.botonExportarEmpleados.Text = "Exportar PDF";
            this.botonExportarEmpleados.UseVisualStyleBackColor = false;
            this.botonExportarEmpleados.Click += new System.EventHandler(this.botonExportarEmpleados_Click);
            // 
            // botonRefrescarEmpleado
            // 
            this.botonRefrescarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonRefrescarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRefrescarEmpleado.ForeColor = System.Drawing.Color.White;
            this.botonRefrescarEmpleado.Location = new System.Drawing.Point(288, 10);
            this.botonRefrescarEmpleado.Name = "botonRefrescarEmpleado";
            this.botonRefrescarEmpleado.Size = new System.Drawing.Size(85, 28);
            this.botonRefrescarEmpleado.TabIndex = 3;
            this.botonRefrescarEmpleado.Text = "Refrescar";
            this.botonRefrescarEmpleado.UseVisualStyleBackColor = false;
            this.botonRefrescarEmpleado.Click += new System.EventHandler(this.botonRefrescarEmpleado_Click);
            // 
            // botonEliminarEmpleado
            // 
            this.botonEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.botonEliminarEmpleado.Location = new System.Drawing.Point(197, 10);
            this.botonEliminarEmpleado.Name = "botonEliminarEmpleado";
            this.botonEliminarEmpleado.Size = new System.Drawing.Size(85, 28);
            this.botonEliminarEmpleado.TabIndex = 2;
            this.botonEliminarEmpleado.Text = "Eliminar";
            this.botonEliminarEmpleado.UseVisualStyleBackColor = false;
            this.botonEliminarEmpleado.Click += new System.EventHandler(this.botonEliminarEmpleado_Click);
            // 
            // botonEditarEmpleado
            // 
            this.botonEditarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditarEmpleado.ForeColor = System.Drawing.Color.White;
            this.botonEditarEmpleado.Location = new System.Drawing.Point(106, 10);
            this.botonEditarEmpleado.Name = "botonEditarEmpleado";
            this.botonEditarEmpleado.Size = new System.Drawing.Size(85, 28);
            this.botonEditarEmpleado.TabIndex = 1;
            this.botonEditarEmpleado.Text = "Editar";
            this.botonEditarEmpleado.UseVisualStyleBackColor = false;
            this.botonEditarEmpleado.Click += new System.EventHandler(this.botonEditarEmpleado_Click);
            // 
            // botonNuevoEmpleado
            // 
            this.botonNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.botonNuevoEmpleado.Location = new System.Drawing.Point(15, 10);
            this.botonNuevoEmpleado.Name = "botonNuevoEmpleado";
            this.botonNuevoEmpleado.Size = new System.Drawing.Size(85, 28);
            this.botonNuevoEmpleado.TabIndex = 0;
            this.botonNuevoEmpleado.Text = "Nuevo";
            this.botonNuevoEmpleado.UseVisualStyleBackColor = false;
            this.botonNuevoEmpleado.Click += new System.EventHandler(this.botonNuevoEmpleado_Click);
            // 
            // tabDepartamentos
            // 
            this.tabDepartamentos.BackColor = System.Drawing.Color.White;
            this.tabDepartamentos.Controls.Add(this.gridDepartamentos);
            this.tabDepartamentos.Controls.Add(this.panelCrudDepartamentos);
            this.tabDepartamentos.Location = new System.Drawing.Point(4, 22);
            this.tabDepartamentos.Name = "tabDepartamentos";
            this.tabDepartamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartamentos.Size = new System.Drawing.Size(716, 434);
            this.tabDepartamentos.TabIndex = 2;
            // 
            // gridDepartamentos
            // 
            this.gridDepartamentos.AllowUserToAddRows = false;
            this.gridDepartamentos.AllowUserToDeleteRows = false;
            this.gridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepartamentos.Location = new System.Drawing.Point(3, 51);
            this.gridDepartamentos.Name = "gridDepartamentos";
            this.gridDepartamentos.ReadOnly = true;
            this.gridDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepartamentos.Size = new System.Drawing.Size(710, 380);
            this.gridDepartamentos.TabIndex = 2;
            // 
            // panelCrudDepartamentos
            // 
            this.panelCrudDepartamentos.Controls.Add(this.botonExportarDepartamentos);
            this.panelCrudDepartamentos.Controls.Add(this.botonRefrescarDepartamento);
            this.panelCrudDepartamentos.Controls.Add(this.botonEliminarDepartamento);
            this.panelCrudDepartamentos.Controls.Add(this.botonEditarDepartamento);
            this.panelCrudDepartamentos.Controls.Add(this.botonNuevoDepartamento);
            this.panelCrudDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudDepartamentos.Location = new System.Drawing.Point(3, 3);
            this.panelCrudDepartamentos.Name = "panelCrudDepartamentos";
            this.panelCrudDepartamentos.Size = new System.Drawing.Size(710, 48);
            this.panelCrudDepartamentos.TabIndex = 1;
            // 
            // botonExportarDepartamentos
            // 
            this.botonExportarDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarDepartamentos.ForeColor = System.Drawing.Color.White;
            this.botonExportarDepartamentos.Location = new System.Drawing.Point(379, 10);
            this.botonExportarDepartamentos.Name = "botonExportarDepartamentos";
            this.botonExportarDepartamentos.Size = new System.Drawing.Size(120, 28);
            this.botonExportarDepartamentos.TabIndex = 4;
            this.botonExportarDepartamentos.Text = "Exportar PDF";
            this.botonExportarDepartamentos.UseVisualStyleBackColor = false;
            this.botonExportarDepartamentos.Click += new System.EventHandler(this.botonExportarDepartamentos_Click);
            // 
            // botonRefrescarDepartamento
            // 
            this.botonRefrescarDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonRefrescarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRefrescarDepartamento.ForeColor = System.Drawing.Color.White;
            this.botonRefrescarDepartamento.Location = new System.Drawing.Point(288, 10);
            this.botonRefrescarDepartamento.Name = "botonRefrescarDepartamento";
            this.botonRefrescarDepartamento.Size = new System.Drawing.Size(85, 28);
            this.botonRefrescarDepartamento.TabIndex = 3;
            this.botonRefrescarDepartamento.Text = "Refrescar";
            this.botonRefrescarDepartamento.UseVisualStyleBackColor = false;
            this.botonRefrescarDepartamento.Click += new System.EventHandler(this.botonRefrescarDepartamento_Click);
            // 
            // botonEliminarDepartamento
            // 
            this.botonEliminarDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEliminarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarDepartamento.ForeColor = System.Drawing.Color.White;
            this.botonEliminarDepartamento.Location = new System.Drawing.Point(197, 10);
            this.botonEliminarDepartamento.Name = "botonEliminarDepartamento";
            this.botonEliminarDepartamento.Size = new System.Drawing.Size(85, 28);
            this.botonEliminarDepartamento.TabIndex = 2;
            this.botonEliminarDepartamento.Text = "Eliminar";
            this.botonEliminarDepartamento.UseVisualStyleBackColor = false;
            this.botonEliminarDepartamento.Click += new System.EventHandler(this.botonEliminarDepartamento_Click);
            // 
            // botonEditarDepartamento
            // 
            this.botonEditarDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEditarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditarDepartamento.ForeColor = System.Drawing.Color.White;
            this.botonEditarDepartamento.Location = new System.Drawing.Point(106, 10);
            this.botonEditarDepartamento.Name = "botonEditarDepartamento";
            this.botonEditarDepartamento.Size = new System.Drawing.Size(85, 28);
            this.botonEditarDepartamento.TabIndex = 1;
            this.botonEditarDepartamento.Text = "Editar";
            this.botonEditarDepartamento.UseVisualStyleBackColor = false;
            this.botonEditarDepartamento.Click += new System.EventHandler(this.botonEditarDepartamento_Click);
            // 
            // botonNuevoDepartamento
            // 
            this.botonNuevoDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonNuevoDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevoDepartamento.ForeColor = System.Drawing.Color.White;
            this.botonNuevoDepartamento.Location = new System.Drawing.Point(15, 10);
            this.botonNuevoDepartamento.Name = "botonNuevoDepartamento";
            this.botonNuevoDepartamento.Size = new System.Drawing.Size(85, 28);
            this.botonNuevoDepartamento.TabIndex = 0;
            this.botonNuevoDepartamento.Text = "Nuevo";
            this.botonNuevoDepartamento.UseVisualStyleBackColor = false;
            this.botonNuevoDepartamento.Click += new System.EventHandler(this.botonNuevoDepartamento_Click);
            // 
            // tabCargos
            // 
            this.tabCargos.BackColor = System.Drawing.Color.White;
            this.tabCargos.Controls.Add(this.gridCargos);
            this.tabCargos.Controls.Add(this.panelCrudCargos);
            this.tabCargos.Location = new System.Drawing.Point(4, 22);
            this.tabCargos.Name = "tabCargos";
            this.tabCargos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargos.Size = new System.Drawing.Size(716, 434);
            this.tabCargos.TabIndex = 3;
            // 
            // gridCargos
            // 
            this.gridCargos.AllowUserToAddRows = false;
            this.gridCargos.AllowUserToDeleteRows = false;
            this.gridCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCargos.Location = new System.Drawing.Point(3, 51);
            this.gridCargos.Name = "gridCargos";
            this.gridCargos.ReadOnly = true;
            this.gridCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCargos.Size = new System.Drawing.Size(710, 380);
            this.gridCargos.TabIndex = 2;
            // 
            // panelCrudCargos
            // 
            this.panelCrudCargos.Controls.Add(this.botonExportarCargos);
            this.panelCrudCargos.Controls.Add(this.botonRefrescarCargo);
            this.panelCrudCargos.Controls.Add(this.botonEliminarCargo);
            this.panelCrudCargos.Controls.Add(this.botonEditarCargo);
            this.panelCrudCargos.Controls.Add(this.botonNuevoCargo);
            this.panelCrudCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudCargos.Location = new System.Drawing.Point(3, 3);
            this.panelCrudCargos.Name = "panelCrudCargos";
            this.panelCrudCargos.Size = new System.Drawing.Size(710, 48);
            this.panelCrudCargos.TabIndex = 1;
            // 
            // botonExportarCargos
            // 
            this.botonExportarCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarCargos.ForeColor = System.Drawing.Color.White;
            this.botonExportarCargos.Location = new System.Drawing.Point(379, 10);
            this.botonExportarCargos.Name = "botonExportarCargos";
            this.botonExportarCargos.Size = new System.Drawing.Size(120, 28);
            this.botonExportarCargos.TabIndex = 4;
            this.botonExportarCargos.Text = "Exportar PDF";
            this.botonExportarCargos.UseVisualStyleBackColor = false;
            this.botonExportarCargos.Click += new System.EventHandler(this.botonExportarCargos_Click);
            // 
            // botonRefrescarCargo
            // 
            this.botonRefrescarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonRefrescarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRefrescarCargo.ForeColor = System.Drawing.Color.White;
            this.botonRefrescarCargo.Location = new System.Drawing.Point(288, 10);
            this.botonRefrescarCargo.Name = "botonRefrescarCargo";
            this.botonRefrescarCargo.Size = new System.Drawing.Size(85, 28);
            this.botonRefrescarCargo.TabIndex = 3;
            this.botonRefrescarCargo.Text = "Refrescar";
            this.botonRefrescarCargo.UseVisualStyleBackColor = false;
            this.botonRefrescarCargo.Click += new System.EventHandler(this.botonRefrescarCargo_Click);
            // 
            // botonEliminarCargo
            // 
            this.botonEliminarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEliminarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarCargo.ForeColor = System.Drawing.Color.White;
            this.botonEliminarCargo.Location = new System.Drawing.Point(197, 10);
            this.botonEliminarCargo.Name = "botonEliminarCargo";
            this.botonEliminarCargo.Size = new System.Drawing.Size(85, 28);
            this.botonEliminarCargo.TabIndex = 2;
            this.botonEliminarCargo.Text = "Eliminar";
            this.botonEliminarCargo.UseVisualStyleBackColor = false;
            this.botonEliminarCargo.Click += new System.EventHandler(this.botonEliminarCargo_Click);
            // 
            // botonEditarCargo
            // 
            this.botonEditarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEditarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditarCargo.ForeColor = System.Drawing.Color.White;
            this.botonEditarCargo.Location = new System.Drawing.Point(106, 10);
            this.botonEditarCargo.Name = "botonEditarCargo";
            this.botonEditarCargo.Size = new System.Drawing.Size(85, 28);
            this.botonEditarCargo.TabIndex = 1;
            this.botonEditarCargo.Text = "Editar";
            this.botonEditarCargo.UseVisualStyleBackColor = false;
            this.botonEditarCargo.Click += new System.EventHandler(this.botonEditarCargo_Click);
            // 
            // botonNuevoCargo
            // 
            this.botonNuevoCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonNuevoCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevoCargo.ForeColor = System.Drawing.Color.White;
            this.botonNuevoCargo.Location = new System.Drawing.Point(15, 10);
            this.botonNuevoCargo.Name = "botonNuevoCargo";
            this.botonNuevoCargo.Size = new System.Drawing.Size(85, 28);
            this.botonNuevoCargo.TabIndex = 0;
            this.botonNuevoCargo.Text = "Nuevo";
            this.botonNuevoCargo.UseVisualStyleBackColor = false;
            this.botonNuevoCargo.Click += new System.EventHandler(this.botonNuevoCargo_Click);
            // 
            // tabVacaciones
            // 
            this.tabVacaciones.BackColor = System.Drawing.Color.White;
            this.tabVacaciones.Controls.Add(this.gridVacaciones);
            this.tabVacaciones.Controls.Add(this.panelCrudVacaciones);
            this.tabVacaciones.Location = new System.Drawing.Point(4, 22);
            this.tabVacaciones.Name = "tabVacaciones";
            this.tabVacaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacaciones.Size = new System.Drawing.Size(716, 434);
            this.tabVacaciones.TabIndex = 4;
            // 
            // gridVacaciones
            // 
            this.gridVacaciones.AllowUserToAddRows = false;
            this.gridVacaciones.AllowUserToDeleteRows = false;
            this.gridVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVacaciones.Location = new System.Drawing.Point(3, 51);
            this.gridVacaciones.Name = "gridVacaciones";
            this.gridVacaciones.ReadOnly = true;
            this.gridVacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVacaciones.Size = new System.Drawing.Size(710, 380);
            this.gridVacaciones.TabIndex = 2;
            // 
            // panelCrudVacaciones
            // 
            this.panelCrudVacaciones.Controls.Add(this.botonExportarVacaciones);
            this.panelCrudVacaciones.Controls.Add(this.botonRefrescarVacacion);
            this.panelCrudVacaciones.Controls.Add(this.botonEliminarVacacion);
            this.panelCrudVacaciones.Controls.Add(this.botonEditarVacacion);
            this.panelCrudVacaciones.Controls.Add(this.botonNuevaVacacion);
            this.panelCrudVacaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudVacaciones.Location = new System.Drawing.Point(3, 3);
            this.panelCrudVacaciones.Name = "panelCrudVacaciones";
            this.panelCrudVacaciones.Size = new System.Drawing.Size(710, 48);
            this.panelCrudVacaciones.TabIndex = 1;
            // 
            // botonExportarVacaciones
            // 
            this.botonExportarVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarVacaciones.ForeColor = System.Drawing.Color.White;
            this.botonExportarVacaciones.Location = new System.Drawing.Point(379, 10);
            this.botonExportarVacaciones.Name = "botonExportarVacaciones";
            this.botonExportarVacaciones.Size = new System.Drawing.Size(120, 28);
            this.botonExportarVacaciones.TabIndex = 4;
            this.botonExportarVacaciones.Text = "Exportar PDF";
            this.botonExportarVacaciones.UseVisualStyleBackColor = false;
            this.botonExportarVacaciones.Click += new System.EventHandler(this.botonExportarVacaciones_Click);
            // 
            // botonRefrescarVacacion
            // 
            this.botonRefrescarVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonRefrescarVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRefrescarVacacion.ForeColor = System.Drawing.Color.White;
            this.botonRefrescarVacacion.Location = new System.Drawing.Point(288, 10);
            this.botonRefrescarVacacion.Name = "botonRefrescarVacacion";
            this.botonRefrescarVacacion.Size = new System.Drawing.Size(85, 28);
            this.botonRefrescarVacacion.TabIndex = 3;
            this.botonRefrescarVacacion.Text = "Refrescar";
            this.botonRefrescarVacacion.UseVisualStyleBackColor = false;
            this.botonRefrescarVacacion.Click += new System.EventHandler(this.botonRefrescarVacacion_Click);
            // 
            // botonEliminarVacacion
            // 
            this.botonEliminarVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEliminarVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarVacacion.ForeColor = System.Drawing.Color.White;
            this.botonEliminarVacacion.Location = new System.Drawing.Point(197, 10);
            this.botonEliminarVacacion.Name = "botonEliminarVacacion";
            this.botonEliminarVacacion.Size = new System.Drawing.Size(85, 28);
            this.botonEliminarVacacion.TabIndex = 2;
            this.botonEliminarVacacion.Text = "Eliminar";
            this.botonEliminarVacacion.UseVisualStyleBackColor = false;
            this.botonEliminarVacacion.Click += new System.EventHandler(this.botonEliminarVacacion_Click);
            // 
            // botonEditarVacacion
            // 
            this.botonEditarVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEditarVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditarVacacion.ForeColor = System.Drawing.Color.White;
            this.botonEditarVacacion.Location = new System.Drawing.Point(106, 10);
            this.botonEditarVacacion.Name = "botonEditarVacacion";
            this.botonEditarVacacion.Size = new System.Drawing.Size(85, 28);
            this.botonEditarVacacion.TabIndex = 1;
            this.botonEditarVacacion.Text = "Editar";
            this.botonEditarVacacion.UseVisualStyleBackColor = false;
            this.botonEditarVacacion.Click += new System.EventHandler(this.botonEditarVacacion_Click);
            // 
            // botonNuevaVacacion
            // 
            this.botonNuevaVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonNuevaVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevaVacacion.ForeColor = System.Drawing.Color.White;
            this.botonNuevaVacacion.Location = new System.Drawing.Point(15, 10);
            this.botonNuevaVacacion.Name = "botonNuevaVacacion";
            this.botonNuevaVacacion.Size = new System.Drawing.Size(85, 28);
            this.botonNuevaVacacion.TabIndex = 0;
            this.botonNuevaVacacion.Text = "Nuevo";
            this.botonNuevaVacacion.UseVisualStyleBackColor = false;
            this.botonNuevaVacacion.Click += new System.EventHandler(this.botonNuevaVacacion_Click);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.White;
            this.tabUsuarios.Controls.Add(this.gridUsuarios);
            this.tabUsuarios.Controls.Add(this.panelCrudUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(716, 434);
            this.tabUsuarios.TabIndex = 5;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsuarios.Location = new System.Drawing.Point(3, 51);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(710, 380);
            this.gridUsuarios.TabIndex = 2;
            // 
            // panelCrudUsuarios
            // 
            this.panelCrudUsuarios.Controls.Add(this.botonExportarUsuarios);
            this.panelCrudUsuarios.Controls.Add(this.botonRefrescarUsuario);
            this.panelCrudUsuarios.Controls.Add(this.botonEliminarUsuario);
            this.panelCrudUsuarios.Controls.Add(this.botonEditarUsuario);
            this.panelCrudUsuarios.Controls.Add(this.botonNuevoUsuario);
            this.panelCrudUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudUsuarios.Location = new System.Drawing.Point(3, 3);
            this.panelCrudUsuarios.Name = "panelCrudUsuarios";
            this.panelCrudUsuarios.Size = new System.Drawing.Size(710, 48);
            this.panelCrudUsuarios.TabIndex = 1;
            // 
            // botonExportarUsuarios
            // 
            this.botonExportarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonExportarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonExportarUsuarios.ForeColor = System.Drawing.Color.White;
            this.botonExportarUsuarios.Location = new System.Drawing.Point(379, 10);
            this.botonExportarUsuarios.Name = "botonExportarUsuarios";
            this.botonExportarUsuarios.Size = new System.Drawing.Size(120, 28);
            this.botonExportarUsuarios.TabIndex = 4;
            this.botonExportarUsuarios.Text = "Exportar PDF";
            this.botonExportarUsuarios.UseVisualStyleBackColor = false;
            this.botonExportarUsuarios.Click += new System.EventHandler(this.botonExportarUsuarios_Click);
            // 
            // botonRefrescarUsuario
            // 
            this.botonRefrescarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonRefrescarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRefrescarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonRefrescarUsuario.Location = new System.Drawing.Point(288, 10);
            this.botonRefrescarUsuario.Name = "botonRefrescarUsuario";
            this.botonRefrescarUsuario.Size = new System.Drawing.Size(85, 28);
            this.botonRefrescarUsuario.TabIndex = 3;
            this.botonRefrescarUsuario.Text = "Refrescar";
            this.botonRefrescarUsuario.UseVisualStyleBackColor = false;
            this.botonRefrescarUsuario.Click += new System.EventHandler(this.botonRefrescarUsuario_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonEliminarUsuario.Location = new System.Drawing.Point(197, 10);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(85, 28);
            this.botonEliminarUsuario.TabIndex = 2;
            this.botonEliminarUsuario.Text = "Eliminar";
            this.botonEliminarUsuario.UseVisualStyleBackColor = false;
            this.botonEliminarUsuario.Click += new System.EventHandler(this.botonEliminarUsuario_Click);
            // 
            // botonEditarUsuario
            // 
            this.botonEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.botonEditarUsuario.Location = new System.Drawing.Point(106, 10);
            this.botonEditarUsuario.Name = "botonEditarUsuario";
            this.botonEditarUsuario.Size = new System.Drawing.Size(85, 28);
            this.botonEditarUsuario.TabIndex = 1;
            this.botonEditarUsuario.Text = "Editar";
            this.botonEditarUsuario.UseVisualStyleBackColor = false;
            this.botonEditarUsuario.Click += new System.EventHandler(this.botonEditarUsuario_Click);
            // 
            // botonNuevoUsuario
            // 
            this.botonNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.botonNuevoUsuario.Location = new System.Drawing.Point(15, 10);
            this.botonNuevoUsuario.Name = "botonNuevoUsuario";
            this.botonNuevoUsuario.Size = new System.Drawing.Size(85, 28);
            this.botonNuevoUsuario.TabIndex = 0;
            this.botonNuevoUsuario.Text = "Nuevo";
            this.botonNuevoUsuario.UseVisualStyleBackColor = false;
            this.botonNuevoUsuario.Click += new System.EventHandler(this.botonNuevoUsuario_Click);
            // 
            // panelBarraVentana
            // 
            this.panelBarraVentana.Controls.Add(this.etiquetaTituloInicio);
            this.panelBarraVentana.Controls.Add(this.botonMinimizar);
            this.panelBarraVentana.Controls.Add(this.botonCerrar);
            this.panelBarraVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraVentana.Location = new System.Drawing.Point(18, 18);
            this.panelBarraVentana.Name = "panelBarraVentana";
            this.panelBarraVentana.Size = new System.Drawing.Size(724, 44);
            this.panelBarraVentana.TabIndex = 1;
            // 
            // etiquetaTituloInicio
            // 
            this.etiquetaTituloInicio.AutoSize = true;
            this.etiquetaTituloInicio.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaTituloInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTituloInicio.Location = new System.Drawing.Point(3, 0);
            this.etiquetaTituloInicio.Name = "etiquetaTituloInicio";
            this.etiquetaTituloInicio.Size = new System.Drawing.Size(174, 45);
            this.etiquetaTituloInicio.TabIndex = 0;
            this.etiquetaTituloInicio.Text = "Dashboard";
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
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.tabControlContenido.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardDepartamentos)).EndInit();
            this.tabEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.panelCrudEmpleados.ResumeLayout(false);
            this.tabDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartamentos)).EndInit();
            this.panelCrudDepartamentos.ResumeLayout(false);
            this.tabCargos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).EndInit();
            this.panelCrudCargos.ResumeLayout(false);
            this.tabVacaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVacaciones)).EndInit();
            this.panelCrudVacaciones.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.panelCrudUsuarios.ResumeLayout(false);
            this.panelBarraVentana.ResumeLayout(false);
            this.panelBarraVentana.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
