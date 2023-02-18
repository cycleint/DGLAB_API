using DgLab.Application.Requisito.Dto;
using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Command
{
    public record RequisitoDeleteCommand(int Id) : IRequest<RequisitoDto>;
}
