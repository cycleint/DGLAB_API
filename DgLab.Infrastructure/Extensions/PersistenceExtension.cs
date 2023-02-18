using System.Data;
using DgLab.Domain.Ports;
using DgLab.Infrastructure.Adapters;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DgLab.Infrastructure.Extensions {

    public static class PersistenceExtensions {
        public static IServiceCollection AddPersistence(this IServiceCollection svc, IConfiguration config) {
            svc.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            svc.AddTransient(typeof(IAlarmaRepository), typeof(AlarmaRepository));
            svc.AddTransient(typeof(IAreaRepository), typeof(AreaRepository));
            svc.AddTransient(typeof(IDiaRepository), typeof(DiaRepository));
            svc.AddTransient(typeof(IGrupoEtarioRepository), typeof(GrupoEtarioRepository));
            svc.AddTransient(typeof(IGrupoRepository), typeof(GrupoRepository));
            svc.AddTransient(typeof(IMuestraRepository), typeof(MuestraRepository));
            svc.AddTransient(typeof(IOrdenImpresionRepository), typeof(OrdenImpresionRepository));
            svc.AddTransient(typeof(IPerfilRepository), typeof(PerfilRepository));
            svc.AddTransient(typeof(IPermisoRepository), typeof(PermisoRepository));
            svc.AddTransient(typeof(IPlantillaRepository), typeof(PlantillaRepository));
            svc.AddTransient(typeof(IPruebaRepository), typeof(PruebaRepository));
            svc.AddTransient(typeof(IRecipienteRepository), typeof(RecipienteRepository));
            svc.AddTransient(typeof(IRequisitoRepository), typeof(RequisitoRepository));
            svc.AddTransient(typeof(IRolRepository), typeof(RolRepository));
            svc.AddTransient(typeof(ISedeRepository), typeof(SedeRepository));
            svc.AddTransient(typeof(ITecnicaRepository), typeof(TecnicaRepository));
            svc.AddTransient(typeof(IUnidadRepository), typeof(UnidadRepository));           
            svc.AddTransient<IDbConnection>((sp) => new SqlConnection(config.GetConnectionString("database")));
            return svc;
        }
    }
}