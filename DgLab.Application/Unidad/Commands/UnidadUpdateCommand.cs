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
   

    public record UnidadUpdateCommand(
       [Required] int Id,
       [Required] string Nombre,
       [Required] string NombreInter,
       [Required] int Factor,
       [Required] bool Estado       
   ) : IRequest<UnidadDto>;
}
