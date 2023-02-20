using DgLab.Application.Unidad.Dto;
using DgLab.Application.Usuario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Commands
{


    public record UsuarioCreateCommand(
        [Required] string Identificacion,
        [Required] string Nombre,
        [Required] string Apellido,
        [Required] string Correo,
        [Required] string Firma,
        [Required] string Contrasena,
        [Required] bool Estado,
        [Required] int IdUsuario
    ) : IRequest<UsuarioDto>;


}
