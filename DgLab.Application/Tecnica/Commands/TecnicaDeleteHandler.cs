using AutoMapper;
using DgLab.Application.Tecnica.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Commands
{
    public class TecnicaDeleteHandler : IRequestHandler<TecnicaDeleteCommand, TecnicaDto>
    {
        private readonly TecnicaService _tecnicaService;
        private readonly IMapper _mapper;

        public TecnicaDeleteHandler(TecnicaService tecnicaService, IMapper mapper)
        {
            _tecnicaService = tecnicaService;
            _mapper = mapper;
        }

        public async Task<TecnicaDto> Handle(TecnicaDeleteCommand request, CancellationToken cancellationToken)
        {
            var unidad = await _tecnicaService.EliminarTecnicaPorId(request.Id);

            return _mapper.Map<TecnicaDto>(unidad);
        }
    }
}
