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
    public class UnidadUpdateHandler : IRequestHandler<UnidadUpdateCommand, UnidadDto>
    {
        private readonly UnidadService _unidadService;
        private readonly IMapper _mapper;

        public UnidadUpdateHandler(UnidadService unidadService, IMapper mapper)
        {
            _unidadService = unidadService;
            _mapper = mapper;
        }
        public async Task<UnidadDto> Handle(UnidadUpdateCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _unidadService.ActualizarUnidad(
                  new DgLab.Domain.Entities.Unidad {
                    Id=request.Id,
                    Nombre = request.Nombre,
                    NombreInter = request.NombreInter,
                    Factor=request.Factor,
                    Estado=request.Estado
                  });

            return _mapper.Map<UnidadDto>(unidad);
        }
    }
}
