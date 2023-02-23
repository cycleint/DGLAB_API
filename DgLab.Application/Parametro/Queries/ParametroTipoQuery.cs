using DgLab.Application.Parametro.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Parametro.Queries
{
  

    public record ParametroTipoQuery(string Tipo) : IRequest<List<ParametroDto>>;
}
