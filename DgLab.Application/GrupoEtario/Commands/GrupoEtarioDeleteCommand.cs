using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Commands
{
    public record GrupoEtarioDeleteCommand(int Id) : IRequest<GrupoEtarioDto>;
}
