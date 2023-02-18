using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Commands
{   
    public record UnidadDeleteCommand(int Id) : IRequest<UnidadDto>;
}
