using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IPermisoRepository : IGenericRepository<Permiso>
    {
        public Task<List<Permiso>> ObtenerPermisos();
        public Task<Permiso> GuardarPermiso(Permiso permiso);
        public Task<Permiso> ActualizarPermiso(Permiso permiso);
        public Task<Permiso> ObtenerPermisoPorId(Guid id);
        public Task EliminarPermiso(Guid id);
    }
}
