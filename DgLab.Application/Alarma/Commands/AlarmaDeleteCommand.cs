using DgLab.Application.Alarma.Dto;
using DgLab.Application.Area.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Commands
{
    public record AlarmaDeleteCommand(int Id) : IRequest<AlarmaDto>;
}
