using AutoMapper;
using DgLab.Application.Recipiente.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Commands
{
    public class RecipienteUpdateHandler : IRequestHandler<RecipienteUpdateCommand, RecipienteDto>
    {
        private readonly RecipienteService _recipienteService;
        private readonly IMapper _mapper;

        public RecipienteUpdateHandler(RecipienteService recipienteService, IMapper mapper)
        {
            _recipienteService = recipienteService;
            _mapper = mapper;
        }
        public async Task<RecipienteDto> Handle(RecipienteUpdateCommand request, CancellationToken cancellationToken)
        {
            var requisito = await _recipienteService.ActualizarRecipiente(
                new DgLab.Domain.Entities.Recipiente
                {
                    Id = request.Id,
                    Nombre = request.Nombre,
                    Imagen = request.Imagen,
                    IdUnidad = request.IdUnidad,
                    Estado = request.Estado,
                    
                });

            return _mapper.Map<RecipienteDto>(requisito);
        }
    }
}
