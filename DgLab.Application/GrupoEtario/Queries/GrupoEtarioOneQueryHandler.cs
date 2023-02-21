using AutoMapper;
using Dapper;
using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Queries
{
    public class GrupoEtarioOneQueryHandler : IRequestHandler<GrupoEtarioOneQuery, GrupoEtarioDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public GrupoEtarioOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<GrupoEtarioDto> Handle(GrupoEtarioOneQuery request, CancellationToken cancellationToken)
        {
            var grupoEtario = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.GrupoEtario>
                 ("SELECT Id,Codigo,Nombre,Genero,IdUnidad,RangoInicial,RangoFinal,Estado,IdUsuario,NombreEstacion,Fechaserver " +
                 "FROM Per.GrupoEtario where Id = @Id", new { Id = request.Id });
            return _mapper.Map<GrupoEtarioDto>(grupoEtario);
        }
    }
}
