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
    public class RequisitoService
    {
        readonly IRequisitoRepository _repository;
        public RequisitoService(IRequisitoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Requisito> GuardarRequisito(Requisito requisito)
        {
            return await _repository.GuardarRequisito(requisito);
        }

        public async Task<Requisito> ActualizarRequisito(Requisito requisito)
        {
            var entity = await ObtenerRequisitoPorId(requisito.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Nombre = requisito.Nombre;
            entity.Descripcion = requisito.Descripcion;
            entity.Estado = requisito.Estado; ;
            return await _repository.ActualizarRequisito(entity);
        }

        public async Task<Requisito> ObtenerRequisitoPorId(int id)
        {
            return await _repository.ObtenerRequisitoPorId(id);
        }

        public async Task<Requisito> EliminarRequisitoPorId(int id)
        {
            Requisito requisito = await ObtenerRequisitoPorId(id);
            if (requisito is null) { throw new ArgumentNullException(nameof(requisito)); }
            requisito.Estado = false;
            return await _repository.ActualizarRequisito(requisito);
        }
    }
}
