namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposTotalesCodigos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaServicios", "CodigoFactura", c => c.String());
            AddColumn("dbo.FacturaServicios", "TotalDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Factura", "TotalDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Factura", "CodigoFactura", c => c.String());
            AddColumn("dbo.Factura", "CanalGenerado", c => c.String());
            AddColumn("dbo.Servicios", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transaccion", "CodigoTransaccion", c => c.String());
            AddColumn("dbo.Transaccion", "Canal", c => c.String());
            DropColumn("dbo.Factura", "Descuento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factura", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transaccion", "Canal");
            DropColumn("dbo.Transaccion", "CodigoTransaccion");
            DropColumn("dbo.Servicios", "Descuento");
            DropColumn("dbo.Factura", "CanalGenerado");
            DropColumn("dbo.Factura", "CodigoFactura");
            DropColumn("dbo.Factura", "TotalDescuento");
            DropColumn("dbo.FacturaServicios", "TotalDescuento");
            DropColumn("dbo.FacturaServicios", "CodigoFactura");
        }
    }
}
