using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CORE_Api
{
    public class DataService : DbContext
    {
        public DataService() : base("name=ConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public async Task<T> GetByIdAsync<T>(params object[] keys) where T : class =>
            await Set<T>().FindAsync(keys);

        public new async Task<T> Add<T>(T data) where T : class
        {
            var entity = Set<T>().Add(data);
            await SaveChangesAsync();
            return entity;
        }

        public new async Task AddRange<T>(IEnumerable<T> data) where T : class
        {
            var enumerable = data as T[] ?? data.ToArray();
            Set<T>().AddRange(enumerable);
            await SaveChangesAsync();
        }
        public new async Task Update<T>(T data, params object[] keys) where T : class
        {
            var entity = Set<T>().Find(keys);
            if (entity == null)
            {
                return;
            }
            this.Entry(entity).CurrentValues.SetValues(data);
            await SaveChangesAsync();
        }

        public async Task DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            Set<T>().RemoveRange(entities);
            await SaveChangesAsync();
        }
        public async Task Delete<T>(T data) where T : class
        {
            Set<T>().Remove(data);
            await SaveChangesAsync();
        }

        public DbSet<Aseguradora> Aseguradora { get; set; }
        public DbSet<Autorizaciones> Autorizaciones { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Entidad> Entidad { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<FacturaServicios> FacturaServicios { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<HistoricoAcciones> HistoricoAcciones { get; set; }
        public DbSet<Ingreso> Ingreso { get; set; }
        public DbSet<Log4Net> Log4Net { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Nacionalidad> Nacionalidad { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilRole> PerfilRole { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RolPersona> RolPersona { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoSangre> TipoSangre { get; set; }
        public DbSet<TipoServicio> TipoServicio { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
