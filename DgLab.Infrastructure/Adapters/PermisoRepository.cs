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
    public class PermisoRepository : GenericRepository<Permiso>, IPermisoRepository
    {
        public PermisoRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Permiso> ActualizarPermiso(Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPermiso(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Permiso> GuardarPermiso(Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public Task<Permiso> ObtenerPermisoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Permiso>> ObtenerPermisos()
        {
            throw new NotImplementedException();
        }
    }
}
