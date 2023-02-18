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

        public async Task<Rol> ActualizarRol(Rol rol)
        {
            return await UpdateAsync(rol);
        }       

        public async Task<Rol> GuardarRol(Rol rol)
        {
            return await AddAsync(rol);
        }
        

        public async Task<Rol> ObtenerRolPorId(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
