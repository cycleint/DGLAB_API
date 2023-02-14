using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IAreaRepository : IGenericRepository<Area>
    {
        public Task<List<Area>> ObtenerAreas();
        public Task<Area> GuardarArea(Area area);
        public Task<Area> ActualizarArea(Area area);
        public Task<Area> ObtenerAreaPorId(Guid id);
        public Task EliminarArea(Guid id);
    }
}
