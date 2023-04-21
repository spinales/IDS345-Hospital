namespace Caja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actualizar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factura", "TotalDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Factura", "TotalDescuento");
        }
    }
}
