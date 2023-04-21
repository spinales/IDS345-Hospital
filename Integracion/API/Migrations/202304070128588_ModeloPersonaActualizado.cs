namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloPersonaActualizado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Persona", "UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Persona", new[] { "UsuarioID" });
            AlterColumn("dbo.Persona", "UsuarioID", c => c.Int());
            CreateIndex("dbo.Persona", "UsuarioID");
            AddForeignKey("dbo.Persona", "UsuarioID", "dbo.Usuario", "UsuarioID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persona", "UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Persona", new[] { "UsuarioID" });
            AlterColumn("dbo.Persona", "UsuarioID", c => c.Int(nullable: false));
            CreateIndex("dbo.Persona", "UsuarioID");
            AddForeignKey("dbo.Persona", "UsuarioID", "dbo.Usuario", "UsuarioID", cascadeDelete: true);
        }
    }
}
