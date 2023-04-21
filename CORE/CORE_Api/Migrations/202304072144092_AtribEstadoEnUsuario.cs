namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtribEstadoEnUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Perfil", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Perfil", "Estado");
        }
    }
}
