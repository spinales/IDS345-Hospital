using API.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using API.DTOs.Inputs;
using API.DTOs.Views;


namespace API.Controllers
{
    public class WEBController : ApiController
    {
        [HttpPost]
        [Route("WEB/login")]
        public async Task<IHttpActionResult> LoginPaciente(string usuario, string clave)
        {
            // Conectarse al Core y consumir el servicio para validar el usuario y la clave
            bool coreRespondio = false;
            
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var persona = new PersonaView();
                var ds = new DataService();
                var local = new Persona
                {
                    Apellido = persona.Apellido,
                    Documento = persona.Documento,
                    Estado = persona.Estado,
                    NacionalidadID = persona.NacionalidadID,
                    Nombre = persona.Nombre,
                    PersonaID = persona.PersonaID,
                    RolPersonaID = persona.RolPersonaID,
                    Sexo = persona.Sexo,
                    Telefono = persona.Telefono,
                    TipoDocumentoID = persona.TipoDocumentoID,
                    TipoSangreID = persona.TipoSangreID,
                    UpdatedAt = DateTime.Now,
                    Usuario = new Usuario()
                    {
                        Email = persona.Usuario.Email,
                        Estado = persona.Usuario.Estado,
                        Password = persona.Usuario.Password,
                        SucursalID = persona.Usuario.SucursalID,
                        UpdatedAt = DateTime.Now,
                        UsuarioID = persona.Usuario.UsuarioID,
                        Username = persona.Usuario.Username
                    }
                };
                ds.Persona.AddOrUpdate(x=>x.PersonaID, local);
                await ds.SaveChangesAsync();
                return Ok(persona);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var personas = await ds.GetAll<Persona>(
                        x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Usuario.Username == usuario &&
                              x.Usuario.Password == clave && x.Estado == true), 
                              x=> x.Usuario);
                    
                    var persona = personas.FirstOrDefault();
                    PersonaView respuesta = null;
                    if (persona != null)
                    {
                        respuesta = new PersonaView()
                        {
                            Apellido = persona.Apellido,
                            Documento = persona.Documento,
                            Estado = persona.Estado,
                            NacionalidadID = persona.NacionalidadID,
                            Nombre = persona.Nombre,
                            PersonaID = persona.PersonaID,
                            RolPersonaID = persona.RolPersonaID,
                            Sexo = persona.Sexo,
                            Telefono = persona.Telefono,
                            TipoDocumentoID = persona.TipoDocumentoID,
                            TipoSangreID = persona.TipoSangreID,
                            UpdatedAt = persona.UpdatedAt,
                            Usuario = new UsuarioView()
                            {
                                Email = persona.Usuario.Email,
                                Estado = persona.Usuario.Estado,
                                Password = persona.Usuario.Password,
                                SucursalID = persona.Usuario.SucursalID,
                                UpdatedAt = persona.Usuario.UpdatedAt,
                                UsuarioID = persona.Usuario.UsuarioID,
                                Username = persona.Usuario.Username
                            }
                        };
                    }
                    return Ok(respuesta);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/transacciones/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerTransaccionesPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var transacciones = new List<TransaccionView>();
                return Ok(transacciones);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var transacciones = await ds.GetAll<Transaccion>(
                        x => x.Cuenta.Persona.Documento == documento);
                    
                    var respuesta = transacciones.Select(x => new TransaccionView()
                    {
                        Monto = x.Monto,
                        TipoTransaccion = x.TipoTransaccion,
                        CreatedAt = x.CreatedAt,
                        Estado = x.Estado,
                        Descripcion = x.Descripcion,
                        MetodoPagoID = x.MetodoPagoID,
                        CuentaID = x.CuentaID,
                        EmpleadoID = x.EmpleadoID,
                        CodigoTransaccion = x.CodigoTransaccion
                        
                    }).ToList();
                    
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        
        [HttpGet]
        [Route("WEB/cuentas/paciente/get")]
        public async Task<IHttpActionResult> ObtenerCuentasPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var cuentas = new List<CuentaView>();
                var ds = new DataService();
                var local = cuentas.Select(x => new Cuenta()
                {
                    CuentaID = x.CuentaID,
                    Balance = x.Balance,
                    Estado = x.Estado,
                    PacienteID = x.PacienteID,
                    UpdatedAt = DateTime.Now
                });
                ds.Cuenta.AddOrUpdate(x=>x.CuentaID, local.ToArray());
                await ds.SaveChangesAsync();
                return Ok(cuentas);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var cuentas = await ds.GetAll<Cuenta>(
                        x => x.Persona.Documento == documento);
                    
                    var respuesta = cuentas.Select(x => new CuentaView()
                    {
                        CuentaID = x.CuentaID,
                        Balance = x.Balance,
                        Estado = x.Estado,
                        PacienteID = x.PacienteID,
                        UpdatedAt = x.UpdatedAt
                    }).ToList();
                    
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/ingresos/paciente/get")]
        public async Task<IHttpActionResult> ObtenerIngresosPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var ingresos = new List<IngresoView>();
                var ds = new DataService();
                var local = ingresos.Select(x => new Ingreso()
                {
                    IngresoID = x.IngresoID,
                    HabitacionID = x.HabitacionID,
                    PacienteID = x.PacienteID,
                    CuentaID = x.CuentaID,
                    FechaInicio = x.FechaInicio,
                    FechaFin = x.FechaFin,
                    Alta = x.Alta,
                    Estado = x.Estado,
                    MontoIngreso = x.MontoIngreso,
                    UpdatedAt = DateTime.Now
                });
                ds.Ingreso.AddOrUpdate(x=>x.IngresoID, local.ToArray());
                await ds.SaveChangesAsync();
                return Ok(ingresos);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var ingresos = await ds.GetAll<Ingreso>(
                        x => x.Persona.Documento == documento, x => x.Habitacion);
                    
                    var respuesta = ingresos.Select(x => new IngresoView()
                    {
                        IngresoID = x.IngresoID,
                        HabitacionID = x.HabitacionID,
                        PacienteID = x.PacienteID,
                        CuentaID = x.CuentaID,
                        FechaInicio = x.FechaInicio,
                        FechaFin = x.FechaFin,
                        Alta = x.Alta,
                        Estado = x.Estado,
                        MontoIngreso = x.MontoIngreso
                    }).ToList();
                    
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        
        
        
        [HttpGet]
        [Route("WEB/consultas/paciente/get")]
        public async Task<IHttpActionResult> ObtenerConsultasPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var consultas = new List<ConsultaView>();
                return Ok(consultas);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var consultas = await ds.GetAll<Consulta>(
                        x => x.FacturaServicios.Factura.Paciente.Documento == documento, x => x.Doctor);
                    
                    var respuesta = consultas.Select(x => new ConsultaView()
                    {
                        CodigoFactura = x.FacturaServicios.CodigoFactura,
                        Descripcion = x.Descripcion,
                        UpdatedAt = x.UpdatedAt,
                        Doctor = new DoctorView()
                        {
                            Apellido = x.Doctor.Apellido,
                            Documento = x.Doctor.Documento,
                            Estado = x.Doctor.Estado,
                            NacionalidadID = x.Doctor.NacionalidadID,
                            Nombre = x.Doctor.Nombre,
                            PersonaID = x.Doctor.PersonaID,
                            RolPersonaID = x.Doctor.RolPersonaID,
                            Sexo = x.Doctor.Sexo,
                            Telefono = x.Doctor.Telefono,
                            TipoDocumentoID = x.Doctor.TipoDocumentoID,
                            TipoSangreID = x.Doctor.TipoSangreID,
                            UpdatedAt = x.Doctor.UpdatedAt
                        }
                        
                    }).ToList();
                    
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/transacciones/cuenta/get")]
        public async Task<IHttpActionResult> ObtenerTransaccionesCuenta(int CuentaID)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var transacciones = new List<TransaccionView>();

                return Ok(transacciones);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var transacciones = await ds.GetAll<Transaccion>(
                        x => x.Cuenta.CuentaID == CuentaID);
                    
                    var respuesta = transacciones.Select(x => new TransaccionView()
                    {
                        Monto = x.Monto,
                        TipoTransaccion = x.TipoTransaccion,
                        CreatedAt = x.CreatedAt,
                        Estado = x.Estado,
                        Descripcion = x.Descripcion,
                        MetodoPagoID = x.MetodoPagoID,
                        CuentaID = x.CuentaID,
                        EmpleadoID = x.EmpleadoID,
                        CodigoTransaccion = x.CodigoTransaccion
                    }).ToList();
                    
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/servicios/get")]
        public async Task<IHttpActionResult> ObtenerServicios()
        {
            // Conectarse al CORE y obtener los servicios
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var servicios = new List<ServiciosView>();
                var ds = new DataService();
                var local = servicios.Select(x => new Servicios()
                {
                    ServicioID = x.ServicioID,
                    Precio = x.Precio,
                    Descripcion = x.Descripcion,
                    UpdatedAt = DateTime.Now,
                    Estado = x.Estado, 
                    TipoServicio = new TipoServicio()
                    {
                        Descripcion = x.TipoServicio.Descripcion,
                        TipoServicioID = x.TipoServicio.TipoServicioID,
                        UpdatedAt = DateTime.Now
                    },
                    Impuesto = x.Impuesto,
                    Descuento = x.Descuento
                });
                ds.Servicios.AddOrUpdate(x=>x.ServicioID, local.ToArray());
                await ds.SaveChangesAsync();
                return Ok(servicios);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var servicios = await ds.GetAll<Servicios>(
                        x=> x.Estado == true, x => x.TipoServicio);
                    var respuesta = servicios.Select(x => new ServiciosView()
                    {
                        ServicioID = x.ServicioID,
                        Precio = x.Precio,
                        Descripcion = x.Descripcion,
                        UpdatedAt = x.UpdatedAt,
                        Estado = x.Estado, 
                        TipoServicio = new TipoServicioView()
                        {
                            Descripcion = x.TipoServicio.Descripcion,
                            TipoServicioID = x.TipoServicioID
                        },
                        Impuesto = x.Impuesto,
                        Descuento = x.Descuento
                    }).ToList();
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/servicios/top5/get")]
        public async Task<IHttpActionResult> ObtenerTopServicios()
        {
            // Conectarse al CORE y obtener los servicios
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var servicios = new List<ServiciosView>();
                var ds = new DataService();
                var local = servicios.Select(x => new Servicios()
                {
                    ServicioID = x.ServicioID,
                    Precio = x.Precio,
                    Descripcion = x.Descripcion,
                    UpdatedAt = DateTime.Now,
                    Estado = x.Estado, 
                    TipoServicio = new TipoServicio()
                    {
                        Descripcion = x.TipoServicio.Descripcion,
                        TipoServicioID = x.TipoServicio.TipoServicioID,
                        UpdatedAt = DateTime.Now
                    },
                    Impuesto = x.Impuesto,
                    Descuento = x.Descuento
                });
                ds.Servicios.AddOrUpdate(x=>x.ServicioID, local.ToArray());
                await ds.SaveChangesAsync();
                return Ok(servicios);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var servicios = await ds.GetAll<Servicios>(
                        x => x.Estado == true);
                    var respuesta = servicios
                        .OrderByDescending(x=>x.FacturaServicios.Count)
                        .Take(5)
                        .Select(x => new ServiciosView()
                        {
                            ServicioID = x.ServicioID,
                            Precio = x.Precio,
                            Descripcion = x.Descripcion,
                            UpdatedAt = x.UpdatedAt,
                            Estado = x.Estado, 
                            TipoServicio = new TipoServicioView()
                            {
                                Descripcion = x.TipoServicio.Descripcion,
                                TipoServicioID = x.TipoServicioID
                            },
                            Impuesto = x.Impuesto,
                            Descuento = x.Descuento
                        }).ToList();
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }

        [HttpPost]
        [Route("WEB/facturas/registrar")]
        public IHttpActionResult RegistrarFactura(FacturaInput factura)
        {
            DataService ds = new DataService();
            var transaccion = ds.Database.BeginTransaction();
            try
            {
                ds.Database.ExecuteSqlCommand("EXEC sp_registrar_factura @TotalFinal, @TotalDescuento, @TotalBruto, @CuentaID, @PacienteID, @EmpleadoID, @MetodoPagoID, @CreatedAt, @CodigoFactura, @Canal",
                    new SqlParameter("@TotalFinal", factura.TotalFinal),
                    new SqlParameter("@TotalDescuento", factura.TotalDescuento),
                    new SqlParameter("@TotalBruto", factura.TotalBruto),
                    new SqlParameter("@CuentaID", factura.CuentaID == null ? DBNull.Value : (object)factura.CuentaID),
                    new SqlParameter("@PacienteID", factura.PacienteID),
                    new SqlParameter("@EmpleadoID", factura.EmpleadoID == null ? DBNull.Value : (object) factura.EmpleadoID),
                    new SqlParameter("@MetodoPagoID", factura.MetodoPagoID),
                    new SqlParameter("@CreatedAt", factura.CreatedAt),
                    new SqlParameter("@CodigoFactura", factura.CodigoFactura),
                    new SqlParameter("@Canal", "WEB")
                );
                
                foreach (var servicio in factura.Servicios)
                {
                    var ID = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var PrecioUnitario = new SqlParameter("@PrecioUnitario", servicio.PrecioUnitario);
                    var Cantidad = new SqlParameter("@Cantidad", servicio.Cantidad);
                    var Impuesto = new SqlParameter("@Impuesto", servicio.Impuesto);
                    var Descuento = new SqlParameter("@Descuento", servicio.Descuento);
                    var TotalImpuesto = new SqlParameter("@TotalImpuesto", servicio.TotalImpuesto);
                    var TotalDescuento = new SqlParameter("@TotalDescuento", servicio.TotalDescuento);
                    var TotalBruto = new SqlParameter("@TotalBruto", servicio.TotalBruto);
                    var TotalFinal = new SqlParameter("@TotalFinal", servicio.TotalFinal);
                    var Descripcion = new SqlParameter("@Descripcion", servicio.Descripcion);
                    var CreatedAt = new SqlParameter("@CreatedAt", servicio.CreatedAt);
                    var ServicioID = new SqlParameter("@ServicioID", servicio.ServicioID);
                    var CodigoFactura = new SqlParameter("@CodigoFactura", factura.CodigoFactura);
                    ds.Database.ExecuteSqlCommand(
                        "EXEC sp_registrar_factura_servicio @PrecioUnitario, @Cantidad, @Impuesto, @Descuento, @TotalImpuesto, @TotalDescuento, @TotalBruto, @TotalFinal, @Descripcion, @CreatedAt, @ServicioID, @CodigoFactura, @ID OUT",
                        PrecioUnitario,
                        Cantidad,
                        Impuesto,
                        Descuento,
                        TotalImpuesto,
                        TotalDescuento,
                        TotalBruto,
                        TotalFinal,
                        Descripcion,
                        CreatedAt,
                        ServicioID,
                        CodigoFactura,
                        ID
                    );
                    
                    if(servicio.Consulta != null)
                        ds.Database.ExecuteSqlCommand("EXEC sp_registrar_consulta @CodigoFactura, @Descripcion, @DoctorID, @CreatedAt, @DetalleID",
                            new SqlParameter("@CodigoFactura", factura.CodigoFactura),
                            new SqlParameter("@DoctorID", servicio.Consulta.DoctorID),
                            new SqlParameter("@Descripcion", servicio.Consulta.Descripcion),
                            new SqlParameter("@CreatedAt", servicio.Consulta.CreatedAt),
                            new SqlParameter("@DetalleID", (int)ID.Value)
                        );
                }
                
                // Conectarse al Core y consumir el servicio para registrar la factura alla
                bool coreRespondio = false;
                if (coreRespondio)
                {  
                    // Crear un procedure para colocar la fecha del envio al Core en la base de datos de la integracion para esa Transaccion
                }
                transaccion.Commit();
                return Ok();
            }
            catch (Exception e)
            {
                transaccion.Rollback();
                return BadRequest("Hubo un error al resitrar la factura, intente mas tarde");
            }
            
        }
        
        [HttpPost]
        [Route("WEB/transacciones/registrar")]
        public IHttpActionResult RegistrarTransacciones(TransaccionInput transaccionCuenta)
        {
            DataService ds = new DataService();
            var transaccion = ds.Database.BeginTransaction();
            try
            {
                ds.Database.ExecuteSqlCommand(
                    "EXEC [dbo].sp_registrar_transaccion @Monto, @Descripcion, @TipoTransaccion, @MetodoPagoID, @CuentaID, @EmpleadoID, @CreatedAt, @CodigoTransaccion, @Canal",
                    new SqlParameter("@Monto", transaccionCuenta.Monto),
                    new SqlParameter("@Descripcion", transaccionCuenta.Descripcion),
                    new SqlParameter("@TipoTransaccion", transaccionCuenta.TipoTransaccion),
                    new SqlParameter("@MetodoPagoID", transaccionCuenta.MetodoPagoID),
                    new SqlParameter("@CuentaID", transaccionCuenta.CuentaID),
                    new SqlParameter("@EmpleadoID", transaccionCuenta.EmpleadoID == null ? DBNull.Value : (object) transaccionCuenta.EmpleadoID),
                    new SqlParameter("@CreatedAt", transaccionCuenta.CreatedAt),
                    new SqlParameter("@CodigoTransaccion", transaccionCuenta.CodigoTransaccion),
                    new SqlParameter("@Canal", "WEB")
                );

                // Conectarse al Core y consumir el servicio para registrar la transaccion alla
                bool coreRespondio = false;
                if (coreRespondio)
                {  
                    // Crear un procedure para colocar la fecha del envio al Core en la base de datos de la integracion para esa Transaccion
                }
                transaccion.Commit();
                return Ok();
            }
            catch (Exception e)
            {
                transaccion.Rollback();
                return BadRequest("Hubo un error al registrar la transaccion, intente mas tarde");
            }
        }
        
        [HttpGet]
        [Route("WEB/doctores/get")]
        public async Task<IHttpActionResult> ObtenerDoctores()
        {
            // Conectarse al CORE y obtener los doctores del sistema
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                // Actualizacion dentro de la integracion
                var doctores = new List<DoctorView>();
                var ds = new DataService();
                var local = doctores.Select(x=>new Persona()
                {
                    Apellido = x.Apellido,
                    Documento = x.Documento,
                    Estado = x.Estado,
                    NacionalidadID = x.NacionalidadID,
                    Nombre = x.Nombre,
                    PersonaID = x.PersonaID,
                    RolPersonaID = x.RolPersonaID,
                    Sexo = x.Sexo,
                    Telefono = x.Telefono,
                    TipoDocumentoID = x.TipoDocumentoID,
                    TipoSangreID = x.TipoSangreID,
                    UpdatedAt = DateTime.Now
                });
                ds.Persona.AddOrUpdate(x=>x.PersonaID, local.ToArray());
                await ds.SaveChangesAsync();
                return Ok(doctores);
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var doctores = await ds.GetAll<Persona>(
                        x => (x.Estado == true && x.RolPersonaID == (int)Enums.RolPersona.Doctor));
                    var respuesta = doctores.Select(x => new DoctorView()
                    {
                        Apellido = x.Apellido,
                        Documento = x.Documento,
                        Estado = x.Estado,
                        NacionalidadID = x.NacionalidadID,
                        Nombre = x.Nombre,
                        PersonaID = x.PersonaID,
                        RolPersonaID = x.RolPersonaID,
                        Sexo = x.Sexo,
                        Telefono = x.Telefono,
                        TipoDocumentoID = x.TipoDocumentoID,
                        TipoSangreID = x.TipoSangreID,
                        UpdatedAt = x.UpdatedAt
                    }).ToList();
                    return Ok(respuesta.Count > 0 ? respuesta : null);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
    }
}
