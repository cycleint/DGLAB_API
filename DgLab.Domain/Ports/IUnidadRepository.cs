using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IUnidadRepository : IGenericRepository<Unidad>
    {
       
        public Task<Unidad> GuardarUnidad(Unidad unidad);
        public Task<Unidad> ActualizarUnidad(Unidad unidad);
        public Task<Unidad> ObtenerUnidadPorId(int id);        
    }
}
