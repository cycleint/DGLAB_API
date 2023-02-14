using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IRecipienteRepository : IGenericRepository<Recipiente>
    {
        public Task<List<Recipiente>> ObtenerRecipientes();
        public Task<Recipiente> GuardarRecipiente(Recipiente recipiente);
        public Task<Recipiente> ActualizarRecipiente(Recipiente recipiente);
        public Task<Recipiente> ObtenerRecipientePorId(Guid id);
        public Task EliminarRecipiente(Guid id);
    }
}
