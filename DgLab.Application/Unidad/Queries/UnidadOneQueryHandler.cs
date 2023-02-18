using AutoMapper;
using Dapper;
using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Queries
{
    public class UnidadOneQueryHandler : IRequestHandler<UnidadOneQuery, UnidadDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public UnidadOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<UnidadDto> Handle(UnidadOneQuery request, CancellationToken cancellationToken)
        {
          
            var unidad = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Unidad>
                ("select Id,Nombre,NombreInter,Factor,Estado,IdUsuario,NombreEstacion,Fechaserver from Per.Unidad where Id = @Id", new { Id = request.Id });
            return _mapper.Map<UnidadDto>(unidad);
        }
    }
}
