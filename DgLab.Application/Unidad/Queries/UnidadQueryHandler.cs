using AutoMapper;
using Dapper;
using DgLab.Application.Unidad.Dto;
using DgLab.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad.Queries
{
    public class UnidadQueryHandler : IRequestHandler<UnidadQuery, List<UnidadDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public UnidadQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<UnidadDto>> Handle(UnidadQuery request, CancellationToken cancellationToken)
        {
            var unidades = await _dapperSource.QueryAsync
                 ("select Id,Nombre,NombreInter,Factor,Estado,IdUsuario,NombreEstacion,Fechaserver from Per.Unidad"
                 );
                
            return _mapper.Map<List<UnidadDto>>(unidades);
        }
    }
}
