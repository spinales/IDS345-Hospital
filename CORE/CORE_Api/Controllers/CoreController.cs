using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CORE_Api.Controllers
{
    public class CoreController : ApiController
    {
        [HttpPost]
        [Route("CORE/InsertarUsuario")]
        public IHttpActionResult InsertarUsuario([FromBody] Usuario usuario)
        {
            var ds = new DataService();
            ds.Database.ExecuteSqlCommand("sp_insert_usuario @Username, @Password, @Email, @SucursalID, @PerfilID",
                                            new SqlParameter("@Username", usuario.Username),
                                            new SqlParameter("@Password", usuario.Password),
                                            new SqlParameter("@Email", usuario.Email),
                                            new SqlParameter("@SucursalID", usuario.SucursalID),
                                            new SqlParameter("@PerfilID", usuario.PerfilID)
                                            );
            return Ok("Registro Exitoso");
        }
    }
}
