using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Queries
{
    public record RecipienteQuery() : IRequest<List<RecipienteDto>>;
}
