using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using DgLab.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Infrastructure.Adapters
{
    public class PlantillaRepository : GenericRepository<Plantilla>, IPlantillaRepository
    {
        public PlantillaRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Plantilla> ActualizarPlantilla(Plantilla plantilla)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPlantilla(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Plantilla> GuardarPlantilla(Plantilla plantilla)
        {
            throw new NotImplementedException();
        }

        public Task<Plantilla> ObtenerPlantillaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Plantilla>> ObtenerPlantillas()
        {
            throw new NotImplementedException();
        }
    }
}
