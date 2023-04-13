using API.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using RolPersona = API.Enums.RolPersona;
using TipoServicio = API.Enums.TipoServicio;


namespace API.Controllers
{
    public class WEBController : ApiController
    {
        [HttpPost]
        [Route("WEB/login")]
        public async Task<IHttpActionResult> LoginPaciente(string username, string password)
        {
            // Conectarse al CORE y validar el Paciente
                // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
                // Retornar una respuesta a la capa WEB
            bool coreRespondio = false;
            
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var personas = await ds.GetAll<Persona>(
                        x => (x.RolPersonaID == (int)Enums.RolPersona.Pacientes && x.Usuario.Username == username &&
                              x.Usuario.Password == password && x.Estado == true), 
                              x=> x.Usuario);
                    
                    var persona = personas.Select(x => new Persona()
                    {
                        PersonaID = x.PersonaID,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Documento = x.Documento,
                        Estado = x.Estado,
                        RolPersonaID = x.RolPersonaID,
                        TipoDocumentoID = x.TipoDocumentoID,
                        TipoSangreID = x.TipoSangreID,
                        Usuario = new Usuario()
                        {
                            Username = x.Usuario.Username,
                            Password = x.Usuario.Password,
                            UsuarioID = x.Usuario.UsuarioID,
                            CreatedAt = x.Usuario.CreatedAt,
                            UpdatedAt = x.Usuario.UpdatedAt,
                            DeletedAt = x.Usuario.DeletedAt,
                            SucursalID = x.Usuario.SucursalID,
                            Estado = x.Usuario.Estado,
                            Email = x.Usuario.Email
                        }
                    }).FirstOrDefault();
                    return Ok(persona);
                }
                catch (Exception e)
                {
                    return BadRequest("");
                }
            }
        }
        
        [HttpPost]
        [Route("WEB/transacciones")]
        public IHttpActionResult RegistrarTransaccionCuenta(Transaccion transaccion)
        {
            // Registrar la transaccion en la base de datos de la integracion
                // Implementar un try catch para capturar cualquier error y notificarlo a la capa WEB
            
            // Conectarse al Core y consumir el servicio para registrar la transaccion alla
            return Ok();
        }

        [HttpPost]
        [Route("WEB/facturas")]
        public IHttpActionResult RegistrarFactura(Factura factura)
        {
            // Registrar la factura en la base de datos de la integracion
                // Implementar un try catch para capturar cualquier error y notificarlo a la capa WEB
            
            // Conectarse al Core y consumir el servicio para registrar la transaccion alla
            return Ok();
        }
        
        [HttpPost]
        [Route("WEB/facturas/consultas")]
        public IHttpActionResult RegistrarConsulta(int DetalleID, int DoctorID)
        {
            // Registrar la transaccion en la base de datos de la integracion
            // Implementar un try catch para capturar cualquier error y notificarlo a la capa WEB
            
            // Conectarse al Core y consumir el servicio para registrar la transaccion alla
            return Ok();
        }

        [HttpGet]
        [Route("WEB/servicios/consultas")]
        public async Task<IHttpActionResult> ObtenerServiciosConsulta()
        {
            // Conectarse al CORE y obtener los servicios de tipo consulta
                // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
            // Retornar una respuesta a la capa WEB
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var consultas = await ds.GetAll<Servicios>(
                        x => (x.TipoServicio.TipoServicioID == (int)Enums.TipoServicio.Consultas && x.Estado == true), 
                        null);
                    consultas = consultas.Select(x => new Servicios()
                    {
                        ServicioID = x.ServicioID,
                        Precio = x.Precio,
                        Descripcion = x.Descripcion,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Estado = x.Estado,
                        TipoServicio = new Modelos.TipoServicio()
                        {
                            TipoServicioID = x.TipoServicio.TipoServicioID,
                            Descripcion = x.TipoServicio.Descripcion
                        }
                    }).ToList();
                    return Ok(consultas);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/servicios/analisis")]
        public async Task<IHttpActionResult> ObtenerServiciosAnalisis()
        {
            // Conectarse al CORE y obtener los servicios de tipo analisis
                // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
            // Retornar una respuesta a la capa WEB
            bool coreRespondio = false;
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var analisis = await ds.GetAll<Servicios>(
                        x => (x.TipoServicio.TipoServicioID == (int)Enums.TipoServicio.Analisis && x.Estado == true), 
                        null);
                    analisis = analisis.Select(x => new Servicios()
                    {
                        ServicioID = x.ServicioID,
                        Precio = x.Precio,
                        Descripcion = x.Descripcion,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Estado = x.Estado,
                        TipoServicio = new Modelos.TipoServicio()
                        {
                            TipoServicioID = x.TipoServicio.TipoServicioID,
                            Descripcion = x.TipoServicio.Descripcion
                        }
                    }).ToList();
                    return Ok(analisis);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/servicios/procedimientos")]
        public async Task<IHttpActionResult> ObtenerServiciosProcedimientos()
        {
            // Conectarse al CORE y obtener los servicios de tipo procedimientos
                // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
            // Retornar una respuesta a la capa WEB
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var procedimientos = await ds.GetAll<Servicios>(
                        x => (x.TipoServicio.TipoServicioID == (int)Enums.TipoServicio.Procedimientos && x.Estado == true), 
                        null);
                    procedimientos = procedimientos.Select(x => new Servicios()
                    {
                        ServicioID = x.ServicioID,
                        Precio = x.Precio,
                        Descripcion = x.Descripcion,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Estado = x.Estado,
                        TipoServicio = new Modelos.TipoServicio()
                        {
                            TipoServicioID = x.TipoServicio.TipoServicioID,
                            Descripcion = x.TipoServicio.Descripcion
                        }
                    }).ToList();
                    return Ok(procedimientos);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }

        [HttpGet]
        [Route("WEB/cuentas/paciente")]
        public async Task<IHttpActionResult> ObtenerCuentasPaciente(string DocumentoPaciente)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
                // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
            // Retornar una respuesta a la capa WEB
            
            bool coreRespondio = false;
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var cuentas = await ds.GetAll<Cuenta>(
                        x => (x.Persona.Documento == DocumentoPaciente && x.Estado == true && x.Balance > 0), 
                              x=> x.Persona);
                    cuentas = cuentas.Select(x => new Cuenta()
                    {
                        CuentaID = x.CuentaID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Estado = x.Estado,
                        Balance = x.Balance,
                        Persona = new Persona()
                        {
                            PersonaID = x.Persona.PersonaID,
                            Nombre = x.Persona.Nombre,
                            Apellido = x.Persona.Apellido,
                            Documento = x.Persona.Documento
                        }
                    }).ToList();
                    return Ok(cuentas);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
        
        [HttpGet]
        [Route("WEB/personas/doctores")]
        public async Task<IHttpActionResult> ObtenerDoctores()
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            // En funcion de la respuesta del CORE, actualizar la base de datos de integración si es necesario
            // Retornar una respuesta a la capa WEB

            bool coreRespondio = false;
            if (coreRespondio)
            {
                return Ok();
            }
            else
            { 
                var ds = new DataService();
                try
                {
                    var doctores = await ds.GetAll<Persona>(
                        x => (x.RolPersonaID == (int)Enums.RolPersona.Doctor && x.Estado == true), 
                        x=> x.TipoSangre);
                    doctores = doctores.Select(x => new Persona()
                    {
                        PersonaID = x.PersonaID,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        Documento = x.Documento,
                        Estado = x.Estado,
                        RolPersona = new Modelos.RolPersona()
                        {
                            RolPersonaID = x.RolPersona.RolPersonaID,
                            Descripcion = x.RolPersona.Descripcion
                        },
                        TipoDocumento = new TipoDocumento()
                        {
                            Nombre = x.TipoDocumento.Nombre,
                            TipoDocumentoID = x.TipoDocumento.TipoDocumentoID
                        },
                        TipoSangre = new TipoSangre()
                        {
                            Nombre = x.TipoSangre.Nombre,
                            TipoSangreID = x.TipoSangre.TipoSangreID
                        }
                    }).ToList();
                    return Ok(doctores);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
    }
}
