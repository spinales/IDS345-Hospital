namespace Caja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuadreActualizado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetalleEfectivo", "CuadreID", "dbo.Cuadre");
            DropIndex("dbo.DetalleEfectivo", new[] { "CuadreID" });
            AlterColumn("dbo.DetalleEfectivo", "CuadreID", c => c.Int());
            CreateIndex("dbo.DetalleEfectivo", "CuadreID");
            AddForeignKey("dbo.DetalleEfectivo", "CuadreID", "dbo.Cuadre", "CuadreID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleEfectivo", "CuadreID", "dbo.Cuadre");
            DropIndex("dbo.DetalleEfectivo", new[] { "CuadreID" });
            AlterColumn("dbo.DetalleEfectivo", "CuadreID", c => c.Int(nullable: false));
            CreateIndex("dbo.DetalleEfectivo", "CuadreID");
            AddForeignKey("dbo.DetalleEfectivo", "CuadreID", "dbo.Cuadre", "CuadreID", cascadeDelete: false);
        }
    }
}
