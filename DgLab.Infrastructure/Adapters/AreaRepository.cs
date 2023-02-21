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

        public async Task<Area> ActualizarArea(Area area)
        {
            return await UpdateAsync(area);
        }

        public async Task<Area> GuardarArea(Area area)
        {
            return await AddAsync(area);
        }

        public async Task<Area> ObtenerAreaPorId(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
