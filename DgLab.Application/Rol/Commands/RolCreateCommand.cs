using DgLab.Application.Rol.Dto;
using DgLab.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Commands
{
    public record RolCreateCommand(
       [Required] string Nombre,
       [Required] bool Estado,
       [Required] int IdUsuario
   ) : IRequest<RolDto>;
}
