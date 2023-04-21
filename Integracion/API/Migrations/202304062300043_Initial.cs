namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aseguradora",
                c => new
                    {
                        AseguradoraID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200, unicode: false),
                        Telefono = c.String(maxLength: 200, unicode: false),
                        Direccion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.AseguradoraID);
            
            CreateTable(
                "dbo.Autorizaciones",
                c => new
                    {
                        AutorizacionID = c.Int(nullable: false, identity: true),
                        MontoAutorizado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        AseguradoraID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.AutorizacionID)
                .ForeignKey("dbo.Aseguradora", t => t.AseguradoraID, cascadeDelete: false)
                .Index(t => t.AseguradoraID);
            
            CreateTable(
                "dbo.FacturaServicios",
                c => new
                    {
                        DetalleID = c.Int(nullable: false, identity: true),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Int(nullable: false),
                        Impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalImpuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAutorizado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalFinal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descripcion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                        AutorizacionID = c.Int(nullable: false),
                        ServicioID = c.Int(nullable: false),
                        FacturaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleID)
                .ForeignKey("dbo.Autorizaciones", t => t.AutorizacionID, cascadeDelete: false)
                .ForeignKey("dbo.Factura", t => t.FacturaID, cascadeDelete: false)
                .ForeignKey("dbo.Servicios", t => t.ServicioID, cascadeDelete: false)
                .Index(t => t.AutorizacionID)
                .Index(t => t.ServicioID)
                .Index(t => t.FacturaID);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaID = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                        TotalFinal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAutorizado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CuentaID = c.Int(nullable: false),
                        PacienteID = c.Int(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                        MetodoPagoID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                        Persona_PersonaID = c.Int(),
                    })
                .PrimaryKey(t => t.FacturaID)
                .ForeignKey("dbo.Persona", t => t.Persona_PersonaID)
                .ForeignKey("dbo.Cuenta", t => t.CuentaID, cascadeDelete: false)
                .ForeignKey("dbo.Persona", t => t.EmpleadoID, cascadeDelete: false)
                .ForeignKey("dbo.MetodoPago", t => t.MetodoPagoID, cascadeDelete: false)
                .ForeignKey("dbo.Persona", t => t.PacienteID, cascadeDelete: false)
                .Index(t => t.CuentaID)
                .Index(t => t.PacienteID)
                .Index(t => t.EmpleadoID)
                .Index(t => t.MetodoPagoID)
                .Index(t => t.Persona_PersonaID);
            
            CreateTable(
                "dbo.Cuenta",
                c => new
                    {
                        CuentaID = c.Int(nullable: false, identity: true),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        PacienteID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.CuentaID)
                .ForeignKey("dbo.Persona", t => t.PacienteID, cascadeDelete: false)
                .Index(t => t.PacienteID);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        PersonaID = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        Apellido = c.String(maxLength: 100, unicode: false),
                        Documento = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 100, unicode: false),
                        UsuarioID = c.Int(nullable: false),
                        TipoSangreID = c.Int(nullable: false),
                        TipoDocumentoID = c.Int(nullable: false),
                        NacionalidadID = c.Int(nullable: false),
                        RolPersonaID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.PersonaID)
                .ForeignKey("dbo.Nacionalidad", t => t.NacionalidadID, cascadeDelete: false)
                .ForeignKey("dbo.RolPersona", t => t.RolPersonaID, cascadeDelete: false)
                .ForeignKey("dbo.TipoDocumento", t => t.TipoDocumentoID, cascadeDelete: false)
                .ForeignKey("dbo.TipoSangre", t => t.TipoSangreID, cascadeDelete: false)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.UsuarioID)
                .Index(t => t.TipoSangreID)
                .Index(t => t.TipoDocumentoID)
                .Index(t => t.NacionalidadID)
                .Index(t => t.RolPersonaID);
            
            CreateTable(
                "dbo.Ingreso",
                c => new
                    {
                        IngresoID = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Alta = c.Boolean(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        MontoIngreso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CuentaID = c.Int(nullable: false),
                        PacienteID = c.Int(nullable: false),
                        HabitacionID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.IngresoID)
                .ForeignKey("dbo.Cuenta", t => t.CuentaID, cascadeDelete: false)
                .ForeignKey("dbo.Habitacion", t => t.HabitacionID, cascadeDelete: false)
                .ForeignKey("dbo.Persona", t => t.PacienteID, cascadeDelete: false)
                .Index(t => t.CuentaID)
                .Index(t => t.PacienteID)
                .Index(t => t.HabitacionID);
            
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        HabitacionID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 100, unicode: false),
                        Estado = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.HabitacionID);
            
            CreateTable(
                "dbo.Nacionalidad",
                c => new
                    {
                        NacionalidadID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.NacionalidadID);
            
            CreateTable(
                "dbo.RolPersona",
                c => new
                    {
                        RolPersonaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        Descripcion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.RolPersonaID);
            
            CreateTable(
                "dbo.TipoDocumento",
                c => new
                    {
                        TipoDocumentoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.TipoDocumentoID);
            
            CreateTable(
                "dbo.TipoSangre",
                c => new
                    {
                        TipoSangreID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.TipoSangreID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Estado = c.Boolean(nullable: false),
                        SucursalID = c.Int(nullable: false),
                        PerfilID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .ForeignKey("dbo.Perfil", t => t.PerfilID, cascadeDelete: false)
                .ForeignKey("dbo.Sucursal", t => t.SucursalID, cascadeDelete: false)
                .Index(t => t.SucursalID)
                .Index(t => t.PerfilID);
            
            CreateTable(
                "dbo.HistoricoAcciones",
                c => new
                    {
                        HistoricoID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        UsuarioID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.HistoricoID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: false)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        PerfilID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.PerfilID);
            
            CreateTable(
                "dbo.PerfilRole",
                c => new
                    {
                        PerfilID = c.Int(nullable: false),
                        EntidadID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.PerfilID, t.EntidadID, t.RoleID })
                .ForeignKey("dbo.Entidad", t => t.EntidadID, cascadeDelete: false)
                .ForeignKey("dbo.Perfil", t => t.PerfilID, cascadeDelete: false)
                .ForeignKey("dbo.Role", t => t.RoleID, cascadeDelete: false)
                .Index(t => t.PerfilID)
                .Index(t => t.EntidadID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Entidad",
                c => new
                    {
                        EntidadId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.EntidadId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Sucursal",
                c => new
                    {
                        SucursalID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        Direccion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.SucursalID);
            
            CreateTable(
                "dbo.MetodoPago",
                c => new
                    {
                        MetodoPagoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.MetodoPagoID);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioID = c.Int(nullable: false, identity: true),
                        TipoServicioID = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ServicioID)
                .ForeignKey("dbo.TipoServicio", t => t.TipoServicioID, cascadeDelete: false)
                .Index(t => t.TipoServicioID);
            
            CreateTable(
                "dbo.TipoServicio",
                c => new
                    {
                        TipoServicioID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100, unicode: false),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.TipoServicioID);
            
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        DetalleId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 200, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.DetalleId)
                .ForeignKey("dbo.Persona", t => t.DoctorId, cascadeDelete: false)
                .ForeignKey("dbo.FacturaServicios", t => t.DetalleId)
                .Index(t => t.DetalleId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Log4Net",
                c => new
                    {
                        LogID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Thread = c.String(maxLength: 255, unicode: false),
                        Level = c.String(maxLength: 50, unicode: false),
                        Logger = c.String(maxLength: 255, unicode: false),
                        Message = c.String(maxLength: 8000, unicode: false),
                        Exception = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.LogID);
            
            CreateTable(
                "dbo.Transaccion",
                c => new
                    {
                        TransaccionID = c.Int(nullable: false, identity: true),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        Descripcion = c.String(),
                        TipoTransaccion = c.String(),
                        MetodoPagoID = c.Int(nullable: false),
                        CuentaID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        SendedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.TransaccionID)
                .ForeignKey("dbo.Cuenta", t => t.CuentaID, cascadeDelete: false)
                .ForeignKey("dbo.MetodoPago", t => t.MetodoPagoID, cascadeDelete: false)
                .Index(t => t.MetodoPagoID)
                .Index(t => t.CuentaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaccion", "MetodoPagoID", "dbo.MetodoPago");
            DropForeignKey("dbo.Transaccion", "CuentaID", "dbo.Cuenta");
            DropForeignKey("dbo.Consulta", "DetalleId", "dbo.FacturaServicios");
            DropForeignKey("dbo.Consulta", "DoctorId", "dbo.Persona");
            DropForeignKey("dbo.FacturaServicios", "ServicioID", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "TipoServicioID", "dbo.TipoServicio");
            DropForeignKey("dbo.FacturaServicios", "FacturaID", "dbo.Factura");
            DropForeignKey("dbo.Factura", "PacienteID", "dbo.Persona");
            DropForeignKey("dbo.Factura", "MetodoPagoID", "dbo.MetodoPago");
            DropForeignKey("dbo.Factura", "EmpleadoID", "dbo.Persona");
            DropForeignKey("dbo.Factura", "CuentaID", "dbo.Cuenta");
            DropForeignKey("dbo.Cuenta", "PacienteID", "dbo.Persona");
            DropForeignKey("dbo.Persona", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "SucursalID", "dbo.Sucursal");
            DropForeignKey("dbo.Usuario", "PerfilID", "dbo.Perfil");
            DropForeignKey("dbo.PerfilRole", "RoleID", "dbo.Role");
            DropForeignKey("dbo.PerfilRole", "PerfilID", "dbo.Perfil");
            DropForeignKey("dbo.PerfilRole", "EntidadID", "dbo.Entidad");
            DropForeignKey("dbo.HistoricoAcciones", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Persona", "TipoSangreID", "dbo.TipoSangre");
            DropForeignKey("dbo.Persona", "TipoDocumentoID", "dbo.TipoDocumento");
            DropForeignKey("dbo.Persona", "RolPersonaID", "dbo.RolPersona");
            DropForeignKey("dbo.Persona", "NacionalidadID", "dbo.Nacionalidad");
            DropForeignKey("dbo.Ingreso", "PacienteID", "dbo.Persona");
            DropForeignKey("dbo.Ingreso", "HabitacionID", "dbo.Habitacion");
            DropForeignKey("dbo.Ingreso", "CuentaID", "dbo.Cuenta");
            DropForeignKey("dbo.Factura", "Persona_PersonaID", "dbo.Persona");
            DropForeignKey("dbo.FacturaServicios", "AutorizacionID", "dbo.Autorizaciones");
            DropForeignKey("dbo.Autorizaciones", "AseguradoraID", "dbo.Aseguradora");
            DropIndex("dbo.Transaccion", new[] { "CuentaID" });
            DropIndex("dbo.Transaccion", new[] { "MetodoPagoID" });
            DropIndex("dbo.Consulta", new[] { "DoctorId" });
            DropIndex("dbo.Consulta", new[] { "DetalleId" });
            DropIndex("dbo.Servicios", new[] { "TipoServicioID" });
            DropIndex("dbo.PerfilRole", new[] { "RoleID" });
            DropIndex("dbo.PerfilRole", new[] { "EntidadID" });
            DropIndex("dbo.PerfilRole", new[] { "PerfilID" });
            DropIndex("dbo.HistoricoAcciones", new[] { "UsuarioID" });
            DropIndex("dbo.Usuario", new[] { "PerfilID" });
            DropIndex("dbo.Usuario", new[] { "SucursalID" });
            DropIndex("dbo.Ingreso", new[] { "HabitacionID" });
            DropIndex("dbo.Ingreso", new[] { "PacienteID" });
            DropIndex("dbo.Ingreso", new[] { "CuentaID" });
            DropIndex("dbo.Persona", new[] { "RolPersonaID" });
            DropIndex("dbo.Persona", new[] { "NacionalidadID" });
            DropIndex("dbo.Persona", new[] { "TipoDocumentoID" });
            DropIndex("dbo.Persona", new[] { "TipoSangreID" });
            DropIndex("dbo.Persona", new[] { "UsuarioID" });
            DropIndex("dbo.Cuenta", new[] { "PacienteID" });
            DropIndex("dbo.Factura", new[] { "Persona_PersonaID" });
            DropIndex("dbo.Factura", new[] { "MetodoPagoID" });
            DropIndex("dbo.Factura", new[] { "EmpleadoID" });
            DropIndex("dbo.Factura", new[] { "PacienteID" });
            DropIndex("dbo.Factura", new[] { "CuentaID" });
            DropIndex("dbo.FacturaServicios", new[] { "FacturaID" });
            DropIndex("dbo.FacturaServicios", new[] { "ServicioID" });
            DropIndex("dbo.FacturaServicios", new[] { "AutorizacionID" });
            DropIndex("dbo.Autorizaciones", new[] { "AseguradoraID" });
            DropTable("dbo.Transaccion");
            DropTable("dbo.Log4Net");
            DropTable("dbo.Consulta");
            DropTable("dbo.TipoServicio");
            DropTable("dbo.Servicios");
            DropTable("dbo.MetodoPago");
            DropTable("dbo.Sucursal");
            DropTable("dbo.Role");
            DropTable("dbo.Entidad");
            DropTable("dbo.PerfilRole");
            DropTable("dbo.Perfil");
            DropTable("dbo.HistoricoAcciones");
            DropTable("dbo.Usuario");
            DropTable("dbo.TipoSangre");
            DropTable("dbo.TipoDocumento");
            DropTable("dbo.RolPersona");
            DropTable("dbo.Nacionalidad");
            DropTable("dbo.Habitacion");
            DropTable("dbo.Ingreso");
            DropTable("dbo.Persona");
            DropTable("dbo.Cuenta");
            DropTable("dbo.Factura");
            DropTable("dbo.FacturaServicios");
            DropTable("dbo.Autorizaciones");
            DropTable("dbo.Aseguradora");
        }
    }
}
