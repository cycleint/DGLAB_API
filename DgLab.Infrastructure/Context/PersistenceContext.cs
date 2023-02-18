using DgLab.Domain.Entities;
using DgLab.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DgLab.Infrastructure.Context
{
    public class PersistenceContext : DbContext
    {

        private readonly IConfiguration _config;

        public PersistenceContext(DbContextOptions<PersistenceContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }

            modelBuilder.HasDefaultSchema(_config.GetValue<string>("SchemaName"));          
            modelBuilder.Entity<Alarma>();
            modelBuilder.Entity<Area>();
            modelBuilder.Entity<Dia>();
            modelBuilder.Entity<Grupo>();
            modelBuilder.Entity<GrupoEtario>();
            modelBuilder.Entity<Muestra>();
            modelBuilder.Entity<OrdenImpresion>();
            modelBuilder.Entity<Perfil>();
            modelBuilder.Entity<Permiso>();
            modelBuilder.Entity<Plantilla>();
            modelBuilder.Entity<Prueba>();
            modelBuilder.Entity<Recipiente>();
            modelBuilder.Entity<Requisito>();
            modelBuilder.Entity<Rol>();
            modelBuilder.Entity<Sede>();
            modelBuilder.Entity<Tecnica>();
            modelBuilder.Entity<Unidad>();


            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    var t = entityType.ClrType;
            //    if (typeof(DomainEntity).IsAssignableFrom(t))
            //    {
            //        modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn").HasDefaultValueSql("GETDATE()");
            //        modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModifiedOn").HasDefaultValueSql("GETDATE()");
            //    }
            //}

            base.OnModelCreating(modelBuilder);
        }
    }
}
