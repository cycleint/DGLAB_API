using DgLab.Application.Alarma.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Commands
{

    public record AlarmaCreateCommand(       
        [Required] string Nombre,
        [Required] string Descripcion,       
        [Required] bool Estado,
        [Required] int IdUsuario
    ) : IRequest<AlarmaDto>;
}
