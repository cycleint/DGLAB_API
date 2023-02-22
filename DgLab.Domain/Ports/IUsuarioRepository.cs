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
        public Task<Usuario> ActualizarUsuario(Usuario usuario);
        public Task<Usuario> ObtenerUsuarioPorId(int id);
        public Task<Usuario> ObtenerUsuarioPorCodigo(string codigo);
        public Task<Usuario> ObtenerUsuarioPorCorreo(string correo);
        public Task<Usuario> ObtenerUsuarioPorCorreoUsuario(string correo);
        public Task<Usuario> ObtenerUsuarioPorIdentificacion(string identificacion);
    }
}
