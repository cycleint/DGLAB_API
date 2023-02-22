using DgLab.Application.Recipiente.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Commands
{
    public record RecipienteDeleteCommand(int Id) : IRequest<RecipienteDto>;
}
