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
    public class AreaRepository : GenericRepository<Area>, IAreaRepository
    {
        public AreaRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Area> ActualizarArea(Area area)
        {
            throw new NotImplementedException();
        }

        public Task EliminarArea(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Area> GuardarArea(Area area)
        {
            throw new NotImplementedException();
        }

        public Task<Area> ObtenerAreaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Area>> ObtenerAreas()
        {
            throw new NotImplementedException();
        }
    }
}
