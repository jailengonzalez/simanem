using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Servicios
{
    public class AutenticacionServicio
    {
        private readonly SiManEmContexto _contexto;

        public AutenticacionServicio(SiManEmContexto contexto)
        {
            _contexto = contexto;
        }
        public Usuario Autenticar(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                return null;
            }
            var contrasenaHash = ObtenerHash(contrasena);

            var usuarioEncontrado = _contexto.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario &&
                                    u.Contrasena == contrasenaHash &&
                                    u.Estado == "Activo");

            return usuarioEncontrado;
        }

        public static string ObtenerHash(string texto)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(texto);
                var hash = sha.ComputeHash(bytes);
                var sb = new StringBuilder();
                foreach (var b in hash)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
