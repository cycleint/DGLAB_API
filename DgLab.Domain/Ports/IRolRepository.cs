using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IRolRepository : IGenericRepository<Rol>
    {       
        public Task<Rol> GuardarRol(Rol rol);
        public Task<Rol> ActualizarRol(Rol rol);
        public Task<Rol> ObtenerRolPorId(int id);
      
    }
}
