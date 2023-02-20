using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        public Task<Usuario> GuardarUsuario(Usuario usuario);
        public Task<Usuario> ObtenerUsuarioPorCorreo(string correo);
    }
}
