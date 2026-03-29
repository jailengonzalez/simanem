using System;
using System.Drawing;
using System.Windows.Forms;
using SiManEm.Datos;
using SiManEm.Modelos;
using SiManEm.Servicios;

namespace SiManEm
{
    public partial class Login : Form
    {
        private Point _puntoArrastre;
        private bool _arrastrando;

        public Login()
        {
            InitializeComponent();
        }

        private void MostrarError(string mensaje = "Usuario o contraseña incorrectos")
        {
            etiquetaError.Text = mensaje;
            etiquetaError.Visible = true;
            campoContrasena.Clear();
            campoContrasena.Focus();
        }

        private void OcultarError()
        {
            etiquetaError.Visible = false;
        }

        private void EjecutarLogin()
        {
            OcultarError();

            var nombreUsuario = campoUsuario.Text.Trim();
            var contrasena = campoContrasena.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MostrarError("Ingrese usuario y contraseña");
                return;
            }

            Usuario usuarioEncontrado;

            using (var contexto = new SiManEmContexto())
            {
                var servicio = new AutenticacionServicio(contexto);
                usuarioEncontrado = servicio.Autenticar(nombreUsuario, contrasena);
            }

            if (usuarioEncontrado == null)
            {
                MostrarError();
                return;
            }

            this.Hide();
            using (var inicio = new Inicio(usuarioEncontrado.NombreUsuario))
            {
                inicio.ShowDialog();
            }
            this.Close();
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            EjecutarLogin();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void campoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                campoContrasena.Focus();
            }
        }

        private void campoContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                EjecutarLogin();
            }
        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _arrastrando = true;
                _puntoArrastre = e.Location;
            }
        }

        private void panelIzquierdo_MouseMove(object sender, MouseEventArgs e)
        {
            if (_arrastrando)
            {
                var diferencia = new Point(e.X - _puntoArrastre.X, e.Y - _puntoArrastre.Y);
                Location = new Point(Location.X + diferencia.X, Location.Y + diferencia.Y);
                _puntoArrastre = e.Location;
            }
        }

        private void panelIzquierdo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _arrastrando = false;
            }
        }
    }
}
