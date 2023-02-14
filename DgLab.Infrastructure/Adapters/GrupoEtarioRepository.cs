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

        public Task<GrupoEtario> ActualizarGrupoEtario(GrupoEtario grupoEtario)
        {
            throw new NotImplementedException();
        }

        public Task EliminarGrupoEtario(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoEtario> GuardarGrupoEtario(GrupoEtario grupoEtario)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoEtario> ObtenerGrupoEtarioPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GrupoEtario>> ObtenerGrupoEtarios()
        {
            throw new NotImplementedException();
        }
    }
}
