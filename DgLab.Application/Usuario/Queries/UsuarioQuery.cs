using DgLab.Application.Usuario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Queries
{
   
    public record UsuarioQuery() : IRequest<List<UsuarioDto>>;
}
