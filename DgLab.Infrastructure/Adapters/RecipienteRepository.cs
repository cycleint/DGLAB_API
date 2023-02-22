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

        public async Task<Recipiente> ActualizarRecipiente(Recipiente recipiente)
        {
            return await UpdateAsync(recipiente);
        }

        public async Task<Recipiente> GuardarRecipiente(Recipiente recipiente)
        {
            return await AddAsync(recipiente);
        }

        public async Task<Recipiente> ObtenerRecipientePorId(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
