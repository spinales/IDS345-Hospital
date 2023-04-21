namespace CORE_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProceduresIngresosAutorizacionCuenta : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE PROCEDURE sp_insert_ingreso
(
    @FechaInicio DATETIME,
    @FechaFin DATETIME,
    @Alta BIT,
    @MontoIngreso DECIMAL(18, 2),
    @CuentaID INT,
    @PacienteID INT,
    @HabitacionID INT
)
AS
BEGIN
    INSERT INTO Ingreso (FechaInicio, FechaFin, Alta, MontoIngreso, CuentaID, PacienteID, HabitacionID, CreatedAt)
    VALUES (@FechaInicio, @FechaFin, @Alta, @MontoIngreso, @CuentaID, @PacienteID, @HabitacionID, GETDATE())
END");

            Sql(@"CREATE PROCEDURE sp_update_ingreso
(
    @IngresoID INT,
    @FechaInicio DATETIME,
    @FechaFin DATETIME,
    @Alta BIT,
    @MontoIngreso DECIMAL(18, 2),
    @CuentaID INT,
    @PacienteID INT,
    @HabitacionID INT
)
AS
BEGIN
    UPDATE Ingreso
    SET FechaInicio = COALESCE(@FechaInicio, FechaInicio),
        FechaFin = COALESCE(@FechaFin, FechaFin),
        Alta = COALESCE(@Alta, Alta),
        MontoIngreso = COALESCE(@MontoIngreso, MontoIngreso),
        CuentaID = COALESCE(@CuentaID, CuentaID),
        PacienteID = COALESCE(@PacienteID, PacienteID),
        HabitacionID = COALESCE(@HabitacionID, HabitacionID),
        UpdatedAt = GETDATE()
    WHERE IngresoID = @IngresoID
END");

            Sql(@"CREATE PROCEDURE sp_switch_ingreso
        @IngresoID INT
        AS
        BEGIN
        SET NOCOUNT ON;
        UPDATE Ingreso
    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
    WHERE IngresoID = @IngresoID;
END;");
            Sql(@"CREATE PROCEDURE sp_insert_autorizacion
(
    @MontoAutorizado DECIMAL(18, 2),
    @AseguradoraID INT
)
AS
BEGIN
    INSERT INTO Autorizaciones (MontoAutorizado, AseguradoraID, CreatedAt)
    VALUES (@MontoAutorizado, @AseguradoraID, GETDATE())
END");

            Sql(@"CREATE PROCEDURE sp_update_autorizacion
(
    @AutorizacionID INT,
    @MontoAutorizado DECIMAL(18, 2),
    @AseguradoraID INT
)
AS
BEGIN
    UPDATE Autorizaciones
    SET MontoAutorizado = COALESCE(@MontoAutorizado, MontoAutorizado),
        AseguradoraID = COALESCE(@AseguradoraID, AseguradoraID),
        UpdatedAt = GETDATE()
    WHERE AutorizacionID = @AutorizacionID
END");

            Sql(@"CREATE PROCEDURE sp_switch_autorizacion
        @AutorizacionID INT
        AS
        BEGIN
        SET NOCOUNT ON;
        UPDATE Autorizaciones
    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
    WHERE AutorizacionID = @AutorizacionID;
END;");
            Sql(@"CREATE PROCEDURE sp_insert_cuenta
(
    @Balance DECIMAL(18, 2),
    @PacienteID INT
)
AS
BEGIN
    INSERT INTO Cuenta (Balance, PacienteID, CreatedAt)
    VALUES (@Balance, @PacienteID, GETDATE())
END");


            Sql(@"CREATE PROCEDURE sp_update_cuenta
(
    @CuentaID INT,
    @Balance DECIMAL(18, 2),
    @PacienteID INT
)
AS
BEGIN
    UPDATE Cuenta
    SET Balance = COALESCE(@Balance, Balance),
        PacienteID = COALESCE(@PacienteID, PacienteID),
        UpdatedAt = GETDATE()
    WHERE CuentaID = @CuentaID
END");

            Sql(@"CREATE PROCEDURE sp_switch_cuenta
        @CuentaID INT
        AS
        BEGIN
        SET NOCOUNT ON;
        UPDATE Cuenta
    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
    WHERE CuentaID = @CuentaID;
END;");

            Sql(@"CREATE PROCEDURE sp_insert_servicio
(
    @TipoServicioID INT,
    @Descripcion VARCHAR(100),
    @Precio DECIMAL(18, 2),
    @Impuesto DECIMAL(18, 2),
    @Descuento DECIMAL(18, 2)
)
AS
BEGIN
    INSERT INTO Servicios (TipoServicioID, Descripcion, Precio, Impuesto, Descuento, CreatedAt)
    VALUES (@TipoServicioID, @Descripcion, @Precio, @Impuesto, @Descuento, GETDATE())
END");

            Sql(@"CREATE PROCEDURE sp_update_servicio
(
    @ServicioID INT,
    @TipoServicioID INT = NULL,
    @Descripcion VARCHAR(100) = NULL,
    @Precio DECIMAL(18, 2) = NULL,
    @Impuesto DECIMAL(18, 2) = NULL,
    @Descuento DECIMAL(18, 2) = NULL
)
AS
BEGIN
    UPDATE Servicios
    SET TipoServicioID = COALESCE(@TipoServicioID, TipoServicioID),
        Descripcion = COALESCE(@Descripcion, Descripcion),
        Precio = COALESCE(@Precio, Precio),
        Impuesto = COALESCE(@Impuesto, Impuesto),
        Descuento = COALESCE(@Descuento, Descuento),
        UpdatedAt = GETDATE()
    WHERE ServicioID = @ServicioID
END");

            Sql(@"CREATE PROCEDURE sp_switch_servicio
        @ServicioID INT
        AS
        BEGIN
        SET NOCOUNT ON;
        UPDATE Servicios
    SET Estado = CASE WHEN Estado = 1 THEN 0 ELSE 1 END,
        UpdatedAt = CASE WHEN Estado = 1 THEN UpdatedAt ELSE GETDATE() END,
        DeletedAt = CASE WHEN Estado = 1 THEN GETDATE() ELSE DeletedAt END
    WHERE ServicioID = @ServicioID;
END;");
        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_insert_ingreso");
            Sql(@"DROP PROCEDURE sp_update_ingreso");
            Sql(@"DROP PROCEDURE sp_switch_ingreso");
            Sql(@"DROP PROCEDURE sp_insert_autorizacion");
            Sql(@"DROP PROCEDURE sp_update_autorizacion");
            Sql(@"DROP PROCEDURE sp_switch_autorizacion");
            Sql(@"DROP PROCEDURE sp_insert_cuenta");
            Sql(@"DROP PROCEDURE sp_update_cuenta");
            Sql(@"DROP PROCEDURE sp_switch_cuenta");
            Sql(@"DROP PROCEDURE sp_insert_servicio");
            Sql(@"DROP PROCEDURE sp_update_servicio");
            Sql(@"DROP PROCEDURE sp_switch_servicio");
        }
    }
}
