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

        public Task<Alarma> ActualizarAlarma(Alarma alarma)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAlarma(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Alarma> GuardarAlarma(Alarma alarma)
        {
            throw new NotImplementedException();
        }

        public Task<Alarma> ObtenerAlarmaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alarma>> ObtenerAlarmas()
        {
            throw new NotImplementedException();
        }
    }
}
