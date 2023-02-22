using AutoMapper;
using DgLab.Application.Unidad.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Commands
{
    public class UnidadDeleteHandler : IRequestHandler<UnidadDeleteCommand, UnidadDto>
    {
        private readonly UnidadService _unidadService;
        private readonly IMapper _mapper;

        public UnidadDeleteHandler(UnidadService unidadService, IMapper mapper)
        {
            _unidadService = unidadService;
            _mapper = mapper;
        }

        public async Task<UnidadDto> Handle(UnidadDeleteCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _unidadService.EliminarUnidadPorId(request.Id);
            return _mapper.Map<UnidadDto>(unidad);
        }
    }
}
