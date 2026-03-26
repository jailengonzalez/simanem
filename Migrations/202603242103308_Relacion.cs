namespace SiManEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cargo", "DepartamentoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cargo", "DepartamentoID");
            AddForeignKey("dbo.Cargo", "DepartamentoID", "dbo.Departamento", "DepartamentoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cargo", "DepartamentoID", "dbo.Departamento");
            DropIndex("dbo.Cargo", new[] { "DepartamentoID" });
            DropColumn("dbo.Cargo", "DepartamentoID");
        }
    }
}
