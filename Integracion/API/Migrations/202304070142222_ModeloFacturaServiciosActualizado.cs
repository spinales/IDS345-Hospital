namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloFacturaServiciosActualizado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FacturaServicios", "AutorizacionID", "dbo.Autorizaciones");
            DropIndex("dbo.FacturaServicios", new[] { "AutorizacionID" });
            AlterColumn("dbo.FacturaServicios", "AutorizacionID", c => c.Int());
            CreateIndex("dbo.FacturaServicios", "AutorizacionID");
            AddForeignKey("dbo.FacturaServicios", "AutorizacionID", "dbo.Autorizaciones", "AutorizacionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaServicios", "AutorizacionID", "dbo.Autorizaciones");
            DropIndex("dbo.FacturaServicios", new[] { "AutorizacionID" });
            AlterColumn("dbo.FacturaServicios", "AutorizacionID", c => c.Int(nullable: false));
            CreateIndex("dbo.FacturaServicios", "AutorizacionID");
            AddForeignKey("dbo.FacturaServicios", "AutorizacionID", "dbo.Autorizaciones", "AutorizacionID", cascadeDelete: true);
        }
    }
}
