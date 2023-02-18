using AutoMapper;
using Dapper;
using DgLab.Application.Rol.Commands;
using DgLab.Application.Rol.Dto;
using DgLab.Application.Tecnica.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Queries
{
    public class RolQueryHandler : IRequestHandler<RolQuery, List<RolDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RolQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<RolDto>> Handle(RolQuery request, CancellationToken cancellationToken)
        {
            var roles = await _dapperSource.QueryAsync
                  ("SELECT Id,Nombre,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Rol");

            return _mapper.Map<List<RolDto>>(roles);
        }
    }
}
