using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using DgLab.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Infrastructure.Adapters
{
    public class PerfilRepository : GenericRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(PersistenceContext context) : base(context)
        {
        }

        public Task<Perfil> ActualizarPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPerfil(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Perfil> GuardarPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public Task<List<Perfil>> ObtenerPerfiles()
        {
            throw new NotImplementedException();
        }

        public Task<Perfil> ObtenerPerfilPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
