namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedimientos : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE PROCEDURE sp_registrar_factura
                    @TotalFinal DECIMAL(18,2),
                    @TotalDescuento DECIMAL(18,2),
                    @TotalBruto DECIMAL(18,2),
                    @CuentaID INT = NULL,
                    @PacienteID INT,
                    @EmpleadoID INT = NULL,
                    @MetodoPagoID INT,
                    @CreatedAt DATETIME,
                    @CodigoFactura NVARCHAR(255),
                    @Canal NVARCHAR(100)
                AS
                BEGIN
                    INSERT INTO Factura(TotalFinal, TotalDescuento, TotalBruto, CuentaID, PacienteID, EmpleadoID, MetodoPagoID, CreatedAt, Estado, CodigoFactura, Canal, TotalAutorizado)
                    VALUES (@TotalFinal, @TotalDescuento, @TotalBruto, @CuentaID, @PacienteID, @EmpleadoID, @MetodoPagoID, @CreatedAt, 1, @CodigoFactura, @Canal, 0);
                    IF(@CuentaID is not NULL)
                    BEGIN
                        INSERT INTO Transaccion(Monto, Descripcion, TipoTransaccion, MetodoPagoID, CuentaID, EmpleadoID, CreatedAt, CodigoTransaccion, Canal, Estado)
                        VALUES (@TotalFinal, 'Factura agregada a la cuenta: ' + @CodigoFactura, 'Cargo', @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, NEWID(), @Canal, 1); 
                    
                        UPDATE Cuenta
                            SET Balance = Balance + @TotalFinal
                        WHERE CuentaID = @CuentaID;
                    END
                END
                GO            
            ");
            
            Sql(@"CREATE OR ALTER PROCEDURE sp_registrar_factura_servicio
                    @PrecioUnitario DECIMAL(18,2),
                    @Cantidad INT,
                    @Impuesto DECIMAL(18,2),
                    @Descuento DECIMAL(18,2),
                    @TotalImpuesto DECIMAL(18,2),
                    @TotalDescuento DECIMAL(18,2),
                    @TotalBruto DECIMAL(18,2),
                    @TotalFinal DECIMAL(18,2),
                    @Descripcion NVARCHAR(255),
                    @CreatedAt DATETIME,
                    @ServicioID INT,
                    @CodigoFactura NVARCHAR(255),
                    @ID INT OUTPUT
                AS
                BEGIN
                    DECLARE @FacturaID INT =  (SELECT TOP 1 FacturaID FROM Factura WHERE CodigoFactura = @CodigoFactura);

                    INSERT INTO FacturaServicios(PrecioUnitario, Cantidad, Impuesto, Descuento, TotalImpuesto, TotalDescuento, TotalBruto, TotalFinal, Descripcion, CreatedAt, ServicioID, FacturaID, TotalAutorizado)
                    VALUES (@PrecioUnitario, @Cantidad, @Impuesto, @Descuento, @TotalImpuesto, @TotalDescuento, @TotalBruto, @TotalFinal, @Descripcion, @CreatedAt, @ServicioID, @FacturaID, 0);

                    SET @ID = SCOPE_IDENTITY();
                END
                GO
            ");
            
            Sql(@"CREATE OR ALTER PROCEDURE sp_registrar_consulta 
                    @CodigoFactura NVARCHAR(255),
                    @Descripcion NVARCHAR(255),
                    @DoctorID INT,
                    @CreatedAt DATETIME,
                    @DetalleID INT
                AS
                BEGIN
                    
                    INSERT INTO Consulta(DoctorID, Descripcion, CreatedAt, DetalleId)
                    VALUES (@DoctorID, @Descripcion, @CreatedAt, @DetalleID);
                END
                GO            
            ");
            
            Sql(@"CREATE OR ALTER PROCEDURE sp_registrar_transaccion
                    @Monto DECIMAL(18,2),                    
                    @Descripcion NVARCHAR(255),
                    @TipoTransaccion NVARCHAR(100),
                    @MetodoPagoID INT,
                    @CuentaID INT,
                    @EmpleadoID INT = NULL,
                    @CreatedAt DATETIME,
                    @CodigoTransaccion NVARCHAR(255),
                    @Canal NVARCHAR(100)
                AS
                BEGIN
                    DECLARE @Signo INT = -1;
                    IF(@TipoTransaccion = 'Cargo') 
                        SET @Signo = 1;

                    UPDATE Cuenta
                        SET Balance = Balance + (@Monto * @Signo)
                    WHERE CuentaID = @CuentaID; 

                    INSERT INTO Transaccion(Monto, Descripcion, TipoTransaccion, MetodoPagoID, CuentaID, EmpleadoID, CreatedAt, CodigoTransaccion, Canal, Estado)
                    VALUES (@Monto, @Descripcion, @TipoTransaccion, @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, @CodigoTransaccion, @Canal, 1);
                END
                GO            
            ");

            Sql(@"CREATE PROCEDURE sp_insert_historico_acciones
                    @Descripcion VARCHAR(100),
                    @UsuarioID INT
                    AS
                    BEGIN
                        INSERT INTO HistoricoAcciones (Descripcion, UsuarioID, CreatedAt)
                        VALUES (@Descripcion, @UsuarioID, GETDATE())
                    END
                ");

        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_registrar_factura");
            
            Sql(@"DROP PROCEDURE sp_registrar_factura_servicio");
            
            Sql(@"DROP PROCEDURE sp_registrar_consulta");
            
            Sql(@"DROP PROCEDURE sp_registrar_transaccion");
            
            Sql(@"DROP PROCEDURE sp_insert_historico_acciones");
        }
    }
}
