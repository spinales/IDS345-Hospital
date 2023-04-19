using log4net;
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
        private readonly ILog log = LogManager.GetLogger("API Logger");
        [HttpPost]
        [Route("CORE/InsertarUsuario")]
        public IHttpActionResult InsertarUsuario([FromBody] Usuario usuario)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH).
            // Guardar logs en la base de datos (Log4NetLog).
            var ds = new DataService();
            ds.Database.ExecuteSqlCommand("sp_insert_usuario @Username, @Password, @Email, @SucursalID, @PerfilID",
                                            new SqlParameter("@Username", usuario.Username),
                                            new SqlParameter("@Password", usuario.Password),
                                            new SqlParameter("@Email", usuario.Email),
                                            new SqlParameter("@SucursalID", usuario.SucursalID),
                                            new SqlParameter("@PerfilID", usuario.PerfilID)
                                            );
            log.Info("log - Usuario Insertado en Core");
            return Ok("Registro Exitoso");
        }

        
    }
}
