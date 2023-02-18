
using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Commands
{
    public record UnidadCreateCommand(
        [Required] string Nombre,
        [Required] string NombreInter,
        [Required] int Factor,
        [Required] bool Estado,
        [Required] int IdUsuario
    ) : IRequest<UnidadDto>;

   
}
