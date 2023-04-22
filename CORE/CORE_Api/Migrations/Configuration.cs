namespace CORE_Api.Migrations
{
    using Modelos;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Services.Description;

    internal sealed class Configuration : DbMigrationsConfiguration<CORE_Api.DataService>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CORE_Api.DataService service)
        {
            IList<Aseguradora> defaultAseguradora = new List<Aseguradora>() {
                new Aseguradora {
                    AseguradoraID = 1,
                    Nombre = "ARS Humano",
                    Telefono = "829-452-5452",
                    Direccion = "Avenida 27 de Febrero #234",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Aseguradora {
                    AseguradoraID = 2,
                    Nombre = "ARS Palic",
                    Telefono = "809-514-5415",
                    Direccion = "Avenida John F. Kennedy #123",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Aseguradora {
                    AseguradoraID = 3,
                    Nombre = "ARS Banreservas",
                    Telefono = "849-541-7851",
                    Direccion = "Avenida Lope de Vega #24",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Aseguradora.AddOrUpdate(x => x.AseguradoraID, defaultAseguradora.ToArray());

            IList<Entidad> defaultEntidad = new List<Entidad>()
            {
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Usuario,
                    Descripcion = "Usuarios",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Perfiles,
                    Descripcion = "Perfiles",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Personas,
                    Descripcion = "Personas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Autorizaciones,
                    Descripcion = "Autorizaciones",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Servicios,
                    Descripcion = "Servicios",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Ingresos,
                    Descripcion = "Ingresos",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                 new Entidad()
                {
                    EntidadId = (int)Enums.Entidad.Cuentas,
                    Descripcion = "Cuentas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
            };
            service.Entidad.AddOrUpdate(x => x.EntidadId, defaultEntidad.ToArray());

            IList<Role> defaultRole = new List<Role>()
            {
                new Role()
                {
                    RoleID = (int)Enums.Role.Visualizar,
                    Nombre = "Visualizar",
                    Descripcion = "Tiene permiso de visualizar los datos de la entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    RoleID = (int)Enums.Role.Modificar,
                    Nombre = "Modificar",
                    Descripcion = "Tiene permiso de modificar los datos de la entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    RoleID = (int)Enums.Role.Activar,
                    Nombre = "Activar/Desactivar",
                    Descripcion = "Tiene permiso de activar o desactivar una entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    RoleID = (int)Enums.Role.Crear,
                    Nombre = "Crear",
                    Descripcion = "Tiene permiso de crear un registro de una entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };
            service.Role.AddOrUpdate(x => x.RoleID, defaultRole.ToArray());

            IList<Perfil> defaultPerfil = new List<Perfil>()
            {
                new Perfil()
                {
                    PerfilID = 1,
                    Nombre = "Administrador",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Perfil.AddOrUpdate(x => x.PerfilID, defaultPerfil.ToArray());

            IList<Nacionalidad> defaultNacionalidad = new List<Nacionalidad>()
            {
                new Nacionalidad()
                {
                    NacionalidadID = 1,
                    Nombre = "Dominicano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    NacionalidadID = 2,
                    Nombre = "Estadounidense",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    NacionalidadID = 3,
                    Nombre = "Venezolano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    NacionalidadID = 4,
                    Nombre = "Colombiano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    NacionalidadID = 5,
                    Nombre = "Mexicano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    NacionalidadID = 6,
                    Nombre = "Haitiano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Nacionalidad.AddOrUpdate(x => x.NacionalidadID, defaultNacionalidad.ToArray());

            IList<TipoDocumento> defaultTipoDocumento = new List<TipoDocumento>()
            {
                new TipoDocumento()
                {
                    TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                    Nombre = "Cédula",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoDocumento()
                {
                    TipoDocumentoID = (int)Enums.TipoDocumento.Pasaporte,
                    Nombre = "Pasaporte",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoDocumento()
                {
                    TipoDocumentoID = (int)Enums.TipoDocumento.LicenciaConducir,
                    Nombre = "Licencia de conducir",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoDocumento.AddOrUpdate(x => x.TipoDocumentoID, defaultTipoDocumento.ToArray());
            IList<TipoSangre> defaultTipoSangre = new List<TipoSangre>()
            {
                new TipoSangre()
                {
                    TipoSangreID = 1,
                    Nombre = "O+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 2,
                    Nombre = "O-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 3,
                    Nombre = "A+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 4,
                    Nombre = "A-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 5,
                    Nombre = "AB+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 6,
                    Nombre = "AB-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 7,
                    Nombre = "B+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    TipoSangreID = 8,
                    Nombre = "B-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoSangre.AddOrUpdate(x => x.TipoSangreID, defaultTipoSangre.ToArray());

            IList<TipoServicio> defaultTipoServicio = new List<TipoServicio>()
            {
                new TipoServicio()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Consultas,
                    Nombre = "Consulta",
                    Descripcion = "Este es el tipo de servicio para atenderse en consulta con un doctor",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoServicio()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Analisis,
                    Nombre = "Analisis",
                    Descripcion = "Este es el tipo de servicio para realizarse un análisis o estudio clinico",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoServicio()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Procedimientos,
                    Nombre = "Procedimiento",
                    Descripcion = "Este es el tipo de servicio para realizarse un procedimiento",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoServicio.AddOrUpdate(x => x.TipoServicioID, defaultTipoServicio.ToArray());

            IList<RolPersona> defaultRolPersona = new List<RolPersona>()
            {
                new RolPersona()
                {
                    RolPersonaID = (int)Enums.RolPersona.Cajero,
                    Nombre = "Cajero",
                    Descripcion = "Este es el rol para los empleados que tienen acceso a la aplicacion de caja",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new RolPersona()
                {
                    RolPersonaID = (int)Enums.RolPersona.Pacientes,
                    Nombre = "Cliente",
                    Descripcion = "Este es el rol para los pacientes del hospital, que tienen acceso a la aplicacion web",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new RolPersona()
                {
                    RolPersonaID = (int)Enums.RolPersona.Administrador,
                    Nombre = "Personal administrativo",
                    Descripcion = "Este es el rol para el personal administrativo, que tiene acceso al CORE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new RolPersona()
                {
                    RolPersonaID = (int)Enums.RolPersona.Doctor,
                    Nombre = "Doctor",
                    Descripcion = "Este es el rol para los doctores del hospital, no tienen acceso a ninguna de las aplicaciones pero permiten registrar sus consultas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.RolPersona.AddOrUpdate(x => x.RolPersonaID, defaultRolPersona.ToArray());

            IList<Habitacion> defaultHabiTacion = new List<Habitacion>()
            {
                new Habitacion()
                {
                    HabitacionID = 1,
                    Codigo = "AH1015",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Habitacion()
                {
                    HabitacionID = 2,
                    Codigo = "GC1015",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Habitacion()
                {
                    HabitacionID = 3,
                    Codigo = "AJ2644",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Habitacion.AddOrUpdate(x => x.HabitacionID, defaultHabiTacion.ToArray());

            IList<MetodoPago> defaultMetodoPago = new List<MetodoPago>()
            {
                new MetodoPago()
                {
                    MetodoPagoID = (int)Enums.MetodoPago.Cuenta,
                    Nombre = "Cuenta",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new MetodoPago()
                {
                    MetodoPagoID = (int)Enums.MetodoPago.Tarjeta,
                    Nombre = "Tarjeta de credito/debito",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new MetodoPago()
                {
                    MetodoPagoID = (int)Enums.MetodoPago.Efectivo,
                    Nombre = "Efectivo",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.MetodoPago.AddOrUpdate(x => x.MetodoPagoID, defaultMetodoPago.ToArray());

            IList<PerfilRole> defaultPerfilRole = new List<PerfilRole>()
            {
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 1,
                    EntidadID = 6,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 2,
                    EntidadID = 6,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 3,
                    EntidadID = 6,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new PerfilRole()
                {
                    PerfilID = 1,
                    RoleID = 4,
                    EntidadID = 6,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.PerfilRole.AddOrUpdate(x => new { x.PerfilID, x.RoleID, x.EntidadID }, defaultPerfilRole.ToArray());

            service.Sucursal.AddOrUpdate(x => x.SucursalID, new Sucursal()
            {
                SucursalID = 1,
                Nombre = "Sucursal Principal",
                Direccion = "Avenida 27 de Febrero"
            });

            service.Usuario.AddOrUpdate(x => x.UsuarioID, new Usuario()
            {
                UsuarioID = 1,
                Estado = true,
                Username = "Administrador1",
                Password = "HycyZr5SsvIjLWY8H08uYJsNa3FkrGhtaHdDqX8lsOM=",
                PerfilID = 1,
                SucursalID = 1
            });

            service.Persona.AddOrUpdate(x => x.PersonaID, new Persona()
            {
                PersonaID = 1,
                Estado = true,
                Sexo = "M",
                Nombre = "Pablo",
                Apellido = "Mota",
                Telefono = "0000000000",
                NacionalidadID = 1,
                RolPersonaID = (int)Enums.RolPersona.Administrador,
                TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                Documento = "0000000000",
                UsuarioID = 1,
                TipoSangreID = 1
            });
            service.Persona.AddOrUpdate(x => x.PersonaID, new Persona()
            {
                PersonaID = 2,
                Estado = true,
                Sexo = "F",
                Nombre = "Maria",
                Apellido = "Mota",
                Telefono = "0000000000",
                NacionalidadID = 1,
                RolPersonaID = (int)Enums.RolPersona.Administrador,
                TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                Documento = "0000000000",
                UsuarioID = 1,
                TipoSangreID = 1
            });
            service.Persona.AddOrUpdate(x => x.PersonaID, new Persona()
            {
                PersonaID = 3,
                Estado = true,
                Sexo = "M",
                Nombre = "Miguel",
                Apellido = "Mota",
                Telefono = "0000000000",
                NacionalidadID = 1,
                RolPersonaID = (int)Enums.RolPersona.Administrador,
                TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                Documento = "0000000000",
                UsuarioID = 1,
                TipoSangreID = 1
            });
            base.Seed(service);
        }
    }
}
