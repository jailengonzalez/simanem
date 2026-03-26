using System.Data.Entity;
using SiManEm.Modelos;

namespace SiManEm.Datos
{
    public class SiManEmContexto : DbContext
    {
        public SiManEmContexto() : base("name=SiManEmConexion")
        {
        }

        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<HistorialSalario> HistorialSalarios { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }
        public virtual DbSet<ConfiguracionNomina> ConfiguracionesNomina { get; set; }
        public virtual DbSet<EscalaIsr> EscalasIsr { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Salario)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HistorialSalario>()
                .Property(h => h.SalarioAnterior)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HistorialSalario>()
                .Property(h => h.SalarioNuevo)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ConfiguracionNomina>()
                .Property(c => c.PorcentajeAfp)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ConfiguracionNomina>()
                .Property(c => c.PorcentajeArs)
                .HasPrecision(18, 2);

            modelBuilder.Entity<EscalaIsr>()
                .Property(e => e.LimiteInferior)
                .HasPrecision(18, 2);

            modelBuilder.Entity<EscalaIsr>()
                .Property(e => e.LimiteSuperior)
                .HasPrecision(18, 2);

            modelBuilder.Entity<EscalaIsr>()
                .Property(e => e.Tasa)
                .HasPrecision(18, 4);

            modelBuilder.Entity<EscalaIsr>()
                .Property(e => e.CuotaFija)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Empleado>()
                .HasRequired(e => e.Departamento)
                .WithMany(d => d.Empleados)
                .HasForeignKey(e => e.DepartamentoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasRequired(e => e.Cargo)
                .WithMany(c => c.Empleados)
                .HasForeignKey(e => e.CargoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .HasRequired(c => c.Departamento)
                .WithMany(d => d.Cargos)
                .HasForeignKey(c => c.DepartamentoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HistorialSalario>()
                .HasRequired(h => h.Empleado)
                .WithMany(e => e.HistorialSalarios)
                .HasForeignKey(h => h.EmpleadoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vacaciones>()
                .HasRequired(v => v.Empleado)
                .WithMany(e => e.Vacaciones)
                .HasForeignKey(v => v.EmpleadoID)
                .WillCascadeOnDelete(false);
        }
    }
}
