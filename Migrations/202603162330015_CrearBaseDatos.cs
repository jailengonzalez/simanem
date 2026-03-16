namespace SiManEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        CargoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.CargoID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        DepartamentoID = c.Int(nullable: false),
                        CargoID = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.EmpleadoID)
                .ForeignKey("dbo.Cargo", t => t.CargoID)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoID)
                .Index(t => t.DepartamentoID)
                .Index(t => t.CargoID);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        DepartamentoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.HistorialSalario",
                c => new
                    {
                        HistorialID = c.Int(nullable: false, identity: true),
                        EmpleadoID = c.Int(nullable: false),
                        SalarioAnterior = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalarioNuevo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCambio = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HistorialID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Vacaciones",
                c => new
                    {
                        VacacionID = c.Int(nullable: false, identity: true),
                        EmpleadoID = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.VacacionID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(nullable: false, maxLength: 50),
                        Contrasena = c.String(nullable: false, maxLength: 512),
                        Rol = c.String(nullable: false, maxLength: 30),
                        Estado = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacaciones", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.HistorialSalario", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Empleado", "DepartamentoID", "dbo.Departamento");
            DropForeignKey("dbo.Empleado", "CargoID", "dbo.Cargo");
            DropIndex("dbo.Vacaciones", new[] { "EmpleadoID" });
            DropIndex("dbo.HistorialSalario", new[] { "EmpleadoID" });
            DropIndex("dbo.Empleado", new[] { "CargoID" });
            DropIndex("dbo.Empleado", new[] { "DepartamentoID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Vacaciones");
            DropTable("dbo.HistorialSalario");
            DropTable("dbo.Departamento");
            DropTable("dbo.Empleado");
            DropTable("dbo.Cargo");
        }
    }
}
