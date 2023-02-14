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

        public Task<Tecnica> ActualizarTecnica(Tecnica tecnica)
        {
            throw new NotImplementedException();
        }

        public Task EliminarTecnica(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Tecnica> GuardarTecnica(Tecnica tecnica)
        {
            throw new NotImplementedException();
        }

        public Task<Tecnica> ObtenerTecnicaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tecnica>> ObtenerTecnicas()
        {
            throw new NotImplementedException();
        }
    }
}
