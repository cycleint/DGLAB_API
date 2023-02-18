using AutoMapper;
using DgLab.Application.Requisito.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Command
{
    public class RequisitoDeleteHandler : IRequestHandler<RequisitoDeleteCommand, RequisitoDto>
    {
        private readonly RequisitoService _requisitoService;
        private readonly IMapper _mapper;

        public RequisitoDeleteHandler(RequisitoService requisitoService, IMapper mapper)
        {
            _requisitoService = requisitoService;
            _mapper = mapper;
        }
        public async Task<RequisitoDto> Handle(RequisitoDeleteCommand request, CancellationToken cancellationToken)
        {
            var requisito = await _requisitoService.EliminarRequisitoPorId( request.Id);

            return _mapper.Map<RequisitoDto>(requisito);
        }
    }
}
