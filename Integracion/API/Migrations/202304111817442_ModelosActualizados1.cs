namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelosActualizados1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaServicios", "CodigoFactura", c => c.String());
            AddColumn("dbo.Factura", "CodigoFactura", c => c.String());
            AddColumn("dbo.Factura", "CanalGenerado", c => c.String());
            AddColumn("dbo.Servicios", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transaccion", "EmpleadoID", c => c.Int(nullable: false));
            AddColumn("dbo.Transaccion", "CodigoTransaccion", c => c.String());
            AddColumn("dbo.Transaccion", "Canal", c => c.String());
            CreateIndex("dbo.Transaccion", "EmpleadoID");
            AddForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona", "PersonaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona");
            DropIndex("dbo.Transaccion", new[] { "EmpleadoID" });
            DropColumn("dbo.Transaccion", "Canal");
            DropColumn("dbo.Transaccion", "CodigoTransaccion");
            DropColumn("dbo.Transaccion", "EmpleadoID");
            DropColumn("dbo.Servicios", "Descuento");
            DropColumn("dbo.Factura", "CanalGenerado");
            DropColumn("dbo.Factura", "CodigoFactura");
            DropColumn("dbo.FacturaServicios", "CodigoFactura");
        }
    }
}
