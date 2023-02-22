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
    public class RecipienteService
    {

        readonly IRecipienteRepository _repository;
        public RecipienteService(IRecipienteRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Recipiente> GuardarRecipiente(Recipiente recipiente)
        {
            return await _repository.GuardarRecipiente(recipiente);
        }

        public async Task<Recipiente> ActualizarRecipiente(Recipiente recipiente)
        {
            var entity = await ObtenerRecipientePorId(recipiente.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Nombre = recipiente.Nombre;
            entity.Imagen = recipiente.Imagen;
            entity.IdUnidad= recipiente.IdUnidad;
            entity.Estado = recipiente.Estado;
            return await _repository.ActualizarRecipiente(entity);
        }

        public async Task<Recipiente> ObtenerRecipientePorId(int id)
        {
            return await _repository.ObtenerRecipientePorId(id);
        }

        public async Task<Recipiente> EliminarRecipientePorId(int id)
        {
            Recipiente recipiente = await ObtenerRecipientePorId(id);
            if (recipiente is null) { throw new ArgumentNullException(nameof(recipiente)); }
            recipiente.Estado = false;
            return await _repository.ActualizarRecipiente(recipiente);
        }
    }
}
