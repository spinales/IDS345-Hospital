namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelosActualizados : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ingreso", "FechaFin", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ingreso", "FechaFin", c => c.DateTime(nullable: false));
        }
    }
}
