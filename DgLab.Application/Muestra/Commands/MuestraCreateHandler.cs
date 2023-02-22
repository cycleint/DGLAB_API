using AutoMapper;
using DgLab.Application.Muestra.Dto;
using DgLab.Application.Recipiente.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Commands
{
    public class MuestraCreateHandler : IRequestHandler<MuestraCreateCommand, MuestraDto>
    {
        private readonly MuestraService _muestraService;
        private readonly IMapper _mapper;

        public MuestraCreateHandler(MuestraService MuestraService, IMapper mapper)
        {
            _muestraService = MuestraService;
            _mapper = mapper;
        }
        public async Task<MuestraDto> Handle(MuestraCreateCommand request, CancellationToken cancellationToken)
        {
            var muestra = await _muestraService.GuardarMuestra(
                 new DgLab.Domain.Entities.Muestra
                 {
                     Codigo=request.Codigo,
                     Nombre = request.Nombre,
                     IdRecipiente=request.IdRecipiente,
                     CantEtiqueta=request.CantEtiqueta,
                     DiasAlmacena=request.DiasAlmacena,
                     AlmacenaEspecial=request.AlmacenaEspecial,
                     TipoLaboratorio=request.TipoLaboratorio,
                     Informacion=request.Informacion,
                     Valoracion=request.Valoracion,
                     Estado = request.Estado,
                     IdUsuario = request.IdUsuario
                 });

            return _mapper.Map<MuestraDto>(muestra);
        }
    }
}
