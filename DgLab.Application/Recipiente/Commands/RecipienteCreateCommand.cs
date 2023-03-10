using DgLab.Application.Recipiente.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Commands
{

    public record RecipienteCreateCommand(
        [Required] string Nombre ,
        [Required] string Imagen ,
        [Required] int IdUnidad,
        [Required] bool Estado,
        [Required] int IdUsuario
    ) : IRequest<RecipienteDto>;
}
