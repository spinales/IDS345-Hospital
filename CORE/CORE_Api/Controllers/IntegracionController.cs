using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CORE_Api.Controllers
{
    public class IntegracionController : ApiController
    {
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

            var tipoServicios = await ds.GetAll<TipoServicio>(null, x => x.Servicios);
            return Ok(tipoServicios);
        }

    }
}
