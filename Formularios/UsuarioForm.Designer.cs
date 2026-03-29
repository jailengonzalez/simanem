namespace SiManEm.Formularios
{
    partial class UsuarioForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label etiquetaContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label etiquetaContrasenaInfo;
        private System.Windows.Forms.Label etiquetaRol;
        private System.Windows.Forms.TextBox txtRol;
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
            this.etiquetaNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.etiquetaContrasenaInfo = new System.Windows.Forms.Label();
            this.etiquetaRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaNombreUsuario
            // 
            this.etiquetaNombreUsuario.AutoSize = true;
            this.etiquetaNombreUsuario.Location = new System.Drawing.Point(20, 23);
            this.etiquetaNombreUsuario.Name = "etiquetaNombreUsuario";
            this.etiquetaNombreUsuario.Size = new System.Drawing.Size(86, 13);
            this.etiquetaNombreUsuario.TabIndex = 0;
            this.etiquetaNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 20);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(250, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // etiquetaContrasena
            // 
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Location = new System.Drawing.Point(20, 63);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(61, 13);
            this.etiquetaContrasena.TabIndex = 2;
            this.etiquetaContrasena.Text = "Contrasena";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(140, 60);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(250, 20);
            this.txtContrasena.TabIndex = 3;
            // 
            // etiquetaContrasenaInfo
            // 
            this.etiquetaContrasenaInfo.AutoSize = true;
            this.etiquetaContrasenaInfo.ForeColor = System.Drawing.Color.DimGray;
            this.etiquetaContrasenaInfo.Location = new System.Drawing.Point(140, 84);
            this.etiquetaContrasenaInfo.Name = "etiquetaContrasenaInfo";
            this.etiquetaContrasenaInfo.Size = new System.Drawing.Size(104, 13);
            this.etiquetaContrasenaInfo.TabIndex = 4;
            this.etiquetaContrasenaInfo.Text = "Ingrese una clave.";
            // 
            // etiquetaRol
            // 
            this.etiquetaRol.AutoSize = true;
            this.etiquetaRol.Location = new System.Drawing.Point(20, 113);
            this.etiquetaRol.Name = "etiquetaRol";
            this.etiquetaRol.Size = new System.Drawing.Size(23, 13);
            this.etiquetaRol.TabIndex = 5;
            this.etiquetaRol.Text = "Rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(140, 110);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(250, 20);
            this.txtRol.TabIndex = 6;
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Location = new System.Drawing.Point(20, 153);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(40, 13);
            this.etiquetaEstado.TabIndex = 7;
            this.etiquetaEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(140, 150);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(250, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(220, 190);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(80, 28);
            this.botonAceptar.TabIndex = 9;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(310, 190);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 28);
            this.botonCancelar.TabIndex = 10;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.etiquetaEstado);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.etiquetaRol);
            this.Controls.Add(this.etiquetaContrasenaInfo);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.etiquetaContrasena);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.etiquetaNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
