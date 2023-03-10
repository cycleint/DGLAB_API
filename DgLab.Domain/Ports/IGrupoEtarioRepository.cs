using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IGrupoEtarioRepository : IGenericRepository<GrupoEtario>
    {       
        public Task<GrupoEtario> GuardarGrupoEtario(GrupoEtario grupoEtario);
        public Task<GrupoEtario> ActualizarGrupoEtario(GrupoEtario grupoEtario);
        public Task<GrupoEtario> ObtenerGrupoEtarioPorId(int id);
        
    }
}
