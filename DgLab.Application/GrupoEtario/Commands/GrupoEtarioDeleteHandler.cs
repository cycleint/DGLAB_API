using AutoMapper;
using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.Requisito.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Commands
{
    public class GrupoEtarioDeleteHandler : IRequestHandler<GrupoEtarioDeleteCommand, GrupoEtarioDto>
    {

        private readonly GrupoEtarioService _grupoEtarioService;
        private readonly IMapper _mapper;

        public GrupoEtarioDeleteHandler(GrupoEtarioService grupoEtarioService, IMapper mapper)
        {
            _grupoEtarioService = grupoEtarioService;
            _mapper = mapper;
        }
        public async Task<GrupoEtarioDto> Handle(GrupoEtarioDeleteCommand request, CancellationToken cancellationToken)
        {
            var grupoEtario = await _grupoEtarioService.EliminarAreaPorId(request.Id);
            return _mapper.Map<GrupoEtarioDto>(grupoEtario);
        }
    }
}
