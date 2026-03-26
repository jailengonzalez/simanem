namespace SiManEm.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class EnlazarCargoDepartamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cargo", "DepartamentoID", c => c.Int(nullable: true));

            Sql(@"
                IF NOT EXISTS (SELECT 1 FROM dbo.Departamento)
                BEGIN
                    INSERT INTO dbo.Departamento (Nombre, Descripcion)
                    VALUES ('General', 'Departamento por defecto para datos heredados')
                END

                DECLARE @DepartamentoPorDefecto INT
                SET @DepartamentoPorDefecto = (SELECT TOP 1 DepartamentoID FROM dbo.Departamento ORDER BY DepartamentoID)

                UPDATE dbo.Cargo
                SET DepartamentoID = @DepartamentoPorDefecto
                WHERE DepartamentoID IS NULL
                   OR DepartamentoID NOT IN (SELECT DepartamentoID FROM dbo.Departamento)
            ");

            AlterColumn("dbo.Cargo", "DepartamentoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cargo", "DepartamentoID");
            AddForeignKey("dbo.Cargo", "DepartamentoID", "dbo.Departamento", "DepartamentoID", cascadeDelete: false);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Cargo", "DepartamentoID", "dbo.Departamento");
            DropIndex("dbo.Cargo", new[] { "DepartamentoID" });
            DropColumn("dbo.Cargo", "DepartamentoID");
        }
    }
}
