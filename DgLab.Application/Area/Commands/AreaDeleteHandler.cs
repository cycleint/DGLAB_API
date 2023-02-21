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
    public class AreaDeleteHandler : IRequestHandler<AreaDeleteCommand, AreaDto>
    {
        private readonly AreaService _areaService;
        private readonly IMapper _mapper;

        public AreaDeleteHandler(AreaService areaService, IMapper mapper)
        {
            _areaService = areaService;
            _mapper = mapper;
        }

        public async Task<AreaDto> Handle(AreaDeleteCommand request, CancellationToken cancellationToken)
        {
            var area = await _areaService.EliminarAreaPorId(request.Id);
            return _mapper.Map<AreaDto>(area);
        }
    }
}
