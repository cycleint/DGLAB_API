using DgLab.Application.Muestra.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Commands
{
   
    public record MuestraUpdateCommand(
            [Required] int Id,
            [Required][MaxLength(5)] string Codigo,
            [Required] string Nombre,
            [Required] int IdRecipiente,
            [Required] int CantEtiqueta,
            [Required] int DiasAlmacena,
            [Required] bool AlmacenaEspecial,
            [Required] int TipoLaboratorio,
            [Required] string Informacion,
            [Required] string Valoracion,
            [Required] bool Estado            
        ) : IRequest<MuestraDto>;
}
