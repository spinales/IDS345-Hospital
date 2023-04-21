namespace Caja.Migrations
{
    using Modelos;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Caja.Services.DataService>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Caja.Services.DataService service)
        {

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

            IList<Servicios> defaultServicios = new List<Servicios>()
            {
                new Servicios()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Consultas,
                    Descripcion = "Consulta Oftealmologicas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    Precio = 1000,
                    Descuento = 0,
                    Estado = true
                },
                new Servicios()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Analisis,
                    Descripcion = "Hemograma básico",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    Precio = 500,
                    Descuento = 0,
                    Estado = true
                },
                new Servicios()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Procedimientos,
                    Descripcion = "Extracción de muela",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    Precio = 3000,
                    Impuesto = 0.18m,
                    Descuento = 0,
                    Estado = true
                },
                new Servicios()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Consultas,
                    Descripcion = "Consulta de cardiologia",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    Precio = 2000,
                    Impuesto = 0.18m,
                    Descuento = 0,
                    Estado = true
                },
                new Servicios()
                {
                    TipoServicioID = (int)Enums.TipoServicio.Analisis,
                    Descripcion = "Hemograma completo",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    Precio = 1000,
                    Impuesto = 0.18m,
                    Descuento = 0,
                    Estado = true
                },
            };

            service.Servicios.AddOrUpdate(x => x.ServicioID, defaultServicios.ToArray());

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
                    Descripcion = "Este es el rol para los doctores del hospital, no tienen acceso a ninguna de las aplicaciones",
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

            IList<Cuenta> defaultCuentas = new List<Cuenta>()
            {
                new Cuenta()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    CuentaID = 1,
                    Estado = true,
                    PacienteID = 2,
                    Balance = 1500
                }
            };
            service.Cuenta.AddOrUpdate(x => x.CuentaID, defaultCuentas.ToArray());
            
            IList<Transaccion> defaultTransacciones = new List<Transaccion>()
            {
                new Transaccion()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    CuentaID = 1,
                    Estado = true,
                    Monto = 1000,
                    Descripcion = "Cargo por internamiento",
                    TipoTransaccion = "Cargo"
                },
                new Transaccion()
                {
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                    SendedAt = null,
                    CuentaID = 1,
                    Estado = true,
                    Monto = 500,
                    Descripcion = "Cargo por analisis",
                    TipoTransaccion = "Cargo"
                }
            };
            service.Cuenta.AddOrUpdate(x => x.CuentaID, defaultCuentas.ToArray());
            

            IList<Sucursal> defaultSucursales = new List<Sucursal>()
            {
                new Sucursal()
                {
                    SucursalID = 1,
                    Nombre = "Sucursal Principal",
                    Direccion = "Avenida 27 de Febrero"
                }
            };

            service.Sucursal.AddOrUpdate(x => x.SucursalID, defaultSucursales.ToArray());

            IList<Usuario> defaultUsuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    UsuarioID = 3,
                    Estado = true,
                    Username = "Cajero1",
                    Password = "HycyZr5SsvIjLWY8H08uYJsNa3FkrGhtaHdDqX8lsOM=" ,
                    SucursalID = 1
                }
            };

            service.Usuario.AddOrUpdate(x => x.UsuarioID, defaultUsuarios.ToArray());

            IList<Persona> defaultPersonas = new List<Persona>()
            {
                new Persona()
                {
                    PersonaID = 2,
                    Estado = true,
                    Sexo = "M",
                    Nombre = "Raul",
                    Apellido = "Castro",
                    Telefono = "829-546-5454",
                    NacionalidadID = 1,
                    RolPersonaID = (int)Enums.RolPersona.Pacientes,
                    TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                    Documento = "0000000002",
                    UsuarioID = null,
                    TipoSangreID = 1
                },
                new Persona()
                {
                    PersonaID = 3,
                    Estado = true,
                    Sexo = "M",
                    Nombre = "Paulo",
                    Apellido = "Marquez",
                    Telefono = "829-546-4154",
                    NacionalidadID = 1,
                    RolPersonaID = (int)Enums.RolPersona.Cajero,
                    TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                    Documento = "0000000003",
                    UsuarioID = 3,
                    TipoSangreID = 1
                },
                new Persona()
                {
                    PersonaID = 4,
                    Estado = true,
                    Sexo = "M",
                    Nombre = "Marlon",
                    Apellido = "Brando",
                    Telefono = "829-546-4154",
                    NacionalidadID = 1,
                    RolPersonaID = (int)Enums.RolPersona.Doctor,
                    TipoDocumentoID = (int)Enums.TipoDocumento.Cedula,
                    Documento = "0000002403",
                    UsuarioID = null,
                    TipoSangreID = 1
                }
            };

            service.Persona.AddOrUpdate(x => x.PersonaID, defaultPersonas.ToArray());
            base.Seed(service);
        }
    }
}
