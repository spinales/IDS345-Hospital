using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CORE_Api.DTOs.Inputs;
using CORE_Api.DTOs.Views;
using log4net;

namespace CORE_Api.Controllers
{
    public class IntegracionController : ApiController
    {
        private readonly ILog log = LogManager.GetLogger("API Logger");
        [HttpPost]
        [Route("CI/pacientes/login")]
        public async Task<IHttpActionResult> LoginPaciente(string usuario, string clave)
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
                log.Info("Se ha logueado el usuario " + persona.Usuario.Username);
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha logueado el usuario " + persona.Usuario.Username, persona.Usuario.UsuarioID);
                return Ok(respuesta);
            }
            catch (Exception e)
            {
                log.Error("Login fallido" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpGet]
        [Route("CI/transacciones/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerTransaccionesPaciente(string documento, int userID)
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de las transacciones del paciente cuyo documento es " + documento, userID);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de transacciones de paciente fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }


        [HttpGet]
        [Route("CI/cuentas/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerCuentasPaciente(string documento, int userID)
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de las cuentas del paciente cuyo documento es " + documento, userID);
                return Ok(respuesta.Count > 0 ? respuesta : null);
                    
            }
            catch (Exception e)
            {
                log.Error("Consulta de cuentas de paciente fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }

        [HttpGet]
        [Route("CI/ingresos/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerIngresosPaciente(string documento, int usertID)
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
                    
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de los ingresos del paciente cuyo documento es " + documento, usertID);

                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de ingresos de paciente fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpGet] //web
        [Route("CI/consultas/paciente/get")]
        public async Task<IHttpActionResult> ObtenerConsultasPaciente(string documento, int userID)
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de las consultas del paciente cuyo documento es " + documento, userID);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de consultas de un paciente fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpGet]
        [Route("CI/transacciones/cuenta/get")]
        public async Task<IHttpActionResult> ObtenerTransaccionesCuenta(int cuentaID, int userID)
        {
            var ds = new DataService();
            try
            {
                var transacciones = await ds.GetAll<Transaccion>(
                    x => x.Cuenta.CuentaID == cuentaID);

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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha solicitado el historial de transacciones de la cuenta " + cuentaID,
                    userID);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de transacciones de una cuenta fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpGet]
        [Route("CI/servicios/get")]
        public async Task<IHttpActionResult> ObtenerServicios()
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de los servicios", 1);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de servicios fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpGet] //WEB
        [Route("CI/servicios/top5/get")]
        public async Task<IHttpActionResult> ObtenerTopServicios(int userID)
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos de los servicios", 1);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de top 5 servicios fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpPost] 
        [Route("CI/factura/registrar")]
        public IHttpActionResult RegistrarFactura(FacturaInput factura, int userID)
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
                    new SqlParameter("@Canal", "CAJA")
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
                transaccion.Commit();
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha registrado una factura", userID);
                return Ok();
            }
            catch (Exception e)
            {
                log.Error("Registro de factura fallido" + e.Message);
                transaccion.Rollback();
                return BadRequest("Hubo un error al resitrar la factura, intente mas tarde");
            }
        }
        
        [HttpGet]
        [Route("CI/doctores/get")]
        public async Task<IHttpActionResult> ObtenerDoctores(int userID)
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
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha solicitado la lista de doctores", userID);
                return Ok(respuesta.Count > 0 ? respuesta : null);
            }
            catch (Exception e)
            {
                log.Error("Consulta de doctores fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
        
        [HttpPost]
        [Route("CI/transacciones/registrar")]
        public IHttpActionResult RegistrarTransacciones(TransaccionInput transaccionCuenta, int userID)
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
                    new SqlParameter("@Canal", "CAJA")
                );
                transaccion.Commit();
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha registrado una transaccion", userID);
                return Ok();
            }
            catch (Exception e)
            {
                log.Error("Registro de transacciones fallido" + e.Message);
                transaccion.Rollback();
                return BadRequest("Hubo un error al registrar la transaccion, intente mas tarde");
            }
        }
        
        [HttpPost]
        [Route("CI/cajeros/login")]
        public async Task<IHttpActionResult> LoginCajero(string usuario, string clave)
        {
            var ds = new DataService();
            try
            {
                var personas = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Cajero && x.Usuario.Username == usuario &&
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
                            Username = persona.Usuario.Username,
                        }
                        
                    };
                }
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se ha logeado el usuario " + usuario, persona.Usuario.UsuarioID);
                return Ok(respuesta);
            }
            catch (Exception e)
            {
                log.Error("Login de cajero fallido" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }

        [HttpGet]
        [Route("CI/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerPaciente(string documento, int userID)
        {
            var ds = new DataService();
            try
            {
                var personas = await ds.GetAll<Persona>(
                    x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Documento == documento && x.Estado == true));
                    
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
                    };
                }
                AuditoriaAccion auditoria = new AuditoriaAccion();
                auditoria.RegistrarAccion("Se han solicitado los datos del paciente cuyo documento es " + documento, userID);
                return Ok(respuesta);
            }
            catch (Exception e)
            {
                log.Error("Consulta de pacientes fallida" + e.Message);
                return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
            }
        }
    }
}
