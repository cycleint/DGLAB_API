using DgLab.Application.Area.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Queries
{
    public record AreaOneQuery(int Id) : IRequest<AreaDto>;
}
