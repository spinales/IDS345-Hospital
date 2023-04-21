﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using API.DTOs.Inputs;
using API.DTOs.Views;
using API.Services;
using Modelos;

namespace API.Controllers
{
    public class CajaController : ApiController
    {
        [HttpPost]
        [Route("CAJA/login")]
        public async Task<IHttpActionResult> LoginCajero(string usuario, string clave)
        {
            // Conectarse al Core y consumir el servicio para validar el usuario y la clave
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
                    return Ok(respuesta);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("CAJA/cuentas/paciente/get")]
        public async Task<IHttpActionResult> ObtenerCuentasPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
            
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
        [Route("CAJA/transacciones/cuenta/get")]
        public async Task<IHttpActionResult> ObtenerTransaccionesCuenta(int CuentaID)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
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
        [Route("CAJA/pacientes/get")]
        public async Task<IHttpActionResult> ObtenerPaciente(string documento)
        {
            // Conectarse al CORE y obtener las cuentas del paciente
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

                    return Ok(respuesta);
                }
                catch (Exception e)
                {
                    return BadRequest("No fue posible emitir una respuesta, intente mas tarde");
                }
            }
        }
        
        [HttpGet]
        [Route("CAJA/servicios/get")]
        public async Task<IHttpActionResult> ObtenerServicios()
        {
            // Conectarse al CORE y obtener los servicios
            
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
        
        [HttpPost]
        [Route("CAJA/facturas/registrar")]
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
                
                // Conectarse al Core y consumir el servicio para registrar la factura alla
                
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
        [Route("CAJA/transacciones/registrar")]
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
                    new SqlParameter("@Canal", "CAJA")
                );

                // Conectarse al Core y consumir el servicio para registrar la transaccion alla
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
        [Route("CAJA/doctores/get")]
        public async Task<IHttpActionResult> ObtenerDoctores()
        {
            // Conectarse al CORE y obtener los doctores del sistema
            
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