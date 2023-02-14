using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IGrupoRepository:IGenericRepository<Grupo>
    {
        public Task<List<Grupo>> ObtenerGrupos();
        public Task<Grupo> GuardarGrupo(Grupo grupo);
        public Task<Grupo> ActualizarGrupo(Grupo grupo);
        public Task<Grupo> ObtenerGrupoPorId(Guid id);
        public Task EliminarGrupo(Guid id);
    }
}
