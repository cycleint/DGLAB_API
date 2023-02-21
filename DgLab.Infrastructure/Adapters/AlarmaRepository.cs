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
    public class AlarmaRepository : GenericRepository<Alarma>,IAlarmaRepository
    {
        public AlarmaRepository(PersistenceContext context) : base(context)
        {
        }

        public async Task<Alarma> ActualizarAlarma(Alarma alarma)
        {
            return await UpdateAsync(alarma);
        }

        public async Task<Alarma> GuardarAlarma(Alarma alarma)
        {
            return await AddAsync(alarma);
        }

        public async Task<Alarma> ObtenerAlarmaPorId(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
