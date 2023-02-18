using AutoMapper;
using DgLab.Application.Tecnica.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Commands
{
    public class TecnicaCreateHandler : IRequestHandler<TecnicaCreateCommand, TecnicaDto>
    {
        private readonly TecnicaService _tecnicaService;
        private readonly IMapper _mapper;

        public TecnicaCreateHandler(TecnicaService tecnicaService, IMapper mapper)
        {
            _tecnicaService = tecnicaService;
            _mapper = mapper;
        }
        public async Task<TecnicaDto> Handle(TecnicaCreateCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _tecnicaService.GuardarTecnica(
                  new DgLab.Domain.Entities.Tecnica
                  {
                      Codigo = request.Codigo,
                      Descripcion = request.Descripcion,                    
                      Estado = request.Estado,
                      IdUsuario = request.IdUsuario
                  });

            return _mapper.Map<TecnicaDto>(unidad);
        }
    }


}
