namespace Caja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procedimientos_Paola : DbMigration
    {
        public override void Up()
        {
            Sql(@"create procedure sp_insert_InicioDia

                    @Balance decimal,
                    @CajeroID int,
                    @IdIngreso int OUTPUT
                AS
                BEGIN

                    insert into InicioDia(Balance, CajeroID, CreatedAt) Values(@Balance, @CajeroID, GETDATE())

                    SET @IdIngreso = SCOPE_IDENTITY()
                END;
            "
            );

            Sql(@"create procedure sp_Detalle_Efectivo

                        @DosmilPesos int,
		                @MilPesos int,
                        @QuinientosPesos int,
                        @DocientosPesos int,
                        @cienPesos int,
                        @CincuentaPesos int,
                        @VeinticincoPesos int,
		                @DiezPesos int,
                        @CincoPesos int,
                        @UnPeso int,
                        @TotalEfectivo int,
		                @InicioDiaID int,
		                @CuadreID int
                AS
                BEGIN
		                insert into DetalleEfectivo(DosmilPesos, MilPesos, QuinientosPesos, DocientosPesos, cienPesos, CincuentaPesos, VeinticincoPesos, DiezPesos, CincoPesos, UnPeso, TotalEfectivo, InicioDiaID, CuadreID, CreatedAt) 
		                Values(@DosmilPesos, @MilPesos, @QuinientosPesos, @DocientosPesos, @cienPesos, @CincuentaPesos, @VeinticincoPesos, @DiezPesos, @CincoPesos, @UnPeso, @TotalEfectivo, @InicioDiaID, @CuadreID, GETDATE())
                END;
            "
            );

            Sql(@"CREATE OR ALTER PROCEDURE sp_registrar_transaccion
                    @Monto DECIMAL(18,2),                    
                    @Descripcion NVARCHAR(255),
                    @TipoTransaccion NVARCHAR(100),
                    @MetodoPagoID INT,
                    @CuentaID INT,
                    @EmpleadoID INT = NULL,
                    @CreatedAt DATETIME,
                    @CodigoTransaccion NVARCHAR(255)
                    
                AS
                BEGIN
                    DECLARE @Signo INT = -1;
                    IF(@TipoTransaccion = 'Cargo') 
                        SET @Signo = 1;

                    UPDATE Cuenta
                        SET Balance = Balance + (@Monto * @Signo)
                    WHERE CuentaID = @CuentaID; 

                    INSERT INTO Transaccion(Monto, Descripcion, TipoTransaccion, MetodoPagoID, CuentaID, EmpleadoID, CreatedAt, CodigoTransaccion, Estado)
                    VALUES (@Monto, @Descripcion, @TipoTransaccion, @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, @CodigoTransaccion, 1);
                END
                GO            
            ");

        }
        
        public override void Down()
        {
            Sql(@"DROP PROCEDURE sp_insert_InicioDia");

            Sql(@"DROP PROCEDURE sp_Detalle_Efectivo");

        }
    }
}
