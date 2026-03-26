namespace SiManEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RETENCIONES : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfiguracionNomina",
                c => new
                    {
                        ConfiguracionNominaID = c.Int(nullable: false, identity: true),
                        PorcentajeAfp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PorcentajeArs = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ConfiguracionNominaID);
            
            CreateTable(
                "dbo.EscalaIsr",
                c => new
                    {
                        EscalaIsrID = c.Int(nullable: false, identity: true),
                        LimiteInferior = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LimiteSuperior = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tasa = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CuotaFija = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EscalaIsrID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EscalaIsr");
            DropTable("dbo.ConfiguracionNomina");
        }
    }
}
