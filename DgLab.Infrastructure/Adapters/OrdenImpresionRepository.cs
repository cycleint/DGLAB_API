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
    public class OrdenImpresionRepository : GenericRepository<OrdenImpresion>, IOrdenImpresionRepository
    {
        public OrdenImpresionRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<OrdenImpresion> ActualizarOrdenImpresion(OrdenImpresion ordenImpresion)
        {
            throw new NotImplementedException();
        }

        public Task EliminarOrdenImpresion(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<OrdenImpresion> GuardarOrdenImpresion(OrdenImpresion ordenImpresion)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrdenImpresion>> ObtenerOrdenImpresiones()
        {
            throw new NotImplementedException();
        }

        public Task<OrdenImpresion> ObtenerOrdenImpresionPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
