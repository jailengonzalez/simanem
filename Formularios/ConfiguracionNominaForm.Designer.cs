namespace SiManEm.Formularios
{
    partial class ConfiguracionNominaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label etiquetaAfp;
        private System.Windows.Forms.Label etiquetaArs;
        private System.Windows.Forms.TextBox _txtAfp;
        private System.Windows.Forms.TextBox _txtArs;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Button _btnRecargar;
        private System.Windows.Forms.DataGridView _gridEscalas;
        private System.Windows.Forms.Button _btnAgregarEscala;
        private System.Windows.Forms.Button _btnEditarEscala;
        private System.Windows.Forms.Button _btnEliminarEscala;

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
            this.etiquetaAfp = new System.Windows.Forms.Label();
            this.etiquetaArs = new System.Windows.Forms.Label();
            this._txtAfp = new System.Windows.Forms.TextBox();
            this._txtArs = new System.Windows.Forms.TextBox();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._btnRecargar = new System.Windows.Forms.Button();
            this._gridEscalas = new System.Windows.Forms.DataGridView();
            this._btnAgregarEscala = new System.Windows.Forms.Button();
            this._btnEditarEscala = new System.Windows.Forms.Button();
            this._btnEliminarEscala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._gridEscalas)).BeginInit();
            this.SuspendLayout();
            // 
            // etiquetaAfp
            // 
            this.etiquetaAfp.AutoSize = true;
            this.etiquetaAfp.Location = new System.Drawing.Point(20, 21);
            this.etiquetaAfp.Name = "etiquetaAfp";
            this.etiquetaAfp.Size = new System.Drawing.Size(50, 13);
            this.etiquetaAfp.TabIndex = 0;
            this.etiquetaAfp.Text = "AFP (%)";
            // 
            // etiquetaArs
            // 
            this.etiquetaArs.AutoSize = true;
            this.etiquetaArs.Location = new System.Drawing.Point(260, 21);
            this.etiquetaArs.Name = "etiquetaArs";
            this.etiquetaArs.Size = new System.Drawing.Size(49, 13);
            this.etiquetaArs.TabIndex = 1;
            this.etiquetaArs.Text = "ARS (%)";
            // 
            // _txtAfp
            // 
            this._txtAfp.Location = new System.Drawing.Point(100, 17);
            this._txtAfp.Name = "_txtAfp";
            this._txtAfp.Size = new System.Drawing.Size(120, 20);
            this._txtAfp.TabIndex = 2;
            this._txtAfp.Leave += new System.EventHandler(this._txtAfp_Leave);
            // 
            // _txtArs
            // 
            this._txtArs.Location = new System.Drawing.Point(340, 17);
            this._txtArs.Name = "_txtArs";
            this._txtArs.Size = new System.Drawing.Size(120, 20);
            this._txtArs.TabIndex = 3;
            this._txtArs.Leave += new System.EventHandler(this._txtArs_Leave);
            // 
            // _btnGuardar
            // 
            this._btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this._btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGuardar.ForeColor = System.Drawing.Color.White;
            this._btnGuardar.Location = new System.Drawing.Point(620, 14);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(100, 28);
            this._btnGuardar.TabIndex = 4;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = false;
            this._btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // _btnRecargar
            // 
            this._btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this._btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRecargar.ForeColor = System.Drawing.Color.White;
            this._btnRecargar.Location = new System.Drawing.Point(730, 14);
            this._btnRecargar.Name = "_btnRecargar";
            this._btnRecargar.Size = new System.Drawing.Size(100, 28);
            this._btnRecargar.TabIndex = 5;
            this._btnRecargar.Text = "Recargar";
            this._btnRecargar.UseVisualStyleBackColor = false;
            this._btnRecargar.Click += new System.EventHandler(this._btnRecargar_Click);
            // 
            // _gridEscalas
            // 
            this._gridEscalas.AllowUserToAddRows = false;
            this._gridEscalas.AllowUserToDeleteRows = false;
            this._gridEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridEscalas.Location = new System.Drawing.Point(20, 90);
            this._gridEscalas.MultiSelect = false;
            this._gridEscalas.Name = "_gridEscalas";
            this._gridEscalas.ReadOnly = true;
            this._gridEscalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridEscalas.Size = new System.Drawing.Size(810, 380);
            this._gridEscalas.TabIndex = 6;
            this._gridEscalas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this._gridEscalas_DataBindingComplete);
            // 
            // _btnAgregarEscala
            // 
            this._btnAgregarEscala.Location = new System.Drawing.Point(20, 485);
            this._btnAgregarEscala.Name = "_btnAgregarEscala";
            this._btnAgregarEscala.Size = new System.Drawing.Size(120, 28);
            this._btnAgregarEscala.TabIndex = 7;
            this._btnAgregarEscala.Text = "Agregar Escala";
            this._btnAgregarEscala.UseVisualStyleBackColor = true;
            this._btnAgregarEscala.Click += new System.EventHandler(this.BtnAgregarEscala_Click);
            // 
            // _btnEditarEscala
            // 
            this._btnEditarEscala.Location = new System.Drawing.Point(150, 485);
            this._btnEditarEscala.Name = "_btnEditarEscala";
            this._btnEditarEscala.Size = new System.Drawing.Size(120, 28);
            this._btnEditarEscala.TabIndex = 8;
            this._btnEditarEscala.Text = "Editar Escala";
            this._btnEditarEscala.UseVisualStyleBackColor = true;
            this._btnEditarEscala.Click += new System.EventHandler(this.BtnEditarEscala_Click);
            // 
            // _btnEliminarEscala
            // 
            this._btnEliminarEscala.Location = new System.Drawing.Point(280, 485);
            this._btnEliminarEscala.Name = "_btnEliminarEscala";
            this._btnEliminarEscala.Size = new System.Drawing.Size(120, 28);
            this._btnEliminarEscala.TabIndex = 9;
            this._btnEliminarEscala.Text = "Eliminar Escala";
            this._btnEliminarEscala.UseVisualStyleBackColor = true;
            this._btnEliminarEscala.Click += new System.EventHandler(this.BtnEliminarEscala_Click);
            // 
            // ConfiguracionNominaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this._btnEliminarEscala);
            this.Controls.Add(this._btnEditarEscala);
            this.Controls.Add(this._btnAgregarEscala);
            this.Controls.Add(this._gridEscalas);
            this.Controls.Add(this._btnRecargar);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this._txtArs);
            this.Controls.Add(this._txtAfp);
            this.Controls.Add(this.etiquetaArs);
            this.Controls.Add(this.etiquetaAfp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionNominaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion de Nomina";
            ((System.ComponentModel.ISupportInitialize)(this._gridEscalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
