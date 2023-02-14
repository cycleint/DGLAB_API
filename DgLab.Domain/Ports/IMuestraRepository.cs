using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IMuestraRepository : IGenericRepository<Muestra>
    {
        public Task<List<Muestra>> ObtenerMuestras();
        public Task<Muestra> GuardarMuestra(Muestra muestra);
        public Task<Muestra> ActualizarMuestra(Muestra muestra);
        public Task<Muestra> ObtenerMuestraPorId(Guid id);
        public Task EliminarMuestra(Guid id);
    }
}
