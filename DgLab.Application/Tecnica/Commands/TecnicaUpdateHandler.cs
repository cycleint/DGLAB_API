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
    public class TecnicaUpdateHandler : IRequestHandler<TecnicaUpdateCommand, TecnicaDto>
    {
        private readonly TecnicaService _tecnicaService;
        private readonly IMapper _mapper;

        public TecnicaUpdateHandler(TecnicaService tecnicaService, IMapper mapper)
        {
            _tecnicaService = tecnicaService;
            _mapper = mapper;
        }

        public async Task<TecnicaDto> Handle(TecnicaUpdateCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _tecnicaService.ActualizarTecnica(
                  new DgLab.Domain.Entities.Tecnica
                  {
                      Id= request.Id,
                      Codigo = request.Codigo,
                      Descripcion = request.Descripcion,
                      Estado = request.Estado                     
                  });

            return _mapper.Map<TecnicaDto>(unidad);
        }
    }
}
