using API.Services;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace API.Controllers
{
    public class WEBController : ApiController
    {
        [HttpGet]
        [Route("api/myapi/getPaciente")]
        public IHttpActionResult GetPaciente()
        {
            return Ok();
        }
        
    }
}
