namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class proceduresPersona : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE OR ALTER PROCEDURE sp_insert_persona
(
    @Sexo VARCHAR(1),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Documento VARCHAR(100),
    @Telefono VARCHAR(100),
    @TipoSangreID INT,
    @TipoDocumentoID INT,
    @NacionalidadID INT,
    @RolPersonaID INT
)
AS
BEGIN
    INSERT INTO Personas (Sexo, Nombre, Apellido, Documento, Telefono,  TipoSangreID, TipoDocumentoID, NacionalidadID, RolPersonaID, CreatedAt)
    VALUES (@Sexo, @Nombre, @Apellido, @Documento, @Telefono,  @TipoSangreID, @TipoDocumentoID, @NacionalidadID, @RolPersonaID, getdate())
END");

            Sql(@"CREATE OR ALTER PROCEDURE sp_update_persona
(
    @PersonaID INT,
    @Sexo VARCHAR(1),
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Documento VARCHAR(100),
    @Telefono VARCHAR(100),
    @TipoSangreID INT,
    @TipoDocumentoID INT,
    @NacionalidadID INT,
    @RolPersonaID INT
)
AS
BEGIN
    UPDATE Personas
    SET Sexo = COALESCE(@Sexo, Sexo),
        Nombre = COALESCE(@Nombre, Nombre),
        Apellido = COALESCE(@Apellido, Apellido),
        Documento = COALESCE(@Documento, Documento),
        Telefono = COALESCE(@Telefono, Telefono),
        TipoSangreID = COALESCE(@TipoSangreID, TipoSangreID),
        TipoDocumentoID = COALESCE(@TipoDocumentoID, TipoDocumentoID),
        NacionalidadID = COALESCE(@NacionalidadID, NacionalidadID),
        RolPersonaID = COALESCE(@RolPersonaID, RolPersonaID),
        UpdatedAt = GETDATE()
    WHERE PersonaID = @PersonaID
END");

            Sql(@"CREATE PROCEDURE sp_switch_persona
        @PersonaID INT
        AS
        BEGIN
        SET NOCOUNT ON;
        UPDATE Persona
    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
    WHERE PersonaID = @PersonaID;
END;");

        }

        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_insert_persona");
            Sql(@"DROP PROCEDURE sp_update_persona");
            Sql(@"DROP PROCEDURE sp_switch_persona");
        }
    }
}
