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
    public class UnidadCreateHandler : IRequestHandler<UnidadCreateCommand, UnidadDto>
    {
        private readonly UnidadService _unidadService;
        private readonly IMapper _mapper;

        public UnidadCreateHandler(UnidadService unidadService, IMapper mapper)
        {
            _unidadService = unidadService ;
            _mapper = mapper;
        }

        public async Task<UnidadDto> Handle(UnidadCreateCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _unidadService.GuardarUnidad(
                  new DgLab.Domain.Entities.Unidad {
                        Nombre=request.Nombre,
                        NombreInter=request.NombreInter,
                        Factor=request.Factor,
                        Estado=request.Estado,  
                        IdUsuario=request.IdUsuario
                  });

            return _mapper.Map<UnidadDto>(unidad );
              
        }
    }
}
