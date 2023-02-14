using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IOrdenImpresionRepository:IGenericRepository<OrdenImpresion>
    {
        public Task<List<OrdenImpresion>> ObtenerOrdenImpresiones();
        public Task<OrdenImpresion> GuardarOrdenImpresion(OrdenImpresion ordenImpresion);
        public Task<OrdenImpresion> ActualizarOrdenImpresion(OrdenImpresion ordenImpresion);
        public Task<OrdenImpresion> ObtenerOrdenImpresionPorId(Guid id);
        public Task EliminarOrdenImpresion(Guid id);
    }
}
