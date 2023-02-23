using DgLab.Application.Area.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Commands
{
    

    public record AreaUpdateCommand(
        [Required] int Id,
        [Required][MaxLength(5)] string Codigo,
        [Required] string Abreviatura,
        [Required] string Nombre,
        [Required] string NombreIngles,
        [Required] int IdTipo,
        [Required] bool ValidacionParcial,
        [Required] string Color,
        [Required] bool Estado       
   ) : IRequest<AreaDto>;
}
