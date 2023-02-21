using DgLab.Application.Alarma.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Queries
{
    public record AlarmaOneQuery([Required] int Id) : IRequest<AlarmaDto>;
}
