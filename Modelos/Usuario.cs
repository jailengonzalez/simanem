using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Contraseña hasheada (bcrypt, SHA256, etc.)
        /// </summary>
        [Required]
        [StringLength(512)]
        public string Contrasena { get; set; }

        [Required]
        [StringLength(30)]
        public string Rol { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }
    }
}
