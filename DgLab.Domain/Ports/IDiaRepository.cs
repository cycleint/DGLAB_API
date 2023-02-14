using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IDiaRepository : IGenericRepository<Dia>
    {
        public Task<List<Dia>> ObtenerDias();
        public Task<Dia> GuardarDia(Dia dia);
        public Task<Dia> ActualizarDia(Dia dia);
        public Task<Dia> ObtenerDiaPorId(Guid id);
        public Task EliminarDia(Guid id);
    }
}
