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
        public IHttpActionResult InsertarUsuario(string Username, string Password, string Email, int SucursalID, int PerfilID)
        {
            var ds = new DataService();
            ds.Database.ExecuteSqlCommand("sp_insert_usuario @Username, @Password, @Email, @SucursalID, @PerfilID",
                                            new SqlParameter("@Username", Username),
                                            new SqlParameter("@Password", Password),
                                            new SqlParameter("@Email", Email),
                                            new SqlParameter("@SucursalID", SucursalID),
                                            new SqlParameter("@PerfilID", PerfilID)
                                            );
            return Ok();
        }
    }
}
