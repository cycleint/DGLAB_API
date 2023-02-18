using AutoMapper;
using DgLab.Application.Rol.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Commands
{
    public class RolUpdateHandler : IRequestHandler<RolUpdateCommand, RolDto>
    {
        private readonly RolService _rolService;
        private readonly IMapper _mapper;
        public RolUpdateHandler(RolService rolService, IMapper mapper)
        {
            _rolService = rolService ?? throw new ArgumentNullException(nameof(rolService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<RolDto> Handle(RolUpdateCommand request, CancellationToken cancellationToken)
        {
            var rol = await _rolService.ActualizarRol(
                 new DgLab.Domain.Entities.Rol
                 {
                     Id= request.Id,
                     Nombre = request.Nombre,
                     Estado = request.Estado,                    
                 });

            return _mapper.Map<RolDto>(rol);
        }
    }
}
