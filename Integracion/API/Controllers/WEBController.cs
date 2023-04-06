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


namespace API.Controllers
{
    public class WEBController : ApiController
    {
        [HttpPost]
        [Route("WEB/login")]
        public IHttpActionResult ValidarPaciente(string username, string password)
        {
            // TODO - Conectarse al CORE y validar el Paciente
            // Si el CORE no responde, se debe ejecutar el siguiente codigo para hacer la validacion desde la integracion
            var ds = new DataService();
            var persona = ds.Persona.FirstOrDefault(x =>
                x.Usuario.Username == username && x.Usuario.Password == password && x.Estado == true &&
                x.RolPersonaID == (int)RolPersona.Cliente);
            return Ok(persona);
        }
        
        [HttpPost]
        [Route("WEB/transacciones")]
        public IHttpActionResult RegistrarTransaccionCuenta(Transaccion transaccion)
        {
            var ds = new DataService();
            //TODO - Registrar la transaccion de la cuenta en la base de datos de la integracion

            //TODO - Conectarse al CORE y consumir el servicio para registrar la transaccion de la cuenta alla
            return Ok();
        }

        [HttpPost]
        [Route("WEB/facturas")]
        public IHttpActionResult RegistrarFactura(Factura factura)
        {
            var ds = new DataService();
            //TODO - Registrar la factura en la base de datos de la integracion

            //TODO - Conectarse al CORE y consumir el servicio para registrar la factura alla
            return Ok();
        }

        [HttpGet]
        [Route("WEB/servicios")]
        public IHttpActionResult ObtenerServicios()
        {
            //TODO - Conectarse al CORE y obtener los servicios
            // Si el CORE no responde, se debe ejecutar el siguiente codigo
            var ds = new DataService();
            var servicios = ds.Servicios.ToArray();
            return Ok(servicios);
        }

        [HttpGet]
        [Route("WEB/obtenerCuentasPaciente")]
        public IHttpActionResult ObtenerCuentasPaciente(int PacienteID)
        {
            //TODO - Conectarse al CORE y obtener las cuentas asociadas a un paciente
            // Si el CORE no responde, se debe ejecutar el siguiente codigo
            var ds = new DataService();
            var cuentas = ds.Cuenta.Where(x => x.PacienteID == PacienteID && x.Estado == true).ToArray();
            return Ok(cuentas);
        }

        [HttpGet]
        [Route("WEB/obtenerTiposServicios")]
        public async Task<IHttpActionResult> ObtenerTiposServicios()
        {
            
            //TODO - Conectarse al CORE y obtener los tipos de servicios
            // Si el CORE no responde, se debe ejecutar el siguiente codigo
            
            var ds = new DataService();
            
            var tipoServicios = await ds.GetAll<TipoServicio>(null, x=>x.Servicios);
            return Ok(tipoServicios);
        }
    }
}
