using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using DgLab.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Infrastructure.Adapters
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        readonly PersistenceContext _context;
        public UsuarioRepository(PersistenceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> GuardarUsuario(Usuario usuario)
        {
            return await AddAsync(usuario);
        }

        public async Task<Usuario> ObtenerUsuarioPorCorreo(string correo)
        {
            return await _context.Set<Usuario>().FirstOrDefaultAsync(x=>x.Correo==correo);
        }
    }
}
