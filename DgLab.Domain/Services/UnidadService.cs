using DgLab.Domain.Entities;
using DgLab.Domain.Exception;
using DgLab.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Services
{
    [DomainService]
    public  class UnidadService
    {
        readonly IUnidadRepository _repository;
        public UnidadService(IUnidadRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Unidad> GuardarUnidad(Unidad unidad)
        {            
                return await _repository.GuardarUnidad(unidad);           
        }

        public async Task<Unidad> ActualizarUnidad(Unidad unidad)
        {
            var entity = await ObtenerUnidadPorId(unidad.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Nombre=unidad.Nombre;
            entity.NombreInter=unidad.NombreInter;
            entity.Factor=unidad.Factor;
            entity.Estado=unidad.Estado; ;
            return await _repository.ActualizarUnidad(entity);
        }

        public async Task<Unidad> ObtenerUnidadPorId(int  id)
        {
            return await _repository.ObtenerUnidadPorId(id);
        }

        public async Task<Unidad> EliminarUnidadPorId(int id)
        {
            Unidad unidad = await ObtenerUnidadPorId(id);
            unidad.Estado = false;
            return await _repository.ActualizarUnidad(unidad);
        }



    }
}
