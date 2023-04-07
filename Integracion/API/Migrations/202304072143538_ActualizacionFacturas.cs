namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionFacturas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Factura", "CuentaID", "dbo.Cuenta");
            DropForeignKey("dbo.Factura", "EmpleadoID", "dbo.Persona");
            DropIndex("dbo.Factura", new[] { "CuentaID" });
            DropIndex("dbo.Factura", new[] { "EmpleadoID" });
            AlterColumn("dbo.Factura", "CuentaID", c => c.Int());
            AlterColumn("dbo.Factura", "EmpleadoID", c => c.Int());
            CreateIndex("dbo.Factura", "CuentaID");
            CreateIndex("dbo.Factura", "EmpleadoID");
            AddForeignKey("dbo.Factura", "CuentaID", "dbo.Cuenta", "CuentaID");
            AddForeignKey("dbo.Factura", "EmpleadoID", "dbo.Persona", "PersonaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "EmpleadoID", "dbo.Persona");
            DropForeignKey("dbo.Factura", "CuentaID", "dbo.Cuenta");
            DropIndex("dbo.Factura", new[] { "EmpleadoID" });
            DropIndex("dbo.Factura", new[] { "CuentaID" });
            AlterColumn("dbo.Factura", "EmpleadoID", c => c.Int(nullable: false));
            AlterColumn("dbo.Factura", "CuentaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Factura", "EmpleadoID");
            CreateIndex("dbo.Factura", "CuentaID");
            AddForeignKey("dbo.Factura", "EmpleadoID", "dbo.Persona", "PersonaID", cascadeDelete: true);
            AddForeignKey("dbo.Factura", "CuentaID", "dbo.Cuenta", "CuentaID", cascadeDelete: true);
        }
    }
}
