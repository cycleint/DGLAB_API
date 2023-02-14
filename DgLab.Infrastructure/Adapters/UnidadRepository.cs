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
    public class UnidadRepository : GenericRepository<Unidad>, IUnidadRepository
    {
        public UnidadRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Unidad> ActualizarUnidad(Unidad unidad)
        {
            throw new NotImplementedException();
        }

        public Task EliminarUnidad(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Unidad> GuardarUnidad(Unidad unidad)
        {
            throw new NotImplementedException();
        }

        public Task<List<Unidad>> ObtenerUnidades()
        {
            throw new NotImplementedException();
        }

        public Task<Unidad> ObtenerUnidadPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
