using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface ITecnicaRepository : IGenericRepository<Tecnica>
    {
        public Task<List<Tecnica>> ObtenerTecnicas();
        public Task<Tecnica> GuardarTecnica(Tecnica tecnica);
        public Task<Tecnica> ActualizarTecnica(Tecnica tecnica);
        public Task<Tecnica> ObtenerTecnicaPorId(Guid id);
        public Task EliminarTecnica(Guid id);
    }
}
