using System;
using System.Windows.Forms;
using SiManEm.Modelos;

namespace SiManEm.Formularios
{
    public partial class UsuarioForm : Form
    {
        public string NombreUsuario { get; private set; }
        public string ContrasenaTexto { get; private set; }
        public string Rol { get; private set; }
        public string Estado { get; private set; }

        public UsuarioForm(string titulo, Usuario usuario)
        {
            InitializeComponent();
            Text = titulo;

            txtNombreUsuario.Text = usuario == null ? string.Empty : (usuario.NombreUsuario ?? string.Empty);
            txtRol.Text = usuario == null ? "Administrador" : (usuario.Rol ?? "Administrador");
            txtEstado.Text = usuario == null ? "Activo" : (usuario.Estado ?? "Activo");

            if (usuario != null)
            {
                etiquetaContrasenaInfo.Text = "Si deja la contraseña vacía, se mantiene la actual.";
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            NombreUsuario = txtNombreUsuario.Text.Trim();
            ContrasenaTexto = txtContrasena.Text;
            Rol = txtRol.Text.Trim();
            Estado = txtEstado.Text.Trim();

            if (string.IsNullOrWhiteSpace(NombreUsuario))
            {
                MessageBox.Show("Nombre de usuario es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Rol))
            {
                MessageBox.Show("Rol es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Estado))
            {
                MessageBox.Show("Estado es obligatorio.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
