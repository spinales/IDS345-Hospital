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
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo
            
            using (var ds = new DataService())
            {
                using (DbContextTransaction transaction = ds.Database.BeginTransaction())
                {
                    try
                    { 
                        ds.Database.ExecuteSqlCommand("sp_insert_usuario @Username, @Password, @Email, @SucursalID, @PerfilID",
                                           new SqlParameter("@Username", usuario.Username),
                                           new SqlParameter("@Password", usuario.Password),
                                           new SqlParameter("@Email", usuario.Email),
                                           new SqlParameter("@SucursalID", usuario.SucursalID),
                                           new SqlParameter("@PerfilID", usuario.PerfilID)
                                           );
                        transaction.Commit();
                        log.Info("Registro De Usuario Exitoso");
                        return Ok("Registro De Usuario Exitoso");
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        log.Error("Registro De Usuario Fallido");
                        return Ok("Registro De Usuario Fallido");
                    }
                }
            }

                
               
         
            
            
            
        }

        
    }
}
