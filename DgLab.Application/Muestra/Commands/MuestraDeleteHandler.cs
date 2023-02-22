using AutoMapper;
using DgLab.Application.Muestra.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Commands
{
    public class MuestraDeleteHandler : IRequestHandler<MuestraDeleteCommand, MuestraDto>
    {
        private readonly MuestraService _muestraService;
        private readonly IMapper _mapper;

        public MuestraDeleteHandler(MuestraService MuestraService, IMapper mapper)
        {
            _muestraService = MuestraService;
            _mapper = mapper;
        }
        public async Task<MuestraDto> Handle(MuestraDeleteCommand request, CancellationToken cancellationToken)
        {
            var muestra = await _muestraService.EliminarMuestraPorId( request.Id);
            return _mapper.Map<MuestraDto>(muestra);
        }
    }
}
