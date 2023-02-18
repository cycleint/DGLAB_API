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
    public class RolService
    {
        readonly IRolRepository _repository;
        public RolService(IRolRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Rol> GuardarRol(Rol rol)
        {
            return await _repository.GuardarRol(rol);
        }

        public async Task<Rol> ActualizarRol(Rol rol)
        {
            var entity = await ObtenerRolPorId(rol.Id);
            if (entity is null) { throw new ArgumentNullException(nameof(entity)); }
            entity.Nombre = rol.Nombre;          
            entity.Estado = rol.Estado; ;
            return await _repository.ActualizarRol(entity);
        }

        public async Task<Rol> ObtenerRolPorId(int id)
        {
            return await _repository.ObtenerRolPorId(id);
        }

        public async Task<Rol> EliminarRolPorId(int id)
        {
            Rol rol = await ObtenerRolPorId(id);
            if (rol is null) { throw new ArgumentNullException(nameof(rol)); }
            rol.Estado = false;
            return await _repository.ActualizarRol(rol);
        }
    }
}
