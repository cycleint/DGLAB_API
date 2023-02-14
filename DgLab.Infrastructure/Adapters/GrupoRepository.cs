using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using DgLab.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Infrastructure.Adapters
{
    public class GrupoRepository : GenericRepository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Grupo> ActualizarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public Task EliminarGrupo(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Grupo> GuardarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public Task<Grupo> ObtenerGrupoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Grupo>> ObtenerGrupos()
        {
            throw new NotImplementedException();
        }
    }
}
