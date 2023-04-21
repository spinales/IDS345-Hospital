using System;
using System.Threading.Tasks;
using System.Web.Http;
using API.Services;
using API.Util;
using Microsoft.IdentityModel.Tokens;
using Modelos;

namespace API.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private static readonly log4net.ILog Log = 
            log4net.LogManager.GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        // [ActionName("login")]
        public async Task<IHttpActionResult> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Log.Error("El usuario intento ingresar con los campos vacios");
                return BadRequest("EL username o el password no pueden estar vacios");    
            }


            var ds = new DataService();
            try
            {
                var user = await ds.GetAll<Usuario>(x => x.Username == username 
                                                         && x.Password == password);

                if (user.IsNullOrEmpty()) {
                    Log.Info("El usuario intento acceder con un usuario inexistente.");
                    return BadRequest("EL username no existe, intente con otro");
                }
                
                var token = TokenGenerator.GenerateTokenJwt(username);
                Log.Info("Se ha generado un token para el usuario " + username);
                return Ok(token);
            }
            catch (Exception e)
            {
                Log.Error("Error: " + e);
                return Unauthorized();
            }
        }
    }
}