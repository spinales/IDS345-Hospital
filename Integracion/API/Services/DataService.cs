using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Migrations;
using Modelos;

namespace API.Services
{
    public class DataService : DbContext
    {
        
        private static readonly log4net.ILog Log = 
            log4net.LogManager.GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public DataService(): base("name=ConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataService, Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
        public async Task<T> GetByIdAsync<T>(params object[] keys) where T : class
        {
            Log.Info("Query a la base de datos y traer el registro registro por id de la entidad " + typeof(T));
            return await Set<T>().FindAsync(keys);
        }

        public async Task<List<T>> GetAll<T>(Expression<Func<T, bool>> expression = null,
            params Expression<Func<T, object>>[] includes) where T : class {
            var query = Set<T>().Where(expression ?? (_ => true)).AsQueryable();
            query = includes.Any()
                ? includes.Aggregate(query, (current, include) => current.Include(include))
                : query;

            var response = await query.ToListAsync();
            Log.Info("Query a la base de datos y traer todos los registros de la entidad " + typeof(T));
            return response;
        }

        public new async Task<T> Add<T>(T data) where T : class
        {
            var entity = Set<T>().Add(data);
            await SaveChangesAsync();
            Log.Info("Query a la base de datos y agregar registro de la entidad " + typeof(T));
            return entity;
        }
        public new async Task AddRange<T> (IEnumerable<T> data) where T : class
        {
            var enumerable = data as T[] ?? data.ToArray();
            Set<T>().AddRange(enumerable);
            Log.Info("Query a la base de datos y agregar varios registros de la entidad " + typeof(T));
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
            Log.Info("Query a la base de datos y actualizar el registros de la entidad " + typeof(T));
            await SaveChangesAsync();
        }

        public async Task DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            Set<T>().RemoveRange(entities);
            Log.Info("Query a la base de datos y eliminar varios registros de la entidad " + typeof(T));
            await SaveChangesAsync();
        }
        public async Task Delete<T>(T data) where T : class
        {
            Set<T>().Remove(data);
            Log.Info("Query a la base de datos y eliminar registro de la entidad " + typeof(T));
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