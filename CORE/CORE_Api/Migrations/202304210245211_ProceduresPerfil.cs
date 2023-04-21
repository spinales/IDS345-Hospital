namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProceduresPerfil : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE PROCEDURE sp_insert_perfil
                    @Nombre VARCHAR(100),
                    @Estado BIT = 1
                AS
                BEGIN
                    SET NOCOUNT ON;

                    INSERT INTO Perfil (Nombre, Estado, CreatedAt)
                    VALUES (@Nombre, @Estado, GETDATE());
                END;");


            Sql(@"CREATE PROCEDURE sp_update_perfil
                    @PerfilID INT,
                    @Nombre VARCHAR(100) = NULL
                AS
                BEGIN
                    SET NOCOUNT ON;

                    UPDATE Perfil
                    SET Nombre = COALESCE(@Nombre, Nombre),
                        UpdatedAt = GETDATE()
                    WHERE PerfilID = @PerfilID;
                END;
                ");
            Sql(@"CREATE PROCEDURE sp_switch_perfil
                    @PerfilID INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    UPDATE Perfil
                    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
                        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
                        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
                    WHERE PerfilID = @PerfilID;
                END;");

            Sql(@"CREATE PROCEDURE sp_insert_perfil_role
                    @PerfilID int,
                    @EntidadID int,
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
            Sql(@"DROP PROCEDURE sp_insert_perfil");
            Sql(@"DROP PROCEDURE sp_update_perfil");
            Sql(@"DROP PROCEDURE sp_switch_perfil");
        }
    }
}
