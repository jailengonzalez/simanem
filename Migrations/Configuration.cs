namespace SiManEm.Migrations
{
    using System.Data.Entity.Migrations;
    using SiManEm.Modelos;
    using SiManEm.Servicios;

    internal sealed class Configuration : DbMigrationsConfiguration<SiManEm.Datos.SiManEmContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SiManEm.Datos.SiManEmContexto context)
        {
            context.Usuarios.AddOrUpdate(
                u => u.NombreUsuario,
                new Usuario
                {
                    NombreUsuario = "admin",
                    Contrasena = AutenticacionServicio.ObtenerHash("admin123"),
                    Rol = "Administrador",
                    Estado = "Activo"
                });
        }
    }
}
