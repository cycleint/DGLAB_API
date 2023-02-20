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
    public class IncioSesionHandler : IRequestHandler<IncioSesionCommand, UsuarioDto>
    {
        private readonly UsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public IncioSesionHandler(UsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
        public async Task<UsuarioDto> Handle(IncioSesionCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioService.InicioSesion(request.Correo,request.Contrasena);

            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
