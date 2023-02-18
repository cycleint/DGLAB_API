using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Queries
{

    public record RequisitoOneQuery(int Id) : IRequest<RequisitoDto>;
}
