using AutoMapper;
using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Requisito.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Commands
{
    public class RecipienteCreateHandler : IRequestHandler<RecipienteCreateCommand, RecipienteDto>
    {

        private readonly RecipienteService _recipienteService;
        private readonly IMapper _mapper;

        public RecipienteCreateHandler(RecipienteService recipienteService, IMapper mapper)
        {
            _recipienteService = recipienteService;
            _mapper = mapper;
        }
        public async Task<RecipienteDto> Handle(RecipienteCreateCommand request, CancellationToken cancellationToken)
        {
            var requisito = await _recipienteService.GuardarRecipiente(
                 new DgLab.Domain.Entities.Recipiente
                 {
                     Nombre = request.Nombre,
                     Imagen = request.Imagen,
                     IdUnidad= request.IdUnidad,
                     Estado = request.Estado,
                     IdUsuario = request.IdUsuario
                 });

            return _mapper.Map<RecipienteDto>(requisito);
        }
    }
}
