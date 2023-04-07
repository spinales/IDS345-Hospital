namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedures_Usuarios : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE PROCEDURE sp_insert_usuario
                    @Username VARCHAR(100),
                    @Password VARCHAR(100),
                    @Email VARCHAR(100),
                    @SucursalID INT,
                    @PerfilID INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    INSERT INTO Usuario (Username, Password, Email, Estado, SucursalID, PerfilID, CreatedAt)
                    VALUES (@Username, @Password, @Email, 1, @SucursalID, @PerfilID, GETDATE());
                END;
                ");

            Sql(@"CREATE PROCEDURE sp_update_usuario
            @UsuarioID INT,
            @Username VARCHAR(100) = NULL,
            @Password VARCHAR(100) = NULL,
            @Email VARCHAR(100) = NULL,
            @Estado BIT = NULL,
            @SucursalID INT = NULL,
            @PerfilID INT = NULL
            AS
            BEGIN
                SET NOCOUNT ON;

                UPDATE Usuario
                SET Username = COALESCE(@Username, Username),
                    Password = COALESCE(@Password, Password),
                    Email = COALESCE(@Email, Email),
                    Estado = COALESCE(@Estado, Estado),
                    SucursalID = COALESCE(@SucursalID, SucursalID),
                    PerfilID = COALESCE(@PerfilID, PerfilID),
                    UpdatedAt = GETDATE()
                WHERE UsuarioID = @UsuarioID;
            END;
            ");

            Sql(@"CREATE PROCEDURE sp_get_usuarios
                AS
                BEGIN
                    SET NOCOUNT ON;

                    SELECT UsuarioID, Username, Password, Email, Estado, SucursalID, PerfilID, CreatedAt, UpdatedAt, DeletedAt, SendedAt
                    FROM Usuario;
                END;");

            Sql(@"CREATE PROCEDURE sp_getID_usuario
                    @UsuarioID INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    SELECT UsuarioID, Username, Password, Email, Estado, SucursalID, PerfilID, CreatedAt, UpdatedAt, DeletedAt, SendedAt
                    FROM Usuario
                    WHERE UsuarioID = @UsuarioID;
                END;");

            Sql(@"CREATE PROCEDURE sp_switch_usuario
                    @UsuarioID INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    UPDATE Usuario
                    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
                        UpdatedAt = CASE WHEN Estado = 1 THEN NULL ELSE GETDATE() END,
                        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE NULL END
                    WHERE UsuarioID = @UsuarioID;
                END;
                                ");
        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_insert_usuario");

            Sql(@"DROP PROCEDURE sp_update_usuario");

            Sql(@"DROP PROCEDURE sp_get_usuarios");

            Sql(@"DROP PROCEDURE sp_getID_usuario");

            Sql(@"DROP PROCEDURE sp_switch_usuario");

        }
    }
}
