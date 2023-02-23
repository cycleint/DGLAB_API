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
    public class ParametroRepositoty : GenericRepository<Parametro>, IParametroRepositoty
    {
        public ParametroRepositoty(PersistenceContext context) : base(context)
        {
        }

        public async Task<Parametro> ObtenerParametroPorTipo(string tipo)
        {
            return await GetByIdAsync(tipo);
        }
    }
}
