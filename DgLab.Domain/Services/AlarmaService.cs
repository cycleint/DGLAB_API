using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Services
{
    [DomainService]
    public class AlarmaService
    {
        readonly IAlarmaRepository _repository;
        public AlarmaService(IAlarmaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Alarma> GuardarAlarma(Alarma alarma)
        {
            return await _repository.GuardarAlarma(alarma);
        }

        public async Task<Alarma> ActualizarAlarma(Alarma alarma)
        {
            var entity = await ObtenerAlarmaPorId(alarma.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }          
            entity.Nombre = alarma.Nombre;
            entity.Descripcion = alarma.Descripcion;         
            entity.Estado = alarma.Estado;
            return await _repository.ActualizarAlarma(entity);
        }

        public async Task<Alarma> ObtenerAlarmaPorId(int id)
        {
            return await _repository.ObtenerAlarmaPorId(id);
        }

        public async Task<Alarma> EliminarAlarmaPorId(int id)
        {
            Alarma alarma = await ObtenerAlarmaPorId(id);
            if (alarma is null) { throw new ArgumentNullException(nameof(alarma)); }
            alarma.Estado = false;
            return await _repository.ActualizarAlarma(alarma);
        }
    }
}
