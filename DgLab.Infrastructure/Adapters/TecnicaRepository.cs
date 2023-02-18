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
    public class TecnicaRepository : GenericRepository<Tecnica>, ITecnicaRepository
    {
        public TecnicaRepository(PersistenceContext context) : base(context)
        {
        }

        public async Task<Tecnica> ActualizarTecnica(Tecnica tecnica)
        {
            return await UpdateAsync(tecnica);
        }       

        public async Task<Tecnica> GuardarTecnica(Tecnica tecnica)
        {
            return await AddAsync(tecnica);
        }

        public async Task<Tecnica> ObtenerTecnicaPorId(int id)
        {
            return await GetByIdAsync(id);
        }

       
    }
}
