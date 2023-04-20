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
    public class CoreController : ApiController
    {
        private readonly ILog log = LogManager.GetLogger("API Logger");
        [HttpPost]
        [Route("CORE/usuario/registrar")]
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
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Registro De Usuario Fallido " + e.Message);
                        return Ok("Registro De Usuario Fallido " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/usuario/modificar")]
        public IHttpActionResult ModificarUsuario([FromBody] Usuario usuario)
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
                        ds.Database.ExecuteSqlCommand("sp_update_usuario @UsuarioID INT,@Username VARCHAR(100) ,@Password VARCHAR(100) ,@Email VARCHAR(100) ," +
                            "@Estado BIT = NULL, @SucursalID INT, @PerfilID INT ",
                                           new SqlParameter("@Username", usuario.Username),
                                           new SqlParameter("@Password", usuario.Password),
                                           new SqlParameter("@Email", usuario.Email),
                                           new SqlParameter("@Estado", usuario.Estado),
                                           new SqlParameter("@SucursalID", usuario.SucursalID),
                                           new SqlParameter("@PerfilID", usuario.PerfilID)
                                           );
                        transaction.Commit();
                        log.Info("Modificacion de usuario exitosa");
                        return Ok("Modificacion de usuario exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Modificacion de usuario fallida " + e.Message );
                        return Ok("Modificacion de usuario fallida " + e.Message);
                    }
                }
            }
        }

        [HttpGet]
        [Route("CORE/usuario/get")]
        public async Task<IHttpActionResult> BuscarUsuarios()
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                    try
                    {
                    var usuarios = await ds.GetAll<Usuario>(null);

                    var usuario = usuarios.Select(x => new Usuario()
                    {
                        Username = x.Username,
                        Password = x.Password,
                        UsuarioID = x.UsuarioID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SucursalID = x.SucursalID,
                        PerfilID = x.PerfilID,
                        Estado = x.Estado,
                        Email = x.Email
                    }
                ).ToList();
                    log.Info("Consulta de todos los usuarios exitosa");
                    return Ok(usuario);
                        
                    }
                    catch (Exception e)
                    { 
                        log.Error("Consulta de todos los usuarios fallida " + e.Message);
                        return Ok("Consulta de todos los usuarios fallida " + e.Message);
                    }
            }
        }

        [HttpGet]
        [Route("CORE/usuario/getID")]
        public async Task<IHttpActionResult> BuscarUsuario(int id)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var usuario = await ds.Usuario
                    .Where(u => u.UsuarioID == id)
                    .Select(u => new
                    {
                        u.UsuarioID,
                        u.Username,
                        u.Password,
                        u.Email,
                        u.Estado,
                        u.PerfilID,
                        u.SucursalID,
                        u.CreatedAt,
                        u.UpdatedAt,
                        u.DeletedAt,
                        u.SendedAt
                     })
                    .FirstOrDefaultAsync();

                    if (usuario == null)
                    {
                        return NotFound();
                    }
                    log.Info("Consulta de usuario exitosa");
                    return Ok(usuario);

                }
                catch (Exception e)
                {
                    log.Error(e.Message);
                    return Ok(e.Message);
                }
            }
        }


        [HttpGet]
        [Route("CORE/perfiles/get")]
        public async Task<IHttpActionResult> BuscarPerfiles()
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var perfiles= await ds.GetAll<Perfil>(null);

                    log.Info("Consulta de todos los perfiles exitosa");
                    return Ok(perfiles);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de todos los perfiles fallida " + e.Message);
                    return Ok("Consulta de todos los perfiles fallida " + e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/sucursales/get")]
        public async Task<IHttpActionResult> BuscarSucursales()
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var sucursales = await ds.GetAll<Sucursal>(null);

                    log.Info("Consulta de todas las sucursales exitosa");
                    return Ok(sucursales);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas las sucursales fallida " + e.Message);
                    return Ok("Consulta de todas las sucursales fallida " + e.Message);
                }
            }
        }
    }
    }

