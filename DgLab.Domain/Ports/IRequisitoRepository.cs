using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IRequisitoRepository : IGenericRepository<Requisito>
    {      
        public Task<Requisito> GuardarRequisito(Requisito requisito);
        public Task<Requisito> ActualizarRequisito(Requisito requisito);
        public Task<Requisito> ObtenerRequisitoPorId(int id);
      
    }
}
