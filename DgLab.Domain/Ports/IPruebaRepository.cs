using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IPruebaRepository : IGenericRepository<Prueba>
    {
        public Task<List<Prueba>> ObtenerPruebas();
        public Task<Prueba> GuardarPrueba(Prueba prueba);
        public Task<Prueba> ActualizarPrueba(Prueba prueba);
        public Task<Prueba> ObtenerPruebaPorId(Guid id);
        public Task EliminarPrueba(Guid id);
    }
}
