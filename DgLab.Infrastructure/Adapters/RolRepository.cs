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
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        public RolRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Rol> ActualizarRol(Rol rol)
        {
            throw new NotImplementedException();
        }

        public Task EliminarRol(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Rol> GuardarRol(Rol rol)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rol>> ObtenerRoles()
        {
            throw new NotImplementedException();
        }

        public Task<Rol> ObtenerRolPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
