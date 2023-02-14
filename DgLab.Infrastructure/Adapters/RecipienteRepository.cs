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
    public class RecipienteRepository : GenericRepository<Recipiente>, IRecipienteRepository
    {
        public RecipienteRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Recipiente> ActualizarRecipiente(Recipiente recipiente)
        {
            throw new NotImplementedException();
        }

        public Task EliminarRecipiente(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Recipiente> GuardarRecipiente(Recipiente recipiente)
        {
            throw new NotImplementedException();
        }

        public Task<Recipiente> ObtenerRecipientePorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Recipiente>> ObtenerRecipientes()
        {
            throw new NotImplementedException();
        }
    }
}
