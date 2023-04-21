namespace Caja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedimientos_David : DbMigration
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
                @CodigoFactura NVARCHAR(255)
            AS
            BEGIN
                INSERT INTO Factura(TotalFinal, TotalDescuento, TotalBruto, CuentaID, PacienteID, EmpleadoID, MetodoPagoID, CreatedAt, Estado, CodigoFactura, TotalAutorizado)
                VALUES (@TotalFinal, @TotalDescuento, @TotalBruto, @CuentaID, @PacienteID, @EmpleadoID, @MetodoPagoID, @CreatedAt, 1, @CodigoFactura, 0);
                IF(@CuentaID is not NULL)
                BEGIN
                    INSERT INTO Transaccion(Monto, Descripcion, TipoTransaccion, MetodoPagoID, CuentaID, EmpleadoID, CreatedAt, CodigoTransaccion, Estado)
                    VALUES (@TotalFinal, 'Factura agregada a la cuenta: ' + @CodigoFactura, 'Cargo', @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, NEWID(), 1); 

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

        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_registrar_factura");
            Sql(@"DROP PROCEDURE sp_registrar_factura_servicio");
        }
    }
}
