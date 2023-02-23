using AutoMapper;
using DgLab.Application.Area.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Commands
{
    public class AreaUpdateHandler : IRequestHandler<AreaUpdateCommand, AreaDto>
    {
        private readonly AreaService _areaService;
        private readonly IMapper _mapper;

        public AreaUpdateHandler(AreaService areaService, IMapper mapper)
        {
            _areaService = areaService;
            _mapper = mapper;
        }

        public async Task<AreaDto> Handle(AreaUpdateCommand request, CancellationToken cancellationToken)
        {
            var area = await _areaService.ActualizarArea(
                 new DgLab.Domain.Entities.Area()
                 {
                     Id= request.Id,
                     Codigo = request.Codigo,
                     Abreviatura = request.Abreviatura,
                     Nombre = request.Nombre,
                     NombreIngles = request.NombreIngles,
                     IdTipo = request.IdTipo,
                     ValidacionParcial = request.ValidacionParcial,
                     Color = request.Color,
                     Estado = request.Estado
                 

                 }
                 );
            return _mapper.Map<AreaDto>(area);
        }
    }
}
