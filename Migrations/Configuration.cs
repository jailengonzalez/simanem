namespace SiManEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
            context.ConfiguracionesNomina.AddOrUpdate(
                x => x.ConfiguracionNominaID,
                new ConfiguracionNomina
                {
                    ConfiguracionNominaID = 1,
                    PorcentajeAfp = 3.04m,
                    PorcentajeArs = 3.04m
                }
            );

            context.EscalasIsr.AddOrUpdate(
                x => x.EscalaIsrID,
                new EscalaIsr { EscalaIsrID = 1, LimiteInferior = 0m, LimiteSuperior = 416220.00m, Tasa = 0m, CuotaFija = 0m },
                new EscalaIsr { EscalaIsrID = 2, LimiteInferior = 416220.00m, LimiteSuperior = 624329.00m, Tasa = 0.15m, CuotaFija = 0m },
                new EscalaIsr { EscalaIsrID = 3, LimiteInferior = 624329.00m, LimiteSuperior = 867123.00m, Tasa = 0.20m, CuotaFija = 31216.00m },
                new EscalaIsr { EscalaIsrID = 4, LimiteInferior = 867123.00m, LimiteSuperior = 999999999.99m, Tasa = 0.25m, CuotaFija = 79764.00m }
            );

            context.Departamentos.AddOrUpdate(
                d => d.Nombre,
                new Departamento { Nombre = "Recursos Humanos", Descripcion = "Gestion del personal y clima organizacional" },
                new Departamento { Nombre = "Tecnologia", Descripcion = "Desarrollo de sistemas y soporte" },
                new Departamento { Nombre = "Finanzas", Descripcion = "Contabilidad y control financiero" },
                new Departamento { Nombre = "Operaciones", Descripcion = "Procesos operativos y productividad" }
            );

            context.Usuarios.AddOrUpdate(
                u => u.NombreUsuario,
                new Usuario
                {
                    NombreUsuario = "admin",
                    Contrasena = AutenticacionServicio.ObtenerHash("admin123"),
                    Rol = "Administrador",
                    Estado = "Activo"
                },
                new Usuario
                {
                    NombreUsuario = "rrhh",
                    Contrasena = AutenticacionServicio.ObtenerHash("rrhh123"),
                    Rol = "RecursosHumanos",
                    Estado = "Activo"
                });

            context.SaveChanges();

            var deptoTecnologia = context.Departamentos.First(x => x.Nombre == "Tecnologia");
            var deptoFinanzas = context.Departamentos.First(x => x.Nombre == "Finanzas");
            var deptoRh = context.Departamentos.First(x => x.Nombre == "Recursos Humanos");
            var deptoOperaciones = context.Departamentos.First(x => x.Nombre == "Operaciones");

            context.Cargos.AddOrUpdate(
                c => new { c.Nombre, c.DepartamentoID },
                new Cargo { Nombre = "Gerente", DepartamentoID = deptoRh.DepartamentoID, Descripcion = "Lidera y supervisa el area" },
                new Cargo { Nombre = "Analista", DepartamentoID = deptoFinanzas.DepartamentoID, Descripcion = "Analiza informacion y procesos" },
                new Cargo { Nombre = "Asistente", DepartamentoID = deptoOperaciones.DepartamentoID, Descripcion = "Apoya tareas administrativas y operativas" },
                new Cargo { Nombre = "Desarrollador", DepartamentoID = deptoTecnologia.DepartamentoID, Descripcion = "Implementa soluciones de software" }
            );

            context.SaveChanges();

            var cargoDesarrollador = context.Cargos.First(x => x.Nombre == "Desarrollador");
            var cargoAnalista = context.Cargos.First(x => x.Nombre == "Analista");

            context.Empleados.AddOrUpdate(
                e => e.Nombre,
                new Empleado
                {
                    Nombre = "Juan Perez",
                    DepartamentoID = deptoTecnologia.DepartamentoID,
                    CargoID = cargoDesarrollador.CargoID,
                    FechaInicio = new DateTime(2021, 2, 15),
                    Salario = 65000m,
                    Estado = "Activo"
                },
                new Empleado
                {
                    Nombre = "Maria Rodriguez",
                    DepartamentoID = deptoFinanzas.DepartamentoID,
                    CargoID = cargoAnalista.CargoID,
                    FechaInicio = new DateTime(2022, 6, 3),
                    Salario = 52000m,
                    Estado = "Activo"
                }
            );

            context.SaveChanges();

            var empleadoJuan = context.Empleados.First(x => x.Nombre == "Juan Perez");

            context.Vacaciones.AddOrUpdate(
                v => new { v.EmpleadoID, v.FechaInicio, v.FechaFin },
                new Vacaciones
                {
                    EmpleadoID = empleadoJuan.EmpleadoID,
                    FechaInicio = DateTime.Today.AddDays(15),
                    FechaFin = DateTime.Today.AddDays(22),
                    Estado = "Pendiente"
                }
            );

            context.HistorialSalarios.AddOrUpdate(
                h => new { h.EmpleadoID, h.FechaCambio },
                new HistorialSalario
                {
                    EmpleadoID = empleadoJuan.EmpleadoID,
                    SalarioAnterior = 60000m,
                    SalarioNuevo = 65000m,
                    FechaCambio = new DateTime(2025, 1, 1)
                }
            );
        }
    }
}
