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
    public class RequisitoCreateHandler : IRequestHandler<RequisitoCreateCommand, RequisitoDto>
    {

        private readonly RequisitoService _requisitoService;
        private readonly IMapper _mapper;

        public RequisitoCreateHandler(RequisitoService requisitoService, IMapper mapper)
        {
            _requisitoService = requisitoService;
            _mapper = mapper;
        }
        public async Task<RequisitoDto> Handle(RequisitoCreateCommand request, CancellationToken cancellationToken)
        {
            var requisito = await _requisitoService.GuardarRequisito(
                  new DgLab.Domain.Entities.Requisito
                  {
                      Nombre = request.Nombre,
                      Descripcion = request.Descripcion,
                      Estado = request.Estado,
                      IdUsuario = request.IdUsuario
                  });

            return _mapper.Map<RequisitoDto>(requisito);
        }
    }
}
