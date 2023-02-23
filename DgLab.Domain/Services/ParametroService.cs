using DgLab.Domain.Entities;
using DgLab.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Domain.Services
{
    [DomainService]
    public class ParametroService
    {

        readonly IParametroRepositoty _repository;
        public ParametroService(IParametroRepositoty repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Parametro> ObtenerRecipientePorId(string tipo)
        {
            return await _repository.ObtenerParametroPorTipo(tipo);
        }
    }
}
