namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosDespuesBorrado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transaccion", "EmpleadoID", c => c.Int());
            CreateIndex("dbo.Transaccion", "EmpleadoID");
            AddForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona", "PersonaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaccion", "EmpleadoID", "dbo.Persona");
            DropIndex("dbo.Transaccion", new[] { "EmpleadoID" });
            DropColumn("dbo.Transaccion", "EmpleadoID");
        }
    }
}
