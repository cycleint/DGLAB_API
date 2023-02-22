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

        public async Task<Muestra> ActualizarMuestra(Muestra muestra)
        {
            return await UpdateAsync(muestra);
        }

        public async Task<Muestra> GuardarMuestra(Muestra muestra)
        {
            return await AddAsync(muestra);
        }

        public async Task<Muestra> ObtenerMuestraPorId(int id)
        {
            return await GetByIdAsync(id);
        }


    }
}
