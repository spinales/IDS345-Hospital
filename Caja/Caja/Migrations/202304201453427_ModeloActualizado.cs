namespace Caja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloActualizado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleEfectivo",
                c => new
                    {
                        DetalleEfectivoID = c.Int(nullable: false, identity: true),
                        DosmilPesos = c.Int(nullable: false),
                        MilPesos = c.Int(nullable: false),
                        QuinientosPesos = c.Int(nullable: false),
                        DocientosPesos = c.Int(nullable: false),
                        cienPesos = c.Int(nullable: false),
                        CincuentaPesos = c.Int(nullable: false),
                        VeinticincoPesos = c.Int(nullable: false),
                        DiezPesos = c.Int(nullable: false),
                        CincoPesos = c.Int(nullable: false),
                        UnPeso = c.Int(nullable: false),
                        TotalEfectivo = c.Int(nullable: false),
                        InicioDiaID = c.Int(nullable: false),
                        CuadreID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.DetalleEfectivoID)
                .ForeignKey("dbo.Cuadre", t => t.CuadreID, cascadeDelete: false)
                .ForeignKey("dbo.InicioDia", t => t.InicioDiaID, cascadeDelete: false)
                .Index(t => t.InicioDiaID)
                .Index(t => t.CuadreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleEfectivo", "InicioDiaID", "dbo.InicioDia");
            DropForeignKey("dbo.DetalleEfectivo", "CuadreID", "dbo.Cuadre");
            DropIndex("dbo.DetalleEfectivo", new[] { "CuadreID" });
            DropIndex("dbo.DetalleEfectivo", new[] { "InicioDiaID" });
            DropTable("dbo.DetalleEfectivo");
        }
    }
}
