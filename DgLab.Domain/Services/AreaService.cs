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
    public class AreaService
    {
        readonly IAreaRepository _repository;
        public AreaService(IAreaRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Area> GuardarArea(Area area)
        {            
             return await _repository.GuardarArea(area);           
            
        }

        public async Task<Area> ActualizarArea(Area area)
        {
            var entity = await ObtenerAreaPorId(area.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Codigo = area.Codigo;
            entity.Abreviatura= area.Abreviatura;
            entity.Nombre= area.Nombre;
            entity.NombreIngles=area.NombreIngles;
            entity.IdTipo = area.IdTipo;
            entity.ValidacionParcial= area.ValidacionParcial;
            entity.Color= area.Color;
            entity.Estado= area.Estado;            
            return await _repository.ActualizarArea(entity);
        }

        public async Task<Area> ObtenerAreaPorId(int id)
        {
            return await _repository.ObtenerAreaPorId(id);
        }

        public async Task<Area> EliminarAreaPorId(int id)
        {
            Area area = await ObtenerAreaPorId(id);
            if (area is null) { throw new ArgumentNullException(nameof(area)); }
            area.Estado = false;
            return await _repository.ActualizarArea(area);
        }
    }
}
