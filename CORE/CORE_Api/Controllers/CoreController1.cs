using CORE_Api.Enums;
using CORE_Api.Migrations;
using log4net;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace CORE_Api.Controllers
{
    public class CoreController1 : ApiController
    {
        private readonly ILog log = LogManager.GetLogger("API Logger");

        [HttpGet]
        [Route("CORE/persona/get")]
        public async Task<IHttpActionResult> BuscarPersonas()
        {
            using (var ds = new DataService())
            {
                try
                {
                    var personas = await ds.GetAll<Persona>(null);
                    var persona = personas.Select(x => new Persona()
                    {
                        Estado = x.Estado,
                        Sexo = x.Sexo,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Documento = x.Documento,
                        Telefono = x.Telefono,
                        UsuarioID = x.UsuarioID,
                        TipoSangreID = x.TipoSangreID,
                        TipoDocumentoID = x.TipoDocumentoID,
                        NacionalidadID = x.NacionalidadID,
                        RolPersonaID = x.RolPersonaID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SendedAt = x.SendedAt
                    }
                    ).ToList();
                    log.Info("Consulta de todas las personas exitosa");
                    return Ok(persona);
                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas las personas fallida " + e.Message);
                    return Ok("Consulta de todas las personas fallida " +  e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/persona/getID")]
        public async Task<IHttpActionResult>BuscarPersona(int id)
        {
            using (var ds = new DataService())
            {
                try
                {
                    var persona = await ds.Persona.Where(p => p.PersonaID == id).Select(p => new
                    {
                        p.PersonaID,
                        p.Estado,
                        p.Sexo,
                        p.Nombre,
                        p.Apellido,
                        p.Documento,
                        p.Telefono,
                        p.UsuarioID,
                        p.TipoSangre,
                        p.TipoDocumentoID,
                        p.Nacionalidad,
                        p.RolPersonaID,
                        p.CreatedAt,
                        p.UpdatedAt,
                        p.DeletedAt,
                        p.SendedAt
                    }).FirstOrDefaultAsync();
                    if (persona == null)
                    {
                        return NotFound();
                    }
                    log.Info("Consulta de usuario exitosa");
                    return Ok(persona);
                }
                catch (Exception e)
                {
                    log.Error(e.Message);
                    return Ok(e.Message);
                }
            }
        }



    }
}
