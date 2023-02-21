using AutoMapper;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Area.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Commands
{
    public class AlarmaCreateHandler : IRequestHandler<AlarmaCreateCommand, AlarmaDto>
    {
        private readonly AlarmaService _alarmaService;
        private readonly IMapper _mapper;

        public AlarmaCreateHandler(AlarmaService alarmaService, IMapper mapper)
        {
            _alarmaService = alarmaService;
            _mapper = mapper;
        }
        public async Task<AlarmaDto> Handle(AlarmaCreateCommand request, CancellationToken cancellationToken)
        {
            var alarma = await _alarmaService.GuardarAlarma(
                 new DgLab.Domain.Entities.Alarma()
                 {                   
                     Nombre = request.Nombre,
                     Descripcion = request.Descripcion,
                     Estado= request.Estado,
                     IdUsuario = request.IdUsuario

                 }
                 );
            return _mapper.Map<AlarmaDto>(alarma);
        }
    }
}
