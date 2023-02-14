using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IPlantillaRepository : IGenericRepository<Plantilla>
    {
        public Task<List<Plantilla>> ObtenerPlantillas();
        public Task<Plantilla> GuardarPlantilla(Plantilla plantilla);
        public Task<Plantilla> ActualizarPlantilla(Plantilla plantilla);
        public Task<Plantilla> ObtenerPlantillaPorId(Guid id);
        public Task EliminarPlantilla(Guid id);
    }
}
