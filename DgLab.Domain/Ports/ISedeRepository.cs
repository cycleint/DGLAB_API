using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface ISedeRepository : IGenericRepository<Sede>
    {
        public Task<List<Sede>> ObtenerSedes();
        public Task<Sede> GuardarSede(Sede sede);
        public Task<Sede> ActualizarSede(Sede sede);
        public Task<Sede> ObtenerSedePorId(Guid id);
        public Task EliminarSede(Guid id);
    }
}
