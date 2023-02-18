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
    public class UnidadRepository : GenericRepository<Unidad>, IUnidadRepository
    {
        public UnidadRepository(PersistenceContext context) : base(context)
        {
        }

        public async Task<Unidad> ActualizarUnidad(Unidad unidad)
        {
            return await UpdateAsync(unidad);
        }

        public async Task<Unidad> GuardarUnidad(Unidad unidad)
        {            
                return await AddAsync(unidad);            
        }
        

        public async Task<Unidad> ObtenerUnidadPorId(int id)
        {
           return await GetByIdAsync(id);
        }
    }
}
