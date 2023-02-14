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
    public class DiaRepository : GenericRepository<Dia>, IDiaRepository
    {
        public DiaRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Dia> ActualizarDia(Dia dia)
        {
            throw new NotImplementedException();
        }

        public Task EliminarDia(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Dia> GuardarDia(Dia dia)
        {
            throw new NotImplementedException();
        }

        public Task<Dia> ObtenerDiaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Dia>> ObtenerDias()
        {
            throw new NotImplementedException();
        }
    }
}
