using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Commands
{
    public record TecnicaUpdateCommand(
        [Required]  int Id,
        [Required][MaxLength(5)] string Codigo,
        [Required] string Descripcion,
        [Required] bool Estado      
    ) : IRequest<TecnicaDto>;
}
