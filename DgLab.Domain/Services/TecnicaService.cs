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
    public class TecnicaService
    {
        readonly ITecnicaRepository _repository;
        public TecnicaService(ITecnicaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Tecnica> GuardarTecnica(Tecnica tecnica)
        {
            return await _repository.GuardarTecnica(tecnica);
        }

        public async Task<Tecnica> ActualizarTecnica(Tecnica tecnica)
        {
            var entity = await ObtenerTecnicaPorId(tecnica.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Codigo = tecnica.Codigo;
            entity.Descripcion = tecnica.Descripcion;           
            entity.Estado = tecnica.Estado; ;
            return await _repository.ActualizarTecnica(entity);
        }

        public async Task<Tecnica> ObtenerTecnicaPorId(int id)
        {
            return await _repository.ObtenerTecnicaPorId(id);
        }

        public async Task<Tecnica> EliminarTecnicaPorId(int id)
        {
            Tecnica tecnica = await ObtenerTecnicaPorId(id);
            if (tecnica is null) { throw new ArgumentNullException(nameof(tecnica)); }
            tecnica.Estado = false;
            return await _repository.ActualizarTecnica(tecnica);
        }
    }
}
