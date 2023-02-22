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
    public class RecipienteDeleteHandler : IRequestHandler<RecipienteDeleteCommand, RecipienteDto>
    {
        private readonly RecipienteService _recipienteService;
        private readonly IMapper _mapper;

        public RecipienteDeleteHandler(RecipienteService recipienteService, IMapper mapper)
        {
            _recipienteService = recipienteService;
            _mapper = mapper;
        }
        public async Task<RecipienteDto> Handle(RecipienteDeleteCommand request, CancellationToken cancellationToken)
        {
            var recipiente = await _recipienteService.EliminarRecipientePorId(request.Id);
            return _mapper.Map<RecipienteDto>(recipiente);
        }
    }
}
