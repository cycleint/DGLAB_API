using AutoMapper;
using Dapper;
using DgLab.Application.Area.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Queries
{
    public class AreaOneQueryHandler : IRequestHandler<AreaOneQuery, AreaDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public AreaOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<AreaDto> Handle(AreaOneQuery request, CancellationToken cancellationToken)
        {
            var area = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Area>
               ("SELECT  Id,Codigo,Abreviatura,Nombre,NombreIngles,Tipo,ValidacionParcial,Color,Estado,IdUsuario,NombreEstacion,Fechaserver" +
               " FROM Per.Area where Id = @Id", new { Id = request.Id });
            return _mapper.Map<AreaDto>(area);
        }
    }
}
