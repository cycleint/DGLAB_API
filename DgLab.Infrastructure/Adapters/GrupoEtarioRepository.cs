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
    internal class GrupoEtarioRepository : GenericRepository<GrupoEtario>, IGrupoEtarioRepository
    {
        public GrupoEtarioRepository(PersistenceContext context) : base(context)
        {
        }

        public async Task<GrupoEtario> ActualizarGrupoEtario(GrupoEtario grupoEtario)
        {
            return await UpdateAsync(grupoEtario);
        }

        public async Task<GrupoEtario> GuardarGrupoEtario(GrupoEtario grupoEtario)
        {
            return await AddAsync(grupoEtario);
        }

        public async Task<GrupoEtario> ObtenerGrupoEtarioPorId(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
