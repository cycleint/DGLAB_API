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
    public class RequisitoRepository : GenericRepository<Requisito>, IRequisitoRepository
    {
        public RequisitoRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Requisito> ActualizarRequisito(Requisito requisito)
        {
            throw new NotImplementedException();
        }

        public Task EliminarRequisito(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Requisito> GuardarRequisito(Requisito requisito)
        {
            throw new NotImplementedException();
        }

        public Task<Requisito> ObtenerRequisitoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Requisito>> ObtenerRequisitos()
        {
            throw new NotImplementedException();
        }
    }
}
