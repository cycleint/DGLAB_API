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
    public class UsuarioDeleteHandler : IRequestHandler<UsuarioDeleteCommand, UsuarioDto>
    {

        private readonly UsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioDeleteHandler(UsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
        public async Task<UsuarioDto> Handle(UsuarioDeleteCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioService.EliminarUsuarioPorId(request.Id);
            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
