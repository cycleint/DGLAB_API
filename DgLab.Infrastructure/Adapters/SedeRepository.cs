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
    public class SedeRepository : GenericRepository<Sede>, ISedeRepository
    {
        public SedeRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Sede> ActualizarSede(Sede sede)
        {
            throw new NotImplementedException();
        }

        public Task EliminarSede(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Sede> GuardarSede(Sede sede)
        {
            throw new NotImplementedException();
        }

        public Task<Sede> ObtenerSedePorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sede>> ObtenerSedes()
        {
            throw new NotImplementedException();
        }
    }
}
