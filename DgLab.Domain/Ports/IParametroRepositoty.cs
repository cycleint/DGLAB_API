using DgLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Ports
{
    public interface IParametroRepositoty:IGenericRepository<Parametro>
    {
        public Task<Parametro> ObtenerParametroPorTipo(string tipo);
    }
}
