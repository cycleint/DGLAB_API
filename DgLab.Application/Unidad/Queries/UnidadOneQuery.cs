using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Queries
{
    public record UnidadOneQuery(int Id) : IRequest<UnidadDto>;
}
