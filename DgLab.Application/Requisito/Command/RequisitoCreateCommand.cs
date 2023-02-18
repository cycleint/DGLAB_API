using DgLab.Application.Requisito.Dto;
using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Command
{
    public record RequisitoCreateCommand(
       [Required]string Nombre,
       [Required] string Descripcion,
       [Required] bool Estado,
       [Required] int IdUsuario
   ) : IRequest<RequisitoDto>;
}
