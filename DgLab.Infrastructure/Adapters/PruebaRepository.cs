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
    public class PruebaRepository : GenericRepository<Prueba>, IPruebaRepository
    {
        public PruebaRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Prueba> ActualizarPrueba(Prueba prueba)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPrueba(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Prueba> GuardarPrueba(Prueba prueba)
        {
            throw new NotImplementedException();
        }

        public Task<Prueba> ObtenerPruebaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Prueba>> ObtenerPruebas()
        {
            throw new NotImplementedException();
        }
    }
}
