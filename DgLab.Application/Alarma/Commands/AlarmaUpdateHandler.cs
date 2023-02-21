using AutoMapper;
using DgLab.Application.Alarma.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Commands
{
    public class AlarmaUpdateHandler : IRequestHandler<AlarmaUpdateCommand, AlarmaDto>
    {
        private readonly AlarmaService _alarmaService;
        private readonly IMapper _mapper;

        public AlarmaUpdateHandler(AlarmaService alarmaService, IMapper mapper)
        {
            _alarmaService = alarmaService;
            _mapper = mapper;
        }
        public async Task<AlarmaDto> Handle(AlarmaUpdateCommand request, CancellationToken cancellationToken)
        {
            var alarma = await _alarmaService.ActualizarAlarma(
                 new DgLab.Domain.Entities.Alarma()
                 {
                     Id=request.Id,
                     Nombre = request.Nombre,
                     Descripcion = request.Descripcion,
                     Estado = request.Estado,

                 }
                 );
            return _mapper.Map<AlarmaDto>(alarma);
        }
    }
}
