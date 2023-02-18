using DgLab.Application.Tecnica.Dto;
using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Queries
{
    public record TecnicaOneQuery(int Id) : IRequest<TecnicaDto>;
}
