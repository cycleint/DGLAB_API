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
    public class GrupoEtarioCreateHandler : IRequestHandler<GrupoEtarioCreateCommand, GrupoEtarioDto>
    {
        private readonly GrupoEtarioService _grupoEtarioService;
        private readonly IMapper _mapper;

        public GrupoEtarioCreateHandler(GrupoEtarioService grupoEtarioService, IMapper mapper)
        {
            _grupoEtarioService = grupoEtarioService;
            _mapper = mapper;
        }

        public async  Task<GrupoEtarioDto> Handle(GrupoEtarioCreateCommand request, CancellationToken cancellationToken)
        {
            var grupoEtario = await _grupoEtarioService.GuardarGrupoEtario(
                  new DgLab.Domain.Entities.GrupoEtario
                  {
                      Codigo= request.Codigo,
                      Nombre = request.Nombre,
                      Genero = request.Genero,
                      IdUnidad=request.IdUnidad,
                      RangoInicial=request.RangoInicial,
                      RangoFinal=request.RangoFinal,
                      Estado = request.Estado,
                      IdUsuario = request.IdUsuario
                  });

            return _mapper.Map<GrupoEtarioDto>(grupoEtario);
        }
    }
}
