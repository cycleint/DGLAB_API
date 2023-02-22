using DgLab.Application.Muestra.Dto;
using DgLab.Application.Recipiente.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Queries
{
    public record MuestraQuery() : IRequest<List<MuestraDto>>;
}
