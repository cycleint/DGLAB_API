using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IPerfilRepository : IGenericRepository<Perfil>
    {
        public Task<List<Perfil>> ObtenerPerfiles();
        public Task<Perfil> GuardarPerfil(Perfil perfil);
        public Task<Perfil> ActualizarPerfil(Perfil perfil);
        public Task<Perfil> ObtenerPerfilPorId(Guid id);
        public Task EliminarPerfil(Guid id);
    }
}
