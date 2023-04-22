namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterPerfilProcedures : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE OR ALTER PROCEDURE sp_insert_perfil_role
                    @PerfilID int,
                    @EntidadId int,
                    @RoleID int
                AS
                BEGIN
                    SET NOCOUNT ON;
    
                    DECLARE @CreatedAt datetime = GETDATE();
    
                    INSERT INTO PerfilRole (PerfilID, EntidadID, RoleID, CreatedAt)
                    VALUES (@PerfilID, @EntidadID, @RoleID, @CreatedAt);
                END;");
        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_insert_perfil_role");
        }
    }
}
