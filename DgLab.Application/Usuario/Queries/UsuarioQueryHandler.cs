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
    public class UsuarioQueryHandler : IRequestHandler<UsuarioQuery, List<UsuarioDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public UsuarioQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<UsuarioDto>> Handle(UsuarioQuery request, CancellationToken cancellationToken)
        {
            var usuarios = await _dapperSource.QueryAsync
                   ("SELECT Id,Identificacion,Nombre,Apellido,Correo,Firma,Estado,IdUsuario,NombreEstacion,Fechaserver FROM Per.Usuario"
                   );

            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }
    }
}
