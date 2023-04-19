namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionModelos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaServicios", "TotalDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Factura", "TotalDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Factura", "Canal", c => c.String());
            DropColumn("dbo.Factura", "Descuento");
            DropColumn("dbo.Factura", "CanalGenerado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factura", "CanalGenerado", c => c.String());
            AddColumn("dbo.Factura", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Factura", "Canal");
            DropColumn("dbo.Factura", "TotalDescuento");
            DropColumn("dbo.FacturaServicios", "TotalDescuento");
        }
    }
}
