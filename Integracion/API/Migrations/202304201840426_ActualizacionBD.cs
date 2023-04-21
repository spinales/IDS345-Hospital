namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionBD : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona");
            DropIndex("dbo.Transaccion", new[] { "EmpleadoID" });
            AlterColumn("dbo.Transaccion", "EmpleadoID", c => c.Int());
            CreateIndex("dbo.Transaccion", "EmpleadoID");
            AddForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona", "PersonaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona");
            DropIndex("dbo.Transaccion", new[] { "EmpleadoID" });
            AlterColumn("dbo.Transaccion", "EmpleadoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Transaccion", "EmpleadoID");
            AddForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona", "PersonaID", cascadeDelete: true);
        }
    }
}
