namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloUsuarioActualizado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "PerfilID", "dbo.Perfil");
            DropForeignKey("dbo.Usuario", "SucursalID", "dbo.Sucursal");
            DropIndex("dbo.Usuario", new[] { "SucursalID" });
            DropIndex("dbo.Usuario", new[] { "PerfilID" });
            AlterColumn("dbo.Usuario", "SucursalID", c => c.Int());
            AlterColumn("dbo.Usuario", "PerfilID", c => c.Int());
            CreateIndex("dbo.Usuario", "SucursalID");
            CreateIndex("dbo.Usuario", "PerfilID");
            AddForeignKey("dbo.Usuario", "PerfilID", "dbo.Perfil", "PerfilID");
            AddForeignKey("dbo.Usuario", "SucursalID", "dbo.Sucursal", "SucursalID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "SucursalID", "dbo.Sucursal");
            DropForeignKey("dbo.Usuario", "PerfilID", "dbo.Perfil");
            DropIndex("dbo.Usuario", new[] { "PerfilID" });
            DropIndex("dbo.Usuario", new[] { "SucursalID" });
            AlterColumn("dbo.Usuario", "PerfilID", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuario", "SucursalID", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuario", "PerfilID");
            CreateIndex("dbo.Usuario", "SucursalID");
            AddForeignKey("dbo.Usuario", "SucursalID", "dbo.Sucursal", "SucursalID", cascadeDelete: true);
            AddForeignKey("dbo.Usuario", "PerfilID", "dbo.Perfil", "PerfilID", cascadeDelete: true);
        }
    }
}
