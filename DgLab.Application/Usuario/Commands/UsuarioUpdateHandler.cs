using AutoMapper;
using DgLab.Application.Usuario.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Commands
{
    public class UsuarioUpdatehandler : IRequestHandler<UsuarioUpdateCommand, UsuarioDto>
    {
        private readonly UsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioUpdatehandler(UsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
        public async Task<UsuarioDto> Handle(UsuarioUpdateCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioService.ActualizarUsuario(
                   new DgLab.Domain.Entities.Usuario
                   {
                       Id = request.Id,
                       Identificacion = request.Identificacion,
                       Nombre = request.Nombre,
                       Apellido = request.Apellido,
                       Codigo = request.Codigo,
                       Correo = request.Correo,
                       Firma = request.Firma,
                       Foto = request.Foto,                      
                       Estado = request.Estado,
                   });

            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
