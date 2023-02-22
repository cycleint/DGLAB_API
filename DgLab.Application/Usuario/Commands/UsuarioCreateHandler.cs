using AutoMapper;
using DgLab.Application.Unidad.Dto;
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
    public class UsuarioCreateHandler : IRequestHandler<UsuarioCreateCommand, UsuarioDto>
    {
        private readonly UsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioCreateHandler(UsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
        public async Task<UsuarioDto> Handle(UsuarioCreateCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioService.GuardarUsuario(
                  new DgLab.Domain.Entities.Usuario
                  {
                        Identificacion = request.Identificacion,
                        Nombre = request.Nombre,
                        Apellido= request.Apellido,
                        Codigo= request.Codigo,
                        Correo =request.Correo,
                        Firma =request.Firma,
                        Foto= request.Foto,
                        Contrasena =request.Contrasena,
                        Estado=request.Estado,
                        IdUsuario = request.IdUsuario
                  });

            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
