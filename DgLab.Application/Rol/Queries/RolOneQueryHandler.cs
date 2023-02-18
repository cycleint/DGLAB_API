using AutoMapper;
using Dapper;
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
    public class RolOneQueryHandler : IRequestHandler<RolOneQuery, RolDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RolOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<RolDto> Handle(RolOneQuery request, CancellationToken cancellationToken)
        {
            var unidad = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Rol>
               ("SELECT Id,Nombre,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Rol where Id = @Id", new { Id = request.Id });
            return _mapper.Map<RolDto>(unidad);
        }
    }
}
