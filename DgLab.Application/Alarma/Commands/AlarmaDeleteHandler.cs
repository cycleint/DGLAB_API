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
    public class AlarmaDeleteHandler : IRequestHandler<AlarmaDeleteCommand, AlarmaDto>
    {
        private readonly AlarmaService _alarmaService;
        private readonly IMapper _mapper;

        public AlarmaDeleteHandler(AlarmaService alarmaService, IMapper mapper)
        {
            _alarmaService = alarmaService;
            _mapper = mapper;
        }
        public async Task<AlarmaDto> Handle(AlarmaDeleteCommand request, CancellationToken cancellationToken)
        {
            var alarma = await _alarmaService.EliminarAlarmaPorId(request.Id);
            return _mapper.Map<AlarmaDto>(alarma);
        }
    }
}
