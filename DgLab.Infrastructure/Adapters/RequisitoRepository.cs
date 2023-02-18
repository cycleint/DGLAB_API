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
    public class RequisitoRepository : GenericRepository<Requisito>, IRequisitoRepository
    {
        public RequisitoRepository(PersistenceContext context) : base(context)
        {
        }

        public async Task<Requisito> ActualizarRequisito(Requisito requisito)
        {
            return await UpdateAsync(requisito);      
        }
       

        public async Task<Requisito> GuardarRequisito(Requisito requisito)
        {
            return await AddAsync(requisito);
        }

        public async Task<Requisito> ObtenerRequisitoPorId(int id)
        {
            return await GetByIdAsync(id);
        }
        
    }
}
