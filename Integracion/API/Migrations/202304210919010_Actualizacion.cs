namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actualizacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persona", "Sexo", c => c.String(maxLength: 1, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persona", "Sexo");
        }
    }
}
