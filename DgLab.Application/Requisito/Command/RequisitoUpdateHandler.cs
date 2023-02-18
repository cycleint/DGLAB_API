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
    public class RequisitoUpdateHandler : IRequestHandler<RequisitoUpdateCommand, RequisitoDto>
    {
        private readonly RequisitoService _requisitoService;
        private readonly IMapper _mapper;

        public RequisitoUpdateHandler(RequisitoService requisitoService, IMapper mapper)
        {
            _requisitoService = requisitoService;
            _mapper = mapper;
        }
        public async Task<RequisitoDto> Handle(RequisitoUpdateCommand request, CancellationToken cancellationToken)
        {
            var requisito = await _requisitoService.ActualizarRequisito(
                 new DgLab.Domain.Entities.Requisito
                 {
                     Id= request.Id,
                     Nombre = request.Nombre,
                     Descripcion = request.Descripcion,
                     Estado = request.Estado                    
                 });

            return _mapper.Map<RequisitoDto>(requisito);
        }
    }
}
