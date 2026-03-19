namespace SiManEm
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label etiquetaLogo;
        private System.Windows.Forms.Label etiquetaNombreApp;
        private System.Windows.Forms.Label etiquetaSlogan;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Label etiquetaTitulo;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label etiquetaContrasena;
        private System.Windows.Forms.TextBox campoContrasena;
        private System.Windows.Forms.Label etiquetaError;
        private System.Windows.Forms.Button botonEntrar;

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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.etiquetaSlogan = new System.Windows.Forms.Label();
            this.etiquetaNombreApp = new System.Windows.Forms.Label();
            this.etiquetaLogo = new System.Windows.Forms.Label();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.etiquetaError = new System.Windows.Forms.Label();
            this.campoContrasena = new System.Windows.Forms.TextBox();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.etiquetaTitulo = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.panelIzquierdo.Controls.Add(this.etiquetaSlogan);
            this.panelIzquierdo.Controls.Add(this.etiquetaNombreApp);
            this.panelIzquierdo.Controls.Add(this.etiquetaLogo);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(400, 450);
            this.panelIzquierdo.TabIndex = 0;
            this.panelIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            this.panelIzquierdo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseMove);
            this.panelIzquierdo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseUp);
            // 
            // etiquetaSlogan
            // 
            this.etiquetaSlogan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.etiquetaSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(210)))));
            this.etiquetaSlogan.Location = new System.Drawing.Point(40, 260);
            this.etiquetaSlogan.Name = "etiquetaSlogan";
            this.etiquetaSlogan.Size = new System.Drawing.Size(320, 40);
            this.etiquetaSlogan.TabIndex = 2;
            this.etiquetaSlogan.Text = "Sistema de Manejo de Empleados";
            this.etiquetaSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.etiquetaSlogan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            this.etiquetaSlogan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseMove);
            this.etiquetaSlogan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseUp);
            // 
            // etiquetaNombreApp
            // 
            this.etiquetaNombreApp.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.etiquetaNombreApp.ForeColor = System.Drawing.Color.White;
            this.etiquetaNombreApp.Location = new System.Drawing.Point(40, 210);
            this.etiquetaNombreApp.Name = "etiquetaNombreApp";
            this.etiquetaNombreApp.Size = new System.Drawing.Size(320, 45);
            this.etiquetaNombreApp.TabIndex = 1;
            this.etiquetaNombreApp.Text = "SiManEm";
            this.etiquetaNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etiquetaNombreApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            this.etiquetaNombreApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseMove);
            this.etiquetaNombreApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseUp);
            // 
            // etiquetaLogo
            // 
            this.etiquetaLogo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.etiquetaLogo.ForeColor = System.Drawing.Color.White;
            this.etiquetaLogo.Location = new System.Drawing.Point(40, 80);
            this.etiquetaLogo.Name = "etiquetaLogo";
            this.etiquetaLogo.Size = new System.Drawing.Size(320, 120);
            this.etiquetaLogo.TabIndex = 0;
            this.etiquetaLogo.Text = "S";
            this.etiquetaLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.etiquetaLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            this.etiquetaLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseMove);
            this.etiquetaLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseUp);
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.White;
            this.panelDerecho.Controls.Add(this.botonEntrar);
            this.panelDerecho.Controls.Add(this.etiquetaError);
            this.panelDerecho.Controls.Add(this.campoContrasena);
            this.panelDerecho.Controls.Add(this.etiquetaContrasena);
            this.panelDerecho.Controls.Add(this.campoUsuario);
            this.panelDerecho.Controls.Add(this.etiquetaUsuario);
            this.panelDerecho.Controls.Add(this.etiquetaTitulo);
            this.panelDerecho.Controls.Add(this.botonCerrar);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(400, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(400, 450);
            this.panelDerecho.TabIndex = 1;
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.botonEntrar.FlatAppearance.BorderSize = 0;
            this.botonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEntrar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonEntrar.ForeColor = System.Drawing.Color.White;
            this.botonEntrar.Location = new System.Drawing.Point(34, 330);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(330, 40);
            this.botonEntrar.TabIndex = 3;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // etiquetaError
            // 
            this.etiquetaError.AutoSize = true;
            this.etiquetaError.ForeColor = System.Drawing.Color.Red;
            this.etiquetaError.Location = new System.Drawing.Point(31, 290);
            this.etiquetaError.Name = "etiquetaError";
            this.etiquetaError.Size = new System.Drawing.Size(163, 13);
            this.etiquetaError.TabIndex = 6;
            this.etiquetaError.Text = "Usuario o contraseña incorrectos";
            this.etiquetaError.Visible = false;
            // 
            // campoContrasena
            // 
            this.campoContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.campoContrasena.Location = new System.Drawing.Point(34, 245);
            this.campoContrasena.Name = "campoContrasena";
            this.campoContrasena.PasswordChar = '●';
            this.campoContrasena.Size = new System.Drawing.Size(330, 27);
            this.campoContrasena.TabIndex = 2;
            this.campoContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoContrasena_KeyDown);
            // 
            // etiquetaContrasena
            // 
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.etiquetaContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaContrasena.Location = new System.Drawing.Point(30, 220);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(79, 19);
            this.etiquetaContrasena.TabIndex = 4;
            this.etiquetaContrasena.Text = "Contraseña";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.campoUsuario.Location = new System.Drawing.Point(34, 175);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(330, 27);
            this.campoUsuario.TabIndex = 1;
            this.campoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoUsuario_KeyDown);
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.etiquetaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaUsuario.Location = new System.Drawing.Point(30, 150);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(56, 19);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            // 
            // etiquetaTitulo
            // 
            this.etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.etiquetaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.etiquetaTitulo.Location = new System.Drawing.Point(30, 80);
            this.etiquetaTitulo.Name = "etiquetaTitulo";
            this.etiquetaTitulo.Size = new System.Drawing.Size(340, 35);
            this.etiquetaTitulo.TabIndex = 1;
            this.etiquetaTitulo.Text = "Iniciar sesión";
            // 
            // botonCerrar
            // 
            this.botonCerrar.FlatAppearance.BorderSize = 0;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.botonCerrar.ForeColor = System.Drawing.Color.Gray;
            this.botonCerrar.Location = new System.Drawing.Point(365, 10);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(30, 30);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.Text = "×";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiManEm - Iniciar sesión";
            this.panelIzquierdo.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
