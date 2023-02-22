using AutoMapper;
using Dapper;
using DgLab.Application.Unidad.Dto;
using DgLab.Application.Usuario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Queries
{
    public class UsuarioOneQueryHandler : IRequestHandler<UsuarioOneQuery, UsuarioDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public UsuarioOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<UsuarioDto> Handle(UsuarioOneQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Usuario>
               ("SELECT Id,Identificacion,Nombre,Apellido,Codigo,Correo,Firma,Foto,Estado,IdUsuario,NombreEstacion,Fechaserver FROM Per.Usuario where Id = @Id", new { Id = request.Id });
            return _mapper.Map<UsuarioDto>(usuario);
        }
    }
}
