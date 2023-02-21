using AutoMapper;
using Dapper;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Area.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Queries
{
    public class AlarmaOneQueryHandler : IRequestHandler<AlarmaOneQuery, AlarmaDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public AlarmaOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<AlarmaDto> Handle(AlarmaOneQuery request, CancellationToken cancellationToken)
        {
            var alarma = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Alarma>
              ("SELECT Id,Nombre,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Alarma where Id = @Id", new { Id = request.Id });
            return _mapper.Map<AlarmaDto>(alarma);
        }
    }
}
