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
    public class AreaCreateHandler : IRequestHandler<AreaCreateCommand, AreaDto>
    {
        private readonly AreaService _areaService;
        private readonly IMapper _mapper;

        public AreaCreateHandler(AreaService areaService, IMapper mapper)
        {
            _areaService = areaService;
            _mapper = mapper;
        }
        public async  Task<AreaDto> Handle(AreaCreateCommand request, CancellationToken cancellationToken)
        {
            var area = await _areaService.GuardarArea(
                new DgLab.Domain.Entities.Area() { 
                    Codigo= request.Codigo,
                    Abreviatura= request.Abreviatura,
                    Nombre= request.Nombre,
                    NombreIngles= request.NombreIngles,
                    Tipo= request.Tipo,
                    ValidacionParcial= request.ValidacionParcial,
                    Color= request.Color,
                    Estado= request.Estado,
                    IdUsuario= request.IdUsuario

                }
                );
            return _mapper.Map<AreaDto>( area );
        }
    }
}
