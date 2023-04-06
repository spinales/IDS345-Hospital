namespace API.Migrations
{
    using Modelos;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Services.Description;

    internal sealed class Configuration : DbMigrationsConfiguration<API.Services.DataService>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(API.Services.DataService service)
        {
            IList<Aseguradora> defaultAseguradora = new List<Aseguradora>() {
                new Aseguradora {
                    Nombre = "ARS Humano",
                    Telefono = "829-452-5452",
                    Direccion = "Avenida 27 de Febrero #234",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Aseguradora {
                    Nombre = "ARS Palic",
                    Telefono = "809-514-5415",
                    Direccion = "Avenida John F. Kennedy #123",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Aseguradora {
                    Nombre = "ARS Banreservas",
                    Telefono = "849-541-7851",
                    Direccion = "Avenida Lope de Vega #24",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Aseguradora.AddRange(defaultAseguradora);


            IList<Entidad> defaultEntidad = new List<Entidad>()
            {
                new Entidad()
                {
                    Descripcion = "Usuarios",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Perfiles",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Pacientes",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Autorizaciones",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Consultas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Procedimientos",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Analisis",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Entidad()
                {
                    Descripcion = "Ingresos",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };
            service.Entidad.AddRange(defaultEntidad);

            IList<Role> defaultRole = new List<Role>()
            {
                new Role()
                {
                    Nombre = "Visualizar",
                    Descripcion = "Tiene permiso de visualizar los datos de la entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    Nombre = "Modificar",
                    Descripcion = "Tiene permiso de modificar los datos de la entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    Nombre = "Activar/Desactivar",
                    Descripcion = "Tiene permiso de activar o desactivar una entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Role()
                {
                    Nombre = "Crear",
                    Descripcion = "Tiene permiso de crear un registro de una entidad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };
            service.Role.AddRange(defaultRole);

            IList<Perfil> defaultPerfil = new List<Perfil>()
            {
                new Perfil()
                {
                    Nombre = "Administrador",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };
            
            service.Perfil.AddRange(defaultPerfil);

            IList<Nacionalidad> defaultNacionalidad = new List<Nacionalidad>()
            {
                new Nacionalidad()
                {
                    Nombre = "Dominicano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    Nombre = "Estadounidense",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    Nombre = "Venezolano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    Nombre = "Colombiano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    Nombre = "Mexicano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Nacionalidad()
                {
                    Nombre = "Haitiano",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Nacionalidad.AddRange(defaultNacionalidad);

            IList<TipoDocumento> defaultTipoDocumento = new List<TipoDocumento>()
            {
                new TipoDocumento()
                {
                    Nombre = "Cédula",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoDocumento()
                {
                    Nombre = "Pasaporte",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoDocumento()
                {
                    Nombre = "Licencia de conducir",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoDocumento.AddRange(defaultTipoDocumento);

            IList<TipoSangre> defaultTipoSangre = new List<TipoSangre>()
            {
                new TipoSangre()
                {
                    Nombre = "O+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "O-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "A+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "A-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "AB+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "AB-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "B+",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoSangre()
                {
                    Nombre = "B-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoSangre.AddRange(defaultTipoSangre);

            IList<TipoServicio> defaultTipoServicio = new List<TipoServicio>()
            {
                new TipoServicio()
                {
                    Nombre = "Consulta",
                    Descripcion = "Este es el tipo de servicio para atenderse en consulta con un doctor",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoServicio()
                {
                    Nombre = "Analisis",
                    Descripcion = "Este es el tipo de servicio para realizarse un análisis o estudio clinico",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new TipoServicio()
                {
                    Nombre = "Procedimiento",
                    Descripcion = "Este es el tipo de servicio para realizarse un procedimiento",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.TipoServicio.AddRange(defaultTipoServicio);

            IList<RolPersona> defaultRolPersona = new List<RolPersona>()
            {
                new RolPersona()
                {
                    Nombre = "Cajero",
                    Descripcion = "Este es el rol para los empleados que tienen acceso a la aplicacion de caja",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new RolPersona()
                {
                    Nombre = "Cliente",
                    Descripcion = "Este es el rol para los pacientes del hospital, que tienen acceso a la aplicacion web",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new RolPersona()
                {
                    Nombre = "Personal administrativo",
                    Descripcion = "Este es el rol para el personal administrativo, que tiene acceso al CORE",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.RolPersona.AddRange(defaultRolPersona);

            IList<Habitacion> defaultHabiTacion = new List<Habitacion>()
            {
                new Habitacion()
                {
                    Codigo = "AH1015",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Habitacion()
                {
                    Codigo = "GC1015",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new Habitacion()
                {
                    Codigo = "AJ2644",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.Habitacion.AddRange(defaultHabiTacion);

            IList<MetodoPago> defaultMetodoPago = new List<MetodoPago>()
            {
                new MetodoPago()
                {
                    Nombre = "Cuenta",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new MetodoPago()
                {
                    Nombre = "Tarjeta de credito/debito",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                },
                new MetodoPago()
                {
                    Nombre = "Efectivo",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null
                }
            };

            service.MetodoPago.AddRange(defaultMetodoPago);
                       
            base.Seed(service);
        }
    }
}
