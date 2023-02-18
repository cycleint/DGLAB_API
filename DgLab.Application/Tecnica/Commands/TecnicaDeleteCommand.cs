using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Commands
{
    public record TecnicaDeleteCommand(int Id) : IRequest<TecnicaDto>;
}
