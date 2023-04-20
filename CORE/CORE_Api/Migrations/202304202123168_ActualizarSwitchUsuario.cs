namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizarSwitchUsuario : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE OR ALTER PROCEDURE sp_switch_usuario
                    @UsuarioID INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    UPDATE Usuario
                    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
                        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
                        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
                    WHERE UsuarioID = @UsuarioID;
                END;
                ");
        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_switch_usuario");
        }
    }
}
