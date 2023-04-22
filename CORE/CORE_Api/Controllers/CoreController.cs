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
        #region USUARIO
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
                        ds.Database.ExecuteSqlCommand("sp_update_usuario @UsuarioID, @Username ,@Password ,@Email ,@Estado, @SucursalID, @PerfilID",
                                            new SqlParameter("@UsuarioID", usuario.UsuarioID),
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
        [Route("CORE/usuario/login")]
        public async Task<IHttpActionResult> BuscarUsuarioLogin(string username, string password)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var usuario = await ds.Usuario
                    .Where(u => u.Username == username && u.Password == password)
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

                    log.Info("Login exitoso");
                    return Ok(usuario);

                }
                catch (Exception e)
                {
                    log.Error("Login fallido " + e.Message);
                    return Ok("Login fallido " + e.Message);
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

        [HttpPost]
        [Route("CORE/usuario/borrar")]
        public IHttpActionResult BorrarUsuario([FromBody] Usuario usuario)
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
                        ds.Database.ExecuteSqlCommand("sp_switch_usuario @UsuarioID",
                                            new SqlParameter("@UsuarioID", usuario.UsuarioID)
                                           );
                        transaction.Commit();
                        log.Info("Eliminacion de usuario exitosa");
                        return Ok("Eliminacion de usuario exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Eliminacion de usuario fallida " + e.Message);
                        return Ok("Eliminacion de usuario fallida " + e.Message);
                    }
                }
            }
        }
        #endregion

        #region PERFILES
        [HttpPost]
        [Route("CORE/perfil/registrar")]
        public IHttpActionResult RegistrarPerfil ([FromBody] Perfil perfil)
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
                        ds.Database.ExecuteSqlCommand("sp_insert_perfil @Nombre ",
                                           new SqlParameter("@Nombre", perfil.Nombre)
                                           );
                        transaction.Commit();
                        log.Info("Registro de perfil exitoso");
                        return Ok("Registro de perfil exitoso");
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
        [Route("CORE/perfilrole/registrar")]
        public IHttpActionResult RegistrarPerfilRole([FromBody] PerfilRole perfilRole)
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
                        ds.Database.ExecuteSqlCommand("sp_insert_perfil_role @PerfilID, @RoleID, @EntidadId ",
                                           new SqlParameter("@PerfilID", perfilRole.PerfilID),
                                            new SqlParameter("@RoleID", perfilRole.RoleID),
                                            new SqlParameter("@EntidadId", perfilRole.EntidadID)
                                           );
                        transaction.Commit();
                        log.Info("Registro de perfil_rol exitoso");
                        return Ok("Registro de perfil_rol exitoso");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Registro De perfil_rol Fallido " + e.Message);
                        return Ok("Registro De perfil_rol Fallido " + e.Message);
                    }
                }
            }
        }

        [HttpGet]
        [Route("CORE/perfil/getNombre")]
        public async Task<IHttpActionResult> BuscarPerfilNombre(string Nombre)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var perfil = await ds.Perfil
                    .Where(u => u.Nombre == Nombre)
                    .Select(u => new
                    {
                        u.PerfilID,
                        u.Nombre,
                        u.CreatedAt,
                        u.UpdatedAt,
                        u.DeletedAt,
                        u.SendedAt
                    })
                    .FirstOrDefaultAsync();

                    log.Info("Consulta de perfil por nombre exitosa");
                    return Ok(perfil);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de perfil por nombre exitosa "+ e.Message);
                    return Ok("Consulta de perfil por nombre exitosa "+ e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/perfil/getID")]
        public async Task<IHttpActionResult> BuscarPerfilID(int id)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var perfil = await ds.Perfil
                    .Where(u => u.PerfilID == id)
                    .Select(u => new
                    {
                        u.PerfilID,
                        u.Nombre,
                        u.CreatedAt,
                        u.UpdatedAt,
                        u.DeletedAt,
                        u.SendedAt
                    })
                    .FirstOrDefaultAsync();

                    log.Info("Consulta de perfil por id exitosa");
                    return Ok(perfil);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de perfil por id fallida " + e.Message);
                    return Ok("Consulta de perfil por id fallida " + e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/perfil/get")]
        public async Task<IHttpActionResult> BuscarPerfiles()
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var perfiles = await ds.GetAll<Perfil>(null);
                    var perfil = perfiles.Select(x => new Perfil()
                    {
                        PerfilID = x.PerfilID,
                        Nombre = x.Nombre
                    }
                ).ToList();

                    log.Info("Consulta de todos los perfiles exitosa");
                    return Ok(perfil);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de todos los perfiles fallida " + e.Message);
                    return Ok("Consulta de todos los perfiles fallida " + e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/perfilrole/getPerfilEntidadRole")]
        public async Task<IHttpActionResult> BuscarPerfilRole(int perfil, int entidad, int role)
        {
            // Ejecutar insert en HISTORICO_ACCIONES (cada vez que se ejecute).
            // Agregar transacción (ROLLBACK, COMMIT, TRY CATCH). Listo
            // Guardar logs en la base de datos (Log4NetLog). Listo

            using (var ds = new DataService())
            {
                try
                {
                    var perfilrole = await ds.PerfilRole
                    .Where(u => u.PerfilID == perfil && u.EntidadID == entidad &&u.RoleID == role)
                    .Select(u => new
                    {
                        u.PerfilID,
                        u.EntidadID,
                        u.RoleID
                    })
                    .FirstOrDefaultAsync();

                    log.Info("Consulta de perfil por PerfilID, RoleID y EntidadID exitosa");
                    return Ok(perfilrole);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de perfil por PerfilID, RoleID y EntidadID " + e.Message);
                    return Ok("Consulta de perfil por PerfilID, RoleID y EntidadID " + e.Message);
                }
            }
        }

        [HttpPost]
        [Route("CORE/perfil/modificar")]
        public IHttpActionResult ModificarPerfil([FromBody] Perfil perfil)
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
                        ds.Database.ExecuteSqlCommand("sp_update_perfil @PerfilID, @Nombre",
                                            new SqlParameter("@PerfilID", perfil.PerfilID),
                                            new SqlParameter("@Nombre", perfil.Nombre)
                                           );
                        transaction.Commit();
                        log.Info("Modificacion de perfil exitosa");
                        return Ok("Modificacion de perfil exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Modificacion de perfil fallida " + e.Message);
                        return Ok("Modificacion de perfil fallida " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/perfil/borrar")]
        public IHttpActionResult BorrarPerfil([FromBody] Perfil perfil)
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
                        ds.Database.ExecuteSqlCommand("sp_switch_perfil @PerfilID",
                                            new SqlParameter("@PerfilID", perfil.PerfilID)
                                           );
                        transaction.Commit();
                        log.Info("Eliminacion de perfil exitosa");
                        return Ok("Eliminacion de perfil exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Eliminacion de perfil fallida " + e.Message);
                        return Ok("Eliminacion de perfil fallida " + e.Message);
                    }
                }
            }
        }


        #endregion

        [HttpGet]
        [Route("CORE/sucursal/get")]
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
                    var sucursal = sucursales.Select(x => new Sucursal()
                    {
                        SucursalID = x.SucursalID,
                        Nombre = x.Nombre,
                        Direccion = x.Direccion
                    }
                ).ToList();
                    log.Info("Consulta de todas las sucursales exitosa");
                    return Ok(sucursal);

                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas las sucursales fallida " + e.Message);
                    return Ok("Consulta de todas las sucursales fallida " + e.Message);
                }
            }
        }

        #region PERSONA
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
                    return Ok("Consulta de todas las personas fallida " + e.Message);
                }
            }
        }


        [HttpGet]
        [Route("CORE/persona/getID")]
        public async Task<IHttpActionResult> BuscarPersona(int id)
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

        [HttpPost]
        [Route("CORE/persona/registrar")]
        public IHttpActionResult RegistrarPersona([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_insert_persona @Sexo ,@Nombre,@Apellido, @Documento, @Telefono, @TipoSangreID, @TipoDocumentoID, @NacionalidadID, @RolPersonaID",
                                            new SqlParameter("@Sexo", persona.Sexo),
                                            new SqlParameter("@Nombre", persona.Nombre),
                                            new SqlParameter("@Apellido", persona.Apellido),
                                            new SqlParameter("@Documento", persona.Documento),
                                            new SqlParameter("@Telefono", persona.Telefono),
                                            new SqlParameter("@TipoSangreID", persona.TipoSangreID),
                                            new SqlParameter("@TipoDocumentoID", persona.TipoDocumentoID),
                                            new SqlParameter("@NacionalidadID", persona.NacionalidadID),
                                            new SqlParameter("@RolPersonaID", persona.RolPersonaID)
                                           );
                        transaction.Commit();
                        log.Info("Registro de persona exitoso");
                        return Ok("Registro de persona exitoso");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Registro de persona fallido " + e.Message);
                        return Ok("Registro de persona fallido " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/persona/modificar")]
        public IHttpActionResult ModificarPersona([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_update_persona @PersonaID, @Sexo ,@Nombre,@Apellido, @Documento, @Telefono, @UsuarioID , @TipoSangreID, @TipoDocumentoID, @NacionalidadID, @RolPersonaID",
                                            new SqlParameter("@PersonaID", persona.PersonaID),
                                            new SqlParameter("@Sexo", persona.Sexo),
                                            new SqlParameter("@Nombre", persona.Nombre),
                                            new SqlParameter("@Apellido",persona.Apellido),
                                            new SqlParameter("@Documento", persona.Documento),
                                            new SqlParameter("@Telefono", persona.Telefono),
                                            new SqlParameter("@UsuarioID", persona.UsuarioID),
                                            new SqlParameter("@TipoSangreID", persona.TipoSangreID),
                                            new SqlParameter("@TipoDocumentoID", persona.TipoDocumentoID),
                                            new SqlParameter("@NacionalidadID", persona.NacionalidadID),
                                            new SqlParameter("@RolPersonaID", persona.RolPersonaID)
                                           ) ;
                        transaction.Commit();
                        log.Info("Modificacion de persona exitosa");
                        return Ok("Modificacion de persona exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Modificacion de persona fallida " + e.Message);
                        return Ok("Modificacion de persona fallida " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/persona/borrar")]
        public IHttpActionResult BorrarPersona([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_switch_persona @PersonaID",
                                            new SqlParameter("@PersonaID", persona.PersonaID)
                                           );
                        transaction.Commit();
                        log.Info("Eliminacion de persona exitosa");
                        return Ok("Eliminacion de persona exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Eliminacion de persona fallida " + e.Message);
                        return Ok("Eliminacion de persona fallida " + e.Message);
                    }
                }
            }
        }
        #endregion

        #region INGRESOS
        [HttpGet]
        [Route("CORE/ingreso/get")]
        public async Task<IHttpActionResult> BuscarIngresos()
        {
            using (var ds = new DataService())
            {
                try
                {
                    var ingresos = await ds.GetAll<Ingreso>(null);
                    var ingreso = ingresos.Select(x => new Ingreso()
                    {
                        IngresoID = x.IngresoID,
                        FechaInicio = x.FechaInicio,
                        FechaFin = x.FechaFin,
                        Alta = x.Alta,
                        MontoIngreso = x.MontoIngreso,
                        CuentaID = x.CuentaID,
                        PacienteID = x.PacienteID,
                        HabitacionID = x.HabitacionID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SendedAt = x.SendedAt
                    }
                    ).ToList();
                    log.Info("Consulta de todos los ingresos exitosa");
                    return Ok(ingreso);
                }
                catch (Exception e)
                {
                    log.Error("Consulta de todos los ingresos fallida " + e.Message);
                    return Ok("Consulta de todos los ingresos fallida " + e.Message);
                }
            }
        }


        [HttpGet]
        [Route("CORE/ingreso/getID")]
        public async Task<IHttpActionResult> BuscarIngreso(int id)
        {
            using (var ds = new DataService())
            {
                try
                {
                    var ingreso = await ds.Ingreso.Where(x => x.IngresoID == id).Select(x => new
                    {
                        IngresoID = x.IngresoID,
                        FechaInicio = x.FechaInicio,
                        FechaFin = x.FechaFin,
                        Alta = x.Alta,
                        MontoIngreso = x.MontoIngreso,
                        CuentaID = x.CuentaID,
                        PacienteID = x.PacienteID,
                        HabitacionID = x.HabitacionID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SendedAt = x.SendedAt
                    }).FirstOrDefaultAsync();

                    log.Info("Consulta de usuario exitosa");
                    return Ok(ingreso);
                }
                catch (Exception e)
                {
                    log.Error(e.Message);
                    return Ok(e.Message);
                }
            }
        }

        [HttpPost]
        [Route("CORE/ingreso/registrar")]
        public IHttpActionResult RegistrarIngreso([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_insert_ingreso @Sexo ,@Nombre,@Apellido, @Documento, @Telefono, @UsuarioID , @TipoSangreID, @TipoDocumentoID, @NacionalidadID, @RolPersonaID",
                                            new SqlParameter("@Sexo", persona.Sexo),
                                            new SqlParameter("@Nombre", persona.Nombre),
                                            new SqlParameter("@Apellido", persona.Apellido),
                                            new SqlParameter("@Documento", persona.Documento),
                                            new SqlParameter("@Telefono", persona.Telefono),
                                            new SqlParameter("@UsuarioID", persona.UsuarioID),
                                            new SqlParameter("@TipoSangreID", persona.TipoSangreID),
                                            new SqlParameter("@TipoDocumentoID", persona.TipoDocumentoID),
                                            new SqlParameter("@NacionalidadID", persona.NacionalidadID),
                                            new SqlParameter("@RolPersonaID", persona.RolPersonaID)
                                           );
                        transaction.Commit();
                        log.Info("Registro de persona exitoso");
                        return Ok("Registro de persona exitoso");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Registro de persona fallido " + e.Message);
                        return Ok("Registro de persona fallido " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/persona/modificar")]
        public IHttpActionResult ModificarIngreso([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_update_persona @PersonaID, @Sexo ,@Nombre,@Apellido, @Documento, @Telefono, @UsuarioID , @TipoSangreID, @TipoDocumentoID, @NacionalidadID, @RolPersonaID",
                                            new SqlParameter("@PersonaID", persona.PersonaID),
                                            new SqlParameter("@Sexo", persona.Sexo),
                                            new SqlParameter("@Nombre", persona.Nombre),
                                            new SqlParameter("@Apellido", persona.Apellido),
                                            new SqlParameter("@Documento", persona.Documento),
                                            new SqlParameter("@Telefono", persona.Telefono),
                                            new SqlParameter("@UsuarioID", persona.UsuarioID),
                                            new SqlParameter("@TipoSangreID", persona.TipoSangreID),
                                            new SqlParameter("@TipoDocumentoID", persona.TipoDocumentoID),
                                            new SqlParameter("@NacionalidadID", persona.NacionalidadID),
                                            new SqlParameter("@RolPersonaID", persona.RolPersonaID)
                                           );
                        transaction.Commit();
                        log.Info("Modificacion de persona exitosa");
                        return Ok("Modificacion de persona exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Modificacion de persona fallida " + e.Message);
                        return Ok("Modificacion de persona fallida " + e.Message);
                    }
                }
            }
        }

        [HttpPost]
        [Route("CORE/persona/borrar")]
        public IHttpActionResult BorrarIngreso([FromBody] Persona persona)
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
                        ds.Database.ExecuteSqlCommand("sp_switch_persona @PersonaID",
                                            new SqlParameter("@PersonaID", persona.PersonaID)
                                           );
                        transaction.Commit();
                        log.Info("Eliminacion de persona exitosa");
                        return Ok("Eliminacion de persona exitosa");
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        log.Error("Eliminacion de persona fallida " + e.Message);
                        return Ok("Eliminacion de persona fallida " + e.Message);
                    }
                }
            }
        }
        #endregion

        [HttpGet]
        [Route("CORE/autorizacion/get")]
        public async Task<IHttpActionResult> BuscarAutorizaciones()
        {
            using (var ds = new DataService())
            {
                try
                {
                    var autos = await ds.GetAll<Autorizaciones>(null);
                    var auto = autos.Select(x => new Autorizaciones()
                    {
                        Estado = x.Estado,
                        AutorizacionID = x.AutorizacionID,
                        MontoAutorizado = x.MontoAutorizado,
                        AseguradoraID = x.AseguradoraID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SendedAt = x.SendedAt
                    }
                    ).ToList();
                    log.Info("Consulta de todas las autorizaciones exitosa");
                    return Ok(auto);
                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas  las autorizaciones  fallida " + e.Message);
                    return Ok("Consulta de todas las autorizaciones  fallida " + e.Message);
                }
            }
        }

        [HttpGet]
        [Route("CORE/cuenta/get")]
        public async Task<IHttpActionResult> BuscarCuentas()
        {
            using (var ds = new DataService())
            {
                try
                {
                    var autos = await ds.GetAll<Cuenta>(null);
                    var auto = autos.Select(x => new Cuenta()
                    {
                        CuentaID = x.CuentaID,
                        Balance = x.Balance,
                        Estado = x.Estado,
                        PacienteID = x.PacienteID,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt,
                        DeletedAt = x.DeletedAt,
                        SendedAt = x.SendedAt
                    }
                    ).ToList();
                    log.Info("Consulta de todas las consultas exitosa");
                    return Ok(auto);
                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas  las consultas  fallida " + e.Message);
                    return Ok("Consulta de todas las consultas  fallida " + e.Message);
                }
            }
        }


        [HttpGet]
        [Route("CORE/servicio/get")]
        public async Task<IHttpActionResult> BuscarServicios()
        {
            using (var ds = new DataService())
            {
                try
                {
                    
                    var servicios = from s in ds.Servicios
                                        select s;

                        
                    
                    log.Info("Consulta de todas las autorizaciones exitosa");
                    return Ok(servicios.ToList());
                }
                catch (Exception e)
                {
                    log.Error("Consulta de todas  las autorizaciones  fallida " + e.Message);
                    return Ok("Consulta de todas las autorizaciones  fallida " + e.Message);
                }
            }
            }
        }
}

