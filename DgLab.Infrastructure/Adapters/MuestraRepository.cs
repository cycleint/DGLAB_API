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
    public class MuestraRepository : GenericRepository<Muestra>, IMuestraRepository
    {
        public MuestraRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Muestra> ActualizarMuestra(Muestra muestra)
        {
            throw new NotImplementedException();
        }

        public Task EliminarMuestra(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Muestra> GuardarMuestra(Muestra muestra)
        {
            throw new NotImplementedException();
        }

        public Task<Muestra> ObtenerMuestraPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Muestra>> ObtenerMuestras()
        {
            throw new NotImplementedException();
        }
    }
}
